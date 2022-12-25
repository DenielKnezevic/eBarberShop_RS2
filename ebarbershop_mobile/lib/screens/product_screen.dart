import 'package:ebarbershop_mobile/models/proizvod.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../utils/util.dart';

class ProductScreen extends StatefulWidget {
  const ProductScreen({Key? key}) : super(key: key);

  @override
  State<ProductScreen> createState() => _ProductScreenState();
}

class _ProductScreenState extends State<ProductScreen> {
  ProizvodProvider? _proizvodProvider = null;
  List<Proizvod> data = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _proizvodProvider = context.read<ProizvodProvider>();
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
              child: GridView.count(
            crossAxisCount: 2,
            mainAxisSpacing: 2,
            crossAxisSpacing: 2,
            children: _buildProducts(),
          ))
        ]),
      )),
    );
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
               elevation: 6.0,
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Container(
                    decoration: BoxDecoration( borderRadius: BorderRadius.circular(10)),
                    width: 170,
                    child: imageFromBase64String(e.slika!),
                  ),
                  SizedBox(height: 10,),
                  Text(
                    e.naziv!,
                    style: Theme.of(context).textTheme.headline6,
                  ),
                  Text(
                    '\$${e.cijena!}',
                    style: Theme.of(context).textTheme.subtitle2,
                  ),
                  IconButton(
                    onPressed: () {
                      // Add code to handle the "Buy" button press here
                    },
                    icon: Icon(Icons.shopping_cart_rounded),
                  ),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
