Imports System.IO
Imports System.Configuration
Imports System.Threading
Public Class Form1

    'Dim anexo As New Entidades.AnexoEN

    Dim convertir As New convertir

    Dim Invoice As New Invoice

    Dim NotaCredito As New CreditNote
    Dim NotaDebito As New DebitNote

    Dim FactXML As New FacturaXML
    Dim NotaCreXML As New NotaCreditoXML
    Dim NotaDebXML As New NotaDebitoXML

    Dim resumenXML As New ResumenDiarioXML
    Dim serializador As New Serializador
    Dim Certificador As New Certificador

    Dim PATH_xml As String = ConfigurationManager.AppSettings("path_xmlGEN").ToString
    Dim PATH_zip As String = ConfigurationManager.AppSettings("path_zipGEN").ToString
    Dim PATH_cdr As String = ConfigurationManager.AppSettings("path_rptGEN").ToString
    Dim PATH_pdf As String = ConfigurationManager.AppSettings("path_pdf").ToString

    Dim PATH_certificado As String = ConfigurationManager.AppSettings("path_certificado").ToString
    Dim pwdCertificado As String = ConfigurationManager.AppSettings("key1pass").ToString

    Dim Conf_RUC As String = ConfigurationManager.AppSettings("ruc").ToString
    Dim Conf_Company As String = ConfigurationManager.AppSettings("company").ToString
    Dim Conf_Dir As String = ConfigurationManager.AppSettings("dir").ToString
    Dim Conf_Ubigeo As String = ConfigurationManager.AppSettings("ubigeo").ToString
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

    Private Function hola() As String

        'Dim parametros As New ParametrosConexion
        'Dim ServiceConsume As New ServiceConsume
        'parametros.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"
        'parametros.Password = "MODDATOS"
        'parametros.UserName = "20318171701"
        Dim doc As New DocumentoElectronico
        Dim mensaje As String = ""
        Try
            doc.IdDocumento = "FB01-00000010"
            doc.Gravadas = 0.17
            doc.Gratuitas = 0
            doc.Exoneradas = 0
            doc.Inafectas = 0
            doc.MontoPercepcion = 0
            doc.MontoDetraccion = 0
            doc.MontoAnticipo = 0
            doc.FechaEmision = CDate(Now()).ToString("yyyy-MM-dd")
            doc.TipoDocumento = "01"
            doc.TotalVenta = 0.2
            doc.MontoEnLetras = convertir.Letras(doc.TotalVenta)
            doc.DescuentoGlobal = 0
            doc.Moneda = "PEN"
            'EMISOR
            With doc.Emisor
                .NroDocumento = Conf_RUC
                .NombreLegal = Conf_Company
                .TipoDocumento = 6
                .NombreComercial = "FAFIO"
                .Ubigeo = ""
                .Direccion = Conf_Dir
                .Urbanizacion = "-"
                .Departamento = "TACNA"
                .Distrito = "ALTO DE LA ALIANZA"
                .Provincia = "TACNA"
            End With

            'CLIENTE
            With doc.Receptor
                .NroDocumento = "10435533081"
                .TipoDocumento = 6
                .NombreComercial = "Evolution Car Service Empresa Individual de Responsabilidad Limitada".ToUpper
                .NombreLegal = "Evolution Car Service Empresa Individual de Responsabilidad Limitada".ToUpper
                'MsgBox(.NombreLegal.Length)
                .Direccion = "URB. MONTE VERDE II ETAPA B-6 TACNA TACNA TACNA"
            End With
            doc.TotalIgv = 0.03
            doc.TotalIsc = 0
            doc.TotalOtrosTributos = 0
            doc.Relacionados.Add(New DocumentoRelacionado With {
                                .NroDocumento = "001-54545",
                               .TipoDocumento = "09"})
            'ITEMS
            doc.Items.Add(
                New DetalleDocumento With {
                    .ID = "001",
                    .UnidadMedida = "NIU",
                    .Cantidad = 1212.12314,
                    .TotalVenta = 0.2,
                    .ValorUnitario = 0.17,
                    .ValorTotal = 0.17,
                    .Descripcion = "PRODUCTO DE PRUEBA",
                    .CodigoItem = "101010",
                    .PrecioUnitario = 0.2,
                    .Impuesto = 0.03,
                    .TipoImpuesto = 10,
                    .Descuento = 0,
                    .PrecioReferencial = 0.17
                })

            '***************************************************

            Invoice = FactXML.GenerarFactura(doc)

            Dim envio As New FirmadoRequest
            envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PATH_certificado))
            envio.PasswordCertificado = pwdCertificado



            envio.TramaXmlSinFirma = serializador.GenerarXml(Invoice)
            envio.UnSoloNodoExtension = 1
            'Dim nomarchivo = Conf_RUC & "-" & doc.TipoDocumento & "-" & doc.IdDocumento
            'File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
            '                      Convert.FromBase64String(envio.TramaXmlSinFirma))

            Dim response As New FirmadoResponse
            response = Certificador.FirmarXML(envio)


            If Not response.Exito Then
                'Throw New Exception(response.MensajeError)
                Return response.MensajeError

            End If
            Dim envioDoc As New EnviarDocumentoRequest
            envioDoc.Ruc = Conf_RUC
            envioDoc.IdDocumento = doc.IdDocumento
            envioDoc.TipoDocumento = doc.TipoDocumento
            envioDoc.TramaXmlFirmado = response.TramaXmlFirmado
            envioDoc.UsuarioSol = "MODDATOS"
            envioDoc.ClaveSol = "MODDATOS"

            envioDoc.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"

            Dim nomarchivo = envioDoc.Ruc & "-" & envioDoc.TipoDocumento & "-" & envioDoc.IdDocumento

            File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
                                   Convert.FromBase64String(response.TramaXmlFirmado))

            Dim envioRes As New EnviarDocumento
            Dim respuestaEnvio As New EnviarDocumentoResponse

            respuestaEnvio = envioRes.EnviarDocumentoResponse(envioDoc)


            If respuestaEnvio.Exito Then
                'serializador.GenerarZip(respuestaEnvio.TramaZipCdr, respuestaEnvio.NombreArchivo)
                File.WriteAllBytes(PATH_cdr & "\R-" & respuestaEnvio.NombreArchivo, _
                                   Convert.FromBase64String(respuestaEnvio.TramaZipCdr))

                'Dim pdfpath As String = GenerarPDF("E:\sunat_archivos\sfs\LOGO\LogoFafio.png", "000003656565", doc, response, respuestaEnvio, "CONTADO", "wwww.agropecuariaeindustriasfafio.com")
                'File.WriteAllBytes(PATH_pdf & "\" & nomarchivo & ".pdf", _
                '                   Convert.FromBase64String(pdfpath))
                Return PATH_zip & "\R-" & respuestaEnvio.NombreArchivo
            Else
                Return respuestaEnvio.MensajeError
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return mensaje
    End Function

    Dim resumen As New SummaryDocuments
    Dim baja As New VoidedDocuments
    Private Function hola2() As String
        Dim doc As New ResumenDiario
        Dim mensaje As String = ""
        Try
            doc.FechaEmision = CDate(Now()).ToString("yyyy-MM-dd")
            doc.FechaReferencia = "2018-06-26"
            doc.IdDocumento = "RC-" & CDate(Now()).ToString("yyyyMMdd") & "-200"
            'EMISOR
            'With doc.Emisor
            '    .NroDocumento = Conf_RUC
            '    .NombreLegal = Conf_Company
            'End With

            'CLIENTE
            With doc.Emisor
                .NroDocumento = Conf_RUC
                .TipoDocumento = 6
                .NombreLegal = Conf_Company
            End With
            'ITEMS
            doc.Resumenes.Add(
                New GrupoResumenNuevo With {
                    .ID = "1",
                    .TipoDocumento = "03",
                    .TipoDocumentoReceptor = "",
                    .NroDocumentoReceptor = "",
                    .DocumentoRelacionado = "",
                    .TipoDocumentoRelacionado = "",
                    .CodigoEstadoItem = 1,
                    .Moneda = "PEN",
                    .TotalVenta = 3.0,
                    .Gravadas = 2.54,
                    .TotalDescuentos = 0,
                    .Exoneradas = 0,
                    .Inafectas = 0,
                    .TotalIsc = 0,
                    .Exportacion = 0,
                    .Gratuitas = 0,
                    .TotalIgv = 0.46,
                    .TotalOtrosImpuestos = 0,
                    .IdDocumento = "B071-00085515"
            })

            '  doc.Resumenes.Add(
            '    New GrupoResumenNuevo With {
            '        .ID = "2",
            '        .TipoDocumento = "03",
            '        .TipoDocumentoReceptor = "",
            '        .NroDocumentoReceptor = "",
            '        .DocumentoRelacionado = "",
            '        .TipoDocumentoRelacionado = "",
            '        .CodigoEstadoItem = 1,
            '        .Moneda = "PEN",
            '        .TotalVenta = 118,
            '        .Gravadas = 100,
            '        .TotalDescuentos = 0,
            '        .Exoneradas = 0,
            '        .Inafectas = 0,
            '        .TotalIsc = 0,
            '        .Exportacion = 0,
            '        .Gratuitas = 0,
            '        .TotalIgv = 18,
            '        .TotalOtrosImpuestos = 0,
            '        .IdDocumento = "B020-6"
            '})

            resumen = resumenXML.GenerarResumen(doc)

            Dim envio As New FirmadoRequest
            envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PATH_certificado))
            envio.PasswordCertificado = pwdCertificado
            envio.TramaXmlSinFirma = serializador.GenerarXml(resumen)
            envio.UnSoloNodoExtension = 0
            'Dim nomarchivo = Conf_RUC & "-" & doc.TipoDocumento & "-" & doc.IdDocumento
            'File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
            '                      Convert.FromBase64String(envio.TramaXmlSinFirma))

            Dim response As New FirmadoResponse
            response = Certificador.FirmarXML(envio)

            If Not response.Exito Then
                'Throw New Exception(response.MensajeError)
                Return response.MensajeError

            End If
            Dim envioDoc As New EnviarDocumentoRequest
            envioDoc.Ruc = Conf_RUC
            envioDoc.IdDocumento = doc.IdDocumento
            envioDoc.TramaXmlFirmado = response.TramaXmlFirmado

            envioDoc.UsuarioSol = "GHUAN225"
            envioDoc.ClaveSol = "GustHuan"
            envioDoc.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService" 'BETA

            'envioDoc.EndPointUrl = "https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService" 'PRODUCCION


            Dim nomarchivo = envioDoc.Ruc & "-" & envioDoc.IdDocumento

            File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
                                   Convert.FromBase64String(response.TramaXmlFirmado))

            Dim envioRes As New EnviarDocumentoResumen
            Dim respuestaEnvio As New EnviarResumenResponse
            respuestaEnvio = envioRes.EnviarResumenResponse(envioDoc)
            If respuestaEnvio.Exito Then
                txtNroTicket.Text = respuestaEnvio.NroTicket
                Return "se ha generado el ticket " & txtNroTicket.Text
            Else
                txtNroTicket.Text = ""
                Return respuestaEnvio.MensajeError
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return mensaje
    End Function
    Dim bajaXML As New DocumentoBajaXML

    Private Function hola3() As String
        Dim doc As New ComunicacionBaja
        Dim mensaje As String = ""
        Try
            doc.FechaEmision = CDate(Now()).ToString("yyyy-MM-dd")
            doc.FechaReferencia = "2018-07-19 " 'CDate(Now()).ToString("yyyy-MM-dd")
            doc.IdDocumento = "RA-" & CDate(Now()).ToString("yyyyMMdd") & "-201"
            'EMISOR
            'With doc.Emisor
            '    .NroDocumento = Conf_RUC
            '    .NombreLegal = Conf_Company
            'End With
            'CLIENTE
            With doc.Emisor
                .NroDocumento = Conf_RUC
                .TipoDocumento = 6
                .NombreLegal = Conf_Company
            End With
            'ITEMS
            doc.Bajas.Add(
                New DocumentoBaja With {
                    .ID = "1",
                    .TipoDocumento = "01",
                    .Correlativo = "155",
                    .MotivoBaja = "anulacion de la operacion",
                    .Serie = "F201"
                        })

            baja = bajaXML.GenerarBaja(doc)

            Dim envio As New FirmadoRequest
            envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PATH_certificado))
            envio.PasswordCertificado = pwdCertificado
            envio.TramaXmlSinFirma = serializador.GenerarXml(baja)
            envio.UnSoloNodoExtension = 0
            'Dim nomarchivo = Conf_RUC & "-" & doc.TipoDocumento & "-" & doc.IdDocumento
            'File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
            '                      Convert.FromBase64String(envio.TramaXmlSinFirma))

            Dim response As New FirmadoResponse
            response = Certificador.FirmarXML(envio)

            If Not response.Exito Then
                'Throw New Exception(response.MensajeError)
                Return response.MensajeError

            End If
            Dim envioDoc As New EnviarDocumentoRequest
            envioDoc.Ruc = Conf_RUC
            envioDoc.IdDocumento = doc.IdDocumento
            envioDoc.TramaXmlFirmado = response.TramaXmlFirmado
            envioDoc.UsuarioSol = "FACTURA2"
            envioDoc.ClaveSol = "789456123"
            'envioDoc.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"
            envioDoc.EndPointUrl = "https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService"

            Dim nomarchivo = envioDoc.Ruc & "-" & envioDoc.IdDocumento

            File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
                                   Convert.FromBase64String(response.TramaXmlFirmado))

            Dim envioRes As New EnviarDocumentoResumen
            Dim respuestaEnvio As New EnviarResumenResponse
            respuestaEnvio = envioRes.EnviarResumenResponse(envioDoc)
            If respuestaEnvio.Exito Then
                txtNroTicket.Text = respuestaEnvio.NroTicket
                Return "se ha generado el ticket " & txtNroTicket.Text
            Else
                txtNroTicket.Text = ""
                Return respuestaEnvio.MensajeError
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return mensaje
    End Function

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim res As String = hola()
        MsgBox(res)
    End Sub

    Private Sub btnGenResumen_Click(sender As Object, e As EventArgs) Handles btnGenResumen.Click
        Dim res As String = hola2()
        MsgBox(res)
    End Sub
    Private Sub btnConsultarTicket_Click(sender As Object, e As EventArgs) Handles btnConsultarTicket.Click
        Dim GetEstado As New ConsultarTicket
        Dim ConsultaRequest As New ConsultaTicketRequest
        Dim respuestaConsulta As New EnviarDocumentoResponse

        ConsultaRequest.NroTicket = txtNroTicket.Text
        'ConsultaRequest.ClaveSol = "MODDATOS"
        ConsultaRequest.Ruc = Conf_RUC
        'ConsultaRequest.UsuarioSol = "MODDATOS"

        ConsultaRequest.UsuarioSol = "FACTURA2"
        ConsultaRequest.ClaveSol = "789456123"
        ConsultaRequest.EndPointUrl = "https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService"
        'ConsultaRequest.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"
        respuestaConsulta = GetEstado.ConsultarTicket(ConsultaRequest)
        If respuestaConsulta.Exito Then
            File.WriteAllBytes(PATH_cdr & "\" & txtNroTicket.Text & ".zip", _
                           Convert.FromBase64String(respuestaConsulta.TramaZipCdr))
            MsgBox(PATH_cdr & "\" & txtNroTicket.Text & ".zip")
        Else
            MsgBox(respuestaConsulta.MensajeError)
        End If
    End Sub

    Private Sub btnGenerarBaja_Click(sender As Object, e As EventArgs) Handles btnGenerarBaja.Click

        Dim res As String = hola3()
        MsgBox(res)

    End Sub

    Private Function hola4() As String
        Dim doc As New DocumentoElectronico
        Dim mensaje As String = ""
        Try
            doc.IdDocumento = "FT01-00005421"
            doc.Gravadas = 100
            doc.Gratuitas = 0
            doc.Exoneradas = 0
            doc.Inafectas = 0
            doc.MontoPercepcion = 0
            doc.MontoDetraccion = 0
            doc.MontoAnticipo = 0
            doc.FechaEmision = CDate(Now()).ToString("yyyy-MM-dd")
            doc.TipoDocumento = "07"
            doc.TotalVenta = 118
            doc.MontoEnLetras = convertir.Letras(doc.TotalVenta)
            doc.DescuentoGlobal = 0
            doc.Moneda = "PEN"

            'EMISOR
            With doc.Emisor
                .NroDocumento = Conf_RUC
                .NombreLegal = Conf_Company
                .TipoDocumento = 6
                .NombreComercial = "JCH"
                .Ubigeo = Conf_Ubigeo
                .Direccion = Conf_Dir
                .Urbanizacion = "-"
                .Departamento = "LIMA"
                .Distrito = "LA VICTORIA"
                .Provincia = "LIMA"
            End With

            'CLIENTE
            With doc.Receptor
                .NroDocumento = "10435533081"
                .TipoDocumento = 6
                .NombreComercial = ""
                .NombreLegal = "CARLOS EDUARDO MAQUERA MARCA"
            End With
            doc.TotalIgv = 18
            doc.TotalIsc = 0
            doc.TotalOtrosTributos = 0

            doc.Discrepancias.Add(
                New Discrepancia With {
                    .NroReferencia = "F002-45",
                    .Tipo = "01",
                    .Descripcion = "Anulación de la Operación"
})
            doc.Relacionados.Add(
                New DocumentoRelacionado With {
                    .NroDocumento = "F002-45",
                    .TipoDocumento = "01"
                    })
            'ITEMS
            doc.Items.Add(
                New DetalleDocumento With {
                    .ID = "001",
                    .UnidadMedida = "NIU",
                    .Cantidad = 1,
                    .TotalVenta = 118,
                    .Descripcion = "PRODUCTO DE PRUEBA",
                    .CodigoItem = "101010",
                    .PrecioUnitario = 118,
                    .Impuesto = 18,
                    .TipoImpuesto = 10,
                    .Descuento = 0
                })



            '***************************************************

            NotaCredito = NotaCreXML.GenerarNotaCredito(doc)

            Dim envio As New FirmadoRequest
            envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PATH_certificado))
            envio.PasswordCertificado = pwdCertificado
            envio.TramaXmlSinFirma = serializador.GenerarXml(NotaCredito)
            envio.UnSoloNodoExtension = 1
            'Dim nomarchivo = Conf_RUC & "-" & doc.TipoDocumento & "-" & doc.IdDocumento
            'File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
            '                      Convert.FromBase64String(envio.TramaXmlSinFirma))

            Dim response As New FirmadoResponse
            response = Certificador.FirmarXML(envio)

            If Not response.Exito Then
                'Throw New Exception(response.MensajeError)
                Return response.MensajeError

            End If
            Dim envioDoc As New EnviarDocumentoRequest
            envioDoc.Ruc = Conf_RUC
            envioDoc.IdDocumento = doc.IdDocumento
            envioDoc.TipoDocumento = doc.TipoDocumento
            envioDoc.TramaXmlFirmado = response.TramaXmlFirmado

            envioDoc.UsuarioSol = "MODDATOS"
            envioDoc.ClaveSol = "MODDATOS"
            envioDoc.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"

            Dim nomarchivo = envioDoc.Ruc & "-" & envioDoc.TipoDocumento & "-" & envioDoc.IdDocumento

            File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
                                   Convert.FromBase64String(response.TramaXmlFirmado))

            Dim envioRes As New EnviarDocumento
            Dim respuestaEnvio As New EnviarDocumentoResponse
            respuestaEnvio = envioRes.EnviarDocumentoResponse(envioDoc)
            If respuestaEnvio.Exito Then
                'serializador.GenerarZip(respuestaEnvio.TramaZipCdr, respuestaEnvio.NombreArchivo)
                File.WriteAllBytes(PATH_cdr & "\R-" & respuestaEnvio.NombreArchivo, _
                                   Convert.FromBase64String(respuestaEnvio.TramaZipCdr))
                Return PATH_zip & "\R-" & respuestaEnvio.NombreArchivo
            Else
                Return respuestaEnvio.MensajeError
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return mensaje
    End Function

    Private Function hola5() As String
        Dim doc As New DocumentoElectronico
        Dim mensaje As String = ""
        Try
            doc.IdDocumento = "FT01-00005421"
            doc.Gravadas = 100
            doc.Gratuitas = 0
            doc.Exoneradas = 0
            doc.Inafectas = 0
            doc.MontoPercepcion = 0
            doc.MontoDetraccion = 0
            doc.MontoAnticipo = 0
            doc.FechaEmision = CDate(Now()).ToString("yyyy-MM-dd")
            doc.TipoDocumento = "08"
            doc.TotalVenta = 118
            doc.MontoEnLetras = convertir.Letras(doc.TotalVenta)
            doc.DescuentoGlobal = 0
            doc.Moneda = "PEN"

            'EMISOR
            With doc.Emisor
                .NroDocumento = Conf_RUC
                .NombreLegal = Conf_Company
                .TipoDocumento = 6
                .NombreComercial = "JCH"
                .Ubigeo = Conf_Ubigeo
                .Direccion = Conf_Dir
                .Urbanizacion = "-"
                .Departamento = "LIMA"
                .Distrito = "LA VICTORIA"
                .Provincia = "LIMA"
            End With

            'CLIENTE
            With doc.Receptor
                .NroDocumento = "10435533081"
                .TipoDocumento = 6
                .NombreComercial = ""
                .NombreLegal = "CARLOS EDUARDO MAQUERA MARCA"
            End With
            doc.TotalIgv = 18
            doc.TotalIsc = 0
            doc.TotalOtrosTributos = 0

            doc.Discrepancias.Add(
                New Discrepancia With {
                    .NroReferencia = "F002-45",
                    .Tipo = "01",
                    .Descripcion = "Intereses por Mora"
})
            doc.Relacionados.Add(
                New DocumentoRelacionado With {
                    .NroDocumento = "F002-45",
                    .TipoDocumento = "01"
                    })
            'ITEMS
            doc.Items.Add(
                New DetalleDocumento With {
                    .ID = "001",
                    .UnidadMedida = "NIU",
                    .Cantidad = 1,
                    .TotalVenta = 118,
                    .Descripcion = "intereses",
                    .CodigoItem = "101010",
                    .PrecioUnitario = 118,
                    .Impuesto = 18,
                    .TipoImpuesto = 10,
                    .Descuento = 0
                })

            '***************************************************
            NotaDebito = NotaDebXML.GenerarNotaDebito(doc)

            Dim envio As New FirmadoRequest
            envio.CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(PATH_certificado))
            envio.PasswordCertificado = pwdCertificado
            envio.TramaXmlSinFirma = serializador.GenerarXml(NotaDebito)
            envio.UnSoloNodoExtension = 1
            'Dim nomarchivo = Conf_RUC & "-" & doc.TipoDocumento & "-" & doc.IdDocumento
            'File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
            '                      Convert.FromBase64String(envio.TramaXmlSinFirma))

            Dim response As New FirmadoResponse
            response = Certificador.FirmarXML(envio)

            If Not response.Exito Then
                'Throw New Exception(response.MensajeError)
                Return response.MensajeError

            End If
            Dim envioDoc As New EnviarDocumentoRequest
            envioDoc.Ruc = Conf_RUC
            envioDoc.IdDocumento = doc.IdDocumento
            envioDoc.TipoDocumento = doc.TipoDocumento
            envioDoc.TramaXmlFirmado = response.TramaXmlFirmado
            envioDoc.UsuarioSol = "MODDATOS"
            envioDoc.ClaveSol = "MODDATOS"
            envioDoc.EndPointUrl = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"


            Dim nomarchivo = envioDoc.Ruc & "-" & envioDoc.TipoDocumento & "-" & envioDoc.IdDocumento

            File.WriteAllBytes(PATH_xml & "\" & nomarchivo & ".xml", _
                                   Convert.FromBase64String(response.TramaXmlFirmado))

            Dim envioRes As New EnviarDocumento
            Dim respuestaEnvio As New EnviarDocumentoResponse
            respuestaEnvio = envioRes.EnviarDocumentoResponse(envioDoc)
            If respuestaEnvio.Exito Then
                'serializador.GenerarZip(respuestaEnvio.TramaZipCdr, respuestaEnvio.NombreArchivo)
                File.WriteAllBytes(PATH_cdr & "\R-" & respuestaEnvio.NombreArchivo, _
                                   Convert.FromBase64String(respuestaEnvio.TramaZipCdr))
                Return PATH_zip & "\R-" & respuestaEnvio.NombreArchivo
            Else
                Return respuestaEnvio.MensajeError
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return mensaje
    End Function



    Private Sub btnGenerarNC_Click(sender As Object, e As EventArgs) Handles btnGenerarNC.Click
        Dim res As String = hola4()
        MsgBox(res)
    End Sub

    Private Sub btnGenerarND_Click(sender As Object, e As EventArgs) Handles btnGenerarND.Click
        Dim res As String = hola5()
        MsgBox(res)
    End Sub
End Class
