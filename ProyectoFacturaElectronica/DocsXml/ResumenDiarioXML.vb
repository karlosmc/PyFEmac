Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports System.IO
Imports System.Configuration

Public Class ResumenDiarioXML

    'Dim Resumen As ResumenDiario
    Dim documento1 As SummaryDocuments
    Dim DocSunat As New DocumentoSunat
    Public Function GenerarResumen(Resumen As ResumenDiario) As SummaryDocuments
        documento1 = New SummaryDocuments

        documento1.ID = Resumen.IdDocumento

        documento1.IssueDate = CDate(Resumen.FechaEmision).ToString("yyyy-MM-dd")
        documento1.ReferenceDate = CDate(Resumen.FechaReferencia).ToString("yyyy-MM-dd")

        documento1.Signature = New SignatureCac
        documento1.Signature.ID = Resumen.IdDocumento

        documento1.Signature.SignatoryParty = New SignatoryParty
        documento1.Signature.SignatoryParty.PartyIdentification = New PartyIdentification
        documento1.Signature.SignatoryParty.PartyIdentification.ID = New PartyIdentificationID
        documento1.Signature.SignatoryParty.PartyIdentification.ID.Value = Resumen.Emisor.NroDocumento

        documento1.Signature.SignatoryParty.PartyName = New PartyName
        documento1.Signature.SignatoryParty.PartyName.Name = Resumen.Emisor.NombreLegal

        documento1.Signature.DigitalSignatureAttachment = New DigitalSignatureAttachment
        documento1.Signature.DigitalSignatureAttachment.ExternalReference = New ExternalReference
        documento1.Signature.DigitalSignatureAttachment.ExternalReference.URI = "#signatureKG"


        documento1.AccountingSupplierParty = New AccountingSupplierParty
        documento1.AccountingSupplierParty.CustomerAssignedAccountID = Resumen.Emisor.NroDocumento
        documento1.AccountingSupplierParty.AdditionalAccountID = Resumen.Emisor.TipoDocumento  '*********************Tipo de documento de identidad, hacerlo dinámico

        documento1.AccountingSupplierParty.Party = New Party
        documento1.AccountingSupplierParty.Party.PartyLegalEntity = New PartyLegalEntity
        documento1.AccountingSupplierParty.Party.PartyLegalEntity.RegistrationName = Resumen.Emisor.NombreLegal

        Dim linea As VoidedDocumentsLine
        For Each grupo As GrupoResumenNuevo In Resumen.Resumenes
            linea = New VoidedDocumentsLine
            With linea
                .LineId = grupo.ID
                .DocumentTypeCode = grupo.TipoDocumento
                .Id = grupo.IdDocumento ' SERIE Y NUMERO DE COMPROBANTE
                Dim AccountingCustomerParty = New AccountingSupplierParty
                .AccountingCustomerParty.AdditionalAccountID = grupo.TipoDocumentoReceptor
                .AccountingCustomerParty.CustomerAssignedAccountID = grupo.NroDocumentoReceptor

                '*******************NOTAS DE CREDITO
                Dim BillingReference = New BillingReference
                .BillingReference.InvoiceDocumentReference.ID = grupo.DocumentoRelacionado
                .BillingReference.InvoiceDocumentReference.DocumentTypeCode = grupo.TipoDocumentoRelacionado

                .ConditionCode = grupo.CodigoEstadoItem

                '********************total valor DE VENTA O CESION EN USO
                Dim TotalAmount = New PayableAmount
                .TotalAmount.currencyID = grupo.Moneda ' moneda
                .TotalAmount.value = grupo.TotalVenta ' total valor DE VENTA O CESION EN USO

                .BillingPayments = New List(Of BillingPayment)

                Dim BillingPayment = New BillingPayment


                'GRUPO IMPUESTOS
                '****GRAVADA
                BillingPayment = New BillingPayment
                BillingPayment.PaidAmount = New PayableAmount
                BillingPayment.PaidAmount.currencyID = grupo.Moneda ' MONEDA
                BillingPayment.PaidAmount.value = grupo.Gravadas 'operaciones gravadas
                BillingPayment.InstructionID = "01"
                .BillingPayments.Add(BillingPayment)
                'BillingPayments.Add(BillingPayment)

                '****EXONERADA
                If grupo.Exoneradas > 0 Then
                    BillingPayment = New BillingPayment
                    BillingPayment.PaidAmount = New PayableAmount
                    BillingPayment.PaidAmount.currencyID = grupo.Moneda ' MONEDA
                    BillingPayment.PaidAmount.value = grupo.Exoneradas 'operaciones EXONERADAS
                    BillingPayment.InstructionID = "02"
                    .BillingPayments.Add(BillingPayment)
                End If

                '****INAFECTAS
                If grupo.Inafectas > 0 Then
                    BillingPayment = New BillingPayment
                    BillingPayment.PaidAmount = New PayableAmount
                    BillingPayment.PaidAmount.currencyID = grupo.Moneda ' MONEDA
                    BillingPayment.PaidAmount.value = grupo.Inafectas 'operaciones Inafectas
                    BillingPayment.InstructionID = "03"
                    .BillingPayments.Add(BillingPayment)
                End If


                '****EXPORTACION

                If grupo.Exportacion > 0 Then
                    BillingPayment = New BillingPayment
                    BillingPayment.PaidAmount = New PayableAmount
                    BillingPayment.PaidAmount.currencyID = grupo.Moneda ' MONEDA
                    BillingPayment.PaidAmount.value = grupo.Exportacion ' EXPORTACION
                    BillingPayment.InstructionID = "04"
                    .BillingPayments.Add(BillingPayment)
                End If

                '****GRATUITAS
                If grupo.Gratuitas > 0 Then
                    BillingPayment = New BillingPayment
                    BillingPayment.PaidAmount = New PayableAmount
                    BillingPayment.PaidAmount.currencyID = grupo.Gratuitas ' MONEDA
                    BillingPayment.PaidAmount.value = grupo.Gratuitas ' GRATUITAS
                    BillingPayment.InstructionID = "05"
                    .BillingPayments.Add(BillingPayment)
                End If

                'total descuentos
                Dim AllowanceCharge = New AllowanceCharge
                .AllowanceCharge.ChargeIndicator = True
                .AllowanceCharge.Amount = New PayableAmount
                .AllowanceCharge.Amount.currencyID = grupo.Moneda ' MONEDA
                .AllowanceCharge.Amount.value = 0.01 'grupo.TotalDescuentos 'total descuentos


                'impuestos
                Dim TaxTotal As TaxTotal = New TaxTotal
                .TaxTotals = New List(Of TaxTotal)


                '  End If

                '**************************ISC


                ' If grupo.TotalIsc > 0 Then

                TaxTotal = New TaxTotal
                TaxTotal.TaxAmount = New PayableAmount
                TaxTotal.TaxAmount.currencyID = grupo.Moneda
                TaxTotal.TaxAmount.value = grupo.TotalIsc  ' TOTAL ISC
                'TaxTotal.TaxSubtotal
                TaxTotal.TaxSubtotal = New TaxSubtotal
                TaxTotal.TaxSubtotal.TaxAmount = New PayableAmount
                TaxTotal.TaxSubtotal.TaxAmount.currencyID = grupo.Moneda
                TaxTotal.TaxSubtotal.TaxAmount.value = grupo.TotalIsc 'total isc

                TaxTotal.TaxSubtotal.TaxCategory = New TaxCategory
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme = New TaxScheme
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID = "2000"
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name = "ISC"
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode = "EXC"
                .TaxTotals.Add(TaxTotal)

                ' End If

                '**************************IGV
                ' If grupo.TotalIgv > 0 Then
                TaxTotal = New TaxTotal
                TaxTotal.TaxAmount = New PayableAmount
                TaxTotal.TaxAmount.currencyID = grupo.Moneda
                TaxTotal.TaxAmount.value = grupo.TotalIgv  ' TOTAL IGV
                'TaxTotal.TaxSubtotal
                TaxTotal.TaxSubtotal = New TaxSubtotal
                TaxTotal.TaxSubtotal.TaxAmount = New PayableAmount
                TaxTotal.TaxSubtotal.TaxAmount.currencyID = grupo.Moneda
                TaxTotal.TaxSubtotal.TaxAmount.value = grupo.TotalIgv
                'TaxTotal.TaxAmount.currencyID = grupo.Moneda
                'TaxTotal.TaxAmount.value = grupo.TotalIgv  ' TOTAL IGV

                TaxTotal.TaxSubtotal.TaxCategory = New TaxCategory
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme = New TaxScheme
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID = 1000
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name = "IGV"
                TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode = "VAT"
                .TaxTotals.Add(TaxTotal)

                If grupo.TotalOtrosImpuestos > 0 Then
                    TaxTotal = New TaxTotal
                    TaxTotal.TaxAmount = New PayableAmount
                    TaxTotal.TaxAmount.currencyID = grupo.Moneda
                    TaxTotal.TaxAmount.value = grupo.TotalOtrosImpuestos  ' TOTAL IGV
                    'TaxTotal.TaxSubtotal
                    TaxTotal.TaxSubtotal = New TaxSubtotal
                    TaxTotal.TaxSubtotal.TaxAmount = New PayableAmount
                    TaxTotal.TaxSubtotal.TaxAmount.currencyID = grupo.Moneda
                    TaxTotal.TaxSubtotal.TaxAmount.value = grupo.TotalOtrosImpuestos ' total otros impuesto

                    TaxTotal.TaxSubtotal.TaxCategory = New TaxCategory
                    TaxTotal.TaxSubtotal.TaxCategory.TaxScheme = New TaxScheme
                    TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID = 9999
                    TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name = "OTROS"
                    TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode = "OTH"
                    .TaxTotals.Add(TaxTotal)
                End If

            End With
            documento1.SumaryDocumentsLines.Add(linea)
        Next

        Return documento1

    End Function

    'Public Function EnviarBaja(archivozip As String)
    '    Try
    '        Dim filezip As String = archivozip & ".zip"
    '        Dim con As New ServiceConsume

    '        Dim respuesta As New ResponseDocument
    '        Return con.EnviarResumenBaja(DocSunat)
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    '    'respuesta.responder(con.E
    'End Function

    'Public Function ConsultarEstado(ticket As String)
    '    Dim con As New ServiceConsume
    '    Dim mensaje As String = con.ObtenerEstado(ticket)
    '    Return mensaje
    'End Function

End Class
