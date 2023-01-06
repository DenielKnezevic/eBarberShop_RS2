import 'dart:convert';

import 'package:ebarbershop_mobile/providers/base-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';

import '../models/narudzba.dart';


class NarudzbaProvider extends BaseProvider<Narudzba>{
  NarudzbaProvider():super("Narudzba");
  
  @override
  Narudzba fromJson(x) {
    // TODO: implement fromJson
    return Narudzba.fromJson(x);
  }
}