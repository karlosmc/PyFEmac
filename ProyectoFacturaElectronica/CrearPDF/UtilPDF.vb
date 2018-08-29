Imports iTextSharp.text.pdf
Imports iTextSharp.text

Imports System.IO
Imports System.Text
Imports System.Xml
Imports iTextSharp.text.html
Public Class UtilPDF
    Public Function GenerarPDF(pathlogo As String, authsunat As String, doc As DocumentoElectronico, firma As FirmadoResponse, respuesta As EnviarDocumentoResponse, DocCondicion As String, webconsulta As String) As String
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
        Dim PDFData As MemoryStream = New MemoryStream
        Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, PDFData)
        Dim titleFont = FontFactory.GetFont("arial", 10, iTextSharp.text.Font.BOLD)
        Dim miniFont = FontFactory.GetFont("arial", 4, iTextSharp.text.Font.BOLD)
        Dim invoiceFont = FontFactory.GetFont("arial", 12, iTextSharp.text.Font.BOLD)
        Dim titleFontBlue = FontFactory.GetFont("arial", 14, iTextSharp.text.Font.NORMAL, BaseColor.BLUE)
        Dim boldTableFont = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL)
        Dim bodyFont = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)
        Dim bodyFontBold = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)
        Dim bodyFontBold2 = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)
        Dim EmailFont = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLUE)
        Dim TabelHeaderBackGroundColor As BaseColor = WebColors.GetRGBColor("#EEEEEE")

        Dim ObsTitleFont = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)
        Dim ObsBodyFont = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)

        Dim AuthFont = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.ITALIC)

        Dim PageSize As Rectangle = writer.PageSize

        pdfDoc.Open()

        Dim headertable As PdfPTable = New PdfPTable(3)
        headertable.HorizontalAlignment = 0
        headertable.WidthPercentage = 100
        headertable.SetWidths(New Single() {100.0F, 80.0F, 100.0F})
        headertable.DefaultCell.Border = Rectangle.NO_BORDER

        Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(pathlogo)
        'logo.ScaleToFit(100, 15)

        Dim pdfCelllogo As PdfPCell = New PdfPCell(logo)
        pdfCelllogo.Border = Rectangle.NO_BORDER
        headertable.AddCell(pdfCelllogo)

        Dim middlecell As PdfPCell = New PdfPCell()
        middlecell.Border = Rectangle.NO_BORDER
        headertable.AddCell(middlecell)


        Dim nested As PdfPTable = New PdfPTable(1)
        nested.DefaultCell.Border = Rectangle.BOX

        'top 1
        'bottom 2
        'left 4
        'right 8

        Dim tipoDoc As String = ""
        Select Case doc.TipoDocumento
            Case "01"
                tipoDoc = "FACTURA"

            Case "03"
                tipoDoc = "BOLETA"

            Case "07"
                tipoDoc = "NOTA DE CREDITO"

            Case "08"
                tipoDoc = "NOTA DE DEBITO"
            Case Else
                tipoDoc = "BOLETA"
        End Select
        AgregarCeldaTableBorder("RUC N° " & doc.Emisor.NroDocumento, invoiceFont, Nothing, {1, 4, 8}, Element.ALIGN_CENTER, nested, 0, 0, 10.0!, 0, 0, 0, 2.0!)
        AgregarCeldaTableBorder("   ", miniFont, Nothing, {4, 8}, 99, nested, 0, 0, 0, 0, 0, 0, 2.0!)
        AgregarCeldaTableBorder(tipoDoc, invoiceFont, Nothing, {4, 8}, 1, nested, 0, 0, 0, 0, 0, 0, 2.0!)
        AgregarCeldaTableBorder("ELECTRONICA", invoiceFont, Nothing, {4, 8}, 1, nested, 0, 0, 0, 0, 0, 0, 2.0!)
        AgregarCeldaTableBorder(doc.IdDocumento, invoiceFont, Nothing, {2, 4, 8}, 1, nested, 0, 0, 0, 10.0!, 0, 0, 2.0!)

        Dim nesthousing As PdfPCell = New PdfPCell(nested)
        AgregarTableCelda(nesthousing, Nothing, {0}, 99, headertable, 5, 0, 0, 0, 0, 0)


        '///invoice table DATOS DE EMISOR Y RECEPTOR


        Dim Invoicetable As PdfPTable = New PdfPTable(3)
        Invoicetable.HorizontalAlignment = 0
        Invoicetable.WidthPercentage = 100
        Invoicetable.SetWidths(New Single() {320.0!, 100.0!, 100.0!})
        Invoicetable.DefaultCell.Border = Rectangle.NO_BORDER



        Dim nested1 As PdfPTable = New PdfPTable(1)
        nested1.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable(doc.Emisor.NombreLegal, titleFont, Nothing, {0}, 99, nested1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(doc.Emisor.NombreComercial, bodyFont, Nothing, {0}, 99, nested1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(doc.Emisor.Direccion, bodyFont, Nothing, {0}, 99, nested1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(doc.Emisor.Departamento & " - " & doc.Emisor.Provincia & " - " & doc.Emisor.Distrito, bodyFont, Nothing, {0}, 99, nested1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, nested1, 0, 0, 0, 0, 0, 0)


        Dim nesthousing1 As PdfPCell = New PdfPCell(nested1)

        AgregarTableCelda(nesthousing1, Nothing, {0}, 99, Invoicetable, 5, 0, 0, 5.0F, 0, 0)

        Dim middlecell1 As PdfPCell = New PdfPCell

        middlecell1.Border = Rectangle.NO_BORDER
        'middlecell.BorderColorBottom = new BaseColor(System.Drawing.Color.Black);
        'middlecell.BorderWidthBottom = 1f;

        Invoicetable.AddCell(middlecell1)
        Invoicetable.AddCell("")


        Dim Invoicetable2 As PdfPTable = New PdfPTable(4)
        Invoicetable2.HorizontalAlignment = 0
        Invoicetable2.WidthPercentage = 100
        Invoicetable2.SetWidths(New Single() {100.0!, 300.0!, 80.0!, 100})
        Invoicetable2.DefaultCell.Border = Rectangle.NO_BORDER


        Dim clientetable As PdfPTable = New PdfPTable(1)
        clientetable.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable("Nombre/Razón Social:", bodyFontBold, Nothing, {0}, 99, clientetable, 0, 0, 0, 8.0!, 0, 0)
        AgregarCeldaTable("Dirección:", bodyFontBold, Nothing, {0}, 99, clientetable, 0, 0, 0, 8.0!, 0, 0)
        AgregarCeldaTable("Condición:", bodyFontBold, Nothing, {0}, 99, clientetable, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("Moneda:", bodyFontBold, Nothing, {0}, 99, clientetable, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFontBold, Nothing, {0}, 99, clientetable, 0, 0, 0, 0, 0, 0)


        Dim InvoiceTableCol1 As PdfPCell = New PdfPCell(clientetable)
        AgregarTableCelda(InvoiceTableCol1, Nothing, {0}, 99, Invoicetable2, 4, 0, 0, 10.0F, 0, 0)


        Dim reqclientetable As PdfPTable = New PdfPTable(1)
        reqclientetable.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable(Conversion2celdas(doc.Receptor.NombreLegal), bodyFont, Nothing, {0}, 99, reqclientetable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(Conversion2celdas(doc.Receptor.Direccion), bodyFont, Nothing, {0}, 99, reqclientetable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(IIf(String.IsNullOrEmpty(DocCondicion), " ", DocCondicion), bodyFont, Nothing, {0}, 99, reqclientetable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(doc.Moneda, bodyFont, Nothing, {0}, 99, reqclientetable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(" ", bodyFont, Nothing, {0}, 99, reqclientetable, 0, 0, 0, 0, 0, 0)


        Dim InvoiceTableCol2 As PdfPCell = New PdfPCell(reqclientetable)

        AgregarTableCelda(InvoiceTableCol2, Nothing, {0}, 99, Invoicetable2, 5, 0, 0, 10.0F, 0, 0)

        Dim clientetable1 As PdfPTable = New PdfPTable(1)
        clientetable1.DefaultCell.Border = Rectangle.NO_BORDER


        AgregarCeldaTable("RUC:", bodyFontBold, Nothing, {0}, 99, clientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("Fecha:", bodyFontBold, Nothing, {0}, 99, clientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("Doc. Ref. Guía:", bodyFontBold, Nothing, {0}, 99, clientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("Doc. Ref.:", bodyFontBold, Nothing, {0}, 99, clientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("Tipo Nota Crédito:", bodyFontBold, Nothing, {0}, 99, clientetable1, 0, 0, 0, 0, 0, 0)

        Dim InvoiceTableCol3 As PdfPCell = New PdfPCell(clientetable1)

        AgregarTableCelda(InvoiceTableCol3, Nothing, {0}, 99, Invoicetable2, 5, 0, 0, 10.0F, 0, 0)

        Dim rela As String = " "
        Dim nota As String = " "
        Dim disc As String = " "
        For Each relacionados As DocumentoRelacionado In doc.Relacionados
            If relacionados.TipoDocumento = "09" Then
                rela = relacionados.TipoDocumento & " " & relacionados.NroDocumento + rela
            End If
            If relacionados.TipoDocumento = "01" Or relacionados.TipoDocumento = "03" Then
                nota = relacionados.TipoDocumento & " " & relacionados.NroDocumento + nota
            End If
        Next
        For Each discrepancia As Discrepancia In doc.Discrepancias
            disc = discrepancia.Tipo & ": " & discrepancia.Descripcion
        Next

        Dim reqclientetable1 As PdfPTable = New PdfPTable(1)
        reqclientetable1.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable(doc.Receptor.NroDocumento, bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(CDate(doc.FechaEmision).ToString("dd/MM/yyyy"), bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)


        AgregarCeldaTable(rela, bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(nota, bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)

        'AgregarCeldaTable(" ", bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(disc, bodyFont, Nothing, {0}, 99, reqclientetable1, 0, 0, 0, 0, 0, 0)


        Dim InvoiceTableCol4 As PdfPCell = New PdfPCell(reqclientetable1)

        AgregarTableCelda(InvoiceTableCol4, Nothing, {0}, 99, Invoicetable2, 4, 0, 0, 10.0F, 0, 0)

        pdfDoc.Add(headertable)
        Invoicetable.PaddingTop = 10.0!
        pdfDoc.Add(Invoicetable)
        pdfDoc.Add(Invoicetable2)

        Dim itemTable = New PdfPTable(9)

        itemTable.HorizontalAlignment = 0
        itemTable.WidthPercentage = 100
        itemTable.SetWidths(New Single() {10, 90, 10, 16, 20, 20, 20, 20, 20})
        ' then set the column's __relative__ widths
        itemTable.SpacingAfter = 40
        itemTable.DefaultCell.Border = Rectangle.BOX

        AgregarCeldaTable("Item", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        ' AgregarCeldaTable("Codigo", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("Descripción", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("Und.", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("Cant.", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("V. Unitario", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("P. Unitario", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("M. ISC", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("Desc.", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)

        AgregarCeldaTable("Valor Venta", boldTableFont, TabelHeaderBackGroundColor, {"00"}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 5.0!, 0, 0)


        'foreach (DataRow row in dt.Rows)

        For Each item As DetalleDocumento In doc.Items

            'For i As Integer = 0 To 4
            AgregarCeldaTable(item.ID, bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            ' AgregarCeldaTable(item.CodigoItem, bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_LEFT, itemTable, 0, 0, 0, 0, 10.0!, 0)

            AgregarCeldaTable(item.Descripcion, bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_LEFT, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(item.UnidadMedida, bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.Cantidad, "#0.000"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.ValorUnitario, "#0.000"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.PrecioUnitario, "#0.00"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.ImpuestoSelectivo, "#0.00"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.Descuento, "#0.00"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_CENTER, itemTable, 0, 0, 0, 0, 4.0!, 0)

            AgregarCeldaTable(Format(item.ValorTotal, "#0.00"), bodyFont, Nothing, {1, 4, 8, 2}, Element.ALIGN_RIGHT, itemTable, 0, 0, 0, 0, 4.0!, 0)
        Next

        AgregarCeldaTable("SON:" & doc.MontoEnLetras, bodyFont, Nothing, {1}, Element.ALIGN_LEFT, itemTable, 0, 9, 10.0!, -50.0!, 0, 0)

        Dim InvoiceTable3 As PdfPTable = New PdfPTable(4)
        InvoiceTable3.HorizontalAlignment = 0
        InvoiceTable3.WidthPercentage = 100
        InvoiceTable3.SetWidths(New Single() {300.0!, 150.0!, 100.0!, 40.0!})
        ' then set the column's __relative__ widths
        InvoiceTable3.DefaultCell.Border = Rectangle.NO_BORDER


        Dim TableWhite As PdfPTable = New PdfPTable(1)
        TableWhite.DefaultCell.Border = Rectangle.NO_BORDER
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("", bodyFont, Nothing, {0}, 99, TableWhite, 0, 0, 0, 0, 0, 0)


        Dim InvoiceTableTot1 As PdfPCell = New PdfPCell(TableWhite)
        AgregarTableCelda(InvoiceTableTot1, Nothing, {0}, 99, InvoiceTable3, 0, 0, 0, 0, 0, 0)

        Dim TableOper As PdfPTable = New PdfPTable(1)
        TableOper.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable("OP. GRAVADA", bodyFontBold, Nothing, {0}, 99, TableOper, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("OP. INAFECTAS", bodyFontBold, Nothing, {0}, 99, TableOper, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("OP. EXONERADAS", bodyFontBold, Nothing, {0}, 99, TableOper, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("I.S.C.", bodyFontBold, Nothing, {0}, 99, TableOper, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable("I.G.V.", bodyFontBold, Nothing, {2}, 99, TableOper, 0, 0, 0, 10.0!, 0, 0)

        AgregarCeldaTable("IMPORTE TOTAL", bodyFontBold, Nothing, {0}, 99, TableOper, 0, 0, 0, 0, 0, 0)

        Dim InvoiceTabletot2 As PdfPCell = New PdfPCell(TableOper)

        AgregarTableCelda(InvoiceTabletot2, Nothing, {0}, 99, InvoiceTable3, 0, 0, 0, 0, 0, 0)

        Dim TableMoneda As PdfPTable = New PdfPTable(1)
        TableMoneda.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable("PEN", bodyFont, Nothing, {0}, 0, TableMoneda, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("PEN", bodyFont, Nothing, {0}, 0, TableMoneda, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("PEN", bodyFont, Nothing, {0}, 0, TableMoneda, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("PEN", bodyFont, Nothing, {0}, 0, TableMoneda, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable("PEN", bodyFont, Nothing, {2}, 0, TableMoneda, 0, 0, 0, 10.0!, 0, 0)
        AgregarCeldaTable("PEN", bodyFont, Nothing, {0}, 0, TableMoneda, 0, 0, 0, 0, 0, 0)

        Dim InvoiceTableMoneda As PdfPCell = New PdfPCell(TableMoneda)
        AgregarTableCelda(InvoiceTableMoneda, Nothing, {0}, 99, InvoiceTable3, 0, 0, 0, 0, 0, 0)

        Dim TableTOT As PdfPTable = New PdfPTable(1)
        TableTOT.DefaultCell.Border = Rectangle.NO_BORDER

        AgregarCeldaTable(Format(doc.Gravadas, "#0.00"), bodyFont, Nothing, {0}, 2, TableTOT, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable(Format(doc.Inafectas, "#0.00"), bodyFont, Nothing, {0}, 2, TableTOT, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable(Format(doc.Exoneradas, "#0.00"), bodyFont, Nothing, {0}, 2, TableTOT, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable(Format(doc.TotalIsc, "#0.00"), bodyFont, Nothing, {0}, 2, TableTOT, 0, 0, 0, 0, 0, 0)
        AgregarCeldaTable(Format(doc.TotalIgv, "#0.00"), bodyFont, Nothing, {2}, 2, TableTOT, 0, 0, 0, 10.0!, 0, 0)
        AgregarCeldaTable(Format(doc.TotalVenta, "#0.00"), bodyFont, Nothing, {0}, 2, TableTOT, 0, 0, 0, 0, 0, 0)

        Dim InvoiceTabletot3 As PdfPCell = New PdfPCell(TableTOT)
        InvoiceTabletot3.Border = Rectangle.NO_BORDER

        AgregarTableCelda(InvoiceTabletot3, Nothing, {0}, 99, InvoiceTable3, 0, 0, 0, 10.0!, 0, 0)


        '***********OBSERVACIONES SUNAT

        Dim ObsTable = New PdfPTable(1)

        ObsTable.HorizontalAlignment = 0
        ObsTable.WidthPercentage = 100

        'itemTable.SetWidths(New Single() {15, 30, 100, 15, 15, 20, 20, 20, 20, 20})
        ' then set the column's __relative__ widths
        ObsTable.SpacingAfter = 32.0!
        ObsTable.DefaultCell.Border = Rectangle.BOX


        AgregarCeldaTable("Observaciones de SUNAT:", ObsTitleFont, Nothing, {Rectangle.LEFT_BORDER, Rectangle.RIGHT_BORDER, Rectangle.TOP_BORDER}, 0, ObsTable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(respuesta.MensajeRespuesta, ObsBodyFont, Nothing, {Rectangle.LEFT_BORDER, Rectangle.RIGHT_BORDER}, 0, ObsTable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(" ", ObsBodyFont, Nothing, {Rectangle.LEFT_BORDER, Rectangle.RIGHT_BORDER}, 0, ObsTable, 0, 0, 0, 0, 0, 0)

        AgregarCeldaTable(respuesta.Nota, ObsBodyFont, Nothing, {Rectangle.BOTTOM_BORDER, Rectangle.LEFT_BORDER, Rectangle.RIGHT_BORDER}, 0, ObsTable, 0, 0, 0, 0, 0, 0)


        Dim AuthTable = New PdfPTable(2)

        AuthTable.SetWidths(New Single() {150.0!, 280.0!})
        AuthTable.HorizontalAlignment = 0
        AuthTable.WidthPercentage = 100

        'itemTable.SetWidths(New Single() {15, 30, 100, 15, 15, 20, 20, 20, 20, 20})
        ' then set the column's __relative__ widths
        'AuthTable.SpacingAfter = 40
        'AuthTable.DefaultCell.Border = Rectangle.NO_BORDER
        AgregarCeldaTable("Autorizado a ser emisor electrónico mediante R.I. SUNAT Nº ", AuthFont, Nothing, {4, 8}, 0, AuthTable, 0, 0, -30.0!, 0, 0, 0)
        AgregarCeldaTable(authsunat, ObsTitleFont, Nothing, {0}, 0, AuthTable, 0, 0, -30.0!, 0, 0, 0)

        Dim QRtable As PdfPTable = New PdfPTable(1)
        headertable.HorizontalAlignment = 0
        headertable.WidthPercentage = 100
        headertable.DefaultCell.Border = Rectangle.NO_BORDER

        Dim RUC As String = doc.Emisor.NroDocumento
        Dim tipo As String = doc.TipoDocumento
        Dim serDOC As String = Mid(doc.IdDocumento, 1, 4)
        Dim numDOC As String = Mid(doc.IdDocumento, 6, doc.IdDocumento.Length)
        Dim igv As String = doc.TotalIgv
        Dim total As String = doc.TotalVenta
        Dim fecha As String = doc.FechaEmision
        Dim tipocli As String = doc.Receptor.TipoDocumento
        Dim ruccli As String = doc.Receptor.NroDocumento
        'Dim signedvalue As String = "nT57erWwE1Q33NDW+6d0dpQSVW2E4avrXvTGTIljm3vQU/jF5bX2C8wI6PvxPrpOur6Bzo7teDACPcN7Mb801hbRXyJfOlxU4TXrLZTc2pJ4mDFg0YY+KX1RFmyR66Ejkl51dg+dAgBAK4uYUJxgxbX2REOn4B6TOKf2G2Y/SfLbsB2qhEYnuFVBHvNkorBaaotFSUoH3zyqeNVXlvHh0/VjBrd4+6wg788IN/IQYmdoPqC6IFOo3ExkscYeEnx3jE8bsZ2c0s+pSq9/a3jw8eIhmj3tq54Ion0kbgvuqch6eZyfKXjIFY8G3+CVMPuAQ255A0HMwZX9mdPU3gyYTw=="


        Dim hints As IDictionary(Of qrcode.EncodeHintType, Object) = New Dictionary(Of qrcode.EncodeHintType, Object)
        hints.Add(qrcode.EncodeHintType.ERROR_CORRECTION, qrcode.ErrorCorrectionLevel.Q)

        Dim codebar As String = RUC & "|" & tipo & "|" & serDOC & "|" & numDOC & "|" & igv & "|" & total & "|" & fecha & "|" & tipocli & "|" & ruccli & "|"
        Dim codigoQR As BarcodeQRCode = New BarcodeQRCode(codebar, 100, 100, hints)

        Dim qr As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(codigoQR.GetImage)
        'logo.ScaleToFit(100, 15)

        Dim QrCell As PdfPCell = New PdfPCell(qr)
        QrCell.Border = Rectangle.NO_BORDER
        QrCell.HorizontalAlignment = Element.ALIGN_CENTER
        QrCell.PaddingTop = -10.0!
        QRtable.AddCell(QrCell)

        If Not String.IsNullOrEmpty(webconsulta) Then webconsulta = ", consulte en " & webconsulta
        AgregarCeldaTable("Representación Impresa de la " & tipoDoc & " Electrónica" & webconsulta, AuthFont, Nothing, {0}, Element.ALIGN_CENTER, QRtable, 0, 0, 5.0!, 0, 0, 0)
        AgregarCeldaTable("Código hash: " & firma.ResumenFirma, AuthFont, Nothing, {0}, Element.ALIGN_CENTER, QRtable, 0, 0, 5.0!, 0, 0, 0)

        pdfDoc.Add(itemTable)
        pdfDoc.Add(InvoiceTable3)
        pdfDoc.Add(ObsTable)
        pdfDoc.Add(AuthTable)
        pdfDoc.Add(QRtable)
        pdfDoc.Close()
        Return Convert.ToBase64String(PDFData.ToArray)
        ' Descargar(PDFData, pathnomarchivo)
    End Function
    'Private Sub Descargar(pdfData As MemoryStream, pathnombrearchivo As String)
    '    File.WriteAllBytes(pathnombrearchivo, pdfData.ToArray())

    'End Sub
    Private Sub AgregarCeldaTable(texto As String, font As Font, fondo As BaseColor, _
                             borders() As String, alinea As Integer, ptable As PdfPTable, _
                             rowspan As Integer, colspan As Integer, paddingtop As Single, paddingbot As Single, paddingLeft As Single, paddingRight As Single)

        Dim cell As PdfPCell = New PdfPCell(New Phrase(texto, font))
        Select Case borders.Length
            Case 1
                If borders(0) = "00" Then Exit Select
                cell.Border = borders(0)
            Case 2
                cell.Border = (borders(0) Or borders(1))
            Case 3
                cell.Border = (borders(0) Or borders(1) Or borders(2))
            Case 4
                cell.Border = (borders(0) Or borders(1) Or borders(2) Or borders(3))
            Case Else
                cell.Border = 0
        End Select
        If rowspan <> 0 Then cell.Rowspan = rowspan
        If colspan <> 0 Then cell.Colspan = colspan
        If paddingtop <> 0 Then cell.PaddingTop = paddingtop
        If paddingbot <> 0 Then cell.PaddingBottom = paddingbot
        If paddingLeft <> 0 Then cell.PaddingLeft = paddingLeft
        If paddingRight <> 0 Then cell.PaddingRight = paddingRight
        cell.BackgroundColor = fondo
        If alinea <> 99 Then cell.HorizontalAlignment = alinea
        ptable.AddCell(cell)
    End Sub
    Private Sub AgregarTableCelda(cell As PdfPCell, fondo As BaseColor, _
                             borders() As String, alinea As Integer, ptable As PdfPTable, _
                             rowspan As Integer, colspan As Integer, paddingtop As Single, paddingbot As Single, paddingLeft As Single, paddingRight As Single)

        'Dim cell As PdfPCell = New PdfPCell(ptableOr)
        Select Case borders.Length
            Case 1
                If borders(0) = "00" Then Exit Select
                cell.Border = borders(0)
            Case 2
                cell.Border = (borders(0) Or borders(1))
            Case 3
                cell.Border = (borders(0) Or borders(1) Or borders(2))
            Case 4
                cell.Border = (borders(0) Or borders(1) Or borders(2) Or borders(3))
            Case Else
                cell.Border = 0
        End Select
        If rowspan <> 0 Then cell.Rowspan = rowspan
        If colspan <> 0 Then cell.Colspan = colspan
        If paddingtop <> 0 Then cell.PaddingTop = paddingtop
        If paddingbot <> 0 Then cell.PaddingBottom = paddingbot
        If paddingLeft <> 0 Then cell.PaddingLeft = paddingLeft
        If paddingRight <> 0 Then cell.PaddingRight = paddingRight

        cell.BackgroundColor = fondo
        If alinea <> 99 Then cell.HorizontalAlignment = alinea
        ptable.AddCell(cell)
    End Sub

    Private Sub AgregarCeldaTableBorder(texto As String, font As Font, fondo As BaseColor, _
                             borders() As String, alinea As Integer, ptable As PdfPTable, _
                             rowspan As Integer, colspan As Integer, paddingtop As Single, paddingbot As Single, paddingLeft As Single, paddingRight As Single, borderwidth As Single)

        Dim cell As PdfPCell = New PdfPCell(New Phrase(texto, font))
        Select Case borders.Length
            Case 1
                If borders(0) = "00" Then Exit Select
                cell.Border = borders(0)
            Case 2
                cell.Border = (borders(0) Or borders(1))
            Case 3
                cell.Border = (borders(0) Or borders(1) Or borders(2))
            Case 4
                cell.Border = (borders(0) Or borders(1) Or borders(2) Or borders(3))
            Case Else
                cell.Border = 0
        End Select
        If borderwidth <> 0 Then cell.BorderWidth = borderwidth
        If rowspan <> 0 Then cell.Rowspan = rowspan
        If colspan <> 0 Then cell.Colspan = colspan
        If paddingtop <> 0 Then cell.PaddingTop = paddingtop
        If paddingbot <> 0 Then cell.PaddingBottom = paddingbot
        If paddingLeft <> 0 Then cell.PaddingLeft = paddingLeft
        If paddingRight <> 0 Then cell.PaddingRight = paddingRight

        cell.BackgroundColor = fondo
        If alinea <> 99 Then cell.HorizontalAlignment = alinea
        ptable.AddCell(cell)
    End Sub


    Private Sub AgregarCeldaTableItem(texto As String, font As Font, fondo As BaseColor, _
                             borders() As String, alinea As Integer, ptable As PdfPTable, _
                             rowspan As Integer, colspan As Integer, paddingtop As Single, paddingbot As Single, paddingLeft As Single, paddingRight As Single, borderwidth As Single)

        Dim cell As PdfPCell = New PdfPCell(New Phrase(texto, font))
        Select Case borders.Length
            Case 1
                If borders(0) = "00" Then Exit Select
                cell.Border = borders(0)
            Case 2
                cell.Border = (borders(0) Or borders(1))
            Case 3
                cell.Border = (borders(0) Or borders(1) Or borders(2))
            Case 4
                cell.Border = (borders(0) Or borders(1) Or borders(2) Or borders(3))
            Case Else
                cell.Border = 0
        End Select
        If borderwidth <> 0 Then cell.BorderWidth = borderwidth
        If rowspan <> 0 Then cell.Rowspan = rowspan
        If colspan <> 0 Then cell.Colspan = colspan
        If paddingtop <> 0 Then cell.PaddingTop = paddingtop
        If paddingbot <> 0 Then cell.PaddingBottom = paddingbot
        If paddingLeft <> 0 Then cell.PaddingLeft = paddingLeft
        If paddingRight <> 0 Then cell.PaddingRight = paddingRight

        cell.BackgroundColor = fondo
        If alinea <> 99 Then cell.HorizontalAlignment = alinea
        ptable.AddCell(cell)
    End Sub

    Public Function Conversion2celdas(texto As String) As String
        If texto.Length > 57 Then
            Dim texto1 = Mid(texto, 1, 57)
            Dim posret As Integer = InStrRev(texto1, " ")
            Return Mid(texto1, 1, posret) & vbLf & Mid(texto, posret + 1, texto.Length)
        Else
            Return texto & vbLf & " "
        End If
    End Function

End Class