import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/client_screen.dart';
import 'package:iapm_mobile/screens/commandes_screen.dart';
import 'package:iapm_mobile/screens/produit_screen.dart';
import '../services/database.dart';
import 'connexion_screen.dart';

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  void _logout() {
    // Effectuer les opérations de déconnexion ici
    // Par exemple : réinitialiser les variables, fermer la connexion à la base de données, etc.
    DatabaseConnection.disconnect();

    // Redirection vers la page de connexion
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => DatabaseLoginForm()),
    );
  }

  void _goToClientsScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
          builder: (context) => const MyClientPage(
                title: 'Table Client',
              )),
    );
  }

  void _goToProduitsScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
          builder: (context) => const MyProduitPage(
                title: 'Table Produit',
              )),
    );
  }

  void _goToCommandesScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
          builder: (context) => const MyCommandePage(
                title: 'Table Commandes',
              )),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        actions: [
          IconButton(
            icon: Icon(Icons.logout),
            onPressed: _logout,
          ),
        ],
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            ElevatedButton(
              onPressed: _goToClientsScreen,
              style: ElevatedButton.styleFrom(
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(8.0),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.symmetric(
                  vertical: 12.0,
                  horizontal: 24.0,
                ),
                child: Row(
                  mainAxisSize: MainAxisSize.min,
                  children: const [
                    Icon(Icons.people),
                    SizedBox(width: 8.0),
                    Text(
                      'Clients',
                      style: TextStyle(
                        fontSize: 16.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ],
                ),
              ),
            ),
            const SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: _goToProduitsScreen,
              style: ElevatedButton.styleFrom(
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(8.0),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.symmetric(
                  vertical: 12.0,
                  horizontal: 24.0,
                ),
                child: Row(
                  mainAxisSize: MainAxisSize.min,
                  children: const [
                    Icon(Icons.shopping_bag),
                    SizedBox(width: 8.0),
                    Text(
                      'Produits',
                      style: TextStyle(
                        fontSize: 16.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ],
                ),
              ),
            ),
            const SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: _goToCommandesScreen,
              style: ElevatedButton.styleFrom(
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(8.0),
                ),
              ),
              child: Padding(
                padding: const EdgeInsets.symmetric(
                  vertical: 12.0,
                  horizontal: 24.0,
                ),
                child: Row(
                  mainAxisSize: MainAxisSize.min,
                  children: const [
                    Icon(Icons.account_balance_wallet),
                    SizedBox(width: 8.0),
                    Text(
                      'Commandes',
                      style: TextStyle(
                        fontSize: 16.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  selectFromTable(String s) {}
}
