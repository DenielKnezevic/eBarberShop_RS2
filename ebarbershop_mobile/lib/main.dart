// ignore_for_file: prefer_const_constructors, sort_child_properties_last
import 'package:ebarbershop_mobile/providers/cart-provider.dart';
import 'package:ebarbershop_mobile/providers/drzava-provider.dart';
import 'package:ebarbershop_mobile/providers/grad-provider.dart';
import 'package:ebarbershop_mobile/providers/korisnik-provider.dart';
import 'package:ebarbershop_mobile/providers/narudzba-provider.dart';
import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:ebarbershop_mobile/providers/proizvod-provider.dart';
import 'package:ebarbershop_mobile/providers/recenzija-provider.dart';
import 'package:ebarbershop_mobile/providers/rezervacija-provider.dart';
import 'package:ebarbershop_mobile/providers/slika-provider.dart';
import 'package:ebarbershop_mobile/providers/termin-provider.dart';
import 'package:ebarbershop_mobile/providers/uplata-provider.dart';
import 'package:ebarbershop_mobile/providers/usluga-provider.dart';
import 'package:ebarbershop_mobile/screens/cart_screen.dart';
import 'package:ebarbershop_mobile/screens/home_screen.dart';
import 'package:ebarbershop_mobile/screens/narudzbe_screen.dart';
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
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';

void main() {
  Stripe.publishableKey =
      "pk_test_51MJfv3ANnFXjgSPxUlW7LiytL0Y30aS9Ul9fh8cvUmXtPTfIsszqtHPethre4CRYHQENylOrTXpUsyhabTUvENDp00pZ63bpSK";
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
      ChangeNotifierProvider(create: (_) => CartProvider()),
      ChangeNotifierProvider(create: (_) => UplataProvider()),
      ChangeNotifierProvider(create: (_) => NarudzbaProvider())
    ],
    child: MaterialApp(
      theme: ThemeData(primaryColor: Colors.grey[800]),
      debugShowCheckedModeBanner: true,
      home: Home(),
      onGenerateRoute: (settings) {
        if (settings.name == NovostListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => NovostListScreen()));
        }
        if (settings.name == SlikaListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => SlikaListScreen()));
        }
        if (settings.name == HomeScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => HomeScreen()));
        }
        if (settings.name == RezervacijaScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => RezervacijaScreen()));
        }
        if (settings.name == RecenzijaScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => RecenzijaScreen()));
        }
        if (settings.name == RecenzijaDodajScreen.routeName) {
          return MaterialPageRoute(
              builder: ((context) => RecenzijaDodajScreen()));
        }
        if (settings.name == CartScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => CartScreen()));
        }
        if (settings.name == NarudzbeScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => NarudzbeScreen()));
        }

        var uri = Uri.parse(settings.name!);
        if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ProductDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ProductDetailsScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == NovostiDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => NovostiDetailsScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ProfileModifyScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ProfileModifyScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == RecenzijaDetailScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => RecenzijaDetailScreen(id));
        }
      },
    ),
  ));
}

class Home extends StatelessWidget {
  TextEditingController _username = TextEditingController();
  TextEditingController _password = TextEditingController();
  late KorisnikProvider _korisnikProvider;
  final _formKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    _korisnikProvider = Provider.of<KorisnikProvider>(context, listen: false);
    return Scaffold(
        body: SafeArea(
            child: SingleChildScrollView(
      child: Container(
        height: MediaQuery.of(context).size.height,
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
              child: Form(
                key: _formKey,
                child: Column(children: [
                  Container(
                    child: TextFormField(
                      validator: (value) {
                        if (value!.isEmpty || value == null) {
                          return "Username ne moze biti prazno polje";
                        } else if (value.length < 3) {
                          return "Username ne moze da sadrzi manje od 3 karaktera";
                        }
                        return null;
                      },
                      style: TextStyle(color: Colors.amber[200]),
                      controller: _username,
                      decoration: InputDecoration(
                          fillColor: Colors.white.withOpacity(0.3),
                          filled: true,
                          border: InputBorder.none,
                          hintText: "Username",
                          hintStyle: TextStyle(color: Colors.amber[200])),
                    ),
                    padding: EdgeInsets.all(8),
                  ),
                  Container(
                    child: TextFormField(
                      validator: (value) {
                        if (value!.isEmpty || value == null) {
                          return "Password ne moze biti prazno polje";
                        } else if (value.length < 4) {
                          return "Passoword ne moze da sadrzi manje od 4 karaktera";
                        }
                        return null;
                      },
                      obscureText: true,
                      style: TextStyle(color: Colors.amber[200]),
                      controller: _password,
                      decoration: InputDecoration(
                          fillColor: Colors.white.withOpacity(0.3),
                          border: InputBorder.none,
                          hintText: "Password",
                          filled: true,
                          hintStyle: TextStyle(color: Colors.amber[200])),
                    ),
                    padding: EdgeInsets.all(8),
                  ),
                  TextButton(
                    onPressed: () async {
                      if (_formKey.currentState!.validate()) {
                        try {
                          Authorization.Username = _username.text;
                          Authorization.Password = _password.text;

                          Authorization.korisnik =
                              await _korisnikProvider.Authenticate();

                          Navigator.of(context).pushNamedAndRemoveUntil(
                              HomeScreen.routeName, (route) => false);
                        } catch (e) {
                          showDialog(
                              context: context,
                              builder: (BuildContext context) => AlertDialog(
                                    title: Text("Error"),
                                    content: Text(e.toString()),
                                    actions: [
                                      TextButton(
                                        child: Text("Ok"),
                                        onPressed: () => Navigator.pop(context),
                                      )
                                    ],
                                  ));
                        }
                      }
                    },
                    child: Container(
                      height: 40,
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: Colors.amber[300]),
                      child: Center(
                          child: const Text(
                        'Login',
                        style: TextStyle(color: Colors.black, fontSize: 14.0),
                      )),
                    ),
                  ),
                ]),
              ),
            )
          ],
        ),
      ),
    )));
  }
}
