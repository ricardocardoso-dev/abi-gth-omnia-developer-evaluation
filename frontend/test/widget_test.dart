import 'package:flutter_test/flutter_test.dart';
import 'package:wishlist_frontend/main.dart';

void main() {
  testWidgets('renders scaffold placeholder text', (WidgetTester tester) async {
    await tester.pumpWidget(const WishlistApp());

    expect(find.text('Wishlist de Presentes (POC)'), findsOneWidget);
    expect(find.text('Workspace pronto para desenvolvimento autônomo'), findsOneWidget);
  });
}
