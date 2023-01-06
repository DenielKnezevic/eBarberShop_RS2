import 'package:json_annotation/json_annotation.dart';

import 'korisnik.dart';
import 'narudzbaproizvodi.dart';

part 'narudzba.g.dart';

@JsonSerializable()
class Narudzba{
  int? narudzbaID;
  String? brojNarudzbe;
  int? korisnikID;
  DateTime? datumNarudzbe;
  String? narudzbaProizvodi;
  double? ukupnaCijena;
  bool? isCanceled;
  bool? isShipped;
  Korisnik? korisnik;
  List<NarudzbaProizvodi>? narudzbaProizvodis;
  

  Narudzba();

  factory Narudzba.fromJson(Map<String, dynamic> json) => _$NarudzbaFromJson(json);

    Map<String, dynamic> toJson() => _$NarudzbaToJson(this);
}