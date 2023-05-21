import 'package:flutter/material.dart';

class Client {
  final String prenom;
  final String nom;
  final String adresse;
  final int cp;
  final String ville;
  final String email;
  final String login;
  final String mdp;
  final String telephone;
  final String pays;

  Client({
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
