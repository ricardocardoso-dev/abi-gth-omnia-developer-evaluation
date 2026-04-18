import 'package:flutter/material.dart';

void main() {
  runApp(const WishlistApp());
}

class WishlistApp extends StatelessWidget {
  const WishlistApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Wishlist POC',
      home: Scaffold(
        appBar: AppBar(title: const Text('Wishlist POC')),
        body: const Center(
          child: Text('Workspace scaffold pronto para desenvolvimento.'),
        ),
      ),
    );
  }
}
