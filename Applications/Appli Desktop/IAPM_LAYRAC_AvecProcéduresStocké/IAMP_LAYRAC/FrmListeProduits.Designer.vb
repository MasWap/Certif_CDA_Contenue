<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListeProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeProduits))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxRechProduit = New System.Windows.Forms.TextBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.DtgLstProduits = New System.Windows.Forms.DataGridView()
        CType(Me.DtgLstProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Rechercher un produit dans la base de donnée"
        '
        'TxtBoxRechProduit
        '
        Me.TxtBoxRechProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtBoxRechProduit.Location = New System.Drawing.Point(301, 33)
        Me.TxtBoxRechProduit.Name = "TxtBoxRechProduit"
        Me.TxtBoxRechProduit.Size = New System.Drawing.Size(381, 24)
        Me.TxtBoxRechProduit.TabIndex = 47
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
        Me.BtnFermer.Location = New System.Drawing.Point(368, 465)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(266, 49)
        Me.BtnFermer.TabIndex = 54
        Me.BtnFermer.Text = "Fermer la liste"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'DtgLstProduits
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DtgLstProduits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgLstProduits.BackgroundColor = System.Drawing.Color.Snow
        Me.DtgLstProduits.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstProduits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgLstProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgLstProduits.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgLstProduits.EnableHeadersVisualStyles = False
        Me.DtgLstProduits.GridColor = System.Drawing.Color.Gray
        Me.DtgLstProduits.Location = New System.Drawing.Point(30, 72)
        Me.DtgLstProduits.Name = "DtgLstProduits"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLstProduits.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgLstProduits.Size = New System.Drawing.Size(947, 367)
        Me.DtgLstProduits.TabIndex = 55
        '
        'FrmListeProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1007, 533)
        Me.Controls.Add(Me.DtgLstProduits)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxRechProduit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListeProduits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de la liste des produits"
        CType(Me.DtgLstProduits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxRechProduit As TextBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents DtgLstProduits As DataGridView
End Class
