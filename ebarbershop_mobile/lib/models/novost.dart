import 'package:json_annotation/json_annotation.dart';

part 'novost.g.dart';

@JsonSerializable()
class Novost{
  int? novostID;
  String? sadrzaj;
  String? thumbnail;
  String? opis;

  Novost();

    factory Novost.fromJson(Map<String, dynamic> json) => _$NovostFromJson(json);

    Map<String, dynamic> toJson() => _$NovostToJson(this);
}