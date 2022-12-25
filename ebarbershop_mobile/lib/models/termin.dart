import 'package:flutter/cupertino.dart';
import 'package:json_annotation/json_annotation.dart';

import 'korisnik.dart';

part 'termin.g.dart';

@JsonSerializable()
class Termin{
  int? terminID;
  DateTime? datumTermina;
  String? vrijemeTermina;
  int? korisnikID;
  Korisnik? korisnik;

  Termin();

  factory Termin.fromJson(Map<String, dynamic> json) => _$TerminFromJson(json);

    Map<String, dynamic> toJson() => _$TerminToJson(this);
}