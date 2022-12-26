import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/proizvod.dart';

class ProductDetailsScreen extends StatefulWidget {
  static const String routeName = "/product_details";
  String id;
  ProductDetailsScreen(this.id,{Key? key}) : super(key: key);

  @override
  State<ProductDetailsScreen> createState() => _ProductDetailsScreenState();
}

class _ProductDetailsScreenState extends State<ProductDetailsScreen> {
  ProizvodProvider? _proizvodProvider = null;
  Proizvod? _proizvod = null;

  @override
  void initState(){
    // TODO: implement initState
    super.initState();
    _proizvodProvider = context.read<ProizvodProvider>();
    loadData();
  }

    Future loadData() async {
     var tmp = await _proizvodProvider!.getById(int.parse(this.widget.id));
     setState(() {
      _proizvod = tmp;
    });
    }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eBarberShop - Proizvod detalji"),backgroundColor: Colors.grey[900],),
      body: Container(
        height: 1400,
        width: 600,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
          ProizvodDetalji()
        ]),
      ),
    );
  }

  Widget ProizvodDetalji()
  {
    if(_proizvod == null)
    {
      return Center(child: Text("Ucitavanje"),);
    }

    else{
      return Card(
        elevation: 6,
            child: Padding(
              padding: const EdgeInsets.all(15.0),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                Text(_proizvod?.naziv! ?? "N/A", style: TextStyle(fontSize: 42 , fontWeight: FontWeight.bold),),
                SizedBox(height:15),
                Container(
                  child: imageFromBase64String(_proizvod!.slika!),
                  width:300
                ),
                SizedBox(height:15),
                Text("Cijena proizvoda: ${_proizvod?.cijena!.toString()}" , style: TextStyle(fontSize: 20),)]),
            ));
    }
  }
}