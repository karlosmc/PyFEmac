Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

<Serializable()> _
Public Class VoidedDocuments
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


    Public vVoidedDocumentLines As List(Of VoidedDocumentsLine)
    Public Property VoidedDocumentLines As List(Of VoidedDocumentsLine)
        Get
            Return vVoidedDocumentLines
        End Get
        Set(value As List(Of VoidedDocumentsLine))
            vVoidedDocumentLines = value
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
    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml
        Throw New NotImplementedException
    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsVoidedDocuments)
        writer.WriteAttributeString("xmlns:cac", EspacioNombres.cac)
        writer.WriteAttributeString("xmlns:cbc", EspacioNombres.cbc)
        writer.WriteAttributeString("xmlns:ds", EspacioNombres.ds)
        writer.WriteAttributeString("xmlns:ext", EspacioNombres.ext)
        writer.WriteAttributeString("xmlns:sac", EspacioNombres.sac)
        writer.WriteAttributeString("xmlns:xsi", EspacioNombres.xsi)
        'UBLEXTENSIONS******************1
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

        'voided lines  ********************************4
        For Each Item As VoidedDocumentsLine In VoidedDocumentLines

            writer.WriteStartElement("sac:VoidedDocumentsLine")

            writer.WriteElementString("cbc:LineID", Item.LineId.ToString())
            writer.WriteElementString("cbc:DocumentTypeCode", Item.DocumentTypeCode)
            writer.WriteElementString("sac:DocumentSerialID", Item.DocumentSerialId)
            writer.WriteElementString("sac:DocumentNumberID", Item.DocumentNumberId.ToString())
            writer.WriteElementString("sac:VoidReasonDescription", Item.VoidReasonDescription)

            writer.WriteEndElement()
        Next
        'writer.WriteEndElement()

    End Sub

    Public Sub New()
        AccountingSupplierParty = New AccountingSupplierParty
        UBLExtensions = New UBLExtensions
        Signature = New SignatureCac
        vVoidedDocumentLines = New List(Of VoidedDocumentsLine)
        UblVersionId = "2.0"
        CustomizationId = "1.0"
        Formato = New System.Globalization.CultureInfo("es-PE")
    End Sub
End Class
