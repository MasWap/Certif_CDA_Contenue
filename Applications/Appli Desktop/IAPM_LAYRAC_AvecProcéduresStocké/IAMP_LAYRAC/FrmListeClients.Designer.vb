<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeClients))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxRechClient = New System.Windows.Forms.TextBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.DtgLstClients = New System.Windows.Forms.DataGridView()
        CType(Me.DtgLstClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Rechercher un client dans la base de donnée"
        '
        'TxtBoxRechClient
        '
        Me.TxtBoxRechClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtBoxRechClient.Location = New System.Drawing.Point(204, 36)
        Me.TxtBoxRechClient.Name = "TxtBoxRechClient"
        Me.TxtBoxRechClient.Size = New System.Drawing.Size(368, 24)
        Me.TxtBoxRechClient.TabIndex = 51
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnFermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFermer.Location = New System.Drawing.Point(250, 483)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(266, 49)
        Me.BtnFermer.TabIndex = 53
        Me.BtnFermer.Text = "Fermer la liste"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'DtgLstClients
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgLstClients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgLstClients.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgLstClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstClients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgLstClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgLstClients.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgLstClients.EnableHeadersVisualStyles = False
        Me.DtgLstClients.GridColor = System.Drawing.Color.Gray
        Me.DtgLstClients.Location = New System.Drawing.Point(68, 75)
        Me.DtgLstClients.Name = "DtgLstClients"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstClients.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgLstClients.Size = New System.Drawing.Size(645, 385)
        Me.DtgLstClients.TabIndex = 54
        '
        'FrmListeClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(782, 549)
        Me.Controls.Add(Me.DtgLstClients)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxRechClient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de la liste des clients"
        CType(Me.DtgLstClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxRechClient As TextBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents DtgLstClients As DataGridView
End Class
