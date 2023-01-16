import 'package:ebarbershop_mobile/models/recenzija.dart';
import 'package:ebarbershop_mobile/providers/recenzija-provider.dart';
import 'package:ebarbershop_mobile/screens/recenzija_detail_screen.dart';
import 'package:ebarbershop_mobile/screens/recenzija_dodaj_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:provider/provider.dart';

class RecenzijaScreen extends StatefulWidget {
  static const String routeName = "/recenzija";
  const RecenzijaScreen({Key? key}) : super(key: key);

  @override
  State<RecenzijaScreen> createState() => _RecenzijaScreenState();
}

class _RecenzijaScreenState extends State<RecenzijaScreen> {

RecenzijaProvider? _recenzijaProvider = null;
  List<Recenzija> data = [];
  int? rating = null;

    @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _recenzijaProvider = context.read<RecenzijaProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _recenzijaProvider!.Get({'includeKorisnik':true});
    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
            child: Container(
          height: MediaQuery.of(context).size.height - 100,
          child: Column(children: [
            buildHeader(),
            Expanded(
                child: Padding(
              padding: const EdgeInsets.all(8.0),
              child: GridView.count(
                crossAxisCount: 2,
                mainAxisSpacing: 8,
                crossAxisSpacing: 8,
                children: _buildRecenzije(),
              ),
            ))
          ]),
        )),
        floatingActionButton: FloatingActionButton(
          onPressed: () async {
            var refresh = await Navigator.pushNamed(context, RecenzijaDodajScreen.routeName);
            if(refresh == true)
            {
              await loadData();
            }
          },
          backgroundColor: Colors.grey[800],
          child: const Icon(Icons.book),
        )
    );
  }

    Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Recenzije",
        style: TextStyle(
            color: Colors.grey[900], fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<Widget> _buildRecenzije(){
    var list = data
        .map((e) => InkWell(
          onTap: () {
            Navigator.pushNamed(context, "${RecenzijaDetailScreen.routeName}/${e.recenzijaID}");
          },
          child: 
        Card(
              elevation: 4,
              child: Padding(
                padding: EdgeInsets.all(8),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Icon(Icons.account_circle , size:50),
                    Text("${e.korisnik!.ime} ${e.korisnik!.prezime}"),
                    RatingBar(
                      ignoreGestures: true,
                      itemSize:24,
                      maxRating: 5,
                      minRating: 1,
                      initialRating: e.ocjena!.toDouble(),
                      allowHalfRating: false,
                      ratingWidget: RatingWidget(full: Icon(Icons.star,color: Colors.amber),
                      half:Icon(Icons.star,color: Colors.amber) ,
                      empty:Icon(Icons.star,color: Colors.grey))
                    , onRatingUpdate: (rate){
                      rating = rate.toInt();
                    }),
                    SizedBox(height: 15,),
                    Expanded(child:Text("${e.sadrzajRecenzije}" , overflow: TextOverflow.ellipsis,) ,)
                  ],
                ),
              ),
            )),)
        .cast<Widget>()
        .toList();

    return list;
  }
}