import 'package:ebarbershop_mobile/providers/drzava-provider.dart';
import 'package:ebarbershop_mobile/providers/grad-provider.dart';
import 'package:ebarbershop_mobile/providers/korisnik-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/drzava.dart';
import '../models/grad.dart';
import '../models/korisnik.dart';
import '../models/usluga.dart';
import '../providers/usluga-provider.dart';
import '../utils/util.dart';

class ProfileModifyScreen extends StatefulWidget {
  static const String routeName = "/profile_modify";
  String id;
  ProfileModifyScreen(this.id,{Key? key}) : super(key: key);

  @override
  State<ProfileModifyScreen> createState() => _ProfileModifyScreenState();
}

class _ProfileModifyScreenState extends State<ProfileModifyScreen> {

  KorisnikProvider? _korisnikProvider = null;
  DrzavaProvider? _drzavaProvider = null;
  GradProvider? _gradProvider = null;
  Korisnik? _korisnik = null;
  List<Drzava> drzava = [];
  Drzava? _selectedItemDrzava = null;
  List<Grad> grad = [];
  Grad? _selectedItemGrad = null;
  TextEditingController _ImeController = TextEditingController();
  TextEditingController _PrezimeController = TextEditingController();
  TextEditingController _EmailController = TextEditingController();
  TextEditingController _TelefonController = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _korisnikProvider = context.read<KorisnikProvider>();
    _drzavaProvider = context.read<DrzavaProvider>();
    _gradProvider = context.read<GradProvider>();
    loadData();
  }

  Future loadData() async{
     var tmpGrad = await _gradProvider?.Get();
     var tmpDrzava = await _drzavaProvider?.Get();
    var tmpData = await _korisnikProvider!.getById(int.parse(this.widget.id));
    setState(() {
      _korisnik = tmpData;
      drzava = tmpDrzava!;
      grad = tmpGrad!;
      _selectedItemDrzava = drzava.firstWhere((element) => element.drzavaID == _korisnik!.drzavaID);
      _selectedItemGrad = grad.firstWhere((element) => element.gradID == _korisnik!.gradID);
      _EmailController.text = _korisnik!.email!;
      _ImeController.text = _korisnik!.ime!;
      _PrezimeController.text = _korisnik!.prezime!;
      _TelefonController.text = _korisnik!.telefon!;
    });
  }


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eBarberShop - Edit profile"),backgroundColor: Colors.grey[900],),
      body:SafeArea(
        child: SingleChildScrollView(child: Container(child: 
        Column(
          children: [
                buildHeader(),
                SizedBox(height: 50),
                Padding(
          padding: const EdgeInsets.all(20.0),
          child: buildProfile(),
          ),
        SizedBox(height: 10,),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                  FlatButton(onPressed: () async {
                    Map user = {
                      "ime" : _ImeController.text,
                      "prezime" : _PrezimeController.text,
                      "email" : _EmailController.text,
                      "telefon" : _TelefonController.text,
                      "gradID" : _selectedItemGrad!.gradID,
                      "drzavaID" : _selectedItemDrzava!.drzavaID
                    };
                    await _korisnikProvider!.update(Authorization.korisnik!.korisnikID, user);
                    Navigator.pop(context,true);
                    ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Profil uspjesno uredjen")));
                  }, child: Text("Save changes" ,style: TextStyle(color: Colors.white),), color:Colors.grey[900],shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(8))),
                ],)
      
        ]),),),
      )
    );
  }

  Widget buildProfile(){
    if(_korisnik== null)
    {
      return Center(child: Text("Loading"),);
    }

    else{

      return  Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Padding(
            padding: const EdgeInsets.symmetric(vertical: 0 , horizontal: 20),
            child: Row(
              children: [
                Text('Ime:', style: Theme.of(context).textTheme.headline6),
              ],
            ),
          ),
          SizedBox(height: 8),
            Container(
              width: 320,
               child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: TextField(controller:_ImeController, style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 0 , horizontal: 20),
              child: Row(
                children: [
                  Text('Prezime:', style: Theme.of(context).textTheme.headline6),
                ],
              ),
            ),
            SizedBox(height: 8),
            Container(
              width: 320,
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: TextField(controller: _PrezimeController, style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 0 , horizontal: 20),
              child: Row(
                children: [
                  Text('Email:', style: Theme.of(context).textTheme.headline6),
                ],
              ),
            ),
            SizedBox(height: 8),
            Container(
              width: 320,
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: TextField(controller: _EmailController, style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 0 , horizontal: 20),
              child: Row(
                children: [
                  Text('Broj telefona:', style: Theme.of(context).textTheme.headline6),
                ],
              ),
            ),
            SizedBox(height: 8),
            Container(
              width: 320,
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: TextField(controller: _TelefonController, style: TextStyle(fontSize: 18)))),
                 Padding(
                   padding: const EdgeInsets.all(20.0),
                   child: Row(
                     children: [
                       Expanded(
                         child: DropdownButton<Drzava>(
                              isExpanded: true,
                              underline: SizedBox(),
                              value: _selectedItemDrzava,
                              items: drzava.map((e) => DropdownMenuItem(child: Text(e.naziv!),value: e,)).toList(), 
                              onChanged: (val){
                                setState(() {
                                  _selectedItemDrzava = val as Drzava;
                                });
                              } ),
                       ),
                            Expanded(
                              child: DropdownButton<Grad>(
                              isExpanded: true,
                              underline: SizedBox(),
                              value: _selectedItemGrad,
                              items: grad.map((e) => DropdownMenuItem(child: Text(e.naziv!),value: e,)).toList(), 
                              onChanged: (val){
                                setState(() {
                                  _selectedItemGrad = val as Grad;
                                });
                              } ),
                            ),
                     ],
                   ),
                 )
        ],
      );
    }
  }
  
  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Column(children: [
        Text(
        "Edit profile",
        style: TextStyle(
            color: Colors.grey[800], fontSize: 40, fontWeight: FontWeight.w600),
      ),
      ],)
    );
  }
}