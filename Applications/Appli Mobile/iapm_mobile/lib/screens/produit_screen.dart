import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
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
      String sql = 'SELECT * FROM lilian_ppe_marchand_layrac_adapt.produit;';
      final results = await connection.query(sql);
      if (results is Results) {
        final rows = results.toList();
        final produitList = <Produit>[];

        for (var row in rows) {
          final produit = Produit(
            libelle: row['LibelleProduit'] ?? '',
            prix: row['PrixHTProduit'] ?? '',
            qte: row['QteStockProduit'] ?? '',
            fourn: row['idFourn'] ?? '',
            categorie: row['idCat'] ?? '',
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
              title: Text(
                '${produit.libelle}',
                style: TextStyle(
                  fontSize: 22,
                ),
              ),
              children: [
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
      MaterialPageRoute(builder: (context) => DatabaseLoginForm()),
    );
  }

  selectFromTable(String s) {}
}
