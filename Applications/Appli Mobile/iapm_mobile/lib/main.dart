import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/client_screen.dart';
import 'package:iapm_mobile/screens/connexion_screen.dart';
import 'package:iapm_mobile/screens/home_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'IAPM Mobile',
        theme: ThemeData(
          primarySwatch: Colors.red,
        ),
        home: DatabaseLoginForm());
  }
}
