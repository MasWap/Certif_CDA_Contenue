import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/home_screen.dart';
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
  List<Client> filteredClients = [];
  late FocusNode searchFocusNode;
  late TextEditingController searchController; // Ajoutez un contrôleur de texte

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
            idClient: row['idClient'] ?? 0,
            prenom: row['PrenomClient'],
            nom: row['NomClient'],
            adresse: row['AdRueClient'] ?? '',
            cp: row['AdCpClient'] ?? '',
            ville: row['AdVilleClient'] ?? '',
            email: row['emailClient'] ?? '',
            login: row['loginClient'] ?? '',
            mdp: row['mdpClient'] ?? '',
            telephone: row['telClient'] ?? '',
            pays: row['paysClient'] ?? '',
          );
          clientList.add(client);
        }

        setState(() {
          clients = clientList;
          filteredClients = clientList;
        });
      }
    } finally {
      // await connection.close();
    }
  }

  @override
  void initState() {
    super.initState();
    _getClients();
    searchFocusNode = FocusNode();
    searchController = TextEditingController(); // Initialisez le contrôleur de texte
  }

  void _goToAddCli() {
    Navigator.push(
      context,
      MaterialPageRoute(builder: (context) => MyAddCliPage()),
    );
  }

  void _refresh() {
    setState(() {
      filteredClients = clients;
    });
    FocusScope.of(context).unfocus();

    searchController.clear();
  }

  void _logout() {
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
            icon: Icon(Icons.add_circle_outline),
            onPressed: _goToAddCli,
            color: Colors.lightGreen,
          ),
          IconButton(
            icon: Icon(Icons.home),
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
                    onChanged: (value) {
                      setState(() {
                        filteredClients = clients
                            .where((client) => client.nom
                            .toLowerCase()
                            .contains(value.toLowerCase()))
                            .toList();
                      });
                    },
                    focusNode: searchFocusNode,
                    controller: searchController,
                    decoration: InputDecoration(
                      labelText: 'Rechercher un client',
                      prefixIcon: Icon(Icons.search),
                    ),
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
              itemCount: filteredClients.length,
              itemBuilder: (context, index) {
                final client = filteredClients[index];
                return Container(
                  margin: EdgeInsets.symmetric(vertical: 4.0, horizontal: 8.0),
                  decoration: BoxDecoration(
                    color: Color.fromARGB(255, 226, 226, 226),
                    borderRadius: BorderRadius.circular(8.0),
                  ),
                  child: ExpansionTile(
                    tilePadding: EdgeInsets.zero,
                    title: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Text(
                          '${client.prenom} ${client.nom}',
                          style: TextStyle(
                            fontSize: 22,
                            color: Colors.black,
                          ),
                        ),
                        IconButton(
                          icon: Icon(Icons.delete),
                          onPressed: () => _deleteClient(client.idClient),
                          color: Colors.redAccent,
                        ),
                      ],
                    ),
                    children: [
                      ListTile(
                        title: Text(
                          'ID du Client: ${client.idClient}',
                          style: const TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                      ListTile(
                        title: Text(
                          'Adresse: ${client.adresse}',
                          style: const TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                      ListTile(
                        title: Text(
                          'Code postal: ${client.cp}',
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
          ),
        ],
      ),
    );
  }

  void _deleteClient(int idClient) async {
    final connection = DatabaseConnection.connection;

    try {
      showDialog(
        context: context,
        builder: (BuildContext context) {
          return AlertDialog(
            title: Text('Confirmation'),
            content: Text('Êtes-vous sûr de vouloir supprimer ce client ?'),
            actions: [
              TextButton(
                child: Text('Annuler'),
                onPressed: () {
                  Navigator.of(context).pop();
                  _showAvoidNotification('Suppression annulée');
                },
              ),
              TextButton(
                child: Text(
                  'Supprimer',
                  style: TextStyle(color: Colors.redAccent),
                ),
                onPressed: () async {
                  await connection.query(
                    'DELETE FROM Client WHERE idClient = ?',
                    [idClient],
                  );
                  _showDeleteNotification('Client supprimé');
                  _getClients();
                  Navigator.of(context).pop();
                },
              ),
            ],
          );
        },
      );
    } catch (e) {
      // Gérer l'erreur de suppression du client
    }
  }

  void _showDeleteNotification(String message) {
    final snackBar = SnackBar(
      content: Text(message),
      backgroundColor: Colors.red,
    );
    ScaffoldMessenger.of(context).showSnackBar(snackBar);
  }

  void _showAvoidNotification(String message) {
    final snackBar = SnackBar(
      content: Text(message),
      backgroundColor: Colors.amber,
    );
    ScaffoldMessenger.of(context).showSnackBar(snackBar);
  }
}
