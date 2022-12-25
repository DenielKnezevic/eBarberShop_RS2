import 'package:ebarbershop_mobile/models/vrstaproizvoda.dart';
import 'package:flutter/cupertino.dart';
import 'package:json_annotation/json_annotation.dart';

part 'proizvod.g.dart';

@JsonSerializable()
class Proizvod{
  int? proizvodID;
  String? naziv;
  String? sifra;
  double? cijena;
  String? slika;
  int? vrstaProizvodaID;
  VrstaProizvoda? vrstaProizvoda;

  Proizvod();

  factory Proizvod.fromJson(Map<String, dynamic> json) => _$ProizvodFromJson(json);

    Map<String, dynamic> toJson() => _$ProizvodToJson(this);
}