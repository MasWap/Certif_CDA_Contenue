import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/produit_screen.dart';
import '../models/produit.dart';
import '../services/database.dart';

class MyAddProdPage extends StatefulWidget {
  @override
  _MyAddProdPageState createState() => _MyAddProdPageState();
}

class _MyAddProdPageState extends State<MyAddProdPage> {
  final _formKey = GlobalKey<FormState>();
  final _libelleController = TextEditingController();
  final _prixController = TextEditingController();
  final _qteController = TextEditingController();
  final _fournController = TextEditingController();
  final _categorieController = TextEditingController();
  final _cheminimgController = TextEditingController();
  final _descController = TextEditingController();

  @override
  void dispose() {
    _libelleController.dispose();
    _prixController.dispose();
    _qteController.dispose();
    _fournController.dispose();
    _categorieController.dispose();
    _cheminimgController.dispose();
    _descController.dispose();
    super.dispose();
  }

  Future<void> _insertProduit(Produit produit) async {
    final connection = DatabaseConnection.connection;
    final maxIdResult = await connection.query('SELECT MAX(idProduit) as maxId FROM produit');
    final maxId = maxIdResult.first.fields['maxId'] as int;
    produit.idProduit = maxId + 1;

    final insertSql =
        'INSERT INTO produit (idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, cheminImage, descriptionImage) VALUES (?, ?, ?, ?, ?, ?, ?, ?)';
    final insertValues = [
      produit.idProduit,
      produit.libelle,
      produit.prix,
      produit.qte,
      produit.fourn,
      produit.categorie,
      produit.cheminimg,
      produit.desc,
    ];
    await connection.query(insertSql, insertValues);
  }

  void _submitForm() {
    if (_formKey.currentState!.validate()) {
      final produit = Produit(
        idProduit: 0, // Set the ID to 0 or any default value since it will be auto-incremented in the database
        libelle: _libelleController.text,
        prix: double.tryParse(_prixController.text) ?? 0.0,
        qte: int.tryParse(_qteController.text) ?? 0,
        fourn: _fournController.text,
        categorie: _categorieController.text,
        cheminimg: 'interrogation.jpg',
        desc: _descController.text,
      );

      _insertProduit(produit).then((_) {
        // Réinitialisation des champs du formulaire
        _libelleController.clear();
        _prixController.clear();
        _qteController.clear();
        _fournController.clear();
        _categorieController.clear();
        _cheminimgController.clear();
        _descController.clear();

        _showSuccessNotification('Produit ajouté');

        // Redirection vers MyProductPage
        Navigator.pushReplacement(
          context,
          MaterialPageRoute(builder: (context) => MyProduitPage(title: 'Table Produit')),
        );
      }).catchError((error) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Erreur lors de l\'ajout du produit')),
        );
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

  void _annuler() {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(builder: (context) => MyProduitPage(title: 'Table Produit')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Ajouter un produit'),
        actions: [
          IconButton(
            icon: Icon(Icons.clear_outlined),
            onPressed: _annuler,
          ),
        ],
        automaticallyImplyLeading: false,
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: ListView(
            children: [
              TextFormField(
                controller: _libelleController,
                decoration: InputDecoration(labelText: 'Libellé'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un libellé';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _prixController,
                decoration: InputDecoration(labelText: 'Prix'),
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un prix';
                  }
                  if (double.tryParse(value) == null) {
                    return 'Veuillez entrer un prix valide';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _qteController,
                decoration: InputDecoration(labelText: 'Quantité'),
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une quantité';
                  }
                  if (int.tryParse(value) == null) {
                    return 'Veuillez entrer une quantité valide';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _fournController,
                decoration: InputDecoration(labelText: 'Fournisseur'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un fournisseur';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _categorieController,
                decoration: InputDecoration(labelText: 'Catégorie'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une catégorie';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _descController,
                decoration: InputDecoration(labelText: 'Description'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une description';
                  }
                  return null;
                },
              ),
              ElevatedButton(
                onPressed: _submitForm,
                style: ElevatedButton.styleFrom(
                  backgroundColor: Color(0xFF6A7DAF),
                ),
                child: Text('Ajouter'),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
