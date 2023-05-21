import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:iapm_mobile/screens/home_screen.dart';
import '../services/database.dart';
import 'connexion_screen.dart';
import 'package:mysql1/mysql1.dart';
import '../models/commande.dart';
import 'dart:core';


class MyCommandePage extends StatefulWidget {
  const MyCommandePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyCommandePage> createState() => _MyCommandePageState();
}

class _MyCommandePageState extends State<MyCommandePage> {
  List<Commande> commandes = [];
  List<Commande> filteredCommandes = [];
  late FocusNode searchFocusNode;
  late TextEditingController searchController; // Ajoutez un contrôleur de texte

  Future<void> _getCommandes() async {
    final connection = DatabaseConnection.connection;

    try {
      String sql = 'SELECT * FROM lilian_ppe_marchand_layrac_adapt.commande;';
      final results = await connection.query(sql);
      if (results is Results) {
        final rows = results.toList();
        final commandList = <Commande>[];

        for (var row in rows) {
          final command = Commande(
            idcommande: row['idCommande'],
            datecommande: row['DateCommande'],
            idcli: row['idCli'],
          );
          commandList.add(command);
        }
        setState(() {
          commandes = commandList;
          filteredCommandes = commandList;
        });
      }
    } finally {
      // await connection.close();
    }
  }

  @override
  void initState() {
    super.initState();
    _getCommandes();
    searchFocusNode = FocusNode();
    searchController = TextEditingController(); // Initialisez le contrôleur de texte
  }

  void _refresh() {
    setState(() {
      filteredCommandes = commandes;
    });
    FocusScope.of(context).unfocus();

    searchController.clear();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        actions: [
          IconButton(
            icon: const Icon(Icons.home),
            onPressed: _logout,
          ),
        ],
        automaticallyImplyLeading: false,
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                Expanded(
                  child: TextField(
                    focusNode: searchFocusNode,
                    controller: searchController, // Attribuez le contrôleur de texte ici
                    decoration: InputDecoration(
                      labelText: 'Rechercher une commande',
                      suffixIcon: Icon(Icons.search),
                    ),
                    onChanged: (value) {
                      setState(() {
                        filteredCommandes = commandes
                            .where((commande) => commande.idcommande.toString() == value)
                            .toList();
                      });
                    },
                  ),
                ),
                ElevatedButton(
                  onPressed: _refresh,
                  child: Text('Refresh'),
                ),
              ],
            ),
          ),
          Expanded(
            child: ListView.builder(
              itemCount: filteredCommandes.length,
              itemBuilder: (context, index) {
                final commande = filteredCommandes[index];
                return Container(
                  margin: EdgeInsets.symmetric(vertical: 4.0, horizontal: 8.0),
                  decoration: BoxDecoration(
                    color: Color.fromARGB(255, 226, 226, 226), // Couleur de fond grisé
                    borderRadius: BorderRadius.circular(8.0),
                  ),
                  child: ExpansionTile(
                    tilePadding: EdgeInsets.zero,
                    title: Text(
                      '${commande.idcommande}',
                      style: TextStyle(
                        fontSize: 22,
                      ),
                    ),
                    children: [
                      ListTile(
                        title: Text(
                          'ID du client: ${commande.idcli}',
                          style: const TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                      ListTile(
                        title: Text(
                          'Date: ${commande.datecommande}',
                          style: const TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                    ],
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }

  void _logout() {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => MyHomePage(title: 'IAPM Mobile')),
    );
  }

  selectFromTable(String s) {}
}
