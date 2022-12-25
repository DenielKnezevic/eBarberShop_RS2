import 'package:ebarbershop_mobile/providers/base-provider.dart';
import '../models/termin.dart';

class TerminProvider extends BaseProvider<Termin>{
  TerminProvider(): super("Termin");

  @override
  fromJson(x) {
    // TODO: implement fromJson
    return Termin.fromJson(x);
  }
}