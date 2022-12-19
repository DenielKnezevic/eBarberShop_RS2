import 'package:ebarbershop_mobile/providers/base-provider.dart';

import '../models/slika.dart';

class SlikaProvider extends BaseProvider<Slika>{
  SlikaProvider() : super("Slika");

  @override
  Slika fromJson(x) {
    // TODO: implement fromJson
    return Slika.fromJson(x);
  }
}