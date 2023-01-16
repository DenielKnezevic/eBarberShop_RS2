import 'package:ebarbershop_mobile/providers/novosti-provider.dart';
import 'package:ebarbershop_mobile/screens/slika_list_screen.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/novost.dart';
import 'novosti_details_screen.dart';

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
    var tmpData = await _novostiProvider!.Get({'includeKorisnik':true});
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
   floatingActionButton: FloatingActionButton(onPressed: () {
    Navigator.pushNamed(context, SlikaListScreen.routeName);
   },
   backgroundColor: Colors.grey[800],
   child: const Icon(Icons.photo_library_rounded),),
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Column(children: [
        Text(
        "Novosti",
        style: TextStyle(
            color: Colors.grey[800], fontSize: 40, fontWeight: FontWeight.w600),
      ),
      SizedBox(height: 20,),
      Text(
        "Welcome ${Authorization.Username} !",
        style: TextStyle(
            color: Colors.grey[800], fontSize: 24, fontWeight: FontWeight.w600,),
      ),
      ],)
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
          InkWell(
            onTap: () {
              Navigator.pushNamed(context, "${NovostiDetailsScreen.routeName}/${e.novostID}");
            },
            child: Card(
              elevation: 4,
              child: Row(mainAxisAlignment: MainAxisAlignment.start, children: [
                Expanded(
                  child: Container(
                    child: ClipRRect(
                      child: imageFromBase64String(e.thumbnail!)),
                    width: 170,
                  ),
                ),
                Expanded(
                  child: Padding(
                    padding: EdgeInsets.all(8),
                    child: Container(
                      child: Text(e.naslov!,
                      overflow: TextOverflow.ellipsis)),
                  ),
                ),
              ]),
            ),
          ),
            SizedBox(height: 10,)
        ],))
        .cast<Widget>()
        .toList();

    return list;
  }
}
