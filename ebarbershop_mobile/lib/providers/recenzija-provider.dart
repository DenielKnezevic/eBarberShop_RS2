import 'package:ebarbershop_mobile/providers/base-provider.dart';

import '../models/recenzija.dart';

class RecenzijaProvider extends BaseProvider<Recenzija>{
  RecenzijaProvider(): super("Recenzija");

  @override
  fromJson(x) {
    // TODO: implement fromJson
    return Recenzija.fromJson(x);
  }
}