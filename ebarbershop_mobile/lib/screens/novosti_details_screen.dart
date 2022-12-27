import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/novost.dart';
import '../utils/util.dart';

class NovostiDetailsScreen extends StatefulWidget {
  static const String routeName = "/novosti_details";
  String id;
  NovostiDetailsScreen(this.id,{Key? key}) : super(key: key);

  @override
  State<NovostiDetailsScreen> createState() => _NovostiDetailsScreenState();
}

class _NovostiDetailsScreenState extends State<NovostiDetailsScreen> {

  NovostiProvider? _novostiProvider = null;
  Novost? _novost = null;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _novostiProvider = context.read<NovostiProvider>();
    loadData();
  }

  Future loadData() async{
    var tmpData = await _novostiProvider!.getById(int.parse(this.widget.id));
    setState(() {
      _novost = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eBarberShop - Proizvod detalji"),backgroundColor: Colors.grey[900],),
      body: SingleChildScrollView(
        child: Container(
          width: 600,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
            NovostDetalji()
          ]),
        ),
      ),
    );
  }

  Widget NovostDetalji(){
    if(_novost == null)
    {
      return Center(child: Text("Ucitavanje"),);
    }

    else{
      return Padding(
        padding: const EdgeInsets.all(8.0),
        child: Card(
          elevation: 6,
              child: Padding(
                padding: const EdgeInsets.all(15.0),
                child: Column(
                  children: [
                  Container(
                    child: imageFromBase64String(_novost!.thumbnail!),
                    width:400
                  ),
                  SizedBox(height:15),
                  Row(
                    children: [
                      Expanded(child: Text(_novost?.naslov! ?? "N/A", style: TextStyle(fontSize: 28 , fontWeight: FontWeight.bold)))
                    ],
                  ),
                   Row(
                      mainAxisAlignment: MainAxisAlignment.start,
                      children: [
                        Expanded(child: Text("Napisao: ${_novost!.korisnik!.ime} , Datum: ${formatDate(_novost!.datumKreiranja!)}")),
                      ],
                    ),
                  SizedBox(height:15),
                  Row(children: [
                    Expanded(child: Container(child: Text("${_novost!.sadrzaj}" , style: TextStyle(fontSize: 20),)))
                  ],)]),
              )),
      );
    }
  }
}