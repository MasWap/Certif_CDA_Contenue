class Produit {
  final String libelle;
  final double prix;
  final int qte;
  final int fourn;
  final int categorie;
  final String cheminimg;
  final String desc;

  Produit({
    required this.libelle,
    required this.prix,
    required this.qte,
    required this.fourn,
    required this.categorie,
    required this.cheminimg,
    required this.desc,
  });

  toMap() {}
}
