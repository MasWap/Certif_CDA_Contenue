Imports IAMP_LAYRAC.GestionBDD
Imports IAMP_LAYRAC.GestionCommande

Public Class FrmListeCommandes


    Private Sub DtgLstCommandes_load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtgLstCommandes.DataSource = GestionCommande.GetLesCommandes()
        DtgStatsCommandes.DataSource = GestionCommande.GetLesStatsCommandesDTG()

    End Sub

    Private Sub btnFermer_Click_1(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
        FrmStart.Show()
    End Sub

    Private Sub TxtBoxRechCommande_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxRechCommande.TextChanged

        Dim text As String
        Try
            text = TxtBoxRechCommande.Text
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DtgLstCommandes.DataSource = GestionCommande.RechercherCommande(text)

    End Sub

End Class