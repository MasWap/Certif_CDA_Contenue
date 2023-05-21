import 'package:flutter/material.dart';
import 'package:iapm_mobile/screens/client_screen.dart';
import '../models/client.dart';
import '../services/database.dart';

class MyAddCliPage extends StatefulWidget {
  @override
  _MyAddCliPageState createState() => _MyAddCliPageState();
}

class _MyAddCliPageState extends State<MyAddCliPage> {
  final _formKey = GlobalKey<FormState>();
  final _prenomController = TextEditingController();
  final _nomController = TextEditingController();
  final _adresseController = TextEditingController();
  final _cpController = TextEditingController();
  final _villeController = TextEditingController();
  final _emailController = TextEditingController();
  final _loginController = TextEditingController();
  final _mdpController = TextEditingController();
  final _telephoneController = TextEditingController();
  final _paysController = TextEditingController();

  @override
  void dispose() {
    _prenomController.dispose();
    _nomController.dispose();
    _adresseController.dispose();
    _cpController.dispose();
    _villeController.dispose();
    _emailController.dispose();
    _loginController.dispose();
    _mdpController.dispose();
    _telephoneController.dispose();
    _paysController.dispose();
    super.dispose();
  }

  Future<void> _insertClient(Client client) async {
    final connection = DatabaseConnection.connection;
    final maxIdResult = await connection.query('SELECT MAX(idClient) as maxId FROM client');
    final maxId = maxIdResult.first.fields['maxId'] as int;
    client.idClient = maxId + 1;

    final insertSql =
        'INSERT INTO client (idClient, NomClient, PrenomClient, AdRueClient, AdCpClient, AdVilleClient, emailClient, loginClient, mdpClient, telClient, paysClient) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)';
    final insertValues = [
      client.idClient,
      client.nom,
      client.prenom,
      client.adresse,
      client.cp,
      client.ville,
      client.email,
      client.login,
      client.mdp,
      client.telephone,
      client.pays,
    ];
    await connection.query(insertSql, insertValues);
  }

  void _submitForm() {
    if (_formKey.currentState!.validate()) {
      final client = Client(
        idClient: 0,
        prenom: _prenomController.text,
        nom: _nomController.text,
        adresse: _adresseController.text,
        cp: int.tryParse(_cpController.text) ?? 0,
        ville: _villeController.text,
        email: _emailController.text,
        login: _loginController.text,
        mdp: _mdpController.text,
        telephone: _telephoneController.text,
        pays: _paysController.text,
      );

      _insertClient(client).then((_) {
      // Réinitialisation des champs du formulaire
      _prenomController.clear();
      _nomController.clear();
      _adresseController.clear();
      _cpController.clear();
      _villeController.clear();
      _emailController.clear();
      _loginController.clear();
      _mdpController.clear();
      _telephoneController.clear();
      _paysController.clear();

      _showSuccessNotification('Client ajouté');

      // Redirection vers MyProductPage
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => MyClientPage(title: 'Table Client')),
      );
    }).catchError((error) {
    ScaffoldMessenger.of(context).showSnackBar(
    SnackBar(content: Text('Erreur lors de l\'ajout du client')),
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
      MaterialPageRoute(
          builder: (context) => MyClientPage(title: 'Table Client')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Ajouter un client'),
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
                controller: _prenomController,
                decoration: InputDecoration(labelText: 'Prénom'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un prénom';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _nomController,
                decoration: InputDecoration(labelText: 'Nom'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un nom';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _adresseController,
                decoration: InputDecoration(labelText: 'Adresse'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une adresse valide';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _cpController,
                decoration: InputDecoration(labelText: 'Code Postal'),
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un code postal';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _villeController,
                decoration: InputDecoration(labelText: 'Ville'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une ville';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _emailController,
                decoration: InputDecoration(labelText: 'Email'),
                keyboardType: TextInputType.emailAddress,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer une adresse email';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _loginController,
                decoration: InputDecoration(labelText: 'Login'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un login';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _mdpController,
                decoration: InputDecoration(labelText: 'Mot de passe'),
                obscureText: true,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un mot de passe';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _telephoneController,
                decoration: InputDecoration(labelText: 'Téléphone'),
                keyboardType: TextInputType.phone,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un numéro de téléphone';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _paysController,
                decoration: InputDecoration(labelText: 'Pays'),
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un pays';
                  }
                  return null;
                },
              ),
              SizedBox(height: 16.0),
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
