<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListeCommandes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeCommandes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxRechCommande = New System.Windows.Forms.TextBox()
        Me.DtgLstCommandes = New System.Windows.Forms.DataGridView()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.DtgStatsCommandes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DtgLstCommandes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgStatsCommandes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Rechercher une commande dans la base de donnée"
        '
        'TxtBoxRechCommande
        '
        Me.TxtBoxRechCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtBoxRechCommande.Location = New System.Drawing.Point(42, 35)
        Me.TxtBoxRechCommande.Name = "TxtBoxRechCommande"
        Me.TxtBoxRechCommande.Size = New System.Drawing.Size(422, 24)
        Me.TxtBoxRechCommande.TabIndex = 55
        '
        'DtgLstCommandes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgLstCommandes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgLstCommandes.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgLstCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstCommandes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgLstCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgLstCommandes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgLstCommandes.EnableHeadersVisualStyles = False
        Me.DtgLstCommandes.GridColor = System.Drawing.Color.Gray
        Me.DtgLstCommandes.Location = New System.Drawing.Point(75, 83)
        Me.DtgLstCommandes.Name = "DtgLstCommandes"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstCommandes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgLstCommandes.Size = New System.Drawing.Size(359, 294)
        Me.DtgLstCommandes.TabIndex = 57
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
        Me.btnFermer.Location = New System.Drawing.Point(115, 558)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(266, 49)
        Me.btnFermer.TabIndex = 58
        Me.btnFermer.Text = "Fermer la liste"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'DtgStatsCommandes
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgStatsCommandes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgStatsCommandes.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgStatsCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgStatsCommandes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DtgStatsCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgStatsCommandes.DefaultCellStyle = DataGridViewCellStyle7
        Me.DtgStatsCommandes.EnableHeadersVisualStyles = False
        Me.DtgStatsCommandes.GridColor = System.Drawing.Color.Gray
        Me.DtgStatsCommandes.Location = New System.Drawing.Point(33, 406)
        Me.DtgStatsCommandes.Name = "DtgStatsCommandes"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgStatsCommandes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DtgStatsCommandes.Size = New System.Drawing.Size(446, 111)
        Me.DtgStatsCommandes.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nombre de commandes en temps réel"
        '
        'FrmListeCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(507, 628)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtgStatsCommandes)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.DtgLstCommandes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxRechCommande)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeCommandes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de la liste des commandes"
        CType(Me.DtgLstCommandes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgStatsCommandes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxRechCommande As TextBox
    Friend WithEvents DtgLstCommandes As DataGridView
    Friend WithEvents btnFermer As Button
    Friend WithEvents DtgStatsCommandes As DataGridView
    Friend WithEvents Label2 As Label
End Class
