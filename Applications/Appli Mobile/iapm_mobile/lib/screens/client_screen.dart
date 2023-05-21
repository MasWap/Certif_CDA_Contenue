import 'package:flutter/material.dart';
import '../services/database.dart';
import 'ajoutClient_screen.dart';
import 'connexion_screen.dart';
import 'package:mysql1/mysql1.dart';
import '../models/client.dart';

class MyClientPage extends StatefulWidget {
  const MyClientPage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyClientPage> createState() => _MyClientPageState();
}

class _MyClientPageState extends State<MyClientPage> {
  List<Client> clients = [];

  Future<void> _getClients() async {
    final connection = DatabaseConnection.connection;

    try {
      String sql = 'SELECT * FROM lilian_ppe_marchand_layrac_adapt.client;';
      final results = await connection.query(sql);
      if (results is Results) {
        final rows = results.toList();
        final clientList = <Client>[];

        for (var row in rows) {
          final client = Client(
            prenom: row['PrenomClient'],
            nom: row['NomClient'],
            adresse: row['AdRueClient'] ?? '', // Valeur par défaut ''
            cp: row['AdCpClient'] ?? '',
            ville: row['AdVilleClient'] ?? '',
            email: row['emailClient'] ?? '', // Valeur par défaut ''
            login: row['loginClient'] ?? '', // Valeur par défaut ''
            mdp: row['mdpClient'] ?? '', // Valeur par défaut ''
            telephone: row['telClient'] ?? '', // Valeur par défaut ''
            pays: row['paysClient'] ?? '', // Valeur par défaut ''
          );
          clientList.add(client);
        }
        setState(() {
          clients = clientList;
        });
      }
    } finally {
      // await connection.close();
    }
  }

  @override
  void initState() {
    super.initState();
    _getClients(); // Appeler la méthode pour récupérer les clients
  }

  void _goToAddCli() {
    Navigator.push(
      context,
      MaterialPageRoute(builder: (context) => MyAddCliPage()),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
        actions: [
          IconButton(
            icon: Icon(Icons.add),
            onPressed: _goToAddCli,
          ),
          IconButton(
            icon: Icon(Icons.logout),
            onPressed: _logout,
          ),
        ],
      ),
      body: ListView.builder(
        itemCount: clients.length,
        itemBuilder: (context, index) {
          final client = clients[index];
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
                '${client.prenom} ${client.nom}',
                style: TextStyle(
                  fontSize: 22,
                ),
              ),
              children: [
                ListTile(
                  title: Text(
                    'Adresse: ${client.adresse}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Code Postal: ${client.cp}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Ville: ${client.ville}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Email: ${client.email}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Login: ${client.login}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                const ListTile(
                  title: Text(
                    'Mot de passe: ********',
                    style: TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Téléphone: ${client.telephone}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Pays: ${client.pays}',
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
