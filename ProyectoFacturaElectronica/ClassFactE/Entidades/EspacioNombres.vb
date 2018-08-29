
Public Class EspacioNombres
    Public Const xmlnsRetention As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1" 'va ns13
    Public Const xmlnsInvoice As String = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
    Public Const xmlnsCreditNote As String = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2" 'va ns6
    Public Const xmlnsDebitNote As String = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2" ' va ns7
    Public Const xmlnsVoidedDocuments As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1" 'va ns11
    Public Const xmlnsSummaryDocuments As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1" 'va ns10
    Public Const xmlnsInvoiceSummary As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:InvoiceSummary-1" 'va ns10

    Public Const xmlnsPerception As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1" 'va ns14
    Public Const xmlnsDepatchAdvice As String = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2" ' va ns12

    Public Const sac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" ' va
    Public Const cac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
    Public Const cbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
    Public Const udt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
    Public Const ccts As String = "urn:un:unece:uncefact:documentation:2"
    Public Const ext As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
    Public Const qdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" 'va
    Public Const ds As String = "http://www.w3.org/2000/09/xmldsig#"
    Public Const xsi As String = "http://www.w3.org/2001/XMLSchema-instance"
    Public Const ar As String = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2"


    Public Const nodoId As String = "/ar:ApplicationResponse/cbc:ID"
    Public Const nodoResponseDate As String = "/ar:ApplicationResponse/cbc:ResponseDate"
    Public Const nodoResponseTime As String = "ar:ApplicationResponse/cbc:ResponseTime"
    Public Const nodoNote As String = "ar:ApplicationResponse/cbc:Note"
    Public Const nodoResponseCode As String = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode"
    Public Const nodoDescription As String = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description"

End Class



