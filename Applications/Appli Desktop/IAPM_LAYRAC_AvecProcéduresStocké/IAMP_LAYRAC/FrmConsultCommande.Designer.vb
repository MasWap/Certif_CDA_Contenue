<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultCommande
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
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.CmdGB = New System.Windows.Forms.GroupBox()
        Me.dtgProduit = New System.Windows.Forms.DataGridView()
        Me.RchCmdGB = New System.Windows.Forms.GroupBox()
        Me.ComboBoxProd = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.btnSuivantSuivant = New System.Windows.Forms.Button()
        Me.LblCategorieProduit = New System.Windows.Forms.Label()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.TextBoxQteProduit = New System.Windows.Forms.TextBox()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.LblQteProduit = New System.Windows.Forms.Label()
        Me.btnPrecedentPrecedent = New System.Windows.Forms.Button()
        Me.LblProduit = New System.Windows.Forms.Label()
        Me.CmdSelectGB = New System.Windows.Forms.GroupBox()
        Me.txtClientConsult = New System.Windows.Forms.TextBox()
        Me.txtDateConsult = New System.Windows.Forms.TextBox()
        Me.txtNumConsult = New System.Windows.Forms.TextBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btnAjouterCommande = New System.Windows.Forms.Button()
        Me.btnSuprCommande = New System.Windows.Forms.Button()
        Me.CmdGB.SuspendLayout()
        CType(Me.dtgProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RchCmdGB.SuspendLayout()
        Me.CmdSelectGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(300, 388)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(185, 46)
        Me.BtnFermer.TabIndex = 7
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'CmdGB
        '
        Me.CmdGB.Controls.Add(Me.dtgProduit)
        Me.CmdGB.Location = New System.Drawing.Point(38, 223)
        Me.CmdGB.Name = "CmdGB"
        Me.CmdGB.Size = New System.Drawing.Size(725, 159)
        Me.CmdGB.TabIndex = 6
        Me.CmdGB.TabStop = False
        Me.CmdGB.Text = "Contenue de la commande :"
        '
        'dtgProduit
        '
        Me.dtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProduit.Location = New System.Drawing.Point(18, 19)
        Me.dtgProduit.Name = "dtgProduit"
        Me.dtgProduit.Size = New System.Drawing.Size(693, 134)
        Me.dtgProduit.TabIndex = 0
        '
        'RchCmdGB
        '
        Me.RchCmdGB.Controls.Add(Me.ComboBoxProd)
        Me.RchCmdGB.Controls.Add(Me.ComboBoxCat)
        Me.RchCmdGB.Controls.Add(Me.btnSuivantSuivant)
        Me.RchCmdGB.Controls.Add(Me.LblCategorieProduit)
        Me.RchCmdGB.Controls.Add(Me.btnSuivant)
        Me.RchCmdGB.Controls.Add(Me.TextBoxQteProduit)
        Me.RchCmdGB.Controls.Add(Me.btnPrecedent)
        Me.RchCmdGB.Controls.Add(Me.LblQteProduit)
        Me.RchCmdGB.Controls.Add(Me.btnPrecedentPrecedent)
        Me.RchCmdGB.Controls.Add(Me.LblProduit)
        Me.RchCmdGB.Location = New System.Drawing.Point(415, 12)
        Me.RchCmdGB.Name = "RchCmdGB"
        Me.RchCmdGB.Size = New System.Drawing.Size(334, 205)
        Me.RchCmdGB.TabIndex = 5
        Me.RchCmdGB.TabStop = False
        Me.RchCmdGB.Text = "Produits dans la commande :"
        '
        'ComboBoxProd
        '
        Me.ComboBoxProd.FormattingEnabled = True
        Me.ComboBoxProd.Location = New System.Drawing.Point(103, 29)
        Me.ComboBoxProd.Name = "ComboBoxProd"
        Me.ComboBoxProd.Size = New System.Drawing.Size(225, 21)
        Me.ComboBoxProd.TabIndex = 50
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(103, 69)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(225, 21)
        Me.ComboBoxCat.TabIndex = 49
        '
        'btnSuivantSuivant
        '
        Me.btnSuivantSuivant.Location = New System.Drawing.Point(268, 161)
        Me.btnSuivantSuivant.Name = "btnSuivantSuivant"
        Me.btnSuivantSuivant.Size = New System.Drawing.Size(60, 38)
        Me.btnSuivantSuivant.TabIndex = 4
        Me.btnSuivantSuivant.Text = ">>"
        Me.btnSuivantSuivant.UseVisualStyleBackColor = True
        '
        'LblCategorieProduit
        '
        Me.LblCategorieProduit.AutoSize = True
        Me.LblCategorieProduit.Location = New System.Drawing.Point(6, 72)
        Me.LblCategorieProduit.Name = "LblCategorieProduit"
        Me.LblCategorieProduit.Size = New System.Drawing.Size(58, 13)
        Me.LblCategorieProduit.TabIndex = 48
        Me.LblCategorieProduit.Text = "Catégorie :"
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(186, 161)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(66, 38)
        Me.btnSuivant.TabIndex = 3
        Me.btnSuivant.Text = ">"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'TextBoxQteProduit
        '
        Me.TextBoxQteProduit.Location = New System.Drawing.Point(103, 107)
        Me.TextBoxQteProduit.Name = "TextBoxQteProduit"
        Me.TextBoxQteProduit.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxQteProduit.TabIndex = 47
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(89, 161)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(60, 38)
        Me.btnPrecedent.TabIndex = 1
        Me.btnPrecedent.Text = "<"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'LblQteProduit
        '
        Me.LblQteProduit.AutoSize = True
        Me.LblQteProduit.Location = New System.Drawing.Point(6, 110)
        Me.LblQteProduit.Name = "LblQteProduit"
        Me.LblQteProduit.Size = New System.Drawing.Size(89, 13)
        Me.LblQteProduit.TabIndex = 45
        Me.LblQteProduit.Text = "Quantité Produit :"
        '
        'btnPrecedentPrecedent
        '
        Me.btnPrecedentPrecedent.Location = New System.Drawing.Point(6, 161)
        Me.btnPrecedentPrecedent.Name = "btnPrecedentPrecedent"
        Me.btnPrecedentPrecedent.Size = New System.Drawing.Size(65, 38)
        Me.btnPrecedentPrecedent.TabIndex = 0
        Me.btnPrecedentPrecedent.Text = "<<"
        Me.btnPrecedentPrecedent.UseVisualStyleBackColor = True
        '
        'LblProduit
        '
        Me.LblProduit.AutoSize = True
        Me.LblProduit.Location = New System.Drawing.Point(8, 32)
        Me.LblProduit.Name = "LblProduit"
        Me.LblProduit.Size = New System.Drawing.Size(46, 13)
        Me.LblProduit.TabIndex = 44
        Me.LblProduit.Text = "Produit :"
        '
        'CmdSelectGB
        '
        Me.CmdSelectGB.Controls.Add(Me.txtClientConsult)
        Me.CmdSelectGB.Controls.Add(Me.txtDateConsult)
        Me.CmdSelectGB.Controls.Add(Me.txtNumConsult)
        Me.CmdSelectGB.Controls.Add(Me.lblClient)
        Me.CmdSelectGB.Controls.Add(Me.lblDate)
        Me.CmdSelectGB.Controls.Add(Me.lblNum)
        Me.CmdSelectGB.Location = New System.Drawing.Point(15, 12)
        Me.CmdSelectGB.Name = "CmdSelectGB"
        Me.CmdSelectGB.Size = New System.Drawing.Size(211, 108)
        Me.CmdSelectGB.TabIndex = 4
        Me.CmdSelectGB.TabStop = False
        Me.CmdSelectGB.Text = "Commande Sélectionnée :"
        '
        'txtClientConsult
        '
        Me.txtClientConsult.Location = New System.Drawing.Point(60, 74)
        Me.txtClientConsult.Name = "txtClientConsult"
        Me.txtClientConsult.Size = New System.Drawing.Size(142, 20)
        Me.txtClientConsult.TabIndex = 7
        '
        'txtDateConsult
        '
        Me.txtDateConsult.Location = New System.Drawing.Point(60, 46)
        Me.txtDateConsult.Name = "txtDateConsult"
        Me.txtDateConsult.Size = New System.Drawing.Size(142, 20)
        Me.txtDateConsult.TabIndex = 6
        '
        'txtNumConsult
        '
        Me.txtNumConsult.Location = New System.Drawing.Point(60, 19)
        Me.txtNumConsult.Name = "txtNumConsult"
        Me.txtNumConsult.Size = New System.Drawing.Size(142, 20)
        Me.txtNumConsult.TabIndex = 5
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(4, 77)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(39, 13)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(4, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date :"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(4, 22)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(50, 13)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "Numéro :"
        '
        'btnAjouterCommande
        '
        Me.btnAjouterCommande.Location = New System.Drawing.Point(232, 37)
        Me.btnAjouterCommande.Name = "btnAjouterCommande"
        Me.btnAjouterCommande.Size = New System.Drawing.Size(177, 37)
        Me.btnAjouterCommande.TabIndex = 8
        Me.btnAjouterCommande.Text = "Ajouter un produit"
        Me.btnAjouterCommande.UseVisualStyleBackColor = True
        '
        'btnSuprCommande
        '
        Me.btnSuprCommande.Location = New System.Drawing.Point(232, 89)
        Me.btnSuprCommande.Name = "btnSuprCommande"
        Me.btnSuprCommande.Size = New System.Drawing.Size(177, 37)
        Me.btnSuprCommande.TabIndex = 1
        Me.btnSuprCommande.Text = "Supprmer un produit"
        Me.btnSuprCommande.UseVisualStyleBackColor = True
        '
        'FrmConsultCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 444)
        Me.Controls.Add(Me.btnAjouterCommande)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.CmdGB)
        Me.Controls.Add(Me.RchCmdGB)
        Me.Controls.Add(Me.CmdSelectGB)
        Me.Controls.Add(Me.btnSuprCommande)
        Me.Name = "FrmConsultCommande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultations des commandes avec ajout et suppression de produits"
        Me.CmdGB.ResumeLayout(False)
        CType(Me.dtgProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RchCmdGB.ResumeLayout(False)
        Me.RchCmdGB.PerformLayout()
        Me.CmdSelectGB.ResumeLayout(False)
        Me.CmdSelectGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFermer As Button
    Friend WithEvents CmdGB As GroupBox
    Friend WithEvents dtgProduit As DataGridView
    Friend WithEvents RchCmdGB As GroupBox
    Friend WithEvents btnSuivantSuivant As Button
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents btnPrecedentPrecedent As Button
    Friend WithEvents CmdSelectGB As GroupBox
    Friend WithEvents txtDateConsult As TextBox
    Friend WithEvents txtNumConsult As TextBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents btnSuprCommande As Button
    Friend WithEvents btnAjouterCommande As Button
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents LblCategorieProduit As Label
    Friend WithEvents TextBoxQteProduit As TextBox
    Friend WithEvents LblQteProduit As Label
    Friend WithEvents LblProduit As Label
    Friend WithEvents txtClientConsult As TextBox
    Friend WithEvents ComboBoxProd As ComboBox
End Class
