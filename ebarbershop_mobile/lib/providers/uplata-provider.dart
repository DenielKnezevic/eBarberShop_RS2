import 'dart:convert';

import 'package:ebarbershop_mobile/providers/base-provider.dart';
import 'package:ebarbershop_mobile/utils/util.dart';

import '../models/uplata.dart';


class UplataProvider extends BaseProvider<Uplata>{
  UplataProvider():super("Uplata");
  
  @override
  Uplata fromJson(x) {
    // TODO: implement fromJson
    return Uplata.fromJson(x);
  }
}