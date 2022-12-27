import 'package:ebarbershop_mobile/providers/korisnik-provider.dart';
import 'package:ebarbershop_mobile/screens/profile_modify_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/korisnik.dart';
import '../utils/util.dart';

class ProfileScreen extends StatefulWidget {
  const ProfileScreen({Key? key}) : super(key: key);

  @override
  State<ProfileScreen> createState() => _ProfileScreenState();
}

class _ProfileScreenState extends State<ProfileScreen> {

  KorisnikProvider? _korisnikProvider = null;
  Korisnik? korisnik = null;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _korisnikProvider = context.read<KorisnikProvider>();
    loadData();
  }

  Future loadData() async {
    var tmp = await _korisnikProvider!.getById(Authorization.korisnik!.korisnikID!);
    setState(() {
      korisnik = tmp;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body:SingleChildScrollView(child: Container(child: 
      Column(
        children: [
              buildHeader(),
              SizedBox(height: 10),
              Text("${Authorization.Username}" , style: TextStyle( fontSize: 32, fontWeight: FontWeight.bold, color: Colors.grey[900])),
              Icon(Icons.account_circle,size: 130.0,),
              Padding(
        padding: const EdgeInsets.all(20.0),
        child: buildUser() ,
      ),
      SizedBox(height: 10,),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                FlatButton(onPressed: (){ Navigator.pushNamed(context, "${ProfileModifyScreen.routeName}/${Authorization.korisnik!.korisnikID}");}, child: Text("Edit profile" ,style: TextStyle(color: Colors.white),), color:Colors.grey[900],shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(8))),
              ],)

      ]),),)
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Column(children: [
        Text(
        "Profil",
        style: TextStyle(
            color: Colors.grey[800], fontSize: 40, fontWeight: FontWeight.w600),
      ),
      ],)
    );
  }

  Widget buildUser(){
    if(korisnik == null)
    {
      return Center(child: Text("Ucitavanje"),);
    }

    else{
      return Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Ime:', style: Theme.of(context).textTheme.headline6),
            SizedBox(height: 8),
            Container(
              width: 320,
              decoration: BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.black.withOpacity(0.3),
                    width: 1,
                  ),
                ),
              ),
               child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: Text('${korisnik!.ime}', style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Text('Prezime:', style: Theme.of(context).textTheme.headline6),
            SizedBox(height: 8),
            Container(
              width: 320,
              decoration: BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.black.withOpacity(0.3),
                    width: 1,
                  ),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: Text('${korisnik!.prezime}', style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Text('Email:', style: Theme.of(context).textTheme.headline6),
            SizedBox(height: 8),
            Container(
              width: 320,
              decoration: BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.black.withOpacity(0.3),
                    width: 1,
                  ),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: Text('${korisnik!.email}', style: TextStyle(fontSize: 18)))
            ),
            SizedBox(height: 16),
            Text('Datum rodjenja:', style: Theme.of(context).textTheme.headline6),
            SizedBox(height: 8),
            Container(
              width: 320,
              decoration: BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.black.withOpacity(0.3),
                    width: 1,
                  ),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: Text('${formatDate(korisnik!.datumRodjenja!)}', style: TextStyle(fontSize: 18)))),
                 SizedBox(height: 16),
            Text('Broj telefona:', style: Theme.of(context).textTheme.headline6),
            SizedBox(height: 8),
            Container(
              width: 320,
              decoration: BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.black.withOpacity(0.3),
                    width: 1,
                  ),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.only(bottom: 4),
                child: Text('${Authorization.korisnik!.telefon}', style: TextStyle(fontSize: 18))))
          ],
        );
    }
  }
}