<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAMSClient))
        Me.LblCodeClient = New System.Windows.Forms.Label()
        Me.LblNomClient = New System.Windows.Forms.Label()
        Me.LblPrenomClient = New System.Windows.Forms.Label()
        Me.LblRueClient = New System.Windows.Forms.Label()
        Me.LblCPClient = New System.Windows.Forms.Label()
        Me.TextBoxCodeClient = New System.Windows.Forms.TextBox()
        Me.TextBoxNomClient = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomClient = New System.Windows.Forms.TextBox()
        Me.TextBoxCpClient = New System.Windows.Forms.TextBox()
        Me.TextBoxRueClient = New System.Windows.Forms.TextBox()
        Me.lblVilleClient = New System.Windows.Forms.Label()
        Me.TextBoxVilleClient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxRechProduit = New System.Windows.Forms.TextBox()
        Me.GrpBox1 = New System.Windows.Forms.GroupBox()
        Me.labelCommentaire = New System.Windows.Forms.Label()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnMoins = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnSuivantSuivant = New FontAwesome.Sharp.IconButton()
        Me.btnSuivant = New FontAwesome.Sharp.IconButton()
        Me.btnPrecedent = New FontAwesome.Sharp.IconButton()
        Me.btnPrecedentPredecent = New FontAwesome.Sharp.IconButton()
        Me.DtgClient = New System.Windows.Forms.DataGridView()
        Me.GrpBox1.SuspendLayout()
        CType(Me.DtgClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodeClient
        '
        Me.LblCodeClient.AutoSize = True
        Me.LblCodeClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCodeClient.Location = New System.Drawing.Point(23, 50)
        Me.LblCodeClient.Name = "LblCodeClient"
        Me.LblCodeClient.Size = New System.Drawing.Size(99, 20)
        Me.LblCodeClient.TabIndex = 0
        Me.LblCodeClient.Text = "Code Client :"
        '
        'LblNomClient
        '
        Me.LblNomClient.AutoSize = True
        Me.LblNomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblNomClient.Location = New System.Drawing.Point(23, 97)
        Me.LblNomClient.Name = "LblNomClient"
        Me.LblNomClient.Size = New System.Drawing.Size(50, 20)
        Me.LblNomClient.TabIndex = 1
        Me.LblNomClient.Text = "Nom :"
        '
        'LblPrenomClient
        '
        Me.LblPrenomClient.AutoSize = True
        Me.LblPrenomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPrenomClient.Location = New System.Drawing.Point(23, 144)
        Me.LblPrenomClient.Name = "LblPrenomClient"
        Me.LblPrenomClient.Size = New System.Drawing.Size(72, 20)
        Me.LblPrenomClient.TabIndex = 2
        Me.LblPrenomClient.Text = "Prenom :"
        '
        'LblRueClient
        '
        Me.LblRueClient.AutoSize = True
        Me.LblRueClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblRueClient.Location = New System.Drawing.Point(23, 191)
        Me.LblRueClient.Name = "LblRueClient"
        Me.LblRueClient.Size = New System.Drawing.Size(47, 20)
        Me.LblRueClient.TabIndex = 3
        Me.LblRueClient.Text = "Rue :"
        '
        'LblCPClient
        '
        Me.LblCPClient.AutoSize = True
        Me.LblCPClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCPClient.Location = New System.Drawing.Point(23, 238)
        Me.LblCPClient.Name = "LblCPClient"
        Me.LblCPClient.Size = New System.Drawing.Size(103, 20)
        Me.LblCPClient.TabIndex = 4
        Me.LblCPClient.Text = "Code Postal :"
        '
        'TextBoxCodeClient
        '
        Me.TextBoxCodeClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodeClient.Location = New System.Drawing.Point(156, 48)
        Me.TextBoxCodeClient.Multiline = True
        Me.TextBoxCodeClient.Name = "TextBoxCodeClient"
        Me.TextBoxCodeClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxCodeClient.TabIndex = 1
        '
        'TextBoxNomClient
        '
        Me.TextBoxNomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomClient.Location = New System.Drawing.Point(156, 95)
        Me.TextBoxNomClient.Multiline = True
        Me.TextBoxNomClient.Name = "TextBoxNomClient"
        Me.TextBoxNomClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxNomClient.TabIndex = 2
        '
        'TextBoxPrenomClient
        '
        Me.TextBoxPrenomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenomClient.Location = New System.Drawing.Point(156, 142)
        Me.TextBoxPrenomClient.Multiline = True
        Me.TextBoxPrenomClient.Name = "TextBoxPrenomClient"
        Me.TextBoxPrenomClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxPrenomClient.TabIndex = 3
        '
        'TextBoxCpClient
        '
        Me.TextBoxCpClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCpClient.Location = New System.Drawing.Point(156, 232)
        Me.TextBoxCpClient.Multiline = True
        Me.TextBoxCpClient.Name = "TextBoxCpClient"
        Me.TextBoxCpClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxCpClient.TabIndex = 5
        '
        'TextBoxRueClient
        '
        Me.TextBoxRueClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRueClient.Location = New System.Drawing.Point(156, 187)
        Me.TextBoxRueClient.Multiline = True
        Me.TextBoxRueClient.Name = "TextBoxRueClient"
        Me.TextBoxRueClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxRueClient.TabIndex = 4
        '
        'lblVilleClient
        '
        Me.lblVilleClient.AutoSize = True
        Me.lblVilleClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblVilleClient.Location = New System.Drawing.Point(23, 285)
        Me.lblVilleClient.Name = "lblVilleClient"
        Me.lblVilleClient.Size = New System.Drawing.Size(46, 20)
        Me.lblVilleClient.TabIndex = 18
        Me.lblVilleClient.Text = "Ville :"
        '
        'TextBoxVilleClient
        '
        Me.TextBoxVilleClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVilleClient.Location = New System.Drawing.Point(156, 279)
        Me.TextBoxVilleClient.Multiline = True
        Me.TextBoxVilleClient.Name = "TextBoxVilleClient"
        Me.TextBoxVilleClient.Size = New System.Drawing.Size(270, 26)
        Me.TextBoxVilleClient.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(615, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Rechercher un client dans la base de donnée"
        '
        'TxtBoxRechProduit
        '
        Me.TxtBoxRechProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtBoxRechProduit.Location = New System.Drawing.Point(619, 36)
        Me.TxtBoxRechProduit.Name = "TxtBoxRechProduit"
        Me.TxtBoxRechProduit.Size = New System.Drawing.Size(368, 24)
        Me.TxtBoxRechProduit.TabIndex = 7
        '
        'GrpBox1
        '
        Me.GrpBox1.Controls.Add(Me.labelCommentaire)
        Me.GrpBox1.Controls.Add(Me.TextBoxVilleClient)
        Me.GrpBox1.Controls.Add(Me.LblCodeClient)
        Me.GrpBox1.Controls.Add(Me.LblNomClient)
        Me.GrpBox1.Controls.Add(Me.LblPrenomClient)
        Me.GrpBox1.Controls.Add(Me.LblRueClient)
        Me.GrpBox1.Controls.Add(Me.LblCPClient)
        Me.GrpBox1.Controls.Add(Me.TextBoxCodeClient)
        Me.GrpBox1.Controls.Add(Me.TextBoxNomClient)
        Me.GrpBox1.Controls.Add(Me.TextBoxPrenomClient)
        Me.GrpBox1.Controls.Add(Me.TextBoxCpClient)
        Me.GrpBox1.Controls.Add(Me.TextBoxRueClient)
        Me.GrpBox1.Controls.Add(Me.lblVilleClient)
        Me.GrpBox1.Enabled = False
        Me.GrpBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox1.Location = New System.Drawing.Point(16, 27)
        Me.GrpBox1.Name = "GrpBox1"
        Me.GrpBox1.Size = New System.Drawing.Size(446, 365)
        Me.GrpBox1.TabIndex = 59
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
        Me.btnModif.TabIndex = 62
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = False
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
        Me.btnMoins.TabIndex = 61
        Me.btnMoins.Text = "Supprimer"
        Me.btnMoins.UseVisualStyleBackColor = False
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
        Me.btnPlus.TabIndex = 60
        Me.btnPlus.Text = "Ajouter"
        Me.btnPlus.UseVisualStyleBackColor = False
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
        Me.btnAnnuler.TabIndex = 63
        Me.btnAnnuler.Text = "Annuler la saisie"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        Me.btnAnnuler.Visible = False
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
        Me.btnFermer.Location = New System.Drawing.Point(873, 480)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(266, 52)
        Me.btnFermer.TabIndex = 64
        Me.btnFermer.Text = "Fermer le formulaire"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'btnSuivantSuivant
        '
        Me.btnSuivantSuivant.BackColor = System.Drawing.Color.LightGray
        Me.btnSuivantSuivant.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.btnSuivantSuivant.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnSuivantSuivant.IconColor = System.Drawing.Color.Black
        Me.btnSuivantSuivant.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSuivantSuivant.IconSize = 40
        Me.btnSuivantSuivant.Location = New System.Drawing.Point(979, 414)
        Me.btnSuivantSuivant.Name = "btnSuivantSuivant"
        Me.btnSuivantSuivant.Rotation = 180.0R
        Me.btnSuivantSuivant.Size = New System.Drawing.Size(96, 52)
        Me.btnSuivantSuivant.TabIndex = 68
        Me.btnSuivantSuivant.UseVisualStyleBackColor = False
        '
        'btnSuivant
        '
        Me.btnSuivant.BackColor = System.Drawing.Color.LightGray
        Me.btnSuivant.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.btnSuivant.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnSuivant.IconColor = System.Drawing.Color.Black
        Me.btnSuivant.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSuivant.IconSize = 40
        Me.btnSuivant.Location = New System.Drawing.Point(854, 414)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Rotation = 180.0R
        Me.btnSuivant.Size = New System.Drawing.Size(96, 52)
        Me.btnSuivant.TabIndex = 67
        Me.btnSuivant.UseVisualStyleBackColor = False
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
        Me.btnPrecedent.Location = New System.Drawing.Point(680, 414)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(96, 52)
        Me.btnPrecedent.TabIndex = 66
        Me.btnPrecedent.UseVisualStyleBackColor = False
        '
        'btnPrecedentPredecent
        '
        Me.btnPrecedentPredecent.BackColor = System.Drawing.Color.LightGray
        Me.btnPrecedentPredecent.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.btnPrecedentPredecent.IconColor = System.Drawing.Color.Black
        Me.btnPrecedentPredecent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrecedentPredecent.IconSize = 40
        Me.btnPrecedentPredecent.Location = New System.Drawing.Point(554, 415)
        Me.btnPrecedentPredecent.Name = "btnPrecedentPredecent"
        Me.btnPrecedentPredecent.Rotation = 90.0R
        Me.btnPrecedentPredecent.Size = New System.Drawing.Size(96, 52)
        Me.btnPrecedentPredecent.TabIndex = 65
        Me.btnPrecedentPredecent.UseVisualStyleBackColor = False
        '
        'DtgClient
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgClient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgClient.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgClient.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgClient.EnableHeadersVisualStyles = False
        Me.DtgClient.GridColor = System.Drawing.Color.Gray
        Me.DtgClient.Location = New System.Drawing.Point(486, 75)
        Me.DtgClient.Name = "DtgClient"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgClient.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgClient.Size = New System.Drawing.Size(653, 317)
        Me.DtgClient.TabIndex = 69
        '
        'FrmAMSClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1153, 545)
        Me.Controls.Add(Me.DtgClient)
        Me.Controls.Add(Me.btnSuivantSuivant)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPrecedentPredecent)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnMoins)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.GrpBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxRechProduit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAMSClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de gestion des clients"
        Me.GrpBox1.ResumeLayout(False)
        Me.GrpBox1.PerformLayout()
        CType(Me.DtgClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCodeClient As Label
    Friend WithEvents LblNomClient As Label
    Friend WithEvents LblPrenomClient As Label
    Friend WithEvents LblRueClient As Label
    Friend WithEvents LblCPClient As Label
    Friend WithEvents TextBoxCodeClient As TextBox
    Friend WithEvents TextBoxNomClient As TextBox
    Friend WithEvents TextBoxPrenomClient As TextBox
    Friend WithEvents TextBoxCpClient As TextBox
    Friend WithEvents TextBoxRueClient As TextBox
    Friend WithEvents lblVilleClient As Label
    Friend WithEvents TextBoxVilleClient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxRechProduit As TextBox
    Friend WithEvents GrpBox1 As GroupBox
    Friend WithEvents labelCommentaire As Label
    Friend WithEvents btnModif As Button
    Friend WithEvents btnMoins As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnSuivantSuivant As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSuivant As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrecedent As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrecedentPredecent As FontAwesome.Sharp.IconButton
    Friend WithEvents DtgClient As DataGridView
End Class
