import 'package:flutter/material.dart';
import 'package:mysql1/mysql1.dart';

import '../services/database.dart';
import 'home_screen.dart';

class DatabaseLoginForm extends StatefulWidget {
  @override
  _DatabaseLoginFormState createState() => _DatabaseLoginFormState();
}

class _DatabaseLoginFormState extends State<DatabaseLoginForm> {
  final TextEditingController _hostController = TextEditingController();
  final TextEditingController _portController = TextEditingController();
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _databaseController = TextEditingController();
  final GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();

  String _errorMessage = '';

  Future<void> _connectToDatabase() async {
    final host = _hostController.text.trim();
    final port = int.tryParse(_portController.text.trim());
    final username = _usernameController.text.trim();
    final password = _passwordController.text.trim();
    final databaseName = _databaseController.text.trim();

    final settings = ConnectionSettings(
      host: '10.0.2.2',
      port: 3306,
      user: username,
      password: password,
      db: 'lilian_ppe_marchand_layrac_adapt',
    );

    try {
      await DatabaseConnection.connect(settings);

      // Notify when connexion successful
      _showSuccessNotification('Connexion réussie');

      // Redirect to home_screen.dart
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => const MyHomePage(title: 'Menu des tables')),
      );
    } catch (e) {
      setState(() {
        _errorMessage = 'Erreur lors de la connexion à la base de données : $e';
      });
    }
  }

  void _showSuccessNotification(String message) {
    final snackBar = SnackBar(
      content: Text(message),
      backgroundColor: Colors.green,
    );
    ScaffoldMessenger.of(context).showSnackBar(snackBar);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      key: _scaffoldKey,
      appBar: AppBar(
        title: const Text('Connexion'),
        automaticallyImplyLeading: false,
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            TextField(
              controller: _usernameController,
              decoration: const InputDecoration(
                labelText: 'Nom d\'utilisateur',
              ),
            ),
            TextField(
              controller: _passwordController,
              obscureText: true,
              decoration: const InputDecoration(
                labelText: 'Mot de passe',
              ),
            ),
            const SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: _connectToDatabase,
              style: ElevatedButton.styleFrom(
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(8.0),
                ),
                backgroundColor: Color(0xFF6A7DAF),
              ),
              child: const Text('Se connecter'),
            ),
            if (_errorMessage.isNotEmpty)
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: Text(
                  _errorMessage,
                  style: const TextStyle(color: Colors.red),
                ),
              ),
          ],
        ),
      ),
    );
  }
}
