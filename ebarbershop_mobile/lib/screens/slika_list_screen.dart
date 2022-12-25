import 'package:ebarbershop_mobile/providers/slika-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/slika.dart';

class SlikaListScreen extends StatefulWidget {
  const SlikaListScreen({Key? key}) : super(key: key);
  static const String routeName = '/slike';

  @override
  State<SlikaListScreen> createState() => _SlikaListScreenState();
}

class _SlikaListScreenState extends State<SlikaListScreen> {

  SlikaProvider? _slikaProvider = null;
  List<Slika> data = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _slikaProvider = context.read<SlikaProvider>();
    loadData();
  }

   Future loadData() async {
    var tmpData = await _slikaProvider!.Get();
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eBarberShop galerija"),backgroundColor: Colors.grey[900],),
      body: SafeArea(child: 
      Container(
        height: 700,
        child: 
      Column(children: [
          buildHeader(),
          Expanded(child: GridView.count(
          crossAxisCount: 3,
          mainAxisSpacing:8,
          crossAxisSpacing:8,
          children: _buildGallery(),))
      ]),)),
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Galerija",
        style: TextStyle(
            color: Colors.grey[900], fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<Widget> _buildGallery()
  {
    var list = data.map((e) => 
          Container(
            child:Padding(padding: EdgeInsets.all(4),
            child: Container(
                    width: 180,
                    child: ClipRRect(
                      borderRadius: BorderRadius.circular(10),
                      child: Image(image:imageFromBase64String(e.slikaByte!).image,fit:BoxFit.cover)),)
            ),)
          ).cast<Widget>().toList();

          return list;
  }
}