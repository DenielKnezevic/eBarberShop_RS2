import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/novost.dart';

class NovostListScreen extends StatefulWidget {
  const NovostListScreen({Key? key}) : super(key: key);
  static const String routeName = "/novosti";

  @override
  State<NovostListScreen> createState() => _NovostListScreenState();
}

class _NovostListScreenState extends State<NovostListScreen> {
  NovostiProvider? _novostiProvider = null;
  List<Novost> data = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _novostiProvider = context.read<NovostiProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _novostiProvider!.Get();
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(child: SingleChildScrollView(
      child: Container(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
          buildHeader(),
          Padding(padding: EdgeInsets.symmetric(vertical: 20,horizontal: 10),
          child: Container(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.center,
                children: buildNovosti(),),
          ),)
        ]),
      ),
    ),),
   floatingActionButton: FloatingActionButton(onPressed: () {},
   backgroundColor: Colors.amber[300],
   child: const Icon(Icons.photo_library_rounded),),
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Novosti",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<Widget> buildNovosti() {
    if (data.length == 0) {
      return [
        Center(
          child: Text("Nema podataka za prikaz"),
        )
      ];
    }

    List<Widget> list = data
        .map((e) => Column(children: [
          Container(
              height: 100,
              decoration: BoxDecoration(border: Border.all(color: Colors.black , width: 1) ),
              child: Row(mainAxisAlignment: MainAxisAlignment.start, children: [
                Container(
                  child: imageFromBase64String(e.thumbnail!),
                  width: 173,
                ),
                Padding(
                  padding: EdgeInsets.all(8),
                  child: Container(
                    width:200,
                    child: Text(e.sadrzaj!)),
                ),
              ]),
            ),
            SizedBox(height: 10,)
        ],))
        .cast<Widget>()
        .toList();

    return list;
  }
}
