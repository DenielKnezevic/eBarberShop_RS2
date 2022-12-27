import 'dart:convert';

import 'package:ebarbershop_mobile/providers/base-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';

import '../models/drzava.dart';
import '../models/grad.dart';
import '../models/korisnik.dart';

class GradProvider extends BaseProvider<Grad>{
  GradProvider():super("Grad");
  
  @override
  Grad fromJson(x) {
    // TODO: implement fromJson
    return Grad.fromJson(x);
  }
}