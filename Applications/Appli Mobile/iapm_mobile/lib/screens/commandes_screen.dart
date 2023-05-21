import 'package:flutter/material.dart';
import '../services/database.dart';
import 'connexion_screen.dart';
import 'package:mysql1/mysql1.dart';
import '../models/commande.dart';

class MyCommandePage extends StatefulWidget {
  const MyCommandePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyCommandePage> createState() => _MyCommandePageState();
}

class _MyCommandePageState extends State<MyCommandePage> {
  List<Commande> commandes = [];

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
            datecommande: row['DateCommande'],
            idcli: row['idCli'], // Valeur par défaut ''
          );
          commandList.add(command);
        }
        setState(() {
          commandes = commandList;
        });
      }
    } finally {
      // await connection.close();
    }
  }

  @override
  void initState() {
    super.initState();
    _getCommandes(); // Appeler la méthode pour récupérer les clients
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        actions: [
          IconButton(
            icon: const Icon(Icons.logout),
            onPressed: _logout,
          ),
        ],
      ),
      body: ListView.builder(
        itemCount: commandes.length,
        itemBuilder: (context, index) {
          final commande = commandes[index];
          return Container(
            margin: EdgeInsets.symmetric(vertical: 4.0, horizontal: 8.0),
            decoration: BoxDecoration(
              color:
                  Color.fromARGB(255, 226, 226, 226), // Couleur de fond grisé
              borderRadius: BorderRadius.circular(8.0),
            ),
            child: ExpansionTile(
              tilePadding: EdgeInsets.zero,
              title: Text(
                '${commande.datecommande}',
                style: TextStyle(
                  fontSize: 22,
                ),
              ),
              children: [
                ListTile(
                  title: Text(
                    'Client: ${commande.idcli}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
              ],
            ),
          );
        },
      ),
    );
  }

  void _logout() {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => DatabaseLoginForm()),
    );
  }

  selectFromTable(String s) {}
}
