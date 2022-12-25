import 'package:json_annotation/json_annotation.dart';

import 'korisnik.dart';

part 'novost.g.dart';

@JsonSerializable()
class Novost{
  int? novostID;
  String? naslov;
  String? sadrzaj;
  String? thumbnail;
  String? opis;
  DateTime? datumKreiranja;
  int? korisnikID;
  Korisnik? korisnik;

  Novost();

    factory Novost.fromJson(Map<String, dynamic> json) => _$NovostFromJson(json);

    Map<String, dynamic> toJson() => _$NovostToJson(this);
}