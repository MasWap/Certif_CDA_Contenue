Imports MySql.Data
Imports IAMP_LAYRAC.GestionBDD
Imports IAMP_LAYRAC.GestionCommande

Public Class FrmStart

    Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GestionBDD.SeConnecter()

    End Sub

    Private Sub GestionClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionClientToolStripMenuItem.Click

    End Sub

    Private Sub AjouterClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterClientToolStripMenuItem.Click

        FrmAMSClient.Show()

    End Sub

    Private Sub ListeDesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesClientsToolStripMenuItem.Click

        FrmListeClients.Show()

    End Sub

    Private Sub ListeClientToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AjouterProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterProduitToolStripMenuItem.Click

        FrmAMSProduit.Show()

    End Sub

    Private Sub ListeDeProduitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDeProduitsToolStripMenuItem.Click

        FrmListeProduits.Show()

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub AjoutModifSuprToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutModifSuprToolStripMenuItem.Click
        FrmAMSCommandes.Show()
    End Sub

    Private Sub ListeDeCommandeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDeCommandeToolStripMenuItem.Click
        FrmListeCommandes.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmAMSProduit.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmAMSCommandes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FrmListeClients.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmListeProduits.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmListeCommandes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmAMSClient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ToolTip1.Show("Ouvrir le formulaire de gestion produits", PictureBox1)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        ToolTip1.Show("Ouvrir le formulaire de gestion client", PictureBox3)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.Show("Ouvrir le formulaire de gestion commande", PictureBox2)
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        ToolTip1.Show("Ouvrir la liste des clients", PictureBox4)
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        ToolTip1.Show("Ouvrir la liste des produits", PictureBox5)
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        ToolTip1.Show("Ouvrir la liste des commandes", PictureBox6)
    End Sub

End Class
