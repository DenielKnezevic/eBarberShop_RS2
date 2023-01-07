import 'package:ebarbershop_mobile/providers/rezervacija-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/rezervacija.dart';

class RezervacijaScreen extends StatefulWidget {
  static const String routeName = "/rezervacije";
  const RezervacijaScreen({Key? key}) : super(key: key);

  @override
  State<RezervacijaScreen> createState() => _RezervacijaScreenState();
}

class _RezervacijaScreenState extends State<RezervacijaScreen> {
  RezervacijaProvider? _rezervacijaProvider = null;
  List<Rezervacija> list = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _rezervacijaProvider = context.read<RezervacijaProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _rezervacijaProvider!.Get({
      'korisnikID': Authorization.korisnik!.korisnikID,
      'isCanceled': false,
      'isArchived':false
    });
    setState(() {
      list = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("eBarberShop - Rezervacije"),
        backgroundColor: Colors.grey[900],
      ),
      body: SafeArea(
        child: Column(children: [
          Expanded(
            child: _buildRezervacije(),
          )
        ]),
      ),
    );
  }

  Widget _buildRezervacije() {
    if (list.isEmpty) {
      return Center(
        child: Text("Trenutno nemate aktivnih rezervacija"),
      );
    }

    return Container(
      child: ListView.builder(
        itemCount: list.length,
        itemBuilder: (context, index) {
          return _buildRezervacijeCard(list[index]);
        },
      ),
    );
  }

  Widget _buildRezervacijeCard(Rezervacija item) {
    return ListTile(
      leading: IconButton(
        onPressed: () async {
          Map update = {
            "korisnikID": item.korisnikID,
            "terminID": item.terminID,
            "uslugaID": item.uslugaID,
            "isCanceled": true,
            "isArchived": false
          };

          await _rezervacijaProvider!.update(item.rezervacijaID, update);
          loadData();
          ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Rezervacija otkazana")));
        },
        icon: Icon(Icons.delete_forever),
        iconSize: 40,
        color: Colors.red,
      ),
      title: Text("${formatDate(item.termin!.datumTermina!)}"),
      subtitle: Text(
          "Termin kod ${item.termin!.korisnik!.ime} ${item.termin!.korisnik!.prezime}"),
      trailing: Text("${item.termin!.vrijemeTermina}"),
    );
  }
}
