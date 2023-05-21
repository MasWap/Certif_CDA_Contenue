import 'package:flutter/material.dart';
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

    try {
      final sql =
          'INSERT INTO produit (LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, cheminImage, descriptionImage) VALUES (?, ?, ?, ?, ?, ?, ?)';
      final values = [
        produit.libelle,
        produit.prix,
        produit.qte,
        produit.fourn,
        produit.categorie,
        produit.cheminimg,
        produit.desc,
      ];
      await connection.query(sql, values);
    } finally {
      // await connection.close();
    }
  }

  void _submitForm() {
    if (_formKey.currentState!.validate()) {
      final produit = Produit(
        libelle: _libelleController.text,
        prix: double.tryParse(_prixController.text) ?? 0.0,
        qte: int.tryParse(_qteController.text) ?? 0,
        fourn: int.tryParse(_fournController.text) ?? 0,
        categorie: int.tryParse(_categorieController.text) ?? 0,
        cheminimg: _cheminimgController.text,
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

        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Produit ajouté avec succès')),
        );
      }).catchError((error) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Erreur lors de l\'ajout du produit')),
        );
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Ajouter un produit'),
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
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un fournisseur';
                  }
                  if (int.tryParse(value) == null) {
                    return 'Veuillez entrer un fournisseur valide';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _categorieController,
                decoration: InputDecoration(labelText: 'Catégorie'),
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une catégorie';
                  }
                  if (int.tryParse(value) == null) {
                    return 'Veuillez entrer une catégorie valide';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _cheminimgController,
                decoration: InputDecoration(labelText: 'Chemin de l\'image'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un chemin d\'image';
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
                child: Text('Ajouter'),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
