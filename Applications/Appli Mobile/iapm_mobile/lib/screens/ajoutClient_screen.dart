import 'package:flutter/material.dart';
import '../models/client.dart';

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

  void _submitForm() {
    if (_formKey.currentState!.validate()) {
      final client = Client(
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

      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Client ajouté avec succès')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Ajouter un client'),
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
                    return 'Veuillez entrer une adresse';
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: _cpController,
                decoration: InputDecoration(labelText: 'Code postal'),
                keyboardType: TextInputType.number,
                validator: (value) {
                  if (value!.isEmpty) {
                    return 'Veuillez entrer un code postal';
                  }
                  if (int.tryParse(value) == null) {
                    return 'Veuillez entrer un code postal valide';
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
