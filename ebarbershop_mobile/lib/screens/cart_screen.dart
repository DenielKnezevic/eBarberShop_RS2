import 'dart:convert';

import 'package:ebarbershop_mobile/providers/narudzba-provider.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';

import '../models/cart.dart';
import '../models/uplata.dart';
import '../providers/cart-provider.dart';
import '../providers/uplata-provider.dart';
import '../utils/util.dart';
import 'package:http/http.dart' as http;

class CartScreen extends StatefulWidget {
  static const String routeName = "/cart";
  const CartScreen({Key? key}) : super(key: key);

  @override
  State<CartScreen> createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen> {
  late CartProvider _cartProvider;
  NarudzbaProvider? _narudzbaProvider =null;
  UplataProvider? _uplataProvider = null;
  Map<String, dynamic>? paymentIntentData;
  Uplata? uplata = null;
  double iznos = 0;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _uplataProvider = context.read<UplataProvider>();
  }

  @override
  void didChangeDependencies() {
    // TODO: implement didChangeDependencies
    super.didChangeDependencies();
    _cartProvider = context.watch<CartProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("eBarberShop korpa"),
        backgroundColor: Colors.grey[900],
      ),
      body: Column(
        children: [
          Expanded(child: _buildProductCardList()),
          if (_cartProvider.cart.items.isNotEmpty)
            TextButton(onPressed: () async{
              await makePayment(IzracunajUkupno());
            }, child: Text("Kupi" , style: TextStyle(color: Colors.black , fontSize: 18),)),
        ],
      ),
    );
  }

  double IzracunajUkupno()
  {
    _cartProvider.cart.items.forEach((element) {
      iznos += (element.product.cijena! * element.count).toDouble();
    });

    return iznos;
  }

  Widget _buildProductCardList() {
    if (_cartProvider.cart.items.isEmpty) {
      return Center(
        child: Text("Korpa je trenutno prazna"),
      );
    }

    return Container(
      child: ListView.builder(
        itemCount: _cartProvider.cart.items.length,
        itemBuilder: (context, index) {
          return _buildProductCard(_cartProvider.cart.items[index]);
        },
      ),
    );
  }

  Widget _buildProductCard(CartItem item) {
    return ListTile(
      leading: imageFromBase64String(item.product.slika!),
      title: Text("${item.product.naziv} | Kolicina: ${item.count.toString()}"),
      subtitle: Text(
          "Cijena ${formatNumber(item.product.cijena)} KM | Ukupno: ${formatNumber(item.product.cijena! * item.count)} KM"),
      trailing: IconButton(
        onPressed: () {
          _cartProvider.removeFromCart(item.product);
        },
        icon: Icon(Icons.delete_forever),
        iconSize: 30.0,
        color: Colors.red,
      ),
    );
  }

   Future<void> makePayment(double iznos) async {
    try {
      paymentIntentData =
          await createPaymentIntent((iznos * 100).round().toString(), 'bam');
      await Stripe.instance
          .initPaymentSheet(
              paymentSheetParameters: SetupPaymentSheetParameters(
                  paymentIntentClientSecret:
                      paymentIntentData!['client_secret'],
                  applePay: true,
                  googlePay: true,
                  testEnv: true,
                  style: ThemeMode.dark,
                  merchantCountryCode: 'BIH',
                  merchantDisplayName: 'eBarberShop'))
          .then((value) {});

          //await insertUplata(iznos, paymentIntentData!['id']);

      displayPaymentSheet();
    } catch (e, s) {
      print('exception:$e$s');
    }
  }

  createPaymentIntent(String amount, String currency) async {
    try {
      Map<String, dynamic> body = {
        'amount': amount,
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization':
                'Bearer sk_test_51MJfv3ANnFXjgSPxrqttss02QUEXxTxuRFWt8wa9OW7YAdeSm5BWbyzWW7VMZpgdNAxEoIPrDChOaVPU3TcVMiEE00dFlx2iwO',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }

  insertUplata(double amount, String brojTransakcije) async {
      Map request = {
      "iznos": amount,
      "brojTransakcije": brojTransakcije,
    };

   uplata = await _uplataProvider!.insert(request);
  }

  displayPaymentSheet() async {
    try {
      await Stripe.instance
          .presentPaymentSheet(
              parameters: PresentPaymentSheetParameters(
        clientSecret: paymentIntentData!['client_secret'],
        confirmPayment: true,
      ))
          .onError((error, stackTrace) {
        print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
         showDialog(
          context: context,
          builder: (_) => const AlertDialog(
                content: Text("Ponistena transakcija"),
              ));
        throw Exception("Payment declined");
      });
       
      await InsertStavkeNarudzbe();

      ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Uplata uspjesna")));
    } on StripeException catch (e) {
      showDialog(
          context: context,
          builder: (_) => const AlertDialog(
                content: Text("Ponistena transakcija"),
              ));
    } catch (e) {
      print('$e');
    }
  }

  Future<void> InsertStavkeNarudzbe() async {

    await insertUplata(iznos, paymentIntentData!['id']);

    List<Map> narudzbaProizvodi = [];
    _cartProvider.cart.items.forEach((element) {
      narudzbaProizvodi.add({
        "proizvodID" : element.product.proizvodID,
        "kolicina" : element.count,
      });
    });
    Map narudzba = {
      "korisnikID" : Authorization.korisnik!.korisnikID,
      "uplataID" : uplata!.uplataID,
      "listaProizvoda": narudzbaProizvodi
    };

    await _narudzbaProvider!.insert(narudzba);
    setState(() {
      paymentIntentData = null;
      _cartProvider.cart.items.clear();
    });
  }
}
