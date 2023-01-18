import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/korisnik.dart';
import '../models/novost.dart';
import '../providers/korisnik-provider.dart';
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
  KorisnikProvider? _korisnikProvider = null;
  Novost? _novost = null;
  Korisnik? _korisnik = null;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _novostiProvider = context.read<NovostiProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();
    loadData();
  }

  Future loadData() async{
    var tmpData = await _novostiProvider!.getById(int.parse(this.widget.id));
    var tmpKorisnik = await _korisnikProvider!.getById(tmpData.korisnikID!);
    setState(() {
      _novost = tmpData;
      _korisnik = tmpKorisnik;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eBarberShop - Novost detalji"),backgroundColor: Colors.grey[900],),
      body: SingleChildScrollView(
        child: Container(
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
                        Expanded(child: Text("Napisao: ${_korisnik!.ime} ${_korisnik!.prezime} , Datum: ${formatDate(_novost!.datumKreiranja!)}")),
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