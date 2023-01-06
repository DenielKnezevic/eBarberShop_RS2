import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../models/cart.dart';
import '../providers/cart-provider.dart';
import '../utils/util.dart';

class CartScreen extends StatefulWidget {
  static const String routeName = "/cart";
  const CartScreen({Key? key}) : super(key: key);

  @override
  State<CartScreen> createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen> {
  late CartProvider _cartProvider;
  //late OrderProvider _orderProvider;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

  @override
  void didChangeDependencies() {
    // TODO: implement didChangeDependencies
    super.didChangeDependencies();
    _cartProvider = context.watch<CartProvider>();
    //_orderProvider = context.read<OrderProvider>();
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
            TextButton(onPressed: () {}, child: Text("Kupi" , style: TextStyle(color: Colors.black , fontSize: 18),)),
        ],
      ),
    );
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
          "Cijena ${item.product.cijena} | Ukupno: ${item.product.cijena! * item.count}"),
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
}
