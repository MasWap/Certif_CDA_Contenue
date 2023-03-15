Imports IAMP_LAYRAC.GestionBDD
Imports IAMP_LAYRAC.GestionCommande

Public Class FrmAMSCommandes

    Dim position As Integer = 0
    Dim MesCommandes As DataTable = GestionCommande.GetLesCommandes()

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
        FrmStart.Show()
    End Sub

    Private Sub FrmAMSCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgCommande.DataSource = GestionCommande.GetLesCommandesDTG()

        GestionInterface.AlimenterComboBox(ComboBoxClient, GestionClient.GetLesClientsCombo, "Patronyme", "idClient”)
        rafraichir()

        txtNum.Enabled = False
        txtDate.Enabled = False



    End Sub

    Private Sub rafraichir()

        MesCommandes = GestionCommande.GetLesCommandes()
        txtNum.Text = MesCommandes.Rows(position).Item(0)
        txtDate.Text = MesCommandes.Rows(position).Item(1)
        ComboBoxClient.SelectedValue = MesCommandes.Rows(position).Item(2)

        dtgCommande.DataSource = GestionCommande.GetLesCommandesDTG()
        dtgCommande.ClearSelection()
        dtgCommande.Rows(position).Selected = True


    End Sub


    Private Sub BtnAjouterCommande_Click(sender As Object, e As EventArgs) Handles btnAjouterCommande.Click
        If btnAjouterCommande.Text = "+ Nouvelle Commande" Then
            txtNum.Text = GestionCommande.GetNBCommande + 1
            txtDate.Text = ""
            ComboBoxClient.Text = ""
            btnAjouterCommande.Text = "Valider"
            txtDate.Enabled = True
        Else
            Dim idCommande As Integer
            idCommande = GestionCommande.GetNBCommande + 1
            Dim DateCommande As Date
            Dim idCli As Integer
            idCli = ComboBoxClient.SelectedValue
            DateCommande = txtDate.Text
            GestionCommande.AjouterCommande(idCommande, DateCommande, idCli)
            MessageBox.Show("Commande Ajouté...!", "Insertion")
            dtgCommande.DataSource = GestionCommande.GetLesCommandesDTG()
            btnAjouterCommande.Text = "+ Nouvelle Commande"
            rafraichir()
        End If
        rafraichir()


    End Sub

    Private Sub btnSuprCommande_Click(sender As Object, e As EventArgs) Handles btnSuprCommande.Click
        If btnSuprCommande.Text = "- Supprimer Commande" Then
            txtNum.Text = GestionCommande.GetNBCommande + 1
            txtDate.Text = ""
            ComboBoxClient.Text = ""
            btnSuprCommande.Text = "Valider"
            txtDate.Enabled = True
        Else
            Dim c As Integer
            Dim cli As String
            Dim d As Date
            c = GenererClePrimaire("idCommande", "Commande")
            d = txtDate.Text
            cli = ComboBoxClient.Text

            GestionCommande.SupprimerCommande(c, d, cli)
            MaCommande.CommandText = MaRequete
            MaCommande.ExecuteNonQuery()
            MessageBox.Show("Commande Supprimer...!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0
            rafraichir()
        End If
        rafraichir()
    End Sub


    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        If position > 0 Then
            position = position - 1
        End If
        rafraichir()

    End Sub
    Private Sub btnPrecedentPredecent_Click(sender As Object, e As EventArgs) Handles btnPrecedentPrecedent.Click

        position = 0
        rafraichir()

    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        If (position < GestionCommande.GetNBCommande - 1) Then
            position = position + 1
        End If
        rafraichir()

    End Sub

    Private Sub btnSuivantSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivantSuivant.Click

        position = GestionCommande.GetNBCommande - 1

        rafraichir()

    End Sub

    Private Sub btnConsultCommand_Click(sender As Object, e As EventArgs) Handles btnConsultCommand.Click
        Dim frmConsultCommandes As FrmConsultCommande = New FrmConsultCommande(txtNum.Text, txtDate.Text, ComboBoxClient.Text)
        frmConsultCommandes.Show()
    End Sub

End Class