Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

<Serializable> _
Public Class SummaryDocuments
    'Inherits VoidedDocumentsLine
    Implements IXmlSerializable
    Public vUBLExtensions As UBLExtensions
    Public Property UBLExtensions As UBLExtensions
        Get
            Return vUBLExtensions
        End Get
        Set(value As UBLExtensions)
            vUBLExtensions = value
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

    Public vID As String
    Public Property ID As String
        Get
            Return vID
        End Get
        Set(value As String)
            vID = value
        End Set
    End Property

    Public vIssueDate As DateTime
    Public Property IssueDate As DateTime
        Get
            Return vIssueDate
        End Get
        Set(value As DateTime)
            vIssueDate = value
        End Set
    End Property

    Public vReferenceDate As DateTime
    Public Property ReferenceDate As DateTime
        Get
            Return vReferenceDate
        End Get
        Set(value As DateTime)
            vReferenceDate = value
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


    Public vSumaryDocumentsLines As List(Of VoidedDocumentsLine)
    Public Property SumaryDocumentsLines As List(Of VoidedDocumentsLine)
        Get
            Return vSumaryDocumentsLines
        End Get
        Set(value As List(Of VoidedDocumentsLine))
            vSumaryDocumentsLines = value
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
        UBLExtensions = New UBLExtensions
        Signature = New SignatureCac
        SumaryDocumentsLines = New List(Of VoidedDocumentsLine)
        UblVersionId = "2.0"
        CustomizationId = "1.1"
        Formato = New System.Globalization.CultureInfo("es-PE")
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema

    End Function

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsSummaryDocuments)
        writer.WriteAttributeString("xmlns:cac", EspacioNombres.cac)
        writer.WriteAttributeString("xmlns:cbc", EspacioNombres.cbc)
        writer.WriteAttributeString("xmlns:ds", EspacioNombres.ds)
        writer.WriteAttributeString("xmlns:ext", EspacioNombres.ext)
        writer.WriteAttributeString("xmlns:sac", EspacioNombres.sac)
        writer.WriteAttributeString("xmlns:xsi", EspacioNombres.xsi)
        writer.WriteAttributeString("xsi:schemaLocation", EspacioNombres.xmlnsInvoiceSummary)

        writer.WriteStartElement("ext:UBLExtensions") '1
        'UBLextension******************1.1
        'Dim ext11 = UBLExtensions.Extension1
        'Dim ext1 = UBLExtensions.Extension1.ExtensionContent.AdditionalInformation
        writer.WriteStartElement("ext:UBLExtension")
        'ExtensionContent*******************1.1.1
        writer.WriteStartElement("ext:ExtensionContent")
        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndElement()
        'end extension content ***************1.1.1
        'end extension ***********************1.1
        'end UBLEXTENSIONS *******************1
        writer.WriteElementString("cbc:UBLVersionID", UblVersionId)
        writer.WriteElementString("cbc:CustomizationID", CustomizationId)
        writer.WriteElementString("cbc:ID", ID)
        writer.WriteElementString("cbc:ReferenceDate", ReferenceDate.ToString("yyyy-MM-dd"))
        writer.WriteElementString("cbc:IssueDate", IssueDate.ToString("yyyy-MM-dd"))
        'SIGNATURE************2
        writer.WriteStartElement("cac:Signature")
        writer.WriteElementString("cbc:ID", Signature.ID)
        'SIGNATORYPARTY***************2.1
        writer.WriteStartElement("cac:SignatoryParty")
        'partyidentificacion
        writer.WriteStartElement("cac:PartyIdentification")
        writer.WriteElementString("cbc:ID", Signature.SignatoryParty.PartyIdentification.ID.value)
        writer.WriteEndElement()
        'end partyidentificacion
        'PartyName****************************2.1.1

        writer.WriteStartElement("cac:PartyName")

        writer.WriteStartElement("cbc:Name")
        writer.WriteCData(Signature.SignatoryParty.PartyName.Name)
        writer.WriteEndElement()

        'end partyname***********************2.1.1

        writer.WriteEndElement()
        'end signatoryparty***********************2.1
        writer.WriteEndElement()
        'DigitalSignatureAttachment*************2.2

        writer.WriteStartElement("cac:DigitalSignatureAttachment") '

        writer.WriteStartElement("cac:ExternalReference") '
        writer.WriteElementString("cbc:URI", Signature.DigitalSignatureAttachment.ExternalReference.URI.Trim())
        writer.WriteEndElement() '
        writer.WriteEndElement() '

        'END DigitalSignatureAttachment*************2.2

        'writer.WriteEndElement()
        writer.WriteEndElement() ''  agregado para probar

        'end SIGNATURE************2

        ' AccountingSupplierParty ***********************3

        writer.WriteStartElement("cac:AccountingSupplierParty")
        writer.WriteElementString("cbc:CustomerAssignedAccountID", AccountingSupplierParty.CustomerAssignedAccountID)
        writer.WriteElementString("cbc:AdditionalAccountID", AccountingSupplierParty.AdditionalAccountID)

        'Party******************3.1
        writer.WriteStartElement("cac:Party")


        ' PartyLegalEntity********************3.1.1
        writer.WriteStartElement("cac:PartyLegalEntity")

        'registration name  3.1.1.1
        writer.WriteStartElement("cbc:RegistrationName")
        writer.WriteCData(AccountingSupplierParty.Party.PartyLegalEntity.RegistrationName)
        writer.WriteEndElement()
        'end registration name ****************3.1.1.1

        writer.WriteEndElement()
        'end partylegalentity    ********************3.1.1

        writer.WriteEndElement()
        'end party***********************    3.1

        writer.WriteEndElement()
        'writer.WriteEndElement()
        'end accounting supplier party ***********************    3


        'Summary lines  ********************************4
        For Each Item As VoidedDocumentsLine In SumaryDocumentsLines

            writer.WriteStartElement("sac:SummaryDocumentsLine")
            writer.WriteElementString("cbc:LineID", Item.LineId.ToString())
            writer.WriteElementString("cbc:DocumentTypeCode", Item.DocumentTypeCode)

            If (Not String.IsNullOrEmpty(Item.Id)) Then
                writer.WriteElementString("cbc:ID", Item.Id)
            Else
                '**************************RESUMEN DE BOLETAS O NOTAS
                writer.WriteElementString("sac:DocumentSerialID", Item.DocumentSerialId)
                writer.WriteElementString("sac:StartDocumentNumberID", Item.StartDocumentNumberId.ToString())
                writer.WriteElementString("sac:EndDocumentNumberID", Item.EndDocumentNumberId.ToString())
            End If
            If (Not String.IsNullOrEmpty(Item.AccountingCustomerParty.AdditionalAccountID)) Then

                writer.WriteStartElement("cac:AccountingCustomerParty")

                writer.WriteElementString("cbc:CustomerAssignedAccountID", Item.AccountingCustomerParty.CustomerAssignedAccountID)
                writer.WriteElementString("cbc:AdditionalAccountID", Item.AccountingCustomerParty.AdditionalAccountID)

                writer.WriteEndElement()

            End If
            '******************NOTAS DE CREDITO
            If (Not String.IsNullOrEmpty(Item.BillingReference.InvoiceDocumentReference.ID)) Then
                writer.WriteStartElement("cac:BillingReference")
                writer.WriteStartElement("cac:InvoiceDocumentReference")
                writer.WriteElementString("cbc:ID", Item.BillingReference.InvoiceDocumentReference.ID)
                writer.WriteElementString("cbc:DocumentTypeCode", Item.BillingReference.InvoiceDocumentReference.DocumentTypeCode)
                writer.WriteEndElement()
                writer.WriteEndElement()
            End If

            '**********************modificacion, anulacion etc
            If (Item.ConditionCode.HasValue) Then

                writer.WriteStartElement("cac:Status")

                writer.WriteElementString("cbc:ConditionCode", Item.ConditionCode.Value.ToString())

                writer.WriteEndElement()
            End If

            writer.WriteStartElement("sac:TotalAmount")

            writer.WriteAttributeString("currencyID", Item.TotalAmount.currencyID)
            writer.WriteValue(Item.TotalAmount.value.ToString(Constantes.FormatoNumerico, Formato))
            writer.WriteEndElement()

            For Each billing As BillingPayment In Item.BillingPayments
                writer.WriteStartElement("sac:BillingPayment")
                writer.WriteStartElement("cbc:PaidAmount")
                writer.WriteAttributeString("currencyID", Item.TotalAmount.currencyID)
                writer.WriteValue(billing.PaidAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement()
                writer.WriteElementString("cbc:InstructionID", billing.InstructionID)
                writer.WriteEndElement()
            Next

            writer.WriteStartElement("cac:AllowanceCharge")
            writer.WriteElementString("cbc:ChargeIndicator", IIf(Item.AllowanceCharge.ChargeIndicator, "true", "false"))
            writer.WriteStartElement("cbc:Amount")
            writer.WriteAttributeString("currencyID", Item.AllowanceCharge.Amount.currencyID)
            writer.WriteValue(Item.AllowanceCharge.Amount.value.ToString(Constantes.FormatoNumerico, Formato))

            writer.WriteEndElement()

            writer.WriteEndElement()

            '***************TAXTOTALS ITEM

            For Each TaxTotal As TaxTotal In Item.TaxTotals
                writer.WriteStartElement("cac:TaxTotal")   '6
                writer.WriteStartElement("cbc:TaxAmount")  '6.1
                writer.WriteAttributeString("currencyID", TaxTotal.TaxAmount.currencyID)
                writer.WriteString(TaxTotal.TaxAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '6.1-

                'TaxSubtotal
                writer.WriteStartElement("cac:TaxSubtotal") '6.2

                writer.WriteStartElement("cbc:TaxAmount") '6.2.1
                writer.WriteAttributeString("currencyID", TaxTotal.TaxSubtotal.TaxAmount.currencyID)
                writer.WriteString(TaxTotal.TaxAmount.value.ToString(Constantes.FormatoNumerico, Formato))
                writer.WriteEndElement() '6.2.1-

                'TaxCategory
                writer.WriteStartElement("cac:TaxCategory") '6.2.2
                'TaxScheme
                writer.WriteStartElement("cac:TaxScheme") '6.2.2.1
                writer.WriteElementString("cbc:ID", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID)
                writer.WriteElementString("cbc:Name", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name) 'verificar
                writer.WriteElementString("cbc:TaxTypeCode", TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode)
                writer.WriteEndElement() '6.2.2.1-
                ' END TAXSCHEME

                'endregion
                writer.WriteEndElement() '6.2.2-
                'END TAXCATEGORY
                '
                writer.WriteEndElement() '6.2 -
                'END TAXSUBTOTAL
                '
                writer.WriteEndElement() '6
                'END TAXTOTAL
            Next
            writer.WriteEndElement() '6
        Next

    End Sub
End Class
