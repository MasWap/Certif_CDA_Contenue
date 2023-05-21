import 'package:flutter/material.dart';
import '../services/database.dart';
import 'connexion_screen.dart';
import 'package:mysql1/mysql1.dart';

import 'home_screen.dart';

class MyStatisticPage extends StatefulWidget {
  const MyStatisticPage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyStatisticPage> createState() => _MyStatisticPageState();
}

class _MyStatisticPageState extends State<MyStatisticPage> {
  int totalClients = 0;
  int totalProduits = 0;
  int totalCommandes = 0;

  Future<void> _getStatistics() async {
    final connection = DatabaseConnection.connection;

    try {
      final results = await connection.query('SELECT (SELECT COUNT(*) FROM produit) AS nombre_produits, (SELECT COUNT(*) FROM client) AS nombre_clients, (SELECT COUNT(*) FROM commande) AS nombre_commandes;');

      if (results is Results) {
        final rows = results.toList();
        final Map<String, int> statistics = {
          'clients': rows[0]['nombre_clients'] as int? ?? 0,
          'produits': rows[0]['nombre_produits'] as int? ?? 0,
          'commandes': rows[0]['nombre_commandes'] as int? ?? 0,
        };

        setState(() {
          totalClients = statistics['clients']!;
          totalProduits = statistics['produits']!;
          totalCommandes = statistics['commandes']!;
        });
      }
    } finally {
      // await connection.close();
    }
  }


  @override
  void initState() {
    super.initState();
    _getStatistics();
  }

  void _annuler() {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => MyHomePage(title: 'IAPM Mobile')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        actions: [
          IconButton(
            icon: Icon(Icons.home),
            onPressed: _annuler,
          ),
        ],
        automaticallyImplyLeading: false,
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            StatisticCard(
              label: 'Clients',
              value: totalClients,
              icon: Icons.people,
            ),
            StatisticCard(
              label: 'Produits',
              value: totalProduits,
              icon: Icons.shopping_bag,
            ),
            StatisticCard(
              label: 'Commandes',
              value: totalCommandes,
              icon: Icons.account_balance_wallet,
            ),
          ],
        ),
      ),
    );
  }

  void _logout() {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => DatabaseLoginForm()),
    );
  }
}

class StatisticCard extends StatelessWidget {
  final String label;
  final int value;
  final IconData icon;

  const StatisticCard({
    required this.label,
    required this.value,
    required this.icon,
  });

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: EdgeInsets.all(16.0),
      child: Padding(
        padding: EdgeInsets.all(16.0),
        child: Column(
          children: [
            Icon(
              icon,
              size: 40.0,
            ),
            SizedBox(height: 16.0),
            Text(
              label,
              style: TextStyle(
                fontSize: 20.0,
                fontWeight: FontWeight.bold,
              ),
            ),
            SizedBox(height: 8.0),
            Text(
              value.toString(),
              style: TextStyle(
                fontSize: 24.0,
                fontWeight: FontWeight.bold,
              ),
            ),
          ],
        ),
      ),
    );
  }
}
