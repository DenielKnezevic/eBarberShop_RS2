import 'dart:convert';

import 'package:ebarbershop_mobile/providers/base-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';

import '../models/drzava.dart';
import '../models/korisnik.dart';

class DrzavaProvider extends BaseProvider<Drzava>{
  DrzavaProvider():super("Drzava");
  
  @override
  Drzava fromJson(x) {
    // TODO: implement fromJson
    return Drzava.fromJson(x);
  }
}