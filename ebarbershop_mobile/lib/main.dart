// ignore_for_file: prefer_const_constructors, sort_child_properties_last
import 'package:ebarbershop_mobile/providers/cart-provider.dart';
import 'package:ebarbershop_mobile/providers/drzava-provider.dart';
import 'package:ebarbershop_mobile/providers/grad-provider.dart';
import 'package:ebarbershop_mobile/providers/korisnik-provider.dart';
import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/providers/recenzija-provider.dart';
import 'package:ebarbershop_mobile/providers/rezervacija-provider.dart';
import 'package:ebarbershop_mobile/providers/slika-provider.dart';
import 'package:ebarbershop_mobile/providers/termin-provider.dart';
import 'package:ebarbershop_mobile/providers/usluga-provider.dart';
import 'package:ebarbershop_mobile/screens/cart_screen.dart';
import 'package:ebarbershop_mobile/screens/home_screen.dart';
import 'package:ebarbershop_mobile/screens/novosti_details_screen.dart';
import 'package:ebarbershop_mobile/screens/novosti_list_screen.dart';
import 'package:ebarbershop_mobile/screens/product_detail_screen.dart';
import 'package:ebarbershop_mobile/screens/profile_modify_screen.dart';
import 'package:ebarbershop_mobile/screens/recenzija_detail_screen.dart';
import 'package:ebarbershop_mobile/screens/recenzija_dodaj_screen.dart';
import 'package:ebarbershop_mobile/screens/recenzija_screen.dart';
import 'package:ebarbershop_mobile/screens/rezervacija_screen.dart';
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
      ChangeNotifierProvider(create: (_) => SlikaProvider()),
      ChangeNotifierProvider(create: (_) => RezervacijaProvider()),
      ChangeNotifierProvider(create: (_) => GradProvider()),
      ChangeNotifierProvider(create: (_) => DrzavaProvider()),
      ChangeNotifierProvider(create: (_) => CartProvider())
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
        if(settings.name == RezervacijaScreen.routeName){
          return MaterialPageRoute(builder: ((context) => RezervacijaScreen()));
        }
        if(settings.name == RecenzijaScreen.routeName){
          return MaterialPageRoute(builder: ((context) => RecenzijaScreen()));
        }
        if(settings.name == RecenzijaDodajScreen.routeName){
          return MaterialPageRoute(builder: ((context) => RecenzijaDodajScreen()));
        }
        if(settings.name == CartScreen.routeName){
          return MaterialPageRoute(builder: ((context) => CartScreen()));
        }

         var uri = Uri.parse(settings.name!);
          if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == ProductDetailsScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(builder: (context) => ProductDetailsScreen(id));
          }
          else if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == NovostiDetailsScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(builder: (context) => NovostiDetailsScreen(id));
          }
          else if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == ProfileModifyScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(builder: (context) => ProfileModifyScreen(id));
          }
          else if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == RecenzijaDetailScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(builder: (context) => RecenzijaDetailScreen(id));
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
            height:800,
            decoration: BoxDecoration(
                image: DecorationImage(
                    image: AssetImage("assets/images/eBarber.png"),
                    fit: BoxFit.cover)),
            child: Column(
              children: [
                SizedBox(
                  height: 350,
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
