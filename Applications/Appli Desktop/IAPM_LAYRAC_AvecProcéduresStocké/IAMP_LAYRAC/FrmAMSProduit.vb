Imports IAMP_LAYRAC.GestionBDD
Public Class FrmAMSProduit


    Dim position As Integer = 0
    Dim MesProduits As DataTable = GestionProduit.GetLesProduits()

    Private Sub FrmListeProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtgProduit.DataSource = GestionProduit.GetLesProduitsDTG()
        rafraichir()
        DtgProduit.Columns("PrixHTProduit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DtgProduit.Columns("QteStockProduit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DtgProduit.Columns("isImportant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DtgProduit.Columns("PrixHTProduit").DefaultCellStyle.Format = "# ###.00 €"

        GestionInterface.AlimenterComboBox(ComboBoxFourn, GestionFournisseur.GetLesFournisseurs, “NomFournisseur”, “idFournisseur”)
        GestionInterface.AlimenterComboBox(ComboBoxCat, GestionCategorie.GetLesCategories, “LibelleCategorie”, “idCategorie”)



        TextBoxCodeProduit.Enabled = False



    End Sub

    Private Sub rafraichir()

        MesProduits = GestionProduit.GetLesProduits()
        TextBoxCodeProduit.Text = MesProduits.Rows(position).Item(0)
        TextBoxLibelleProduit.Text = MesProduits.Rows(position).Item(1)
        TextBoxPrixProduit.Text = MesProduits.Rows(position).Item(2)
        TextBoxQteProduit.Text = MesProduits.Rows(position).Item(3)
        ComboBoxFourn.SelectedValue = MesProduits.Rows(position).Item(4)
        ComboBoxCat.SelectedValue = MesProduits.Rows(position).Item(5)

        DtgProduit.DataSource = GestionProduit.GetLesProduitsDTG
        DtgProduit.ClearSelection()
        DtgProduit.Rows(position).Selected = True


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

        If (position < GestionProduit.GetNBProduit - 1) Then
            position = position + 1
        End If
        rafraichir()

    End Sub

    Private Sub btnSuivantSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivantSuivant.Click

        position = GestionProduit.GetNBProduit - 1

        rafraichir()

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        If btnPlus.Text = "Ajouter" Then

            btnModif.Enabled = False
            btnMoins.Enabled = False
            GrpBox1.Enabled = True
            btnAnnuler.Visible = True
            labelCommentaire.Visible = True
            TextBoxCodeProduit.Text = GestionProduit.GetNBProduit + 1
            TextBoxLibelleProduit.Text = ""
            TextBoxPrixProduit.Text = ""
            TextBoxQteProduit.Text = ""
            TxtBoxRechProduit.Text = ""
            btnPlus.ForeColor = Color.FromArgb(184, 66, 77)
            btnPlus.Text = "Valider"
            TextBoxLibelleProduit.Focus()


        Else
            If TextBoxLibelleProduit.Text <> "" Then

                Dim c, t, v As Integer
                Dim n, p, r As String
                c = GenererClePrimaire("idProduit", "Produit")
                'n = txtbLibeleEtudiant.Text
                n = TextBoxLibelleProduit.Text
                p = TextBoxPrixProduit.Text
                r = TextBoxQteProduit.Text
                t = ComboBoxFourn.SelectedValue
                v = ComboBoxCat.SelectedValue


                GestionProduit.AjouterProduit(c, n, p, r, t, v)
                MessageBox.Show("Produit ajouté avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        End If
    End Sub

    Private Sub btnMoins_Click(sender As Object, e As EventArgs) Handles btnMoins.Click

        Dim Reponse As Integer
        Dim c, t, v As Integer
        Dim n, p, r As String
        c = CInt(TextBoxCodeProduit.Text)
        n = TextBoxLibelleProduit.Text
        'RemplaceApostrophesSlash 
        p = TextBoxPrixProduit.Text
        r = TextBoxQteProduit.Text
        t = ComboBoxFourn.SelectedValue
        v = ComboBoxCat.SelectedValue
        Reponse = MessageBox.Show("Confirmez-vous la suppression de ce produit : " & TextBoxLibelleProduit.Text & " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If Reponse = vbYes Then

            GestionProduit.SupprimerProduit(c)

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
            btnModif.ForeColor = Color.FromArgb(184, 66, 77)
            btnModif.Text = "Valider"
            TextBoxLibelleProduit.Focus()

        Else

            If TextBoxCodeProduit.Text <> "" Then
                Dim c, t, v, r, p As Integer
                Dim n As String
                c = TextBoxCodeProduit.Text
                'n = txtbLibeleEtudiant.Text
                n = TextBoxLibelleProduit.Text
                'RemplaceApostrophesSlash
                p = TextBoxPrixProduit.Text
                v = TextBoxQteProduit.Text
                r = ComboBoxFourn.SelectedValue
                t = ComboBoxCat.SelectedValue

                GestionProduit.ModifierProduit(c, n, p, v, r, t)
                MessageBox.Show("Produit modifié avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
        FrmStart.Show()
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click

        GestionPDF.genererpdfdepuisdatatable("Liste des Produits au : ", MonJeuDeDonnees.Tables("TousLesProduitsPDF"))

    End Sub

    Private Sub TxtBoxRechProduit_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxRechProduit.TextChanged

        Dim text As String
        Try
            text = TxtBoxRechProduit.Text
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DtgProduit.DataSource = GestionProduit.RechercherProduit(text)

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