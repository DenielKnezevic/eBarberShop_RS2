import 'package:json_annotation/json_annotation.dart';

part 'korisnik.g.dart';

@JsonSerializable()
class Korisnik{
  int? korisnikID;
  String? ime;
  String? prezime;
  String? korisnickoIme;
  DateTime? datumRodjenja;
  String? email;
  String? telefon;
  String? lokacija;

  Korisnik();

  factory Korisnik.fromJson(Map<String, dynamic> json) => _$KorisnikFromJson(json);

    Map<String, dynamic> toJson() => _$KorisnikToJson(this);
}