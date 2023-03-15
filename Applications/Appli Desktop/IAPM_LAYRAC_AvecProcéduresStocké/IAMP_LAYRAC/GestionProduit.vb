Imports IAMP_LAYRAC.FrmAMSClient
Imports IAMP_LAYRAC.GestionBDD
Public Class GestionProduit

    Public Shared Function GetLesProduits() As DataTable

        Return ExecuterRequeteSelect("Select idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, isImportant from Produit")

    End Function

    Public Shared Sub AjouterProduit(ByVal code As Integer, ByVal libelle As String, ByVal prix As Integer, ByVal qte As Integer, ByVal idfourn As Integer, ByVal idcat As Integer)

        GestionBDD.Executer_Requete_Action("INSERT INTO produit (idproduit, LibelleProduit, PrixHTProduit, QteStockProduit, idfourn, idcat) VALUES( " & code & ", '" & libelle & "', " & prix & ", " & qte & ", " & idfourn & ", " & idcat & ")")

    End Sub

    Public Shared Sub AjouterProduitByCommande(ByVal idCommande As Integer, ByVal idProduit As Integer, ByVal QuantiteProd As Integer)

        GestionBDD.Executer_Requete_Action("INSERT INTO lignedecommande VALUES( " & idCommande & ", " & idProduit & ", " & QuantiteProd & ")")

    End Sub

    Public Shared Sub SupprimerProduit(ByVal code As Integer)

        GestionBDD.Executer_Requete_Action("DELETE FROM Produit WHERE (idProduit = " & code & ")")

    End Sub

    Public Shared Sub ModifierProduit(ByVal code As Integer, ByVal libelle As String, ByVal prix As Integer, ByVal qte As Integer, ByVal idfourn As Integer, ByVal idcat As Integer)

        GestionBDD.Executer_Requete_Action("UPDATE Produit Set idProduit = " & code & ", LibelleProduit = '" & libelle & "', PrixHTProduit = " & prix & ", QteStockProduit = " & qte & ", idFourn = " & idfourn & " , idCat = " & idcat & " WHERE idProduit = " & code & "")

    End Sub

    Public Shared Function RechercherProduit(ByVal text As String) As Data.DataTable

        Return GestionBDD.ExecuterRequeteSelect("SELECT * FROM Produit WHERE (idProduit like '" & "%" & text & "%" & "' OR LibelleProduit like '" & "%" & text & "%" & "' OR PrixHTProduit like '" & "%" & text & "%" & "' OR QteStockProduit like '" & "%" & text & "%" & "' OR idFourn like '" & "%" & text & "%" & "' OR idCat like'" & "%" & text & "%" & "')")

        'SELECT * FROM Produit, Fournisseur, Categorie WHERE Categorie.idCategorie = produit.idCat AND Fournisseur.idFournisseur = Produit.idFourn GROUP BY idProduit

        'SELECT idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, isImportant FROM Produit WHERE (idProduit like '" & "%" & text & "%" & "' OR LibelleProduit like '" & "%" & text & "%" & "' OR PrixHTProduit like '" & "%" & text & "%" & "' OR QteStockProduit like '" & "%" & text & "%" & "' OR idFourn like '" & "%" & text & "%" & "' OR idCat like'" & "%" & text & "%" & "')"

    End Function

    Public Shared Function GetNBProduit() As Integer

        Dim nbProduits As Integer
        MaRequete = "SELECT Count(*) FROM Produit"
        MaCommande.CommandText = MaRequete
        nbProduits = MaCommande.ExecuteScalar()
        Return nbProduits

    End Function

    Public Shared Function GetLesProduitsDTG() As DataTable



        Return ExecuterRequeteSelect("SELECT idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, NomFournisseur, LibelleCategorie, isImportant  FROM Produit, Fournisseur, Categorie WHERE Categorie.idCategorie = produit.idCat AND Fournisseur.idFournisseur = Produit.idFourn GROUP BY idProduit")

    End Function

    Public Shared Function GetLesProduitsDTGConsult() As DataTable

        Return ExecuterRequeteSelect("SELECT idProduit, LibelleProduit, PrixHTProduit, QteStockProduit FROM Produit, Fournisseur, Categorie WHERE Categorie.idCategorie = produit.idCat AND Fournisseur.idFournisseur = Produit.idFourn")

    End Function



End Class
