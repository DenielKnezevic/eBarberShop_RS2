import 'package:ebarbershop_mobile/providers/base-provider.dart';
import '../models/usluga.dart';

class UslugaProvider extends BaseProvider<Usluga>{
  UslugaProvider(): super("Usluga");

  @override
  fromJson(x) {
    // TODO: implement fromJson
    return Usluga.fromJson(x);
  }
}