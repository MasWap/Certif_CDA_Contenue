<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAMSProduit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAMSProduit))
        Me.LblCategorieProduit = New System.Windows.Forms.Label()
        Me.DtgProduit = New System.Windows.Forms.DataGridView()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.TextBoxQteProduit = New System.Windows.Forms.TextBox()
        Me.TxtBoxRechProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxPrixProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxLibelleProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxCodeProduit = New System.Windows.Forms.TextBox()
        Me.LblFournisseurProduit = New System.Windows.Forms.Label()
        Me.LblQteProduit = New System.Windows.Forms.Label()
        Me.LblPrixProduit = New System.Windows.Forms.Label()
        Me.LblProduit = New System.Windows.Forms.Label()
        Me.LblCodeProduit = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.ComboBoxFourn = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.BtnPDF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMoins = New System.Windows.Forms.Button()
        Me.btnPrecedentPrecedent = New FontAwesome.Sharp.IconButton()
        Me.btnPrecedent = New FontAwesome.Sharp.IconButton()
        Me.btnSuivant = New FontAwesome.Sharp.IconButton()
        Me.btnSuivantSuivant = New FontAwesome.Sharp.IconButton()
        Me.GrpBox1 = New System.Windows.Forms.GroupBox()
        Me.labelCommentaire = New System.Windows.Forms.Label()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.DtgProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCategorieProduit
        '
        Me.LblCategorieProduit.AutoSize = True
        Me.LblCategorieProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCategorieProduit.Location = New System.Drawing.Point(23, 285)
        Me.LblCategorieProduit.Name = "LblCategorieProduit"
        Me.LblCategorieProduit.Size = New System.Drawing.Size(86, 20)
        Me.LblCategorieProduit.TabIndex = 39
        Me.LblCategorieProduit.Text = "Catégorie :"
        '
        'DtgProduit
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgProduit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgProduit.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgProduit.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgProduit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgProduit.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgProduit.EnableHeadersVisualStyles = False
        Me.DtgProduit.GridColor = System.Drawing.Color.Gray
        Me.DtgProduit.Location = New System.Drawing.Point(479, 74)
        Me.DtgProduit.Name = "DtgProduit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgProduit.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgProduit.Size = New System.Drawing.Size(765, 318)
        Me.DtgProduit.TabIndex = 38
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnModif.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(181, 414)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(119, 52)
        Me.btnModif.TabIndex = 37
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(343, 414)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(119, 52)
        Me.btnPlus.TabIndex = 35
        Me.btnPlus.Text = "Ajouter"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'TextBoxQteProduit
        '
        Me.TextBoxQteProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBoxQteProduit.Location = New System.Drawing.Point(156, 187)
        Me.TextBoxQteProduit.Multiline = True
        Me.TextBoxQteProduit.Name = "TextBoxQteProduit"
        Me.TextBoxQteProduit.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxQteProduit.TabIndex = 30
        '
        'TxtBoxRechProduit
        '
        Me.TxtBoxRechProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtBoxRechProduit.Location = New System.Drawing.Point(664, 38)
        Me.TxtBoxRechProduit.Name = "TxtBoxRechProduit"
        Me.TxtBoxRechProduit.Size = New System.Drawing.Size(381, 24)
        Me.TxtBoxRechProduit.TabIndex = 29
        '
        'TextBoxPrixProduit
        '
        Me.TextBoxPrixProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBoxPrixProduit.Location = New System.Drawing.Point(156, 142)
        Me.TextBoxPrixProduit.Multiline = True
        Me.TextBoxPrixProduit.Name = "TextBoxPrixProduit"
        Me.TextBoxPrixProduit.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxPrixProduit.TabIndex = 28
        '
        'TextBoxLibelleProduit
        '
        Me.TextBoxLibelleProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBoxLibelleProduit.Location = New System.Drawing.Point(156, 95)
        Me.TextBoxLibelleProduit.Multiline = True
        Me.TextBoxLibelleProduit.Name = "TextBoxLibelleProduit"
        Me.TextBoxLibelleProduit.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxLibelleProduit.TabIndex = 27
        '
        'TextBoxCodeProduit
        '
        Me.TextBoxCodeProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodeProduit.Location = New System.Drawing.Point(156, 48)
        Me.TextBoxCodeProduit.Multiline = True
        Me.TextBoxCodeProduit.Name = "TextBoxCodeProduit"
        Me.TextBoxCodeProduit.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxCodeProduit.TabIndex = 26
        '
        'LblFournisseurProduit
        '
        Me.LblFournisseurProduit.AutoSize = True
        Me.LblFournisseurProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblFournisseurProduit.Location = New System.Drawing.Point(23, 238)
        Me.LblFournisseurProduit.Name = "LblFournisseurProduit"
        Me.LblFournisseurProduit.Size = New System.Drawing.Size(101, 20)
        Me.LblFournisseurProduit.TabIndex = 25
        Me.LblFournisseurProduit.Text = "Fournisseur :"
        '
        'LblQteProduit
        '
        Me.LblQteProduit.AutoSize = True
        Me.LblQteProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblQteProduit.Location = New System.Drawing.Point(23, 191)
        Me.LblQteProduit.Name = "LblQteProduit"
        Me.LblQteProduit.Size = New System.Drawing.Size(132, 20)
        Me.LblQteProduit.TabIndex = 24
        Me.LblQteProduit.Text = "Quantité Produit :"
        '
        'LblPrixProduit
        '
        Me.LblPrixProduit.AutoSize = True
        Me.LblPrixProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPrixProduit.Location = New System.Drawing.Point(23, 144)
        Me.LblPrixProduit.Name = "LblPrixProduit"
        Me.LblPrixProduit.Size = New System.Drawing.Size(67, 20)
        Me.LblPrixProduit.TabIndex = 23
        Me.LblPrixProduit.Text = "Prix HT :"
        '
        'LblProduit
        '
        Me.LblProduit.AutoSize = True
        Me.LblProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblProduit.Location = New System.Drawing.Point(23, 97)
        Me.LblProduit.Name = "LblProduit"
        Me.LblProduit.Size = New System.Drawing.Size(62, 20)
        Me.LblProduit.TabIndex = 22
        Me.LblProduit.Text = "Libellé :"
        '
        'LblCodeProduit
        '
        Me.LblCodeProduit.AutoSize = True
        Me.LblCodeProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodeProduit.Location = New System.Drawing.Point(23, 50)
        Me.LblCodeProduit.Name = "LblCodeProduit"
        Me.LblCodeProduit.Size = New System.Drawing.Size(109, 20)
        Me.LblCodeProduit.TabIndex = 21
        Me.LblCodeProduit.Text = "Code Produit :"
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
        Me.btnFermer.Location = New System.Drawing.Point(978, 482)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(266, 49)
        Me.btnFermer.TabIndex = 41
        Me.btnFermer.Text = "Fermer le formulaire"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'ComboBoxFourn
        '
        Me.ComboBoxFourn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ComboBoxFourn.FormattingEnabled = True
        Me.ComboBoxFourn.Location = New System.Drawing.Point(156, 232)
        Me.ComboBoxFourn.Name = "ComboBoxFourn"
        Me.ComboBoxFourn.Size = New System.Drawing.Size(270, 26)
        Me.ComboBoxFourn.TabIndex = 42
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(156, 279)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(270, 26)
        Me.ComboBoxCat.TabIndex = 43
        '
        'BtnPDF
        '
        Me.BtnPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPDF.Location = New System.Drawing.Point(524, 482)
        Me.BtnPDF.Name = "BtnPDF"
        Me.BtnPDF.Size = New System.Drawing.Size(418, 49)
        Me.BtnPDF.TabIndex = 45
        Me.BtnPDF.Text = "Générer une liste des produits (PDF)"
        Me.BtnPDF.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(660, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Rechercher un produit dans la base de donnée"
        '
        'btnMoins
        '
        Me.btnMoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMoins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMoins.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMoins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMoins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMoins.Location = New System.Drawing.Point(21, 414)
        Me.btnMoins.Name = "btnMoins"
        Me.btnMoins.Size = New System.Drawing.Size(119, 52)
        Me.btnMoins.TabIndex = 36
        Me.btnMoins.Text = "Supprimer"
        Me.btnMoins.UseVisualStyleBackColor = False
        '
        'btnPrecedentPrecedent
        '
        Me.btnPrecedentPrecedent.BackColor = System.Drawing.Color.LightGray
        Me.btnPrecedentPrecedent.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.btnPrecedentPrecedent.IconColor = System.Drawing.Color.Black
        Me.btnPrecedentPrecedent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrecedentPrecedent.IconSize = 40
        Me.btnPrecedentPrecedent.Location = New System.Drawing.Point(599, 415)
        Me.btnPrecedentPrecedent.Name = "btnPrecedentPrecedent"
        Me.btnPrecedentPrecedent.Rotation = 90.0R
        Me.btnPrecedentPrecedent.Size = New System.Drawing.Size(96, 52)
        Me.btnPrecedentPrecedent.TabIndex = 47
        Me.btnPrecedentPrecedent.UseVisualStyleBackColor = False
        '
        'btnPrecedent
        '
        Me.btnPrecedent.BackColor = System.Drawing.Color.LightGray
        Me.btnPrecedent.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnPrecedent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnPrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPrecedent.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnPrecedent.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btnPrecedent.IconColor = System.Drawing.Color.Black
        Me.btnPrecedent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrecedent.IconSize = 40
        Me.btnPrecedent.Location = New System.Drawing.Point(725, 415)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(96, 52)
        Me.btnPrecedent.TabIndex = 48
        Me.btnPrecedent.UseVisualStyleBackColor = False
        '
        'btnSuivant
        '
        Me.btnSuivant.BackColor = System.Drawing.Color.LightGray
        Me.btnSuivant.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.btnSuivant.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnSuivant.IconColor = System.Drawing.Color.Black
        Me.btnSuivant.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSuivant.IconSize = 40
        Me.btnSuivant.Location = New System.Drawing.Point(899, 415)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Rotation = 180.0R
        Me.btnSuivant.Size = New System.Drawing.Size(96, 52)
        Me.btnSuivant.TabIndex = 49
        Me.btnSuivant.UseVisualStyleBackColor = False
        '
        'btnSuivantSuivant
        '
        Me.btnSuivantSuivant.BackColor = System.Drawing.Color.LightGray
        Me.btnSuivantSuivant.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.btnSuivantSuivant.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnSuivantSuivant.IconColor = System.Drawing.Color.Black
        Me.btnSuivantSuivant.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSuivantSuivant.IconSize = 40
        Me.btnSuivantSuivant.Location = New System.Drawing.Point(1024, 415)
        Me.btnSuivantSuivant.Name = "btnSuivantSuivant"
        Me.btnSuivantSuivant.Rotation = 180.0R
        Me.btnSuivantSuivant.Size = New System.Drawing.Size(96, 52)
        Me.btnSuivantSuivant.TabIndex = 50
        Me.btnSuivantSuivant.UseVisualStyleBackColor = False
        '
        'GrpBox1
        '
        Me.GrpBox1.Controls.Add(Me.labelCommentaire)
        Me.GrpBox1.Controls.Add(Me.ComboBoxCat)
        Me.GrpBox1.Controls.Add(Me.ComboBoxFourn)
        Me.GrpBox1.Controls.Add(Me.LblCategorieProduit)
        Me.GrpBox1.Controls.Add(Me.TextBoxQteProduit)
        Me.GrpBox1.Controls.Add(Me.TextBoxPrixProduit)
        Me.GrpBox1.Controls.Add(Me.TextBoxLibelleProduit)
        Me.GrpBox1.Controls.Add(Me.TextBoxCodeProduit)
        Me.GrpBox1.Controls.Add(Me.LblFournisseurProduit)
        Me.GrpBox1.Controls.Add(Me.LblQteProduit)
        Me.GrpBox1.Controls.Add(Me.LblPrixProduit)
        Me.GrpBox1.Controls.Add(Me.LblProduit)
        Me.GrpBox1.Controls.Add(Me.LblCodeProduit)
        Me.GrpBox1.Enabled = False
        Me.GrpBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox1.Location = New System.Drawing.Point(16, 27)
        Me.GrpBox1.Name = "GrpBox1"
        Me.GrpBox1.Size = New System.Drawing.Size(446, 365)
        Me.GrpBox1.TabIndex = 52
        Me.GrpBox1.TabStop = False
        Me.GrpBox1.Text = "Formulaire de saisie"
        '
        'labelCommentaire
        '
        Me.labelCommentaire.AutoSize = True
        Me.labelCommentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCommentaire.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.labelCommentaire.Location = New System.Drawing.Point(24, 333)
        Me.labelCommentaire.Name = "labelCommentaire"
        Me.labelCommentaire.Size = New System.Drawing.Size(250, 16)
        Me.labelCommentaire.TabIndex = 44
        Me.labelCommentaire.Text = "Renseignez tous les champs utiles."
        Me.labelCommentaire.Visible = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnAnnuler.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(181, 480)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(281, 52)
        Me.btnAnnuler.TabIndex = 53
        Me.btnAnnuler.Text = "Annuler la saisie"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        Me.btnAnnuler.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'FrmAMSProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1260, 545)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.GrpBox1)
        Me.Controls.Add(Me.btnSuivantSuivant)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPrecedentPrecedent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPDF)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.DtgProduit)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.TxtBoxRechProduit)
        Me.Controls.Add(Me.btnMoins)
        Me.Controls.Add(Me.btnPlus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAMSProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de gestion des produits"
        CType(Me.DtgProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox1.ResumeLayout(False)
        Me.GrpBox1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCategorieProduit As Label
    Friend WithEvents DtgProduit As DataGridView
    Friend WithEvents btnModif As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents TextBoxQteProduit As TextBox
    Friend WithEvents TxtBoxRechProduit As TextBox
    Friend WithEvents TextBoxPrixProduit As TextBox
    Friend WithEvents TextBoxLibelleProduit As TextBox
    Friend WithEvents TextBoxCodeProduit As TextBox
    Friend WithEvents LblFournisseurProduit As Label
    Friend WithEvents LblQteProduit As Label
    Friend WithEvents LblPrixProduit As Label
    Friend WithEvents LblProduit As Label
    Friend WithEvents LblCodeProduit As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents ComboBoxFourn As ComboBox
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents BtnPDF As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMoins As Button
    Friend WithEvents btnPrecedentPrecedent As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrecedent As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSuivant As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSuivantSuivant As FontAwesome.Sharp.IconButton
    Friend WithEvents GrpBox1 As GroupBox
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents labelCommentaire As Label
    Friend WithEvents DataSet1 As DataSet
End Class
