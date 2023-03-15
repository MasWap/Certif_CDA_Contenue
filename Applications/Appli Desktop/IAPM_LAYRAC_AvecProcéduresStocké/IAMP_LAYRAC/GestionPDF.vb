Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Class GestionPDF
    Public Shared Sub genererpdfdepuisdatatable(ByVal titre As String, ByVal lesdonnees As DataTable)
        Dim Doc As Document = New Document()
        Dim tableau_entete As PdfPTable
        Dim tableau_sous_entete As PdfPTable
        Dim tableau_ligne As PdfPTable
        Dim cellule As PdfPCell = New PdfPCell()
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        Dim nblignes As Integer
        Dim nbcolonnes As Integer

        Try
            PdfWriter.GetInstance(Doc, New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\\pdfExporter.pdf", System.IO.FileMode.Create))
            Doc.SetPageSize(PageSize.A4.Rotate())
            Doc.Open()
            tableau_entete = New PdfPTable(3)
            cellule.Colspan = 0
            tableau_entete.AddCell("Projet Layrac Boutique")
            tableau_entete.AddCell(titre)
            tableau_entete.AddCell(DateTime.Now.ToString())
            tableau_sous_entete = New PdfPTable(6)
            tableau_sous_entete.SpacingBefore = 10
            tableau_sous_entete.AddCell("idProduit")
            tableau_sous_entete.AddCell("LibelleProduit")
            tableau_sous_entete.AddCell("PrixHTProduit")
            tableau_sous_entete.AddCell("QteStockProduit")
            tableau_sous_entete.AddCell("idFourn")
            tableau_sous_entete.AddCell("idCat")
            Doc.Add(tableau_entete)
            Doc.Add(tableau_sous_entete)
            nblignes = lesdonnees.Rows.Count
            nbcolonnes = lesdonnees.Columns.Count
            tableau_ligne = New PdfPTable(2)
            tableau_ligne.SpacingBefore = 20
            Dim uneligne As String = " "
            Dim uneimage As Image = Nothing
            cellule.Colspan = 0
            cellule.Width = 20
            Dim I, j As Integer

            For I = 0 To nblignes - 1

                For j = 0 To nbcolonnes - 1
                    uneligne = uneligne & " |" & " " & lesdonnees.Rows(I).ItemArray(j)
                Next

                uneimage = Image.GetInstance(Environment.CurrentDirectory & "/" & lesdonnees.Rows(I)(6).ToString())
                uneimage.ScaleAbsolute(50.0F, 50.0F)
                tableau_ligne.AddCell(uneligne)
                tableau_ligne.AddCell(New PdfPCell(uneimage))
                uneligne = " "

            Next

            Doc.Add(tableau_ligne)
        Catch ex As Exception
            MessageBox.Show("Erreur sur le fichier PDF | " & ex.Message)
        End Try

        Doc.Close()
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\\pdfExporter.pdf")
    End Sub

End Class





