import 'package:ebarbershop_mobile/models/proizvod.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/screens/product_detail_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../providers/cart-provider.dart';
import '../providers/narudzba-provider.dart';
import '../utils/util.dart';
import 'cart_screen.dart';

class ProductScreen extends StatefulWidget {
  const ProductScreen({Key? key}) : super(key: key);

  @override
  State<ProductScreen> createState() => _ProductScreenState();
}

class _ProductScreenState extends State<ProductScreen> {
  TextEditingController _searchController = TextEditingController();
  ProizvodProvider? _proizvodProvider = null;
  CartProvider? _cartProvider = null;
  NarudzbaProvider? _narudzbaProvider = null;
  List<Proizvod> recommendedData = [];
  List<Proizvod> proizvodData = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _proizvodProvider = context.read<ProizvodProvider>();
    _cartProvider = context.read<CartProvider>();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    loadData();
  }

  Future loadData() async {
    var narudzbe = await _narudzbaProvider!.Get({
      'includeKorisnik':true,
      'includeNarudzbaProizvodi':true,
      'includeUplata':true
    });
    List<Proizvod> tmpData = [];
    if(narudzbe.length >= 2)
    {
      tmpData = await _proizvodProvider!.Recommend();
    }
    else{
      tmpData = await _proizvodProvider!.Get({'includeVrstaProizvoda':true});
    }
    setState((){
      if(narudzbe.length >= 2)
      {
        recommendedData = tmpData;
      }
      else{
        proizvodData = tmpData;
      }

    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
            child: Container(
          height: MediaQuery.of(context).size.height - 100,
          child: Column(children: [
            buildHeader(),
            _buildProductSearch(),
            Expanded(
                child: Padding(
              padding: const EdgeInsets.all(8.0),
              child: GridView.count(
                crossAxisCount: 2,
                mainAxisSpacing: 4,
                crossAxisSpacing: 4,
                children: 
                _buildProducts(),
          ),
            ))
          ]),
        )),
        floatingActionButton: FloatingActionButton(
          onPressed: () {
            Navigator.pushNamed(context, CartScreen.routeName);
          },
          backgroundColor: Colors.grey[800],
          child: const Icon(Icons.shopping_cart),
        ));
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Proizvodi",
        style: TextStyle(
            color: Colors.grey[900], fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

   Widget _buildProductSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              decoration: InputDecoration(
                  hintText: "Search",
                  prefixIcon: Icon(Icons.search , color: Colors.grey,),
                  enabledBorder: OutlineInputBorder(
                    borderSide: BorderSide(color: Colors.amber),
                    borderRadius: BorderRadius.circular(10)
                  ),
                  focusedBorder:OutlineInputBorder(
                    borderSide: BorderSide(color: Colors.amber),
                    borderRadius: BorderRadius.circular(10)) ,
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: BorderSide(color: Colors.amber))),
            ),
          ),
        ),
        Container(
          padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
          child: IconButton(
            icon: Icon(Icons.search_rounded, color: Colors.grey,),
            onPressed: () async {
                var tmpData = await _proizvodProvider?.Get({'naziv': _searchController.text});
                var tmpNarudzbe = await _narudzbaProvider?.Get({
                  'includeKorisnik':true,
                  'includeNarudzbaProizvodi':true,
                  'includeUplata':true
                });
                setState(() {
                  if(_searchController.text != "")
                  {
                    proizvodData = tmpData!;
                  }
                  else if(tmpNarudzbe!.length < 2)
                  {
                    proizvodData = tmpData!;
                  }
                  else{
                    proizvodData = [];
                  }
                });
            },
          ),
        )
      ],
    );
  }

  List<Widget> _buildProducts() {
    List<Widget> list = [];
    if(proizvodData.isEmpty)
    {
      list = recommendedData
        .map((e) => Card(
              elevation: 4,
              child: Padding(
                padding: EdgeInsets.all(4),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text("Preporucen proizvod"),
                    SizedBox(height: 5,),
                    Expanded(
                      child: InkWell(
                          onTap: () {
                            Navigator.pushNamed(context,
                                "${ProductDetailsScreen.routeName}/${e.proizvodID}");
                          },
                          child: Container(
                            child: imageFromBase64String(e.slika!),
                          )),
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Text(
                      e.naziv!,
                      style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                    ),
                    SizedBox(height: 5,),
                    Text(
                      '\BAM ${e.cijena!}',
                      style: Theme.of(context).textTheme.subtitle2,
                    ),
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: ElevatedButton.icon(
                        style: ElevatedButton.styleFrom(
                          primary: Colors.amber[400]
                        ),
                        onPressed: () {
                          _cartProvider?.addToCart(e);
                        },
                        icon: Icon(
                          // <-- Icon
                          Icons.shopping_cart,
                          size: 24.0,
                        ),
                        label: Text('Add to cart'), // <-- Text
                      ),
                    ),
                  ],
                ),
              ),
            ))
        .cast<Widget>()
        .toList();
    }
    else{
      list = proizvodData
        .map((e) => Card(
              elevation: 4,
              child: Padding(
                padding: EdgeInsets.all(4),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Expanded(
                      child: InkWell(
                          onTap: () {
                            Navigator.pushNamed(context,
                                "${ProductDetailsScreen.routeName}/${e.proizvodID}");
                          },
                          child: Container(
                            child: imageFromBase64String(e.slika!),
                          )),
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Text(
                      e.naziv!,
                      style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
                    ),
                    SizedBox(height: 5,),
                    Text(
                      '\$${e.cijena!}',
                      style: Theme.of(context).textTheme.subtitle2,
                    ),
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: ElevatedButton.icon(
                        style: ElevatedButton.styleFrom(
                          primary: Colors.amber[400]
                        ),
                        onPressed: () {
                          _cartProvider?.addToCart(e);
                        },
                        icon: Icon(
                          // <-- Icon
                          Icons.shopping_cart,
                          size: 24.0,
                        ),
                        label: Text('Add to cart'), // <-- Text
                      ),
                    ),
                  ],
                ),
              ),
            ))
        .cast<Widget>()
        .toList();
    }

    return list;
  }
}
