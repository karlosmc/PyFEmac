Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports System.IO
Imports System.Configuration

Public Class DocumentoBajaXML

    Dim documento As VoidedDocuments
    Dim DocSunat As New DocumentoSunat
    Public Function GenerarBaja(Baja As ComunicacionBaja) As VoidedDocuments
        documento = New VoidedDocuments
        documento.ID = Baja.IdDocumento
        documento.IssueDate = CDate(Baja.FechaEmision).ToString("yyyy-MM-dd")
        documento.ReferenceDate = CDate(Baja.FechaReferencia).ToString("yyyy-MM-dd")

        documento.Signature = New SignatureCac
        documento.Signature.ID = Baja.IdDocumento

        documento.Signature.SignatoryParty = New SignatoryParty
        documento.Signature.SignatoryParty.PartyIdentification = New PartyIdentification
        documento.Signature.SignatoryParty.PartyIdentification.ID = New PartyIdentificationID
        documento.Signature.SignatoryParty.PartyIdentification.ID.Value = Baja.Emisor.NroDocumento

        documento.Signature.SignatoryParty.PartyName = New PartyName
        documento.Signature.SignatoryParty.PartyName.Name = Baja.Emisor.NombreLegal


        documento.Signature.DigitalSignatureAttachment = New DigitalSignatureAttachment
        documento.Signature.DigitalSignatureAttachment.ExternalReference = New ExternalReference
        documento.Signature.DigitalSignatureAttachment.ExternalReference.URI = "#signatureKG"


        documento.AccountingSupplierParty = New AccountingSupplierParty
        documento.AccountingSupplierParty.CustomerAssignedAccountID = Baja.Emisor.NroDocumento
        documento.AccountingSupplierParty.AdditionalAccountID = Baja.Emisor.TipoDocumento '*********************Tipo de documento de identidad, hacerlo dinámico

        documento.AccountingSupplierParty.Party = New Party
        documento.AccountingSupplierParty.Party.PartyLegalEntity = New PartyLegalEntity
        documento.AccountingSupplierParty.Party.PartyLegalEntity.RegistrationName = Baja.Emisor.NombreLegal

        Dim linea As VoidedDocumentsLine
        For Each void As DocumentoBaja In Baja.Bajas
            linea = New VoidedDocumentsLine
            With linea
                .LineId = void.ID
                .DocumentTypeCode = void.TipoDocumento
                .DocumentSerialId = void.Serie
                .DocumentNumberId = void.Correlativo
                .VoidReasonDescription = void.MotivoBaja
            End With
            documento.VoidedDocumentLines.Add(linea)
        Next
        'Return EnviarBaja(nombrearchivo)
        Return documento

    End Function

  
End Class
