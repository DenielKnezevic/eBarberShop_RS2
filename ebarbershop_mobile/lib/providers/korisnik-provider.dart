import 'dart:convert';

import 'package:ebarbershop_mobile/providers/base-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';

import '../models/korisnik.dart';

class KorisnikProvider extends BaseProvider<Korisnik>{
  KorisnikProvider():super("Korisnik");
  
  @override
  Korisnik fromJson(x) {
    // TODO: implement fromJson
    return Korisnik.fromJson(x);
  }
}