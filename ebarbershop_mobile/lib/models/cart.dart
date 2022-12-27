import 'package:ebarbershop_mobile/models/proizvod.dart';

class Cart {
    List<CartItem> items = [];
}

class CartItem {
  CartItem(this.product);
  late Proizvod product;
}