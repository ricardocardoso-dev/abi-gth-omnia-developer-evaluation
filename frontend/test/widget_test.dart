import 'package:flutter_test/flutter_test.dart';
import 'package:wishlist_frontend/main.dart';

void main() {
  testWidgets('renders scaffold message', (tester) async {
    await tester.pumpWidget(const WishlistApp());

    expect(find.text('Wishlist POC'), findsOneWidget);
    expect(
      find.text('Workspace scaffold pronto para desenvolvimento.'),
      findsOneWidget,
    );
  });
}
