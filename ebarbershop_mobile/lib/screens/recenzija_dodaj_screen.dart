import 'package:ebarbershop_mobile/providers/recenzija-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:provider/provider.dart';

class RecenzijaDodajScreen extends StatefulWidget {
  static const String routeName = "/recenzija_dodaj";
  const RecenzijaDodajScreen({Key? key}) : super(key: key);

  @override
  State<RecenzijaDodajScreen> createState() => _RecenzijaDodajScreenState();
}

class _RecenzijaDodajScreenState extends State<RecenzijaDodajScreen> {
  RecenzijaProvider? _recenzijaProvider = null;
  TextEditingController _recenzijaController = TextEditingController();
  int? rating = 3;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _recenzijaProvider = context.read<RecenzijaProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("eBarberShop - Edit profile"),
        backgroundColor: Colors.grey[900],
      ),
      body: SafeArea(
          child: SingleChildScrollView(
        child: Container(
          height: 700,
          width: 600,
          child:
              Column(crossAxisAlignment: CrossAxisAlignment.center, children: [
            buildHeader(),
            SizedBox(height: 120),
            Padding(
              padding: const EdgeInsets.all(12.0),
              child: Card(
                elevation: 6,
                child: Padding(
                  padding: const EdgeInsets.all(20.0),
                  child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      crossAxisAlignment: CrossAxisAlignment.center,
                      children: [
                        SizedBox(
                          height: 20,
                        ),
                        Row(
                          children: [
                            Text('Ocjena:',
                                style: Theme.of(context).textTheme.headline6),
                          ],
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        RatingBar(
                            itemSize: 40,
                            maxRating: 5,
                            minRating: 1,
                            initialRating: 3,
                            allowHalfRating: false,
                            ratingWidget: RatingWidget(
                                full: Icon(Icons.star, color: Colors.amber),
                                half: Icon(Icons.star, color: Colors.amber),
                                empty: Icon(Icons.star, color: Colors.grey)),
                            onRatingUpdate: (rate) {
                              rating = rate.toInt();
                            }),
                        SizedBox(
                          height: 30,
                        ),
                        Row(
                          children: [
                            Text('Sadrzaj recenzije:',
                                style: Theme.of(context).textTheme.headline6),
                          ],
                        ),
                        Container(
                            child: TextField(
                                controller: _recenzijaController,
                                style: TextStyle(fontSize: 18))),
                                SizedBox(height: 30,),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                  FlatButton(onPressed: () async {
                    Map recenzija = {
                      "korisnikID":Authorization.korisnik!.korisnikID,
                      "sadrzajRecenzije": _recenzijaController.text,
                      "ocjena" : rating
                    };

                    await _recenzijaProvider!.insert(recenzija);
                    Navigator.pop(context);

                  }, child: Text("Dodaj recenziju" ,style: TextStyle(color: Colors.white),), color:Colors.grey[900],shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(8))),
                ],)
                      ]),
                ),
              ),
            )
          ]),
        ),
      )),
    );
  }

  Widget buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Nova recenzija",
        style: TextStyle(
            color: Colors.grey[900], fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }
}
