import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/home_screen.dart';
import '../services/database.dart';
import 'ajoutProduit_screen.dart';
import 'connexion_screen.dart';
import 'package:mysql1/mysql1.dart';
import '../models/produit.dart';

class MyProduitPage extends StatefulWidget {
  const MyProduitPage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyProduitPage> createState() => _MyProduitPageState();
}

class _MyProduitPageState extends State<MyProduitPage> {
  List<Produit> produits = [];

  Future<void> _getProduits() async {
    final connection = DatabaseConnection.connection;

    try {
      final results = await connection.query('CALL `!GetProduit`()');
      if (results is Results) {
        final rows = results.toList();
        final produitList = <Produit>[];

        for (var row in rows) {
          final produit = Produit(
            idProduit: row['idProduit'] ?? 0,
            libelle: row['LibelleProduit'] ?? '',
            prix: (row['PrixHTProduit'] as num?)?.toDouble() ?? 0.0,
            qte: (row['QteStockProduit'] as int?) ?? 0,
            fourn: row['NomFournisseur'] ?? '',
            categorie: row['LibelleCategorie'] ?? '',
            cheminimg: row['cheminImage'] ?? '',
            desc: row['descriptionImage'] ?? '',
          );
          produitList.add(produit);
        }


        setState(() {
          produits = produitList;
        });
      }
    } finally {
      // await connection.close();
    }
  }

  @override
  void initState() {
    super.initState();
    _getProduits();
  }

  void _goToAddCli() {
    Navigator.push(
      context,
      MaterialPageRoute(builder: (context) => MyAddProdPage()),
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
            icon: Icon(Icons.add_circle_outline),
            onPressed: _goToAddCli,
            color: Colors.lightGreen,
          ),
          IconButton(
            icon: Icon(Icons.home),
            onPressed: _logout,
          ),
        ],
      ),
      body: ListView.builder(
        itemCount: produits.length,
        itemBuilder: (context, index) {
          final produit = produits[index];
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
                    '${produit.libelle}',
                    style: TextStyle(
                      fontSize: 22,
                      color: Colors.black,
                    ),
                  ),
                  IconButton(
                    icon: Icon(Icons.delete),
                    onPressed: () => _deleteProduit(produit.idProduit),
                    color: Colors.redAccent,
                  ),
                ],
              ),
              children: [
                ListTile(
                  title: Text(
                    'ID du Produit: ${produit.idProduit}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Prix Hors Taxes: ${produit.prix}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Stock: ${produit.qte}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Fournisseur: ${produit.fourn}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Catégorie: ${produit.categorie}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ),
                ListTile(
                  title: Text(
                    'Description: ${produit.desc}',
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
      MaterialPageRoute(builder: (context) => MyHomePage(title: 'IAPM Mobile')),
    );
  }

  void _deleteProduit(int idProduit) async {
    final connection = DatabaseConnection.connection;

    try {
      // Afficher le popup de confirmation
      showDialog(
        context: context,
        builder: (BuildContext context) {
          return AlertDialog(
            title: Text('Confirmation'),
            content: Text('Êtes-vous sûr de vouloir supprimer ce produit ?'),
            actions: [
              TextButton(
                child: Text('Annuler'),
                onPressed: () {
                  Navigator.of(context).pop(); // Fermer le popup
                  _showAvoidNotification('Suppression annulée');
                },
              ),
              TextButton(
                child: Text(
                  'Supprimer',
                style: TextStyle(
                  color: Colors.redAccent
                  ),
                ),
                onPressed: () async {
                  // Supprimer le produit de la base de données
                  await connection.query(
                    'DELETE FROM Produit WHERE idProduit = ?',
                    [idProduit],
                  );
                  _showDeleteNotification('Produit supprimé');
                  _getProduits();
                  Navigator.of(context).pop(); // Fermer le popup
                },
              ),
            ],
          );
        },
      );
    } catch (e) {
      // Gérer l'erreur de suppression du produit
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