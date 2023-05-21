import 'package:flutter/material.dart';

class Client {
  int idClient;
  String prenom;
  String nom;
  String adresse;
  int cp;
  String ville;
  String email;
  String login;
  String mdp;
  String telephone;
  String pays;

  Client({
    required this.idClient,
    required this.prenom,
    required this.nom,
    required this.adresse,
    required this.cp,
    required this.ville,
    required this.email,
    required this.login,
    required this.mdp,
    required this.telephone,
    required this.pays,
  });
}
