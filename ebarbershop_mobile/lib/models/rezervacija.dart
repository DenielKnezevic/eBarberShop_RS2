import 'package:ebarbershop_mobile/models/korisnik.dart';
import 'package:ebarbershop_mobile/models/termin.dart';
import 'package:ebarbershop_mobile/models/usluga.dart';
import 'package:json_annotation/json_annotation.dart';

part 'rezervacija.g.dart';

@JsonSerializable()
class Rezervacija{
  int? rezervacijaID;
  int? korisnikID;
  int? terminID;
  int? uslugaID;
  DateTime? datumRezervacije;
  bool? isCanceled;
  bool? isArchived;
  Korisnik? korisnik;
  Termin? termin;
  Usluga? usluga;

  Rezervacija();

  factory Rezervacija.fromJson(Map<String, dynamic> json) => _$RezervacijaFromJson(json);

    Map<String, dynamic> toJson() => _$RezervacijaToJson(this);
}