Imports IAMP_LAYRAC.GestionBDD
Imports MySql.Data
Public Class GestionFournisseur
    Public Shared Function GetLesFournisseurs() As DataTable
        Return ExecuterRequeteSelect(“Select * from fournisseur”)
    End Function

End Class
