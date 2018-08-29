Imports System.IO
Public Class GeneraSUNAT



    Public Function GenerarDocumentoSinFirma(doc As DocumentoElectronico, opc As Integer) As DocumentoResponse
        Dim response As New DocumentoResponse
        Try

            Dim Invoice As New Invoice
            Dim NotaCredito As New CreditNote
            Dim NotaDebito As New DebitNote
            Dim FactXML As New FacturaXML
            Dim NotaCreXML As New NotaCreditoXML
            Dim NotaDebXML As New NotaDebitoXML

            Dim serializador As New Serializador



            Select Case opc
                Case 0
                    Invoice = FactXML.GenerarFactura(doc)
                    response.TramaXmlSinFirma = serializador.GenerarXml(Invoice)
                    response.Exito = True
                    ' Return Invoice
                Case 1
                    NotaCredito = NotaCreXML.GenerarNotaCredito(doc)
                    response.TramaXmlSinFirma = serializador.GenerarXml(NotaCredito)
                    response.Exito = True
                Case 2
                    NotaDebito = NotaDebXML.GenerarNotaDebito(doc)
                    response.TramaXmlSinFirma = serializador.GenerarXml(NotaDebito)
                    response.Exito = True
                Case Else
                    Invoice = FactXML.GenerarFactura(doc)
                    response.TramaXmlSinFirma = serializador.GenerarXml(Invoice)
                    response.Exito = True
            End Select

            Return response
        Catch ex As Exception
            response.Exito = False
            response.MensajeError = ex.Message
            response.Pila = ex.StackTrace
        End Try
        Return response
    End Function

    Public Function GenerarDocumento(doc As DocumentoElectronico, opc As Integer, PathCert As String, PassCert As String) As FirmadoResponse

        Dim Invoice As New Invoice
        Dim NotaCredito As New CreditNote
        Dim NotaDebito As New DebitNote
        Dim FactXML As New FacturaXML
        Dim NotaCreXML As New NotaCreditoXML
        Dim NotaDebXML As New NotaDebitoXML

        Dim serializador As New Serializador
        Dim Certificador As New Certificador

        Dim envio As New FirmadoRequest
        envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PathCert))
        envio.PasswordCertificado = PassCert
        envio.UnSoloNodoExtension = 1
        Select Case opc
            Case 0
                Invoice = FactXML.GenerarFactura(doc)
                envio.TramaXmlSinFirma = serializador.GenerarXml(Invoice)
                ' Return Invoice
            Case 1
                NotaCredito = NotaCreXML.GenerarNotaCredito(doc)
                envio.TramaXmlSinFirma = serializador.GenerarXml(NotaCredito)
                'Return NotaCredito
            Case 2
                NotaDebito = NotaDebXML.GenerarNotaDebito(doc)
                envio.TramaXmlSinFirma = serializador.GenerarXml(NotaDebito)
                'Return NotaCredito
            Case Else
                Invoice = FactXML.GenerarFactura(doc)
                envio.TramaXmlSinFirma = serializador.GenerarXml(Invoice)
                'Return Invoice
        End Select

        Dim response As New FirmadoResponse
        response = Certificador.FirmarXML(envio)

        Return response
    End Function

    Public Function EnviarDocumento(request As EnviarDocumentoRequest) As EnviarDocumentoResponse
        Dim envioRes As New EnviarDocumento
        Dim respuestaEnvio As New EnviarDocumentoResponse
        respuestaEnvio = envioRes.EnviarDocumentoResponse(request)
        Return respuestaEnvio
    End Function

    Public Function EnviarResumen(response As FirmadoResponse, request As EnviarDocumentoRequest) As EnviarResumenResponse
        Dim envioRes As New EnviarDocumentoResumen
        Dim respuestaEnvio As New EnviarResumenResponse
        respuestaEnvio = envioRes.EnviarResumenResponse(request)
        Return respuestaEnvio
    End Function

    Dim pdf As UtilPDF
    Public Function GenerarPDF(pathlogo As String, authsunat As String, doc As DocumentoElectronico, _
                               firma As FirmadoResponse, respuesta As EnviarDocumentoResponse, DocCondicion As String, webconsulta As String) As String
        pdf = New UtilPDF
        Return pdf.GenerarPDF(pathlogo, authsunat, doc, firma, respuesta, DocCondicion, webconsulta)
    End Function

    Public Function ConsultarTicket(consultaRequest As ConsultaTicketRequest) As EnviarDocumentoResponse
        Dim GetEstado As New ConsultarTicket
        Dim respuestaConsulta As New EnviarDocumentoResponse
        respuestaConsulta = GetEstado.ConsultarTicket(consultaRequest)
        Return respuestaConsulta
    End Function

    Public Function GenerarDocFisico(trama As String, PathArchivo As String, archivo As String, extension As String, cdr As Boolean) As String
        If cdr = True Then archivo = "R-" & archivo
        Try
            File.WriteAllBytes(PathArchivo & "\" & archivo & "." & extension, Convert.FromBase64String(trama))
            Return PathArchivo & "\" & archivo & "." & extension
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function GenerarResumenDiario(doc As ResumenDiario, PathCert As String, PassCert As String) As FirmadoResponse
        Dim serializador As New Serializador
        Dim Certificador As New Certificador
        Dim resumenXML As New ResumenDiarioXML
        Dim resumen As New SummaryDocuments
        resumen = resumenXML.GenerarResumen(doc)
        Dim envio As New FirmadoRequest
        envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PathCert))
        envio.PasswordCertificado = PassCert
        envio.UnSoloNodoExtension = 0
        envio.TramaXmlSinFirma = serializador.GenerarXml(resumen)
        Dim response As New FirmadoResponse
        response = Certificador.FirmarXML(envio)
        Return response
    End Function

    Public Function GenerarComunicacionBaja(doc As ComunicacionBaja, PathCert As String, PassCert As String) As FirmadoResponse
        Dim serializador As New Serializador
        Dim Certificador As New Certificador
        Dim DocumentoBajaXML As New DocumentoBajaXML
        Dim ComunicacionBaja As New VoidedDocuments
        ComunicacionBaja = DocumentoBajaXML.GenerarBaja(doc)
        Dim envio As New FirmadoRequest
        envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PathCert))
        envio.PasswordCertificado = PassCert
        envio.UnSoloNodoExtension = 0
        envio.TramaXmlSinFirma = serializador.GenerarXml(ComunicacionBaja)
        Dim response As New FirmadoResponse
        response = Certificador.FirmarXML(envio)
        Return response
    End Function

End Class
