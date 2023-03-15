Imports IAMP_LAYRAC.GestionBDD
Imports MySql.Data
Public Class GestionCategorie
    Public Shared Function GetLesCategories() As DataTable
        Return ExecuterRequeteSelect(“Select * from categorie”)
    End Function

    Public Shared Function GetLesChamps() As DataTable

        Return ExecuterRequeteSelect(“SELECT idCategorie FROM categorie”)

    End Function

End Class
