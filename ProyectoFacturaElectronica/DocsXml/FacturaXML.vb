Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports System.IO
Imports System.Configuration
Public Class FacturaXML

    Dim documento As New Invoice
    Public Function GenerarFactura(Fact As DocumentoElectronico) As Invoice
        documento = New Invoice
        'Fact.MontoEnLetras = " "  ' convertir en letras
        With documento
            .UBLExtensions = New UBLExtensions
            With .UBLExtensions

                .Extension1 = New UBLExtension
                With .Extension1
                    .ID = "SUNAT"
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
                                .ID = "2000"
                                .Value = Fact.MontoEnLetras
                            End With
                            .AdditionalProperties.Add(AdditionalProperties)

                        End With

                    End With
                End With

                '.Extension3 = New UBLExtension
                'With .Extension3
                '    .ID = "DATAADD"
                '    .ExtensionContent = New ExtensionContent
                '    With .ExtensionContent
                '        .AdditionalInformation = New AdditionalInformation
                '        With .AdditionalInformation
                '            .AdditionalMonetaryTotals = New List(Of AdditionalMonetaryTotal)
                '            .AdditionalProperties = New List(Of AdditionalProperty)
                '        End With

                '    End With
                'End With
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
                        .Name = IIf(String.IsNullOrEmpty(Fact.Receptor.NombreComercial), String.Empty, Fact.Receptor.NombreComercial)
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
        If Fact.TotalIsc > 0 Then
            Dim TaxTotal As New TaxTotal
            With TaxTotal
                .TaxAmount = New PayableAmount
                With .TaxAmount
                    .currencyID = Fact.Moneda
                    .value = Fact.TotalIsc
                End With
                .TaxSubtotal = New TaxSubtotal
                With .TaxSubtotal
                    .TaxAmount = New PayableAmount
                    With .TaxAmount
                        .currencyID = Fact.Moneda
                        .value = Fact.TotalIsc

                    End With
                    .TaxCategory = New TaxCategory
                    With .TaxCategory
                        .TaxScheme = New TaxScheme
                        With .TaxScheme
                            .ID = "2000"
                            .Name = "ISC"
                            .TaxTypeCode = "EXC"
                        End With
                    End With
                End With
            End With
            documento.TaxTotals.Add(TaxTotal)
        End If

        If Fact.TotalOtrosTributos > 0 Then
            Dim TaxTotal As New TaxTotal
            With TaxTotal
                .TaxAmount = New PayableAmount
                With .TaxAmount
                    .currencyID = Fact.Moneda
                    .value = Fact.TotalOtrosTributos
                End With
                .TaxSubtotal = New TaxSubtotal
                With .TaxSubtotal
                    .TaxAmount = New PayableAmount
                    With .TaxAmount
                        .currencyID = Fact.Moneda
                        .value = Fact.TotalOtrosTributos

                    End With
                    .TaxCategory = New TaxCategory
                    With .TaxCategory
                        .TaxScheme = New TaxScheme
                        With .TaxScheme
                            .ID = "9999"
                            .Name = "OTROS"
                            .TaxTypeCode = "OTH"
                        End With
                    End With
                End With
            End With
            documento.TaxTotals.Add(TaxTotal)
        End If
        ' NUMERO DE PLACA DEL VEHICULO - GASTOS ART 37° RENTA
      

        documento.UBLExtensions.Extension3 = New UBLExtension


        With documento.UBLExtensions.Extension3
            .ID = ""
            .ExtensionContent = New ExtensionContent
            With .ExtensionContent

                ' Tipo de Operación - Catalogo N° 17 
                If (Not String.IsNullOrEmpty(Fact.TipoOperacion) AndAlso String.IsNullOrEmpty(Fact.DatosGuiaTransportista.RucTransportista)) Then
                    documento.UBLExtensions.Extension3.ExtensionContent.AdditionalInformation.SunatTransaction.Id = Fact.TipoOperacion
                    'si  es emisor Itinerante
                    If (Fact.TipoOperacion = "05") Then

                        Dim AdditionalProperty As New AdditionalProperty
                        With AdditionalProperty
                            .ID = "3000"  ' catalogo 2005 pero es 3000
                            .Value = "Venta realizada por emisor Itinerante"
                        End With

                        documento.UBLExtensions.Extension3.ExtensionContent. _
                        AdditionalInformation.AdditionalProperties.Add(AdditionalProperty)
                    End If

                End If
            End With

            For Each adicional As DatoAdicional In Fact.DatoAdicionales
                documento.UBLExtensions.Extension3.ExtensionContent _
                    .AdditionalInformation.AdditionalProperties.Add(New AdditionalProperty() _
                    With _
                    {
                        .ID = adicional.Codigo,
                        .Value = adicional.Contenido
                    })
            Next

        End With

        If Not String.IsNullOrEmpty(Fact.PlacaVehiculo) Then
            With documento.UBLExtensions.Extension3.ExtensionContent
                .AdditionalInformation.SunatCosts.RoadTransport.LicensePlateId = Fact.PlacaVehiculo
            End With
        End If

        documento.DespatchDocumentReferences = New List(Of InvoiceDocumentReference)
        For Each relacionado As DocumentoRelacionado In Fact.Relacionados
            Dim DespatchDocumentReference As New InvoiceDocumentReference
            With DespatchDocumentReference
                .DocumentTypeCode = relacionado.TipoDocumento
                .ID = relacionado.NroDocumento
            End With
            documento.DespatchDocumentReferences.Add(DespatchDocumentReference)
        Next

        documento.AdditionalDocumentReferences = New List(Of InvoiceDocumentReference)
        For Each relacionado As DocumentoRelacionado In Fact.OtrosDocumentosRelacionados
            Dim AdditionalDocumentReference As New InvoiceDocumentReference
            With AdditionalDocumentReference
                .DocumentTypeCode = relacionado.TipoDocumento
                .ID = relacionado.NroDocumento
            End With
            documento.AdditionalDocumentReferences.Add(AdditionalDocumentReference)
        Next
        If Fact.Gratuitas > 0 Then

            Dim AdditionalProperty As New AdditionalProperty
            With AdditionalProperty
                .ID = "1002"
                .Value = "Articulos gratuitos"
            End With
            documento.UBLExtensions.Extension2.ExtensionContent.AdditionalInformation _
            .AdditionalProperties.Add(AdditionalProperty)
        End If
        Dim dctosporItem = Fact.Items.Sum(Function(d) d.Descuento)
        If (Fact.DescuentoGlobal > 0 OrElse dctosporItem > 0) Then
            documento.UBLExtensions.Extension2.ExtensionContent.AdditionalInformation. _
              AdditionalMonetaryTotals.Add(New AdditionalMonetaryTotal() With {.ID = 2005, .PayableAmount _
              = New PayableAmount() With {.currencyID = Fact.Moneda, .value = Fact.DescuentoGlobal + dctosporItem}})
        End If

        If (Fact.MontoPercepcion > 0) Then

            documento.UBLExtensions.Extension2.ExtensionContent.AdditionalInformation. _
            AdditionalMonetaryTotals.Add(New AdditionalMonetaryTotal() _
            With _
                {
                    .ID = 2001,
                    .ReferenceAmount = New PayableAmount() _
                        With _
                        {
                            .currencyID = Fact.Moneda,
                            .value = Fact.TotalVenta
                        }, .PayableAmount = New PayableAmount() _
                        With _
                        {
                            .currencyID = Fact.Moneda,
                            .value = Fact.MontoPercepcion
                        }, .TotalAmount = New PayableAmount _
                       With _
                       {
                           .currencyID = Fact.Moneda,
                           .value = Fact.TotalVenta + Fact.MontoPercepcion
                       }})

        End If


        If (Fact.MontoAnticipo > 0) Then
            documento.PrepaidPayment = New BillingPayment
            With documento.PrepaidPayment
                .Id = New PartyIdentificationID
                With .Id
                    .SchemeId = Fact.TipoDocAnticipo
                    .Value = Fact.DocAnticipo
                End With
                .PaidAmount = New PayableAmount
                With .PaidAmount
                    .currencyID = Fact.MonedaAnticipo
                    .value = Fact.MontoAnticipo
                End With
                .InstructionID = Fact.Emisor.NroDocumento
            End With
            documento.LegalMonetaryTotal.PrepaidAmount = New PayableAmount
            With documento.LegalMonetaryTotal.PrepaidAmount
                .currencyID = Fact.MonedaAnticipo
                .value = Fact.MontoAnticipo
            End With

        End If

       

        If Fact.MontoDetraccion > 0 Then
            documento.UBLExtensions.Extension2.ExtensionContent _
            .AdditionalInformation.AdditionalMonetaryTotals.Add(New AdditionalMonetaryTotal() _
            With _
            {
                .ID = "2003",
                .PayableAmount = New PayableAmount() _
                With _
                {
                    .currencyID = Fact.Moneda,
                    .value = Fact.MontoDetraccion
                },
                .Percent = Fact.CalculoDetraccion * 100
            })
        End If

        If Not String.IsNullOrEmpty(Fact.DatosGuiaTransportista.RucTransportista) Then
            documento.UBLExtensions.Extension2.ExtensionContent.AdditionalInformation. _
            SunatEmbededDespatchAdvice = New SunatEmbededDespatchAdvice
            With documento.UBLExtensions.Extension2.ExtensionContent.AdditionalInformation.SunatEmbededDespatchAdvice
                .DeliveryAddress = New PostalAddress
                With .DeliveryAddress
                    .ID = Fact.DatosGuiaTransportista.DireccionDestino.Ubigeo
                    .StreetName = Fact.DatosGuiaTransportista.DireccionDestino.Direccion
                    .CitySubdivisionName = Fact.DatosGuiaTransportista.DireccionDestino.Urbanizacion
                    .CityName = Fact.DatosGuiaTransportista.DireccionDestino.Departamento
                    .CountrySubentity = Fact.DatosGuiaTransportista.DireccionDestino.Provincia
                    .District = Fact.DatosGuiaTransportista.DireccionDestino.Distrito
                    .Country = New Country
                    With .Country
                        .IdentificationCode = "PE"
                    End With

                End With
                .OriginAddress = New PostalAddress
                With .OriginAddress
                    .ID = Fact.DatosGuiaTransportista.DireccionOrigen.Ubigeo
                    .StreetName = Fact.DatosGuiaTransportista.DireccionOrigen.Direccion
                    .CitySubdivisionName = Fact.DatosGuiaTransportista.DireccionOrigen.Urbanizacion
                    .CityName = Fact.DatosGuiaTransportista.DireccionOrigen.Departamento
                    .CountrySubentity = Fact.DatosGuiaTransportista.DireccionOrigen.Provincia
                    .District = Fact.DatosGuiaTransportista.DireccionOrigen.Distrito
                    .Country = New Country
                    With .Country
                        .IdentificationCode = "PE"
                    End With

                End With
                .SunatCarrierParty = New AccountingSupplierParty
                With .SunatCarrierParty
                    .CustomerAssignedAccountID = Fact.DatosGuiaTransportista.RucTransportista
                    .AdditionalAccountID = "06"
                    .Party = New Party
                    With .Party
                        .PartyLegalEntity = New PartyLegalEntity
                        With .PartyLegalEntity
                            .RegistrationName = Fact.DatosGuiaTransportista.NombreTransportista
                        End With
                    End With
                End With
                .DriverParty = New AgentParty
                With .DriverParty
                    .PartyIdentification = New PartyIdentification
                    With .PartyIdentification
                        .ID = New PartyIdentificationID
                        With .ID
                            .Value = Fact.DatosGuiaTransportista.NroLicenciaConducir
                        End With
                    End With
                End With
                .SunatRoadTransport = New SunatRoadTransport
                With .SunatRoadTransport
                    .LicensePlateId = Fact.DatosGuiaTransportista.PlacaVehiculo
                    .TransportAuthorizationCode = Fact.DatosGuiaTransportista.CodigoAutorizacion
                    .BrandName = Fact.DatosGuiaTransportista.MarcaVehiculo
                End With
                .TransportModeCode = Fact.DatosGuiaTransportista.ModoTransporte
                .GrossWeightMeasure = New InvoicedQuantity
                With .GrossWeightMeasure
                    .unitCode = Fact.DatosGuiaTransportista.UnidadMedida
                    .Value = Fact.DatosGuiaTransportista.PesoBruto
                End With
            End With
        End If

        Dim linea As New InvoiceLine
        For Each DetalleDocumento As DetalleDocumento In Fact.Items
            linea = New InvoiceLine
            With linea
                .ID = DetalleDocumento.ID
                .InvoicedQuantity = New InvoicedQuantity
                With .InvoicedQuantity
                    .unitCode = DetalleDocumento.UnidadMedida
                    .Value = DetalleDocumento.Cantidad
                End With
                .LineExtensionAmount = New PayableAmount
                With .LineExtensionAmount
                    .currencyID = Fact.Moneda
                    .value = DetalleDocumento.ValorTotal
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
                        .value = DetalleDocumento.ValorUnitario
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


            ' 17 - Afectacion al ISC por ITEM
            If DetalleDocumento.ImpuestoSelectivo > 0 Then
                TaxTotal = New TaxTotal
                With TaxTotal
                    .TaxAmount = New PayableAmount
                    With .TaxAmount
                        .currencyID = Fact.Moneda
                        .value = DetalleDocumento.ImpuestoSelectivo
                    End With
                    .TaxSubtotal = New TaxSubtotal
                    With .TaxSubtotal
                        .TaxAmount = New PayableAmount
                        With .TaxAmount
                            .currencyID = Fact.Moneda
                            .value = DetalleDocumento.ImpuestoSelectivo
                        End With
                        .TaxCategory = New TaxCategory
                        With .TaxCategory
                            .TaxExemptionReasonCode = DetalleDocumento.TipoImpuesto
                            .TierRange = "01"
                            .TaxScheme = New TaxScheme
                            With .TaxScheme
                                .ID = "2000"
                                .Name = "ISC"
                                .TaxTypeCode = "EXC"
                            End With
                        End With
                    End With
                End With
                linea.TaxTotals.Add(TaxTotal)
            End If
            Dim AlternativeConditionPrice As New AlternativeConditionPrice
            With AlternativeConditionPrice
                .PriceAmount = New PayableAmount
                With .PriceAmount
                    .currencyID = Fact.Moneda
                    'Comprobacion que sea una operacion gratuita
                    .value = IIf(Fact.Gratuitas > 0, DetalleDocumento.PrecioReferencial, DetalleDocumento.PrecioUnitario)
                End With
                .PriceTypeCode = DetalleDocumento.TipoPrecio
            End With
            linea.PricingReference.AlternativeConditionPrices.Add(AlternativeConditionPrice)
            'Operaciones no onerosas gratuitas
            If Fact.Gratuitas > 0 Then
                AlternativeConditionPrice = New AlternativeConditionPrice
                With AlternativeConditionPrice
                    .PriceAmount = New PayableAmount
                    With .PriceAmount
                        .currencyID = Fact.Moneda
                        .value = DetalleDocumento.PrecioReferencial
                    End With
                    .PriceTypeCode = "02"
                End With
                linea.PricingReference.AlternativeConditionPrices.Add(AlternativeConditionPrice)
            End If
            'If DetalleDocumento.Descuento > 0 Then
            linea.AllowanceCharge.ChargeIndicator = False
            linea.AllowanceCharge.Amount = New PayableAmount
            With linea.AllowanceCharge.Amount
                .currencyID = Fact.Moneda
                .value = DetalleDocumento.Descuento
            End With
            'End If

            documento.InvoiceLines.Add(linea)
        Next

        Return documento
    End Function
End Class
