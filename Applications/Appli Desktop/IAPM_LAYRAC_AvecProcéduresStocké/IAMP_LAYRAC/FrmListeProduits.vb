Public Class FrmListeProduits
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

        Me.Close()
        FrmStart.Show()

    End Sub

    Private Sub FrmListeProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DtgLstProduits.DataSource = GestionProduit.GetLesProduits()'
        DtgLstProduits.DataSource = GestionPS.GetInfoProduits()

    End Sub

    Private Sub TxtBoxRechProduit_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxRechProduit.TextChanged

        Dim text As String
        Try
            text = TxtBoxRechProduit.Text
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DtgLstProduits.DataSource = GestionProduit.RechercherProduit(text)

    End Sub

End Class