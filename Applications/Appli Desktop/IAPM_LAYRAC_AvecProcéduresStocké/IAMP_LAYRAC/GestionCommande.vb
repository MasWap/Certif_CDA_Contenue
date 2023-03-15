Imports IAMP_LAYRAC.GestionBDD
Imports IAMP_LAYRAC.GestionCommande

Public Class GestionCommande

    Public Shared Function GetLesCommandes() As DataTable

        Return ExecuterRequeteSelect("SELECT * FROM commande")

    End Function

    Public Shared Function GetNBCommande() As Integer

        Dim nbCommande As Integer
        MaRequete = "SELECT Count(*) FROM commande"
        MaCommande.CommandText = MaRequete
        nbCommande = MaCommande.ExecuteScalar()
        Return nbCommande

    End Function

    Public Shared Function GetLesCommandesDTG() As DataTable

        Return ExecuterRequeteSelect("SELECT commande.idCommande, DateCommande,CONCAT(NomClient, ' ', PrenomClient) AS Patronyme, PrixHTProduit*QuantiteCom AS MontantHT 
                                    FROM commande, client, produit, lignedecommande 
                                    WHERE client.idClient = commande.idCli 
                                    AND lignedecommande.idCommande = commande.idCommande 
                                    AND lignedecommande.idProduit = produit.idProduit 
                                    GROUP BY idCommande")

    End Function

    Public Shared Function GetLesStatsCommandesDTG() As DataTable

        Return ExecuterRequeteSelect("SELECT NBCommandes, NBClients, NBProduits, DateStatistiques
                                     FROM statistiques")

    End Function

    Public Shared Sub AjouterCommande(ByVal idCommande As Integer, ByVal DateCommande As Date, ByVal idCli As String)

        GestionBDD.Executer_Requete_Action("INSERT INTO commande VALUES( " & idCommande & ", " & DateCommande & ", " & idCli & ")")

    End Sub

    Public Shared Sub SupprimerCommande(ByVal idCommande As Integer, ByVal DateCommande As Date, ByVal idCli As String)

        GestionBDD.Executer_Requete_Action("delete from commande where idCommande( " & idCommande & ", " & DateCommande & ", " & idCli & ")")

    End Sub

    Public Shared Function GetLesProduitsByCommande(idcom As Integer) As DataTable

        Return ExecuterRequeteSelect("SELECT LibelleProduit, QteStockProduit, LibelleCategorie
                                      FROM Produit, Fournisseur, Categorie, lignedecommande
                                      WHERE Categorie.idCategorie = produit.idCat 
                                      AND Fournisseur.idFournisseur = Produit.idFourn
                                      AND LignedeCommande.idCommande = Produit.idProduit
                                      AND LignedeCommande.idCommande =" & idcom & "")

    End Function

    Public Shared Function RechercherCommande(ByVal text As String) As Data.DataTable

        Return GestionBDD.ExecuterRequeteSelect("SELECT commande.idCommande, DateCommande,CONCAT(NomClient, ' ', PrenomClient) AS Patronyme, PrixHTProduit*QuantiteCom AS MontantHT 
                                    FROM commande, client, produit, lignedecommande 
                                    WHERE client.idClient = commande.idCli 
                                    AND lignedecommande.idCommande = commande.idCommande 
                                    AND lignedecommande.idProduit = produit.idProduit 
                                    AND (commande.idCommande like '" & "%" & text & "%" & "' OR DateCommande like '" & "%" & text & "%" & "' OR nomClient like '" & "%" & text & "%" & "' OR prenomClient like '" & "%" & text & "%" & "')
                                    GROUP BY idCommande")

    End Function

End Class