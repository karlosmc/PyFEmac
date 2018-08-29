Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports System.IO
Imports System.Configuration
Public Class NotaCreditoXML

    Dim documento As CreditNote
    Public Function GenerarNotaCredito(Fact As DocumentoElectronico) As CreditNote
        documento = New CreditNote
        'Fact.MontoEnLetras = " "  ' convertir en letras
        With documento
            .UBLExtensions = New UBLExtensions
            With .UBLExtensions
                .Extension1 = New UBLExtension
                With .Extension1
                    .ExtensionContent = New ExtensionContent
                    With .ExtensionContent
                        .AdditionalInformation = New AdditionalInformation
                        With .AdditionalInformation
                            .AdditionalMonetaryTotals = New List(Of AdditionalMonetaryTotal)

                            Dim AdditionalMonetaryTotal As New AdditionalMonetaryTotal
                            With AdditionalMonetaryTotal
                                .ID = "1001"
                                .PayableAmount = New PayableAmount
                                With .PayableAmount
                                    .currencyID = Fact.Moneda
                                    .value = Fact.Gravadas '*******************GRAVADAS
                                End With
                            End With
                            .AdditionalMonetaryTotals.Add(AdditionalMonetaryTotal)


                            AdditionalMonetaryTotal = New AdditionalMonetaryTotal
                            With AdditionalMonetaryTotal
                                .ID = "1002"
                                .PayableAmount = New PayableAmount
                                With .PayableAmount
                                    .currencyID = Fact.Moneda
                                    .value = Fact.Inafectas '*******************INAFECTAS
                                End With
                            End With
                            .AdditionalMonetaryTotals.Add(AdditionalMonetaryTotal)

                            AdditionalMonetaryTotal = New AdditionalMonetaryTotal
                            With AdditionalMonetaryTotal
                                .ID = "1003"
                                .PayableAmount = New PayableAmount
                                With .PayableAmount
                                    .currencyID = Fact.Moneda
                                    .value = Fact.Exoneradas '*******************EXONERADAS
                                End With
                            End With
                            .AdditionalMonetaryTotals.Add(AdditionalMonetaryTotal)

                            AdditionalMonetaryTotal = New AdditionalMonetaryTotal
                            With AdditionalMonetaryTotal
                                .ID = "1004"
                                .PayableAmount = New PayableAmount
                                With .PayableAmount
                                    .currencyID = Fact.Moneda
                                    .value = Fact.Gratuitas '*******************GRATUITAS
                                End With
                            End With
                            .AdditionalMonetaryTotals.Add(AdditionalMonetaryTotal)

                            .AdditionalProperties = New List(Of AdditionalProperty)
                            Dim AdditionalProperties As New AdditionalProperty

                            With AdditionalProperties
                                .ID = "1000"
                                .Value = Fact.MontoEnLetras
                            End With
                        End With

                    End With
                End With
            End With
            .ID = Fact.IdDocumento
            .IssueDate = CDate(Fact.FechaEmision).ToString("yyyy-MM-dd")
            .InvoiceTypeCode = Fact.TipoDocumento
            .DocumentCurrencyCode = Fact.Moneda
            .Signature = New SignatureCac
            With .Signature
                .ID = Fact.IdDocumento
                .SignatoryParty = New SignatoryParty
                With .SignatoryParty
                    .PartyIdentification = New PartyIdentification
                    With .PartyIdentification
                        .ID = New PartyIdentificationID
                        With .ID
                            .Value = Fact.Emisor.NroDocumento
                        End With
                    End With
                    .PartyName = New PartyName
                    With .PartyName
                        .Name = Fact.Emisor.NombreLegal
                    End With
                End With
                .DigitalSignatureAttachment = New DigitalSignatureAttachment
                With .DigitalSignatureAttachment
                    .ExternalReference = New ExternalReference
                    With .ExternalReference
                        .URI = "#signatureKG"
                    End With
                End With
            End With
            .AccountingSupplierParty = New AccountingSupplierParty
            With .AccountingSupplierParty
                .CustomerAssignedAccountID = Fact.Emisor.NroDocumento
                .AdditionalAccountID = Fact.Emisor.TipoDocumento
                .Party = New Party
                With .Party
                    .PartyName = New PartyName
                    With .PartyName
                        .Name = Fact.Emisor.NombreComercial
                    End With
                    .PostalAddress = New PostalAddress
                    With .PostalAddress
                        .ID = Fact.Emisor.Ubigeo
                        .StreetName = Fact.Emisor.Direccion
                        .CitySubdivisionName = Fact.Emisor.Urbanizacion
                        .CityName = Fact.Emisor.Provincia
                        .District = Fact.Emisor.Distrito
                        .Country = New Country
                        With .Country
                            .IdentificationCode = "PE"
                        End With
                    End With
                    .PartyLegalEntity = New PartyLegalEntity
                    With .PartyLegalEntity
                        .RegistrationName = Fact.Emisor.NombreLegal
                    End With
                End With
            End With
            .AccountingCustomerParty = New AccountingSupplierParty
            With .AccountingCustomerParty
                .CustomerAssignedAccountID = Fact.Receptor.NroDocumento
                .AdditionalAccountID = Fact.Receptor.TipoDocumento
                .Party = New Party
                With .Party
                    .PartyName = New PartyName
                    With .PartyName
                        .Name = Fact.Receptor.NombreComercial ' IIf(String.IsNullOrEmpty(Fact.Receptor.NombreComercial), String.Empty, Fact.Receptor.NombreComercial)
                    End With
                    .PostalAddress = New PostalAddress
                    With .PostalAddress
                        .ID = Fact.Receptor.Ubigeo
                        .StreetName = Fact.Receptor.Direccion
                        .CitySubdivisionName = Fact.Receptor.Urbanizacion
                        .CityName = Fact.Receptor.Provincia
                        .District = Fact.Receptor.Distrito
                        .Country = New Country
                        With .Country
                            .IdentificationCode = "PE"
                        End With
                    End With

                    .PartyLegalEntity = New PartyLegalEntity
                    With .PartyLegalEntity
                        .RegistrationName = Fact.Receptor.NombreLegal
                    End With
                End With
            End With
            .UblVersionId = "2.0"
            .CustomizationId = "1.0"
            .LegalMonetaryTotal = New LegalMonetaryTotal
            With .LegalMonetaryTotal
                .PayableAmount = New PayableAmount
                With .PayableAmount
                    .currencyID = Fact.Moneda
                    .value = Fact.TotalVenta
                End With
                .AllowanceTotalAmount = New PayableAmount
                With .AllowanceTotalAmount
                    .currencyID = Fact.Moneda
                    .value = Fact.DescuentoGlobal
                End With
            End With
            .TaxTotals = New List(Of TaxTotal)

            With .TaxTotals
                Dim TaxTotal As New TaxTotal
                With TaxTotal
                    .TaxAmount = New PayableAmount
                    With .TaxAmount
                        .currencyID = Fact.Moneda
                        .value = Fact.TotalIgv
                    End With
                    .TaxSubtotal = New TaxSubtotal
                    With .TaxSubtotal
                        .TaxAmount = New PayableAmount
                        With .TaxAmount
                            .currencyID = Fact.Moneda
                            .value = Fact.TotalIgv
                        End With
                        .TaxCategory = New TaxCategory
                        With .TaxCategory
                            .TaxScheme = New TaxScheme
                            With .TaxScheme
                                .ID = "1000"
                                .Name = "IGV"
                                .TaxTypeCode = "VAT"
                            End With
                        End With
                    End With
                End With
                .Add(TaxTotal)
            End With
        End With

        For Each Discrep As Discrepancia In Fact.Discrepancias
            Dim discrepancia As New DiscrepancyResponse
            With discrepancia
                .ReferenceID = Discrep.NroReferencia
                .ResponseCode = Discrep.Tipo
                .Description = Discrep.Descripcion
            End With
            documento.DiscrepancyResponses.Add(discrepancia)
        Next

        For Each relacionado As DocumentoRelacionado In Fact.Relacionados
            Dim BillingReference As New BillingReference
            BillingReference.InvoiceDocumentReference = New InvoiceDocumentReference
            With BillingReference.InvoiceDocumentReference
                .ID = relacionado.NroDocumento
                .DocumentTypeCode = relacionado.TipoDocumento
            End With
            documento.BillingReferences.Add(BillingReference)
        Next

        For Each relacionado As DocumentoRelacionado In Fact.OtrosDocumentosRelacionados
            Dim AdditionalDocumentReference As New InvoiceDocumentReference
            With AdditionalDocumentReference
                .DocumentTypeCode = relacionado.TipoDocumento
                .ID = relacionado.NroDocumento
            End With
            documento.AdditionalDocumentReferences.Add(AdditionalDocumentReference)
        Next

        Dim linea As InvoiceLine
        For Each DetalleDocumento As DetalleDocumento In Fact.Items
            linea = New InvoiceLine
            With linea
                .ID = DetalleDocumento.ID
                .CreditedQuantity = New InvoicedQuantity
                With .CreditedQuantity
                    .unitCode = DetalleDocumento.UnidadMedida
                    .Value = DetalleDocumento.Cantidad
                End With
                .LineExtensionAmount = New PayableAmount
                With .LineExtensionAmount
                    .currencyID = Fact.Moneda
                    .value = DetalleDocumento.TotalVenta
                End With
                .PricingReference = New PricingReference
                With .PricingReference
                    .AlternativeConditionPrices = New List(Of AlternativeConditionPrice)
                End With
                .Item = New Item
                With .Item
                    .Description = DetalleDocumento.Descripcion
                    .SellersItemIdentification = New SellersItemIdentification
                    With .SellersItemIdentification
                        .ID = DetalleDocumento.CodigoItem
                    End With

                End With
                .Price = New Price
                With .Price
                    .PriceAmount = New PayableAmount
                    With .PriceAmount
                        .currencyID = Fact.Moneda
                        .value = DetalleDocumento.PrecioUnitario
                    End With
                End With

            End With

            Dim TaxTotal As New TaxTotal

            ' 16 - Afectacion al IGV por ITEM
            With TaxTotal
                .TaxAmount = New PayableAmount
                With .TaxAmount
                    .currencyID = Fact.Moneda
                    .value = DetalleDocumento.Impuesto
                End With
                .TaxSubtotal = New TaxSubtotal
                With .TaxSubtotal
                    .TaxAmount = New PayableAmount
                    With .TaxAmount
                        .currencyID = Fact.Moneda
                        .value = DetalleDocumento.Impuesto
                    End With
                    .TaxCategory = New TaxCategory
                    With .TaxCategory
                        .TaxExemptionReasonCode = DetalleDocumento.TipoImpuesto
                        .TaxScheme = New TaxScheme
                        With .TaxScheme
                            .ID = "1000"
                            .Name = "IGV"
                            .TaxTypeCode = "VAT"
                        End With
                    End With
                End With
            End With
            linea.TaxTotals.Add(TaxTotal)

            documento.CreditNoteLines.Add(linea)
        Next

        Return documento
    End Function
End Class
