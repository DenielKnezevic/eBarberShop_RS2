import 'package:json_annotation/json_annotation.dart';

part 'usluga.g.dart';

@JsonSerializable()
class Usluga{
  int? uslugaID;
  String? naziv;
  String? opis;

  Usluga();

  factory Usluga.fromJson(Map<String, dynamic> json) => _$UslugaFromJson(json);

    Map<String, dynamic> toJson() => _$UslugaToJson(this);
}