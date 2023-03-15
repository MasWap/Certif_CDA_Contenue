<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStart
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStart))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnexionBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDeProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionCommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutModifSuprToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDeCommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnexionBDDToolStripMenuItem, Me.GestionClientToolStripMenuItem, Me.GestionProduitToolStripMenuItem, Me.GestionCommandeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConnexionBDDToolStripMenuItem
        '
        Me.ConnexionBDDToolStripMenuItem.Name = "ConnexionBDDToolStripMenuItem"
        Me.ConnexionBDDToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ConnexionBDDToolStripMenuItem.Text = "Connexion BDD"
        '
        'GestionClientToolStripMenuItem
        '
        Me.GestionClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterClientToolStripMenuItem, Me.ListeDesClientsToolStripMenuItem})
        Me.GestionClientToolStripMenuItem.Name = "GestionClientToolStripMenuItem"
        Me.GestionClientToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GestionClientToolStripMenuItem.Text = "Client"
        '
        'AjouterClientToolStripMenuItem
        '
        Me.AjouterClientToolStripMenuItem.Name = "AjouterClientToolStripMenuItem"
        Me.AjouterClientToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AjouterClientToolStripMenuItem.Text = "Ajout/Modif/Supr"
        '
        'ListeDesClientsToolStripMenuItem
        '
        Me.ListeDesClientsToolStripMenuItem.Name = "ListeDesClientsToolStripMenuItem"
        Me.ListeDesClientsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ListeDesClientsToolStripMenuItem.Text = "Liste des clients"
        '
        'GestionProduitToolStripMenuItem
        '
        Me.GestionProduitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterProduitToolStripMenuItem, Me.ListeDeProduitsToolStripMenuItem})
        Me.GestionProduitToolStripMenuItem.Name = "GestionProduitToolStripMenuItem"
        Me.GestionProduitToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.GestionProduitToolStripMenuItem.Text = "Produit"
        '
        'AjouterProduitToolStripMenuItem
        '
        Me.AjouterProduitToolStripMenuItem.Name = "AjouterProduitToolStripMenuItem"
        Me.AjouterProduitToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AjouterProduitToolStripMenuItem.Text = "Ajout/Modif/Supr"
        '
        'ListeDeProduitsToolStripMenuItem
        '
        Me.ListeDeProduitsToolStripMenuItem.Name = "ListeDeProduitsToolStripMenuItem"
        Me.ListeDeProduitsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ListeDeProduitsToolStripMenuItem.Text = "Liste de produits"
        '
        'GestionCommandeToolStripMenuItem
        '
        Me.GestionCommandeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutModifSuprToolStripMenuItem, Me.ListeDeCommandeToolStripMenuItem})
        Me.GestionCommandeToolStripMenuItem.Name = "GestionCommandeToolStripMenuItem"
        Me.GestionCommandeToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.GestionCommandeToolStripMenuItem.Text = "Commande"
        '
        'AjoutModifSuprToolStripMenuItem
        '
        Me.AjoutModifSuprToolStripMenuItem.Name = "AjoutModifSuprToolStripMenuItem"
        Me.AjoutModifSuprToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AjoutModifSuprToolStripMenuItem.Text = "Ajout/Modif/Supr"
        '
        'ListeDeCommandeToolStripMenuItem
        '
        Me.ListeDeCommandeToolStripMenuItem.Name = "ListeDeCommandeToolStripMenuItem"
        Me.ListeDeCommandeToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ListeDeCommandeToolStripMenuItem.Text = "Liste de commandes"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = ""
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(322, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(577, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(67, 39)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(67, 229)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(322, 229)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(577, 229)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(148, 143)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(117, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(366, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(610, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Commande"
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.Location = New System.Drawing.Point(264, 389)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(266, 49)
        Me.btnFermer.TabIndex = 54
        Me.btnFermer.Text = "Fermer le formulaire"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'FrmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IAPM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConnexionBDDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionProduitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterProduitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionCommandeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDeProduitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDeCommandeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutModifSuprToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFermer As Button
End Class
