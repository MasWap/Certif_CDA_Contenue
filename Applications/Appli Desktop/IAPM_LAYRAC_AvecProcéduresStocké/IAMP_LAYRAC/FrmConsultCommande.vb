Imports IAMP_LAYRAC.GestionBDD
Imports IAMP_LAYRAC.GestionCommande
Imports IAMP_LAYRAC.GestionProduit

Public Class FrmConsultCommande

    Dim position As Integer = 0
    Dim MesCommandes As DataTable = GestionCommande.GetLesCommandes()
    Dim MesProduits As DataTable = GestionProduit.GetLesProduits()

    Dim numCommande As String
    Dim idCommandePS As String
    Dim datesCommande As String
    Dim clientCommande As String

    Public Sub New(ByVal idCommande As String, ByVal dateCommande As String, ByVal client As String)
        InitializeComponent()
        'numCommande = idCommande'
        idCommandePS = idCommande
        datesCommande = dateCommande
        clientCommande = client
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub FrmAMSCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumConsult.Enabled = False
        txtDateConsult.Enabled = False

        ' Recupere les produits associés au numéro de la commande
        ' dtgProduit.DataSource = GestionCommande.GetLesProduitsByCommande(numCommande)'
        dtgProduit.DataSource = GestionPS.GetCommandeById(idCommandePS)
        'dtgProduit.DataSource = GestionPS.GetProduitsByCommande(idCommandePS)

        ' Remplis les textbox
        'txtNumConsult.Text = numCommande'
        txtNumConsult.Text = idCommandePS
        txtDateConsult.Text = datesCommande
        txtClientConsult.Text = clientCommande

        GestionInterface.AlimenterComboBox(ComboBoxCat, GestionCategorie.GetLesCategories, “idCategorie ", "LibelleCategorie”)
        GestionInterface.AlimenterComboBox(ComboBoxProd, GestionProduit.GetLesProduits, “idProduit ", "LibelleProduit”)


        rafraichir()

    End Sub

    Private Sub rafraichir()

        dtgProduit.DataSource = GestionCommande.GetLesProduitsByCommande(idCommandePS)
        'dtgProduit.DataSource = GestionPS.GetProduitsByCommande(idCommandePS)

        'dtgProduit.DataSource = GestionProduit.GetLesProduitsDTG
        dtgProduit.ClearSelection()
        'dtgProduit.Rows(position).Selected = True


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

    Private Sub btnAjouterCommande_Click(sender As Object, e As EventArgs) Handles btnAjouterCommande.Click
        If btnAjouterCommande.Text = "+" Then

            ComboBoxProd.Text = GestionProduit.GetNBProduit + 1
            TextBoxQteProduit.Text = ""
            ComboBoxCat.Text = ""
            btnAjouterCommande.Text = "Valider!"


        Else
            If TextBoxQteProduit.Text <> "" Then

                Dim idProd, idCommande, idProduit, QuantiteProd As Integer
                idProd = GenererClePrimaire("idProduit", "Produit")
                idCommande = ComboBoxProd.Text
                idProduit = TextBoxQteProduit.Text
                QuantiteProd = ComboBoxCat.Text

                GestionProduit.AjouterProduitByCommande(idCommande, idProduit, QuantiteProd)
                position = 0
                rafraichir()
            Else
                MessageBox.Show("Renseigner la Section SVP...!", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ComboBoxCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCat.SelectedIndexChanged

        GestionInterface.AlimenterComboBox(ComboBoxProd, "SELECT * FROM produit WHERE (idCat = " & ComboBoxCat.SelectedValue & ")", “idProduit ", "LibelleProduit”)

    End Sub
End Class