Imports IAMP_LAYRAC.FrmAMSClient
Imports IAMP_LAYRAC.GestionBDD
Public Class FrmAMSClient

    Dim position As Integer = 0
    Dim MesClients As DataTable = GestionClient.GetLesClients()

    Private Sub FrmAMSClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtgClient.DataSource = GestionClient.GetLesClients()
        rafraichir()

        TextBoxCodeClient.Enabled = False

    End Sub

    Private Sub rafraichir()

        MesClients = GestionClient.GetLesClients()
        TextBoxCodeClient.Text = MesClients.Rows(position).Item(0)
        TextBoxNomClient.Text = MesClients.Rows(position).Item(1)
        TextBoxPrenomClient.Text = MesClients.Rows(position).Item(2)
        TextBoxRueClient.Text = MesClients.Rows(position).Item(3)
        TextBoxCpClient.Text = MesClients.Rows(position).Item(4)
        TextBoxVilleClient.Text = MesClients.Rows(position).Item(5)

        DtgClient.DataSource = GestionClient.GetLesClients
        DtgClient.ClearSelection()
        DtgClient.Rows(position).Selected = True



    End Sub

    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        If position > 0 Then
            position = position - 1
        End If
        rafraichir()

    End Sub
    Private Sub btnPrecedentPredecent_Click(sender As Object, e As EventArgs) Handles btnPrecedentPredecent.Click

        position = 0
        rafraichir()

    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        If (position < GestionClient.GetNBClients - 1) Then
            position = position + 1
        End If
        rafraichir()

    End Sub

    Private Sub btnSuivantSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivantSuivant.Click

        position = GestionClient.GetNBClients - 1

        rafraichir()

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        If btnPlus.Text = "Ajouter" Then

            btnModif.Enabled = False
            btnMoins.Enabled = False
            GrpBox1.Enabled = True
            btnAnnuler.Visible = True
            labelCommentaire.Visible = True
            TextBoxCodeClient.Text = GestionClient.GetNBClients + 1
            TextBoxNomClient.Text = ""
            TextBoxPrenomClient.Text = ""
            TextBoxRueClient.Text = ""
            TextBoxCpClient.Text = ""
            TextBoxVilleClient.Text = ""
            btnPlus.ForeColor = Color.FromArgb(184, 66, 77)
            btnPlus.Text = "Valider"
            TextBoxNomClient.Focus()


        Else
            If TextBoxNomClient.Text <> "" Then

                Dim c, t As Integer
                Dim n, p, r, v As String
                c = GenererClePrimaire("idClient", "Client")
                n = TextBoxNomClient.Text
                'RemplaceApostrophesSlash 
                p = TextBoxPrenomClient.Text
                r = TextBoxRueClient.Text
                t = TextBoxCpClient.Text
                v = TextBoxVilleClient.Text


                GestionClient.AjouterClient(c, n, p, r, t, v)
                MessageBox.Show("Client ajouté avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0
                rafraichir()
                btnPlus.Text = "Ajouter"
                btnModif.Enabled = True
                btnMoins.Enabled = True
                GrpBox1.Enabled = False
                btnAnnuler.Visible = False
                labelCommentaire.Visible = False
                btnPlus.ForeColor = Color.Black
            End If
            MessageBox.Show("Veuillez remplir les champs !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMoins_Click(sender As Object, e As EventArgs) Handles btnMoins.Click

        Dim Reponse As Integer
        Dim c, t As Integer
        Dim n, p, r, v As String
        c = CInt(TextBoxCodeClient.Text)
        n = TextBoxNomClient.Text
        'RemplaceApostrophesSlash 
        p = TextBoxPrenomClient.Text
        r = TextBoxRueClient.Text
        t = TextBoxCpClient.Text
        v = TextBoxVilleClient.Text
        Reponse = MessageBox.Show("Confirmez-vous la suppression de ce client : " & TextBoxPrenomClient.Text & " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If Reponse = vbYes Then

            GestionClient.SupprimerClient(c)

        Else

        End If

        position = 0
        rafraichir()

        Exit Sub

    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click

        If btnModif.Text = "Modifier" Then

            btnPlus.Enabled = False
            btnMoins.Enabled = False
            GrpBox1.Enabled = True
            btnAnnuler.Visible = True
            labelCommentaire.Visible = True
            TextBoxNomClient.Text = ""
            TextBoxPrenomClient.Text = ""
            TextBoxRueClient.Text = ""
            TextBoxCpClient.Text = ""
            TextBoxVilleClient.Text = ""
            btnModif.ForeColor = Color.FromArgb(184, 66, 77)
            btnModif.Text = "Valider"
            TextBoxNomClient.Focus()

        Else

            If TextBoxCodeClient.Text <> "" Then
                Dim c, t As Integer
                Dim n, p, r, v As String
                c = TextBoxCodeClient.Text
                n = TextBoxNomClient.Text
                'RemplaceApostrophesSlash 
                p = TextBoxPrenomClient.Text
                r = TextBoxRueClient.Text
                t = TextBoxCpClient.Text
                v = TextBoxVilleClient.Text

                GestionClient.ModifierClient(c, n, p, r, t, v)
                MessageBox.Show("Client modifié avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0
                rafraichir()
                btnModif.Text = "Modifier"
                btnPlus.Enabled = True
                btnMoins.Enabled = True
                GrpBox1.Enabled = False
                btnAnnuler.Visible = False
                labelCommentaire.Visible = False
                btnModif.ForeColor = Color.Black
            End If
            MessageBox.Show("Veuillez remplir les champs !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
        FrmStart.Show()
    End Sub

    Private Sub TxtBoxRechProduit_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxRechProduit.TextChanged

        Dim text As String
        Try
            text = TxtBoxRechProduit.Text
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DtgClient.DataSource = GestionClient.RechercherClient(text)

    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        position = 0
        rafraichir()
        btnPlus.Text = "Ajouter"
        btnModif.Text = "Modifier"
        btnMoins.Text = "Supprimer"
        btnPlus.Enabled = True
        btnModif.Enabled = True
        btnMoins.Enabled = True
        GrpBox1.Enabled = False
        btnAnnuler.Visible = False
        labelCommentaire.Visible = False
        btnPlus.ForeColor = Color.Black
        btnModif.ForeColor = Color.Black
        btnMoins.ForeColor = Color.Black
    End Sub
End Class