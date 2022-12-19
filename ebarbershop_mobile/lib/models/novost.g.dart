// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'novost.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Novost _$NovostFromJson(Map<String, dynamic> json) => Novost()
  ..novostID = json['novostID'] as int?
  ..sadrzaj = json['sadrzaj'] as String?
  ..thumbnail = json['thumbnail'] as String?
  ..opis = json['opis'] as String?;

Map<String, dynamic> _$NovostToJson(Novost instance) => <String, dynamic>{
      'novostID': instance.novostID,
      'sadrzaj': instance.sadrzaj,
      'thumbnail': instance.thumbnail,
      'opis': instance.opis,
    };
