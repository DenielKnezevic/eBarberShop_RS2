// ignore_for_file: prefer_const_constructors, sort_child_properties_last
import 'package:ebarbershop_mobile/providers/korisnik-provider.dart';
import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/providers/recenzija-provider.dart';
import 'package:ebarbershop_mobile/providers/slika-provider.dart';
import 'package:ebarbershop_mobile/providers/termin-provider.dart';
import 'package:ebarbershop_mobile/providers/usluga-provider.dart';
import 'package:ebarbershop_mobile/screens/home_screen.dart';
import 'package:ebarbershop_mobile/screens/novosti_list_screen.dart';
import 'package:ebarbershop_mobile/screens/slika_list_screen.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() {
  runApp(MultiProvider(
    providers: [
      ChangeNotifierProvider(create: (_) => NovostiProvider()),
      ChangeNotifierProvider(create: (_) => KorisnikProvider()),
      ChangeNotifierProvider(create: (_) => ProizvodProvider()),
      ChangeNotifierProvider(create: (_) => RecenzijaProvider()),
      ChangeNotifierProvider(create: (_) => TerminProvider()),
      ChangeNotifierProvider(create: (_) => UslugaProvider()),
      ChangeNotifierProvider(create: (_) => SlikaProvider())
    ],
    child: MaterialApp(
      theme: ThemeData(primaryColor: Colors.grey[800]),
      debugShowCheckedModeBanner: true,
      home: Home(),
      onGenerateRoute: (settings) {
        if(settings.name == NovostListScreen.routeName){
          return MaterialPageRoute(builder: ((context) => NovostListScreen()));
        }
        if(settings.name == SlikaListScreen.routeName){
          return MaterialPageRoute(builder: ((context) => SlikaListScreen()));
        }
         if(settings.name == HomeScreen.routeName){
          return MaterialPageRoute(builder: ((context) => HomeScreen()));
        }
      },
    ),
  ));
}

class Home extends StatelessWidget {

  TextEditingController _username = TextEditingController();
  TextEditingController _password = TextEditingController();
  late KorisnikProvider _korisnikProvider ;

  @override
  Widget build(BuildContext context) {
    _korisnikProvider = Provider.of<KorisnikProvider>(context , listen:false);
    return Scaffold(
            body: SafeArea(
          child: SingleChildScrollView(child: Container(
            height: 700,
            decoration: BoxDecoration(
                image: DecorationImage(
                    image: AssetImage("assets/images/eBarber.png"),
                    fit: BoxFit.fill)),
            child: Column(
              children: [
                SizedBox(
                  height: 320,
                ),
                Padding(
                  padding: EdgeInsets.all(40),
                  child: Column(children: [
                    Container(
                      child: TextField(
                        controller: _username,
                        decoration: InputDecoration(
                            fillColor: Colors.white.withOpacity(0.3),
                            filled: true,
                            border: InputBorder.none,
                            hintText: "Username or email",
                            hintStyle: TextStyle(
                                color: Colors.amber[200])),
                      ),
                      padding: EdgeInsets.all(8),
                    ),
                    Container(
                      child: TextField(
                        controller: _password,
                        decoration: InputDecoration(
                            fillColor: Colors.white.withOpacity(0.3),
                            border: InputBorder.none,
                            hintText: "Password",
                            filled: true,
                            hintStyle: TextStyle(
                                color: Colors.amber[200])),
                      ),
                      padding: EdgeInsets.all(8),
                    ),
                      TextButton(
                  onPressed: () async {
                    Authorization.Username = _username.text;
                    Authorization.Password = _password.text;

                    Authorization.korisnik = await _korisnikProvider.Authenticate();
                    
                    Navigator.of(context).pushNamedAndRemoveUntil(HomeScreen.routeName, (route) => false);
                  },
                  child: Container(
                    height: 40,
                    decoration: BoxDecoration(borderRadius: BorderRadius.circular(10),color: Colors.amber[300]),
                    child: Center(child: const Text(
                      'Login',
                      style: TextStyle(color: Colors.black, fontSize: 14.0),
                    )),
                  ),
                ),
                  ]),
                )
              ],
            ),
          ),)
        ));
  }
}
