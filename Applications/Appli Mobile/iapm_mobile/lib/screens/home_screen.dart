import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/client_screen.dart';
import 'package:iapm_mobile/screens/commandes_screen.dart';
import 'package:iapm_mobile/screens/produit_screen.dart';
import 'package:iapm_mobile/screens/statistics_screen.dart';
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
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Confirmation'),
          content: Text('Êtes-vous sûr de vouloir vous déconnecter ?'),
          actions: [
            TextButton(
              child: Text('Annuler'),
              onPressed: () {
                Navigator.pop(context); // Fermer la boîte de dialogue
              },
            ),
            TextButton(
              child: Text('Déconnexion',
                style: TextStyle(
                color: Colors.redAccent
                ),
              ),
              onPressed: () {
                Navigator.pop(context); // Fermer la boîte de dialogue

                // Effectuer les opérations de déconnexion ici
                // Par exemple : réinitialiser les variables, fermer la connexion à la base de données, etc.
                DatabaseConnection.disconnect();

                // Redirection vers la page de connexion
                Navigator.pushReplacement(
                  context,
                  MaterialPageRoute(builder: (context) => DatabaseLoginForm()),
                );
              },
            ),
          ],
        );
      },
    );
  }

  void _goToClientsScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
          builder: (context) => const MyClientPage(title: 'Table Client')
      )
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
                title: 'Table Commande',
              )),
    );
  }


  void _goToStatisticsScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(builder: (context) => MyStatisticPage(title: 'Statistiques')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        automaticallyImplyLeading: false,
        actions: [
          IconButton(
            icon: Icon(Icons.logout),
            onPressed: _logout,
          ),
        ],
      ),
      body: Container(
        padding: EdgeInsets.all(16.0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            Expanded(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Text(
                    'Bienvenue sur IAPM Mobile\nVeuillez sélectionner une table à consulter',
                    textAlign: TextAlign.center,
                    style: TextStyle(
                      fontSize: 24.0,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ],
              ),
            ),
            SizedBox(height: 16.0),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Expanded(
                  child: ElevatedButton(
                    onPressed: _goToClientsScreen,
                    style: ElevatedButton.styleFrom(
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8.0),
                      ),
                      backgroundColor: Color(0xFF6A7DAF),
                      padding: EdgeInsets.symmetric(
                        vertical: 45.0,
                        horizontal: 32.0,
                      ),
                    ),
                    child: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: const [
                        Icon(Icons.people),
                        SizedBox(width: 8.0),
                        Text(
                          'Clients',
                          style: TextStyle(
                            fontSize: 20.0,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
                SizedBox(width: 16.0),
                Expanded(
                  child: ElevatedButton(
                    onPressed: _goToProduitsScreen,
                    style: ElevatedButton.styleFrom(
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8.0),
                      ),
                      backgroundColor: Color(0xFF6A7DAF),
                      padding: EdgeInsets.symmetric(
                        vertical: 45.0,
                        horizontal: 32.0,
                      ),
                    ),
                    child: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: const [
                        Icon(Icons.shopping_bag),
                        SizedBox(width: 8.0),
                        Text(
                          'Produits',
                          style: TextStyle(
                            fontSize: 20.0,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
            SizedBox(height: 16.0),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Expanded(
                  child: ElevatedButton(
                    onPressed: _goToCommandesScreen,
                    style: ElevatedButton.styleFrom(
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8.0),
                      ),
                      backgroundColor: Color(0xFF6A7DAF),
                      padding: EdgeInsets.symmetric(
                        vertical: 45.0,
                        horizontal: 12.0,
                      ),
                    ),
                    child: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: const [
                        Icon(Icons.account_balance_wallet),
                        SizedBox(width: 8.0),
                        Text(
                          'Commandes',
                          style: TextStyle(
                            fontSize: 20.0,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
                SizedBox(width: 16.0),
                Expanded(
                  child: ElevatedButton(
                    onPressed: _goToStatisticsScreen, // Nouveau bouton pour les statistiques
                    style: ElevatedButton.styleFrom(
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8.0),
                      ),
                      backgroundColor: Color(0xFF6A7DAF),
                      padding: EdgeInsets.symmetric(
                        vertical: 45.0,
                        horizontal: 15.0,
                      ),
                    ),
                    child: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: const [
                        Icon(Icons.analytics),
                        SizedBox(width: 8.0),
                        Text(
                          'Statistiques',
                          style: TextStyle(
                            fontSize: 20.0,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  selectFromTable(String s) {}
}
