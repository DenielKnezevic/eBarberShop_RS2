// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'rezervacija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Rezervacija _$RezervacijaFromJson(Map<String, dynamic> json) => Rezervacija()
  ..rezervacijaID = json['rezervacijaID'] as int?
  ..korisnikID = json['korisnikID'] as int?
  ..terminID = json['terminID'] as int?
  ..uslugaID = json['uslugaID'] as int?
  ..datumRezervacije = json['datumRezervacije'] == null
      ? null
      : DateTime.parse(json['datumRezervacije'] as String)
  ..isCanceled = json['isCanceled'] as bool?
  ..isArchived = json['isArchived'] as bool?
  ..korisnik = json['korisnik'] == null
      ? null
      : Korisnik.fromJson(json['korisnik'] as Map<String, dynamic>)
  ..termin = json['termin'] == null
      ? null
      : Termin.fromJson(json['termin'] as Map<String, dynamic>)
  ..usluga = json['usluga'] == null
      ? null
      : Usluga.fromJson(json['usluga'] as Map<String, dynamic>);

Map<String, dynamic> _$RezervacijaToJson(Rezervacija instance) =>
    <String, dynamic>{
      'rezervacijaID': instance.rezervacijaID,
      'korisnikID': instance.korisnikID,
      'terminID': instance.terminID,
      'uslugaID': instance.uslugaID,
      'datumRezervacije': instance.datumRezervacije?.toIso8601String(),
      'isCanceled': instance.isCanceled,
      'isArchived': instance.isArchived,
      'korisnik': instance.korisnik,
      'termin': instance.termin,
      'usluga': instance.usluga,
    };
