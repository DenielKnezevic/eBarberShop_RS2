import '../models/rezervacija.dart';
import 'base-provider.dart';

class RezervacijaProvider extends BaseProvider<Rezervacija>{
  RezervacijaProvider():super("Rezervacija");
  
  @override
  Rezervacija fromJson(x) {
    // TODO: implement fromJson
    return Rezervacija.fromJson(x);
  }
}