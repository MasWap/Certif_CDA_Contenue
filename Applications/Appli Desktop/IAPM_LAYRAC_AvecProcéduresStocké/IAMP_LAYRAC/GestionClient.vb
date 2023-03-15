Imports IAMP_LAYRAC.GestionBDD
Public Class GestionClient

    Public Shared Function GetLesClientsCombo() As DataTable

        Return ExecuterRequeteSelect("Select idClient, CONCAT(NomClient, ' ', PrenomClient) AS Patronyme from client")

    End Function

    Public Shared Function GetLesClients() As DataTable

        Return ExecuterRequeteSelect("Select idClient, NomClient, PrenomClient, AdRueClient, AdCpClient, AdVilleClient from client")

    End Function

    Public Shared Sub AjouterClient(ByVal code As Integer, ByVal nom As String, ByVal prenom As String, ByVal rue As String, ByVal codePostal As Integer, ByVal ville As String)

        GestionBDD.Executer_Requete_Action("INSERT INTO client (idClient, NomClient, PrenomClient, AdRueClient, AdCpClient, AdVilleClient) VALUES( " & code & ", '" & nom & "', '" & prenom & "', '" & rue & "', " & codePostal & ", '" & ville & "')")

    End Sub


    Public Shared Sub SupprimerClient(ByVal code As Integer)

        GestionBDD.Executer_Requete_Action("DELETE FROM Client WHERE (idClient = " & code & ")")

    End Sub


    Public Shared Sub ModifierClient(ByVal code As Integer, ByVal nom As String, ByVal prenom As String, ByVal rue As String, ByVal codePostal As Integer, ByVal ville As String)

        GestionBDD.Executer_Requete_Action("UPDATE client Set idClient = " & code & ", NomClient = '" & nom & "', PrenomClient = '" & prenom & "', AdRueClient = '" & rue & "', AdCpClient = " & codePostal & " , AdVilleClient ='" & ville & "' where idClient = " & code & "")

    End Sub

    Public Shared Function GetNBClients() As Integer

        Dim nbClients As Integer
        MaRequete = "SELECT Count(*) FROM Client"
        MaCommande.CommandText = MaRequete
        nbClients = MaCommande.ExecuteScalar()
        Return nbClients

    End Function

    Public Shared Function RechercherClient(ByVal text As String) As Data.DataTable

        Return GestionBDD.ExecuterRequeteSelect("SELECT idClient, NomClient, PrenomClient, AdRueClient, AdCpClient, AdVilleClient FROM Client WHERE (idClient like '" & "%" & text & "%" & "' OR NomClient like '" & "%" & text & "%" & "' OR PrenomClient like '" & "%" & text & "%" & "' OR AdRueClient like '" & "%" & text & "%" & "' OR AdCpClient like '" & "%" & text & "%" & "' OR AdVilleClient like'" & "%" & text & "%" & "')")

    End Function



End Class
