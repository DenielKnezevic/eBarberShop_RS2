import 'package:ebarbershop_mobile/providers/base-provider.dart';

import '../models/novost.dart';

class NovostiProvider extends BaseProvider<Novost>{
  NovostiProvider(): super("Novost");

  @override
  fromJson(x) {
    // TODO: implement fromJson
    return Novost.fromJson(x);
  }
}