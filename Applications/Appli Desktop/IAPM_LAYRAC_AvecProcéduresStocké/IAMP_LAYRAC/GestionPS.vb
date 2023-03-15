Imports IAMP_LAYRAC.GestionBDD


Public Class GestionPS
    Public Shared Function GetInfoProduits() As DataTable

        Return GestionBDD.ExecuterRequeteSelect("Call `!GetInfoProduit`")

    End Function

    Public Shared Function GetAllCommandes() As DataTable

        Return GestionBDD.ExecuterRequeteSelect("Call `!GetAllCommande`")

    End Function

    Public Shared Function GetCommandeById(idCommande As Integer)

        Return GestionBDD.ExecuterRequeteSelect("Call `!GetCommandeById`(" & idCommande & ")")

    End Function

    Public Shared Function GetProduitsByCommande(idCommande As Integer)

        Return GestionBDD.ExecuterRequeteSelect("Call `!GetProduitsByCommande`(" & idCommande & ")")

    End Function

End Class
