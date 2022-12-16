// ignore_for_file: prefer_const_constructors, sort_child_properties_last
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Flutter Demo',
        theme: ThemeData(
          primarySwatch: Colors.blue,
        ),
        home: Scaffold(
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
                  height: 350,
                ),
                Padding(
                  padding: EdgeInsets.all(40),
                  child: Column(children: [
                    Container(
                      child: TextField(
                        decoration: InputDecoration(
                            fillColor: Colors.amber[200],
                            border: InputBorder.none,
                            hintText: "Username or email",
                            hintStyle: TextStyle(
                                color: Colors.amber[200])),
                      ),
                      padding: EdgeInsets.all(8),
                    ),
                    Container(
                      child: TextField(
                        decoration: InputDecoration(
                            fillColor: Colors.amber[200],
                            border: InputBorder.none,
                            hintText: "Username or email",
                            hintStyle: TextStyle(
                                color: Colors.amber[200])),
                      ),
                      padding: EdgeInsets.all(8),
                    )
                  ]),
                )
              ],
            ),
          ),)
        )));
  }
}
