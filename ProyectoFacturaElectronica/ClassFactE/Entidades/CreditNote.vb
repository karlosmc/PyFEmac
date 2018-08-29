Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization


<Serializable()> _
Public Class CreditNote
    Implements IXmlSerializable


    Public vIssueDate As DateTime
    Public Property IssueDate As DateTime
        Get
            Return vIssueDate
        End Get
        Set(value As DateTime)
            vIssueDate = value
        End Set
    End Property

    Public vUBLExtensions As UBLExtensions

    Public Property UBLExtensions As UBLExtensions
        Get
            Return vUBLExtensions
        End Get
        Set(value As UBLExtensions)
            vUBLExtensions = value
        End Set
    End Property


    Public vSignature As SignatureCac
    Public Property Signature As SignatureCac
        Get
            Return vSignature
        End Get
        Set(value As SignatureCac)
            vSignature = value
        End Set
    End Property

    Public vAccountingSupplierParty As AccountingSupplierParty
    Public Property AccountingSupplierParty As AccountingSupplierParty
        Get
            Return vAccountingSupplierParty
        End Get
        Set(value As AccountingSupplierParty)
            vAccountingSupplierParty = value
        End Set
    End Property

    Public vInvoiceTypeCode As String
    Public Property InvoiceTypeCode As String
        Get
            Return vInvoiceTypeCode
        End Get
        Set(value As String)
            vInvoiceTypeCode = value
        End Set
    End Property
    Public vID As String

    Public Property ID As String
        Get
            Return vID
        End Get
        Set(value As String)
            vID = value
        End Set
    End Property

    Public vDespatchDocumentReferences As List(Of InvoiceDocumentReference)

    Public Property DespatchDocumentReferences As List(Of InvoiceDocumentReference)
        Get
            Return vDespatchDocumentReferences
        End Get
        Set(value As List(Of InvoiceDocumentReference))
            vDespatchDocumentReferences = value
        End Set
    End Property

    Public vAdditionalDocumentReferences As List(Of InvoiceDocumentReference)

    Public Property AdditionalDocumentReferences As List(Of InvoiceDocumentReference)
        Get
            Return vAdditionalDocumentReferences
        End Get
        Set(value As List(Of InvoiceDocumentReference))
            vAdditionalDocumentReferences = value
        End Set
    End Property

    Public vAccountingCustomerParty As AccountingSupplierParty
    Public Property AccountingCustomerParty As AccountingSupplierParty
        Get
            Return vAccountingCustomerParty

        End Get
        Set(value As AccountingSupplierParty)
            vAccountingCustomerParty = value
        End Set
    End Property
    Private vDiscrepancyResponses As List(Of DiscrepancyResponse)
    Public Property DiscrepancyResponses As List(Of DiscrepancyResponse)
        Get
            Return vDiscrepancyResponses
        End Get
        Set(value As List(Of DiscrepancyResponse))
            vDiscrepancyResponses = value
        End Set
    End Property


    Public vCreditNoteLines As List(Of InvoiceLine)
    Public Property CreditNoteLines As List(Of InvoiceLine)
        Get
            Return vCreditNoteLines
        End Get
        Set(value As List(Of InvoiceLine))
            vCreditNoteLines = value
        End Set
    End Property

    'Public vInvoiceLine As InvoiceLine
    'Public Property InvoiceLine As InvoiceLine
    '    Get
    '        Return vInvoiceLine
    '    End Get
    '    Set(value As InvoiceLine)
    '        vInvoiceLine = value
    '    End Set
    'End Property

    Public vDocumentCurrencyCode As String
    Public Property DocumentCurrencyCode As String
        Get
            Return vDocumentCurrencyCode
        End Get
        Set(value As String)
            vDocumentCurrencyCode = value
        End Set
    End Property

    Public vTaxTotals As List(Of TaxTotal)
    Public Property TaxTotals As List(Of TaxTotal)
        Get
            Return vTaxTotals
        End Get
        Set(value As List(Of TaxTotal))
            vTaxTotals = value
        End Set
    End Property

    Public vLegalMonetaryTotal As LegalMonetaryTotal
    Public Property LegalMonetaryTotal As LegalMonetaryTotal
        Get
            Return vLegalMonetaryTotal
        End Get
        Set(value As LegalMonetaryTotal)
            vLegalMonetaryTotal = value
        End Set
    End Property
    Private vPrepaidPayment As BillingPayment
    Public Property PrepaidPayment As BillingPayment
        Get
            Return vPrepaidPayment
        End Get
        Set(value As BillingPayment)
            vPrepaidPayment = PrepaidPayment
        End Set
    End Property

    Private vBillingReferences As List(Of BillingReference)
    Public Property BillingReferences As List(Of BillingReference)
        Get
            Return vBillingReferences
        End Get
        Set(value As List(Of BillingReference))
            vBillingReferences = value
        End Set
    End Property


    Public vUblVersionId As String
    Public Property UblVersionId As String
        Get
            Return vUblVersionId
        End Get
        Set(value As String)
            vUblVersionId = value
        End Set
    End Property

    Public vCustomizationId As String
    Public Property CustomizationId As String
        Get
            Return vCustomizationId
        End Get
        Set(value As String)
            vCustomizationId = value
        End Set
    End Property
    Public vFormato As IFormatProvider
    Public Property Formato As IFormatProvider
        Get
            Return vFormato
        End Get
        Set(value As IFormatProvider)
            vFormato = value
        End Set
    End Property

    Public Sub New()
        AccountingSupplierParty = New AccountingSupplierParty
        AccountingCustomerParty = New AccountingSupplierParty
        UBLExtensions = New UBLExtensions
        Signature = New SignatureCac
        CreditNoteLines = New List(Of InvoiceLine)
        DiscrepancyResponses = New List(Of DiscrepancyResponse)
        DespatchDocumentReferences = New List(Of InvoiceDocumentReference)
        AdditionalDocumentReferences = New List(Of InvoiceDocumentReference)
        BillingReferences = New List(Of BillingReference)
        TaxTotals = New List(Of TaxTotal)
        LegalMonetaryTotal = New LegalMonetaryTotal
        '        TaxCategory = New TaxCategory

        UblVersionId = "2.0"
        CustomizationId = "1.0"
        Formato = New System.Globalization.CultureInfo("es-PE")


    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml
        Throw New NotImplementedException
    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml

        'Public Const xmlnsRetention As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1" 'va ns13
        'Public Const xmlnsInvoice As String = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
        'Public Const xmlnsCreditNote As String = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2" 'va ns6
        'Public Const xmlnsDebitNote As String = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2" ' va ns7
        'Public Const xmlnsVoidedDocuments As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1" 'va ns11
        'Public Const xmlnsSummaryDocuments As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1" 'va ns10
        'Public Const xmlnsPerception As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1" 'va ns14
        'Public Const xmlnsDepatchAdvice As String = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2" ' va ns12


        writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsCreditNote)
        writer.WriteAttributeString("xmlns:cac", EspacioNombres.cac)
        writer.WriteAttributeString("xmlns:cbc", EspacioNombres.cbc)
        writer.WriteAttributeString("xmlns:sac", EspacioNombres.sac)
        writer.WriteAttributeString("xmlns:ccts", EspacioNombres.ccts)
        'writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsInvoice)
        'writer.WriteAttributeString("xmlns:ns13", EspacioNombres.xmlnsRetention)

        'writer.WriteAttributeString("xmlns:ns7", EspacioNombres.xmlnsDebitNote)
        'writer.WriteAttributeString("xmlns:ns11", EspacioNombres.xmlnsVoidedDocuments)
        'writer.WriteAttributeString("xmlns:ns10", EspacioNombres.xmlnsSummaryDocuments)
        'writer.WriteAttributeString("xmlns:ns14", EspacioNombres.xmlnsPerception)
        'writer.WriteAttributeString("xmlns:ns12", EspacioNombres.xmlnsDepatchAdvice)



        writer.WriteAttributeString("xmlns:ds", EspacioNombres.ds)
        writer.WriteAttributeString("xmlns:ext", EspacioNombres.ext)
        writer.WriteAttributeString("xmlns:qdt", EspacioNombres.qdt)
        writer.WriteAttributeString("xmlns:udt", EspacioNombres.udt)
        writer.WriteAttributeString("xmlns:xsi", EspacioNombres.xsi)


        'UBLEXTENSIONS
        writer.WriteStartElement("ext:UBLExtensions") '1

        'UBLextension
        Dim ext11 = UBLExtensions.Extension1
        Dim ext1 = UBLExtensions.Extension1.ExtensionContent.AdditionalInformation

        writer.WriteStartElement("ext:UBLExtension") '2
        'writer.WriteElementString("cbc:ID", ext11.ID) '3
        'writer.WriteEndElement() '3-

        'ExtensionContent
        writer.WriteStartElement("ext:ExtensionContent") '4

        'AditionalInformation
        If ext1.AdditionalMonetaryTotals.Count > 0 Then
            writer.WriteStartElement("sac:AdditionalInformation") '5

            'AditionalMonetaryTotal

            'writer.WriteStartElement("sac:AdditionalInformation") '6

            For Each AdditionalMonetaryTotal As AdditionalMonetaryTotal In ext1.AdditionalMonetaryTotals
                writer.WriteStartElement("sac:AdditionalMonetaryTotal") '7
                writer.WriteElementString("cbc:ID", AdditionalMonetaryTotal.ID)
                'writer.WriteEndElement() '7

                'PayableAmount
                writer.WriteStartElement("cbc:PayableAmount") '8
                writer.WriteAttributeString("currencyID", AdditionalMonetaryTotal.PayableAmount.currencyID)
                writer.WriteValue(AdditionalMonetaryTotal.PayableAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '8-

                writer.WriteEndElement() '7-
            Next

            'AditionalProperty

            For Each AdditionalProperty As AdditionalProperty In ext1.AdditionalProperties
                writer.WriteStartElement("sac:AdditionalProperty") '9
                writer.WriteElementString("cbc:ID", AdditionalProperty.ID.ToString())
                'writer.WriteEndElement() 

                'Value

                writer.WriteStartElement("cbc:Value") 'verificar
                writer.WriteCData(AdditionalProperty.Value)
                writer.WriteEndElement() 'verificar-
                writer.WriteEndElement() '9-

            Next

            'If Not String.IsNullOrEmpty(ext1.SunatTransaction.Id) Then

            '    writer.WriteStartElement("sac:SUNATTransaction") '10
            '    '
            '    writer.WriteElementString("cbc:ID", ext1.SunatTransaction.Id)
            '    '
            '    writer.WriteEndElement() '10-


            'End If

            writer.WriteEndElement() '-5
            'endregion


            'endregion

        End If
        writer.WriteEndElement() '-4
        'writer.WriteStartElement("sac:AdditionalInformation") '5

      

        writer.WriteEndElement() '-2

        'writer.WriteEndElement() '-2



        'endregion

        '*******************2do extension

        Dim ext21 = UBLExtensions.Extension2
        Dim ext2 = UBLExtensions.Extension2.ExtensionContent.AdditionalInformation

        writer.WriteStartElement("ext:UBLExtension") '2
        'writer.WriteElementString("cbc:ID", ext21.ID)

        'ExtensionContent
        writer.WriteStartElement("ext:ExtensionContent") '3

        'AditionalInformation
        'writer.WriteStartElement("sac:AdditionalInformation") '4

        'AditionalMonetaryTotal

        writer.WriteStartElement("cbc:AdditionalInformation") '5


        'AditionalProperty

        For Each AdditionalProperty As AdditionalProperty In ext2.AdditionalProperties
            writer.WriteStartElement("sac:AdditionalProperty") '6
            writer.WriteElementString("cbc:ID", AdditionalProperty.ID.ToString())

            'Value
            'writer.WriteStartElement("cbc:Name")
            'writer.WriteCData(AccountingSupplierParty.Party.PartyName.Name)
            'writer.WriteEndElement()


            writer.WriteStartElement("cbc:Value") 'verificar
            writer.WriteCData(AdditionalProperty.Value)
            writer.WriteEndElement() 'verificar-
            writer.WriteEndElement() '6-

            'end value

            'writer.WriteEndElement() 

        Next

        writer.WriteEndElement() '-5
        'endregion

        'writer.WriteEndElement() '-4
        'endregion

        writer.WriteEndElement() '-3

        writer.WriteEndElement() '-2  



        '*******************3er extension
        'UBLextension
        'Dim ext4 = UBLExtensions.Extension2
        writer.WriteStartElement("ext:UBLExtension") '2.1

        'ExtensionContent
        writer.WriteStartElement("ext:ExtensionContent") '2.3


        'writer.WriteElementString("Signature", )

        ' zona de certificado digital


        writer.WriteEndElement() '2.3-

        writer.WriteEndElement() '2.1-

        'writer.WriteEndElement()


        '***************fin de extension
        writer.WriteEndElement() '1-


        '**************************************
        writer.WriteElementString("cbc:UBLVersionID", UblVersionId)
        writer.WriteElementString("cbc:CustomizationID", CustomizationId)
        writer.WriteElementString("cbc:ID", ID)
        writer.WriteElementString("cbc:IssueDate", IssueDate.ToString("yyyy-MM-dd"))
        writer.WriteElementString("cbc:DocumentCurrencyCode", DocumentCurrencyCode)


        'Region DiscrepancyResponse

        For Each Discrepancy As DiscrepancyResponse In DiscrepancyResponses
            writer.WriteStartElement("cac:DiscrepancyResponse")
            With Discrepancy
                writer.WriteElementString("cbc:ReferenceID", .ReferenceID)
                writer.WriteElementString("cbc:ResponseCode", .ResponseCode)
                writer.WriteElementString("cbc:Description", .Description)
            End With
            writer.WriteEndElement()
        Next
        'end DiscrepancyResponse

        'Region BillingReference

        For Each Item As BillingReference In BillingReferences
            writer.WriteStartElement("cac:BillingReference")
            With Item
                writer.WriteStartElement("cac:InvoiceDocumentReference")
                With Item.InvoiceDocumentReference
                    writer.WriteElementString("cbc:ID", .ID)
                    writer.WriteElementString("cbc:DocumentTypeCode", .DocumentTypeCode)
                End With
                writer.WriteEndElement()

            End With
            writer.WriteEndElement()
        Next

        'End Region BillingReference

        'Region DespatchDocumentReference
        For Each item As InvoiceDocumentReference In DespatchDocumentReferences
            writer.WriteStartElement("cac:DespatchDocumentReference")
            With item
                writer.WriteElementString("cbc:ID", .ID)
                writer.WriteElementString("cbc:DocumentTypeCode", .DocumentTypeCode)
            End With
            writer.WriteEndElement()
        Next
        'end Region DespatchDocumentReference

        'region AddtionalDocumentReferences

        For Each Item As InvoiceDocumentReference In AdditionalDocumentReferences
            writer.WriteStartElement("cac:AdditionalDocumentReference")
            With Item
                writer.WriteElementString("cbc:ID", .ID)
                writer.WriteElementString("cbc:DocumentTypeCode", .DocumentTypeCode)
            End With
            writer.WriteEndElement()
        Next
        '---------------------------------
        'Signature

        writer.WriteStartElement("cac:Signature") '1
        writer.WriteElementString("cbc:ID", Signature.ID)
        'writer.
        '
        'SignatoryParty

        writer.WriteStartElement("cac:SignatoryParty") '2
        writer.WriteStartElement("cac:PartyIdentification") '3
        writer.WriteElementString("cbc:ID", Signature.SignatoryParty.PartyIdentification.ID.Value)
        writer.WriteEndElement() '3-

        'PartyName Razonsocial
        writer.WriteStartElement("cac:PartyName") '4

        'writer.WriteElementString("cbc:Name", Signature.SignatoryParty.PartyName.Name)

        writer.WriteStartElement("cbc:Name") 'verificar
        writer.WriteCData(Signature.SignatoryParty.PartyName.Name)
        writer.WriteEndElement() 'verificar-
        'writer.WriteEndElement() '-


        writer.WriteEndElement() '4-
        writer.WriteEndElement() '2-

        'DigitalSignatureAttachment
        writer.WriteStartElement("cac:DigitalSignatureAttachment") '5

        writer.WriteStartElement("cac:ExternalReference") '6
        writer.WriteElementString("cbc:URI", Signature.DigitalSignatureAttachment.ExternalReference.URI.Trim())
        writer.WriteEndElement() '5-
        writer.WriteEndElement() '6-
        writer.WriteEndElement() '1-

        'AccountingSuplierParty

        writer.WriteStartElement("cac:AccountingSupplierParty") '1

        writer.WriteElementString("cbc:CustomerAssignedAccountID", AccountingSupplierParty.CustomerAssignedAccountID)
        writer.WriteElementString("cbc:AdditionalAccountID", AccountingSupplierParty.AdditionalAccountID.ToString())

        'Party
        writer.WriteStartElement("cac:Party") '1.1

        'partyname

        ' PartyName
        writer.WriteStartElement("cac:PartyName") '1.1.1

        'writer.WriteStartElement("cbc:Name")
        'writer.WriteCData(AccountingSupplierParty.Party.PartyName.Name)
        'writer.WriteEndElement()
        '        writer.WriteElementString("cbc:Name", AccountingSupplierParty.Party.PartyName.Name)
        writer.WriteStartElement("cbc:Name") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PartyName.Name)
        writer.WriteEndElement() 'verificar-

        writer.WriteEndElement() '1.1.1-

        'writer.WriteStartElement("cac:PartyName")

        'writer.WriteStartElement("cbc:Name")
        'writer.WriteCData(AccountingSupplierParty.Party.PartyName.Name)

        'writer.WriteEndElement()
        'writer.WriteEndElement()

        'PostalAddress
        writer.WriteStartElement("cac:PostalAddress") '1.1.2
        writer.WriteElementString("cbc:ID", AccountingSupplierParty.Party.PostalAddress.ID)

        'writer.WriteElementString("cbc:StreetName", AccountingSupplierParty.Party.PostalAddress.StreetName)
        writer.WriteStartElement("cbc:StreetName") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PostalAddress.StreetName)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:CitySubdivisionName", AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName)
        writer.WriteStartElement("cbc:CitySubdivisionName") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:CityName", AccountingSupplierParty.Party.PostalAddress.CityName)

        writer.WriteStartElement("cbc:CityName") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PostalAddress.CityName)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:CountrySubentity", AccountingSupplierParty.Party.PostalAddress.CountrySubentity)

        writer.WriteStartElement("cbc:CountrySubentity") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PostalAddress.CountrySubentity)
        writer.WriteEndElement() 'verificar-


        'writer.WriteElementString("cbc:District", AccountingSupplierParty.Party.PostalAddress.District)

        writer.WriteStartElement("cbc:District") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PostalAddress.District)
        writer.WriteEndElement() 'verificar-

        'Country
        writer.WriteStartElement("cac:Country") '1.1.2.1
        writer.WriteElementString("cbc:IdentificationCode", AccountingSupplierParty.Party.PostalAddress.Country.IdentificationCode)
        writer.WriteEndElement() '1.1.2.1-
        '
        writer.WriteEndElement() '1.1.2-

        'PartyLegalEntity
        writer.WriteStartElement("cac:PartyLegalEntity") '1.1.3
        'qweqeqpwiepqe
        'writer.WriteElementString("cbc:RegistrationName", AccountingSupplierParty.Party.PartyLegalEntity.RegistrationName)

        writer.WriteStartElement("cbc:RegistrationName") 'verificar
        writer.WriteCData(AccountingSupplierParty.Party.PartyLegalEntity.RegistrationName)
        writer.WriteEndElement() 'verificar-

        writer.WriteEndElement() '1.1.3-
        '
        writer.WriteEndElement() '1.1-
        '

        writer.WriteEndElement() '1-


        '
        'AccountingCustomerParty
        writer.WriteStartElement("cac:AccountingCustomerParty") '2

        writer.WriteElementString("cbc:CustomerAssignedAccountID", AccountingCustomerParty.CustomerAssignedAccountID)
        writer.WriteElementString("cbc:AdditionalAccountID", AccountingCustomerParty.AdditionalAccountID.ToString())

        'Party
        writer.WriteStartElement("cac:Party") '2.1

        'PostalAddress
        writer.WriteStartElement("cac:PostalAddress") '2.1.2
        writer.WriteElementString("cbc:ID", AccountingCustomerParty.Party.PostalAddress.ID)
        'writer.WriteElementString("cbc:StreetName", AccountingCustomerParty.Party.PostalAddress.StreetName)

        writer.WriteStartElement("cbc:StreetName") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PostalAddress.StreetName)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:CitySubdivisionName", AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName)

        writer.WriteStartElement("cbc:CitySubdivisionName") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName)
        writer.WriteEndElement() 'verificar-


        'writer.WriteElementString("cbc:CityName", AccountingCustomerParty.Party.PostalAddress.CityName)
        writer.WriteStartElement("cbc:CityName") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PostalAddress.CityName)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:CountrySubentity", AccountingCustomerParty.Party.PostalAddress.CountrySubentity)

        writer.WriteStartElement("cbc:CountrySubentity") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PostalAddress.CountrySubentity)
        writer.WriteEndElement() 'verificar-

        'writer.WriteElementString("cbc:District", AccountingCustomerParty.Party.PostalAddress.District)

        writer.WriteStartElement("cbc:District") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PostalAddress.District)
        writer.WriteEndElement() 'verificar-

        'Country
        writer.WriteStartElement("cac:Country") '2.1.2.1
        writer.WriteElementString("cbc:IdentificationCode", AccountingCustomerParty.Party.PostalAddress.Country.IdentificationCode)
        writer.WriteEndElement() '2.1.2.1-
        '
        writer.WriteEndElement() '2.1.2-

        'PartyLegalEntity
        writer.WriteStartElement("cac:PartyLegalEntity") '2.1.3

        'writer.WriteElementString("cbc:RegistrationName", AccountingCustomerParty.Party.PartyLegalEntity.RegistrationName)

        writer.WriteStartElement("cbc:RegistrationName") 'verificar
        writer.WriteCData(AccountingCustomerParty.Party.PartyLegalEntity.RegistrationName)
        writer.WriteEndElement() 'verificar-

        writer.WriteEndElement() '2.1.3-
        '

        writer.WriteEndElement() '2.1-
        '

        writer.WriteEndElement() '2-
        '

        'writer.WriteEndElement()
        '


        'taxtotal
        For Each TaxTotal As TaxTotal In TaxTotals

            writer.WriteStartElement("cac:TaxTotal") '3

            writer.WriteStartElement("cbc:TaxAmount") '3.1
            writer.WriteAttributeString("currencyID", TaxTotal.TaxAmount.currencyID)
            writer.WriteString(TaxTotal.TaxAmount.value.ToString(Formato))
            writer.WriteEndElement() '3.1-
            'Taxsubtotal
            writer.WriteStartElement("cac:TaxSubtotal") '3.1.1

            writer.WriteStartElement("cbc:TaxAmount") '3.1.1.1
            writer.WriteAttributeString("currencyID", TaxTotal.TaxSubtotal.TaxAmount.currencyID)
            writer.WriteString(TaxTotal.TaxAmount.value.ToString(Constantes.FormatoNumerico, Formato))
            writer.WriteEndElement() '3.1.1.1-
            'TaxCategory
            writer.WriteStartElement("cac:TaxCategory") '3.1.1.2

            'TaxScheme

            writer.WriteStartElement("cac:TaxScheme") '3.1.1.2.1

            writer.WriteElementString("cbc:ID", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID)

            'writer.WriteElementString("cbc:Name", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name)

            writer.WriteStartElement("cbc:Name") 'verificar
            writer.WriteCData(TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name)
            writer.WriteEndElement() 'verificar-

            writer.WriteElementString("cbc:TaxTypeCode", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode)

            writer.WriteEndElement() '3.1.1.2.1-
            '
            writer.WriteEndElement() '3.1.1.2-

            '
            writer.WriteEndElement() '3.1.1

            '
            writer.WriteEndElement() '3
            '
        Next


        'Region "LegalMonetaryTotal"
        writer.WriteStartElement("cac:LegalMonetaryTotal") '4

        'If LegalMonetaryTotal.AllowanceTotalAmount.value > 0 Then
        '    writer.WriteStartElement("cbc:AllowanceTotalAmount") '4.1

        '    writer.WriteAttributeString("currencyID", LegalMonetaryTotal.AllowanceTotalAmount.currencyID)
        '    writer.WriteValue(LegalMonetaryTotal.AllowanceTotalAmount.value.ToString(Formato))

        '    writer.WriteEndElement() '4.1-
        'End If

        writer.WriteStartElement("cbc:PayableAmount") '4.2

        writer.WriteAttributeString("currencyID", LegalMonetaryTotal.PayableAmount.currencyID)
        writer.WriteValue(LegalMonetaryTotal.PayableAmount.value.ToString(Constantes.FormatoNumerico, Formato))

        writer.WriteEndElement() '4.2-


        writer.WriteEndElement() '4

        '********************invoicelines

        For Each creditNoteLine As InvoiceLine In CreditNoteLines

            writer.WriteStartElement("cac:CreditNoteLine") '5.1

            writer.WriteElementString("cbc:ID", creditNoteLine.ID.ToString())


            'InvoicedQuantity
            writer.WriteStartElement("cbc:CreditedQuantity") '5.1.1
            writer.WriteAttributeString("unitCode", creditNoteLine.CreditedQuantity.unitCode)
            writer.WriteValue(creditNoteLine.InvoicedQuantity.Value.ToString(Constantes.FormatoNumerico, Formato))
            writer.WriteEndElement() '5.1.1-
            'endregion

            'LineExtensionAmount
            writer.WriteStartElement("cbc:LineExtensionAmount") '5.1.2
            writer.WriteAttributeString("currencyID", creditNoteLine.LineExtensionAmount.currencyID)
            writer.WriteValue(creditNoteLine.LineExtensionAmount.value.ToString(Constantes.FormatoNumerico, Formato))
            writer.WriteEndElement() '5.1.2-
            'endregion

            'PricingReference
            writer.WriteStartElement("cac:PricingReference") '5.1.3
            '
            'AlternativeConditionPrice
            For Each Item As AlternativeConditionPrice In creditNoteLine.PricingReference.AlternativeConditionPrices

                writer.WriteStartElement("cac:AlternativeConditionPrice") '5.1.3.1

                'PriceAmount
                writer.WriteStartElement("cbc:PriceAmount") '5.1.3.1.1
                writer.WriteAttributeString("currencyID", Item.PriceAmount.currencyID)
                writer.WriteValue(Item.PriceAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '5.1.3.1.1-
                '
                writer.WriteElementString("cbc:PriceTypeCode", Item.PriceTypeCode)

                writer.WriteEndElement() '5.1.3.1-
            Next
            '
            writer.WriteEndElement() '5.1.3-
            '

            'AllowanceCharge
            If creditNoteLine.AllowanceCharge.ChargeIndicator Then

                writer.WriteStartElement("cac:AllowanceCharge") '5.1.4

                writer.WriteElementString("cbc:ChargeIndicator", CStr(creditNoteLine.AllowanceCharge.ChargeIndicator.ToString).ToLower)

                'Amount
                writer.WriteStartElement("cbc:Amount") '5.1.4.1
                writer.WriteAttributeString("currencyID", creditNoteLine.AllowanceCharge.Amount.currencyID)
                writer.WriteValue(creditNoteLine.AllowanceCharge.Amount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '5.1.4.1-
                'endregion
                writer.WriteEndElement() '5.1.4-

                'End If

            End If
            ' quitado para probar 0990198203810238103801823091803281099999999999999999999999999999999
          


            '
            'Taxtotal
            For Each TaxTotal As TaxTotal In creditNoteLine.TaxTotals
                writer.WriteStartElement("cac:TaxTotal")   '6
                writer.WriteStartElement("cbc:TaxAmount")  '6.1
                writer.WriteAttributeString("currencyID", TaxTotal.TaxAmount.currencyID)
                writer.WriteString(TaxTotal.TaxAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '6.1-

                'TaxSubtotal
                writer.WriteStartElement("cac:TaxSubtotal") '6.2

                'TaxableAmount
                If Not String.IsNullOrEmpty(TaxTotal.TaxableAmount.currencyID) Then

                    writer.WriteStartElement("cbc:TaxableAmount")
                    writer.WriteAttributeString("currencyID", TaxTotal.TaxableAmount.currencyID)
                    writer.WriteString(TaxTotal.TaxableAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                    writer.WriteEndElement()

                End If

                '
                writer.WriteStartElement("cbc:TaxAmount") '6.2.1
                writer.WriteAttributeString("currencyID", TaxTotal.TaxSubtotal.TaxAmount.currencyID)
                writer.WriteString(TaxTotal.TaxAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '6.2.1-
                If TaxTotal.TaxSubtotal.Percent > 0 Then
                    writer.WriteElementString("cbc:Percent", TaxTotal.TaxSubtotal.Percent.ToString(Constantes.FormatoNumerico, Formato))
                End If

                'TaxCategory
                writer.WriteStartElement("cac:TaxCategory") '6.2.2
                '//writer.WriteElementString("cbc:ID", invoiceLine.TaxTotal.TaxSubtotal.TaxCategory.ID);
                'MsgBox(TaxTotal.TaxSubtotal.TaxCategory.TaxExemptionReasonCode.ToString())
                'TaxTotal.TaxSubtotal.TaxCategory = New TaxCategory
                writer.WriteElementString("cbc:TaxExemptionReasonCode", TaxTotal.TaxSubtotal.TaxCategory.TaxExemptionReasonCode)
                If Not String.IsNullOrEmpty(TaxTotal.TaxSubtotal.TaxCategory.TierRange) Then
                    writer.WriteElementString("cbc:TierRange", TaxTotal.TaxSubtotal.TaxCategory.TierRange)

                End If
                'TaxScheme

                writer.WriteStartElement("cac:TaxScheme") '6.2.2.1

                writer.WriteElementString("cbc:ID", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID)
                writer.WriteStartElement("cbc:Name") 'verificar
                writer.WriteCData(TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name)
                writer.WriteEndElement() 'verificar-

                writer.WriteElementString("cbc:TaxTypeCode", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode)

                writer.WriteEndElement() '6.2.2.1-

                'endregion
                writer.WriteEndElement() '6.2.2-
                '
                writer.WriteEndElement() '6.2 -
                '
                writer.WriteEndElement() '6
                '
            Next
            '

            'Item
            writer.WriteStartElement("cac:Item")  '7
            'Description
            '----------writer.WriteElementString("cbc:Description", InvoiceLine.Item.Description)

            writer.WriteStartElement("cbc:Description") 'verificar
            writer.WriteCData(creditNoteLine.Item.Description)
            writer.WriteEndElement() 'verificar-
            '//writer.WriteStartElement("cbc:Description");
            '//writer.WriteCData(invoiceLine.Item.Description);
            '//writer.WriteEndElement();

            'SellersItemIdentification
            writer.WriteStartElement("cac:SellersItemIdentification") '7.1
            writer.WriteElementString("cbc:ID", creditNoteLine.Item.SellersItemIdentification.ID)
            writer.WriteEndElement() '7.1-

            'endregion
            writer.WriteEndElement() '7-
            '
            'Price
            writer.WriteStartElement("cac:Price") '8

            writer.WriteStartElement("cbc:PriceAmount") '8.1
            writer.WriteAttributeString("currencyID", creditNoteLine.Price.PriceAmount.currencyID)
            writer.WriteString(creditNoteLine.Price.PriceAmount.value.ToString(Constantes.FormatoNumerico, Formato))
            writer.WriteEndElement() '8.1

            writer.WriteEndElement() '8

            'endregion
            writer.WriteEndElement() '8 add 20/09/2016
        Next

        'writer.WriteEndElement() '5.1-
    End Sub
End Class


