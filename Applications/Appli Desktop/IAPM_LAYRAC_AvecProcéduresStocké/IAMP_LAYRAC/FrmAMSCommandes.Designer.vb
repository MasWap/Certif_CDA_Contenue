<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSCommandes
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
        Me.CmdSelectGB = New System.Windows.Forms.GroupBox()
        Me.ComboBoxClient = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnAjouterCommande = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btnSuprCommande = New System.Windows.Forms.Button()
        Me.RchCmdGB = New System.Windows.Forms.GroupBox()
        Me.btnConsultCommand = New System.Windows.Forms.Button()
        Me.btnSuivantSuivant = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnPrecedentPrecedent = New System.Windows.Forms.Button()
        Me.CmdGB = New System.Windows.Forms.GroupBox()
        Me.dtgCommande = New System.Windows.Forms.DataGridView()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.CmdSelectGB.SuspendLayout()
        Me.RchCmdGB.SuspendLayout()
        Me.CmdGB.SuspendLayout()
        CType(Me.dtgCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdSelectGB
        '
        Me.CmdSelectGB.Controls.Add(Me.ComboBoxClient)
        Me.CmdSelectGB.Controls.Add(Me.txtDate)
        Me.CmdSelectGB.Controls.Add(Me.btnAjouterCommande)
        Me.CmdSelectGB.Controls.Add(Me.txtNum)
        Me.CmdSelectGB.Controls.Add(Me.lblClient)
        Me.CmdSelectGB.Controls.Add(Me.lblDate)
        Me.CmdSelectGB.Controls.Add(Me.lblNum)
        Me.CmdSelectGB.Controls.Add(Me.btnSuprCommande)
        Me.CmdSelectGB.Location = New System.Drawing.Point(35, 21)
        Me.CmdSelectGB.Name = "CmdSelectGB"
        Me.CmdSelectGB.Size = New System.Drawing.Size(725, 101)
        Me.CmdSelectGB.TabIndex = 0
        Me.CmdSelectGB.TabStop = False
        Me.CmdSelectGB.Text = "Commande Sélectionnée :"
        '
        'ComboBoxClient
        '
        Me.ComboBoxClient.FormattingEnabled = True
        Me.ComboBoxClient.Location = New System.Drawing.Point(189, 68)
        Me.ComboBoxClient.Name = "ComboBoxClient"
        Me.ComboBoxClient.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxClient.TabIndex = 7
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(189, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(215, 20)
        Me.txtDate.TabIndex = 6
        '
        'btnAjouterCommande
        '
        Me.btnAjouterCommande.Location = New System.Drawing.Point(497, 8)
        Me.btnAjouterCommande.Name = "btnAjouterCommande"
        Me.btnAjouterCommande.Size = New System.Drawing.Size(158, 38)
        Me.btnAjouterCommande.TabIndex = 2
        Me.btnAjouterCommande.Text = "+ Nouvelle Commande"
        Me.btnAjouterCommande.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(189, 14)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(215, 20)
        Me.txtNum.TabIndex = 5
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(97, 71)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(39, 13)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(97, 43)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date :"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(97, 16)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(50, 13)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "Numéro :"
        '
        'btnSuprCommande
        '
        Me.btnSuprCommande.Location = New System.Drawing.Point(497, 52)
        Me.btnSuprCommande.Name = "btnSuprCommande"
        Me.btnSuprCommande.Size = New System.Drawing.Size(158, 37)
        Me.btnSuprCommande.TabIndex = 1
        Me.btnSuprCommande.Text = "- Supprimer la Commande"
        Me.btnSuprCommande.UseVisualStyleBackColor = True
        '
        'RchCmdGB
        '
        Me.RchCmdGB.Controls.Add(Me.btnConsultCommand)
        Me.RchCmdGB.Controls.Add(Me.btnSuivantSuivant)
        Me.RchCmdGB.Controls.Add(Me.btnSuivant)
        Me.RchCmdGB.Controls.Add(Me.btnPrecedent)
        Me.RchCmdGB.Controls.Add(Me.btnPrecedentPrecedent)
        Me.RchCmdGB.Location = New System.Drawing.Point(35, 146)
        Me.RchCmdGB.Name = "RchCmdGB"
        Me.RchCmdGB.Size = New System.Drawing.Size(725, 75)
        Me.RchCmdGB.TabIndex = 1
        Me.RchCmdGB.TabStop = False
        Me.RchCmdGB.Text = "Rechercher une Commande :"
        '
        'btnConsultCommand
        '
        Me.btnConsultCommand.Location = New System.Drawing.Point(227, 25)
        Me.btnConsultCommand.Name = "btnConsultCommand"
        Me.btnConsultCommand.Size = New System.Drawing.Size(255, 37)
        Me.btnConsultCommand.TabIndex = 5
        Me.btnConsultCommand.Text = "Consulter Commande"
        Me.btnConsultCommand.UseVisualStyleBackColor = True
        '
        'btnSuivantSuivant
        '
        Me.btnSuivantSuivant.Location = New System.Drawing.Point(642, 25)
        Me.btnSuivantSuivant.Name = "btnSuivantSuivant"
        Me.btnSuivantSuivant.Size = New System.Drawing.Size(60, 38)
        Me.btnSuivantSuivant.TabIndex = 4
        Me.btnSuivantSuivant.Text = ">>"
        Me.btnSuivantSuivant.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(545, 25)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(66, 38)
        Me.btnSuivant.TabIndex = 3
        Me.btnSuivant.Text = ">"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(100, 25)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(60, 38)
        Me.btnPrecedent.TabIndex = 1
        Me.btnPrecedent.Text = "<"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnPrecedentPrecedent
        '
        Me.btnPrecedentPrecedent.Location = New System.Drawing.Point(15, 25)
        Me.btnPrecedentPrecedent.Name = "btnPrecedentPrecedent"
        Me.btnPrecedentPrecedent.Size = New System.Drawing.Size(65, 38)
        Me.btnPrecedentPrecedent.TabIndex = 0
        Me.btnPrecedentPrecedent.Text = "<<"
        Me.btnPrecedentPrecedent.UseVisualStyleBackColor = True
        '
        'CmdGB
        '
        Me.CmdGB.Controls.Add(Me.dtgCommande)
        Me.CmdGB.Location = New System.Drawing.Point(35, 227)
        Me.CmdGB.Name = "CmdGB"
        Me.CmdGB.Size = New System.Drawing.Size(725, 159)
        Me.CmdGB.TabIndex = 2
        Me.CmdGB.TabStop = False
        Me.CmdGB.Text = "Toutes les Commandes :"
        '
        'dtgCommande
        '
        Me.dtgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCommande.Location = New System.Drawing.Point(18, 19)
        Me.dtgCommande.Name = "dtgCommande"
        Me.dtgCommande.Size = New System.Drawing.Size(693, 134)
        Me.dtgCommande.TabIndex = 0
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(297, 392)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(185, 46)
        Me.BtnFermer.TabIndex = 3
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'FrmAMSCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.CmdGB)
        Me.Controls.Add(Me.RchCmdGB)
        Me.Controls.Add(Me.CmdSelectGB)
        Me.Name = "FrmAMSCommandes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Commandes:"
        Me.CmdSelectGB.ResumeLayout(False)
        Me.CmdSelectGB.PerformLayout()
        Me.RchCmdGB.ResumeLayout(False)
        Me.CmdGB.ResumeLayout(False)
        CType(Me.dtgCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdSelectGB As GroupBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents btnConsultCommande As Button
    Friend WithEvents RchCmdGB As GroupBox
    Friend WithEvents btnSuivantSuivant As Button
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents btnPrecedentPrecedent As Button
    Friend WithEvents CmdGB As GroupBox
    Friend WithEvents dtgCommande As DataGridView
    Friend WithEvents BtnFermer As Button
    Friend WithEvents ComboBoxClient As ComboBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnSuprCommande As Button
    Friend WithEvents btnAjouterCommande As Button
    Friend WithEvents btnConsultCommand As Button
End Class
