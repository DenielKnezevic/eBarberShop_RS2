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
      body: SafeArea(child: SingleChildScrollView(child: 
      Container(
        height: 700,
        child: 
      Column(children: [
          buildHeader(),
          Expanded(child: GridView.count(crossAxisCount: 3,
          crossAxisSpacing: 8.0,
          mainAxisSpacing: 8.0,
          children: _buildGallery(),))
      ]),)),)
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Galerija",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<Widget> _buildGallery()
  {
    var list = data.map((e) => 
          Container(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.center,
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                  Container(
                    width: 125,
                    height: 125,
                    child: imageFromBase64String(e.slikaByte!),)
            ]),
          )).cast<Widget>().toList();

          return list;
  }
}