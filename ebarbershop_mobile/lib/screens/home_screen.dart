import 'package:ebarbershop_mobile/screens/novosti_list_screen.dart';
import 'package:ebarbershop_mobile/screens/product_screen.dart';
import 'package:ebarbershop_mobile/screens/profile_screen.dart';
import 'package:ebarbershop_mobile/screens/termini_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({Key? key}) : super(key: key);
  static const String routeName = "/home";

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {

  List<Widget> _pages = <Widget>[
    NovostListScreen(),
    TerminiScreen(),
    ProductScreen(),
    Center(child: Text("Recenzije")),
    ProfileScreen()];
  int _currentIndex = 0;
  void _onItemTapped(int index) {
    setState(() {
      _currentIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar:AppBar(
        backgroundColor: Colors.grey[900],
        title: const Center(child: Text("eBarberShop")),
      ),
      body:_pages.elementAt(_currentIndex),
      bottomNavigationBar:BottomNavigationBar(
        type: BottomNavigationBarType.fixed,
        selectedItemColor:Colors.amber[400],
        unselectedItemColor: Colors.white,
        backgroundColor: Colors.grey[900],
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
            icon: Icon(Icons.newspaper),
            label: 'Novosti',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.calendar_month_rounded),
            label: 'Rezervacije',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.shopping_bag_rounded),
            label: 'Proizvodi',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.star),
            label: 'Recenzije',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.account_circle_rounded),
            label: 'Profil',
          ),
        ],
        currentIndex: _currentIndex,
        onTap: _onItemTapped,
      ),
    );
  }
}