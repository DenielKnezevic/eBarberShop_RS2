// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'termin.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Termin _$TerminFromJson(Map<String, dynamic> json) => Termin()
  ..terminID = json['terminID'] as int?
  ..datumTermina = json['datumTermina'] == null
      ? null
      : DateTime.parse(json['datumTermina'] as String)
  ..vrijemeTermina = json['vrijemeTermina'] as String?
  ..korisnikID = json['korisnikID'] as int?
  ..korisnik = json['korisnik'] == null
      ? null
      : Korisnik.fromJson(json['korisnik'] as Map<String, dynamic>);

Map<String, dynamic> _$TerminToJson(Termin instance) => <String, dynamic>{
      'terminID': instance.terminID,
      'datumTermina': instance.datumTermina?.toIso8601String(),
      'vrijemeTermina': instance.vrijemeTermina,
      'korisnikID': instance.korisnikID,
      'korisnik': instance.korisnik,
    };
