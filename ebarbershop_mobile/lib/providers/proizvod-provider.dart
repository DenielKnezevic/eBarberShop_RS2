import 'package:ebarbershop_mobile/models/proizvod.dart';
import 'package:ebarbershop_mobile/providers/base-provider.dart';

class ProizvodProvider extends BaseProvider<Proizvod>{
  ProizvodProvider(): super("Proizvod");

  @override
  fromJson(x) {
    // TODO: implement fromJson
    return Proizvod.fromJson(x);
  }
}