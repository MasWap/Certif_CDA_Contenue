import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/client_screen.dart';
import 'package:iapm_mobile/screens/connexion_screen.dart';
import 'package:iapm_mobile/screens/home_screen.dart';


void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key});

  // Définir les teintes de couleur pour primarySwatch
  static const MaterialColor primarySwatchColor = MaterialColor(
    0xFFD9D0C8,
    <int, Color>{
      50: Color(0xFFF2EEEC),
      100: Color(0xFFE2DAD6),
      200: Color(0xFFD0C5BE),
      300: Color(0xFFBDB1A6),
      400: Color(0xFFAFA296),
      500: Color(0xFF9F907F),
      600: Color(0xFF958977),
      700: Color(0xFF8A7F6E),
      800: Color(0xFF807666),
      900: Color(0xFF6E654F),
    },
  );

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'IAPM Mobile',
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        primarySwatch: primarySwatchColor,
      ),
      home: DatabaseLoginForm(),
    );
  }
}

