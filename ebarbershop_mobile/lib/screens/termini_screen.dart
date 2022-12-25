import 'package:ebarbershop_mobile/providers/usluga-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/termin.dart';
import '../models/usluga.dart';
import '../providers/termin-provider.dart';

class TerminiScreen extends StatefulWidget {
  const TerminiScreen({Key? key}) : super(key: key);

  @override
  State<TerminiScreen> createState() => _TerminiScreenState();
}

class _TerminiScreenState extends State<TerminiScreen> {

  TerminProvider? _terminProvider = null;
  UslugaProvider? _uslugaProvider = null;
  List<Termin> data = [];
  List<Usluga> usluga = [];
  Usluga? _selectedItem = null;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _uslugaProvider = context.read<UslugaProvider>();
    _terminProvider = context.read<TerminProvider>();
    loadData();
    
  }

  Future loadData() async {
    var tmpUsluga = await _uslugaProvider?.Get();
    var tmpData = await _terminProvider?.Get();
    setState(() {
      data = tmpData!;
      usluga = tmpUsluga!;
      _selectedItem = usluga[0];
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      floatingActionButton: FloatingActionButton(onPressed: () {
   },
   backgroundColor: Colors.grey[800],
   child: const Icon(Icons.calendar_month),),
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
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: _buildTermini(),),
          ),)
        ]),
      ),
    ),),
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Column(children: [
        Text(
        "Rezervacije",
        style: TextStyle(
            color: Colors.grey[800], fontSize: 40, fontWeight: FontWeight.w600),
      )
      ],)
    );
  }

  List<Widget> _buildTermini() {
    if (data.length == 0) {
      return [
        Center(
          child: Text("Nema podataka za prikaz"),
        )
      ];
    }

    List<Widget> list = data
        .map((e) => Column(children: [
          Padding(
            padding: const EdgeInsets.fromLTRB(8.0, 0, 8.0, 0),
            child: Container(
                height: 100,
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  color: Colors.grey[200], ),
                child: Row(mainAxisAlignment: MainAxisAlignment.spaceEvenly, crossAxisAlignment: CrossAxisAlignment.center, children: [
                  Text(e.vrijemeTermina!),
                  DropdownButton<Usluga>(
                    value: _selectedItem,
                    items: usluga.map((e) => DropdownMenuItem(child: Text(e.naziv!),value: e,)).toList(), 
                    onChanged: (val){
                      setState(() {
                        _selectedItem = val as Usluga;
                      });
                    } ),
                  ElevatedButton(
                    style: ElevatedButton.styleFrom(
                        primary: Colors.amber[400]
                    ),
                    onPressed: (){},child: Text("Rezervisi"),)
                ]),
              ),
          ),
        SizedBox(height:10)
        ],))
        .cast<Widget>()
        .toList();

    return list;
  }
}