Imports IAMP_LAYRAC.GestionBDD

Public Class FrmListeClients

    Private Sub FrmListeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Execution de la requète SQL
#Region "Execution de la requète SQL"

#Region "Version brute (Importation requète SQL)"

        'MaRequete = "SELECT * FROM Client"
        'MaCommande.CommandText = MaRequete
        'MonAdapter.SelectCommand = MaCommande
        'MonAdapter.Fill(MonJeuDeDonnees, "TousLesClient")
        'DtgLstClients.DataSource = MonJeuDeDonnees.Tables("TousLesClient")

#End Region


#Region "Version Factorisé (Importation requète SQL)"

        ' DtgLstClients.DataSource = GestionBDD.ExecuterRequeteSelect(“Select * From Client”)

#End Region


#Region "Version Finale"
        DtgLstClients.DataSource = GestionClient.GetLesClients()

#End Region

#End Region

    End Sub


    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

        'Fermeture du Formulaire FrmListeClients

        Me.Close()
        FrmStart.Show()

    End Sub

    Private Sub DtgLstClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TxtBoxRechClient_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxRechClient.TextChanged

        Dim text As String
        Try
            text = TxtBoxRechClient.Text
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DtgLstClients.DataSource = GestionClient.RechercherClient(text)

    End Sub

End Class