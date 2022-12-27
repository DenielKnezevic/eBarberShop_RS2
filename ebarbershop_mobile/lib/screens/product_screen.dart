import 'package:ebarbershop_mobile/models/proizvod.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/screens/product_detail_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../providers/cart-provider.dart';
import '../utils/util.dart';
import 'cart_screen.dart';

class ProductScreen extends StatefulWidget {
  const ProductScreen({Key? key}) : super(key: key);

  @override
  State<ProductScreen> createState() => _ProductScreenState();
}

class _ProductScreenState extends State<ProductScreen> {
  ProizvodProvider? _proizvodProvider = null;
  CartProvider? _cartProvider = null;
  List<Proizvod> data = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _proizvodProvider = context.read<ProizvodProvider>();
    _cartProvider = context.read<CartProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _proizvodProvider!.Get();
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
            child: Container(
          height: 700,
          child: Column(children: [
            buildHeader(),
            Expanded(
                child: Padding(
              padding: const EdgeInsets.all(8.0),
              child: GridView.count(
                crossAxisCount: 2,
                mainAxisSpacing: 8,
                crossAxisSpacing: 8,
                children: _buildProducts(),
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

  List<Widget> _buildProducts() {
    var list = data
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
                            decoration: BoxDecoration(
                                borderRadius: BorderRadius.circular(10)),
                            width: 180,
                            child: imageFromBase64String(e.slika!),
                          )),
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Text(
                      e.naziv!,
                      style: Theme.of(context).textTheme.headline6,
                    ),
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

    return list;
  }
}
