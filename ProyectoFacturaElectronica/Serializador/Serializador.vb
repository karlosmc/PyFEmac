Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Configuration
Imports Ionic.Zip


Public Class Serializador

    ''' <summary>
    ''' Cadena Base64 del certificado Digital
    ''' </summary>
    ''' 
    Dim Conf_key As String = ConfigurationManager.AppSettings("key1pass").ToString
    Dim Conf_RUC As String = ConfigurationManager.AppSettings("ruc").ToString
    Dim PATH_certificado As String = ConfigurationManager.AppSettings("path_certificado").ToString
    Dim PATH_xmlGEN As String = ConfigurationManager.AppSettings("path_xmlGEN").ToString
    Dim PATH_zipGEN As String = ConfigurationManager.AppSettings("path_zipGEN").ToString
    Dim PATH_rptGEN As String = ConfigurationManager.AppSettings("path_rptGEN").ToString

    Public Property RutaCertificadoDigital() As String
        Get
            Return m_RutaCertificadoDigital
        End Get
        Set(value As String)
            m_RutaCertificadoDigital = value
        End Set
    End Property
    Private m_RutaCertificadoDigital As String
    ''' <summary>
    ''' Si el certificado digital tiene Clave se coloca aquí
    ''' </summary>
    Public Property PasswordCertificado() As String
        Get
            Return m_PasswordCertificado
        End Get
        Set(value As String)
            m_PasswordCertificado = value
        End Set
    End Property
    Private m_PasswordCertificado As String
    ''' <summary>
    ''' Hash de la Firma del Documento
    ''' </summary>
    Public Property DigestValue() As String
        Get
            Return m_DigestValue
        End Get
        Set(value As String)
            m_DigestValue = value
        End Set
    End Property
    Private m_DigestValue As String
    ''' <summary>
    ''' Tipo de Documento segun SUNAT
    ''' </summary>
    Public Property TipoDocumento() As Integer
        Get
            Return m_TipoDocumento
        End Get
        Set(value As Integer)
            m_TipoDocumento = value
        End Set
    End Property
    Private m_TipoDocumento As Integer

    Public Sub New()
        ' Factura es Por Defecto.
        TipoDocumento = 1
    End Sub
    ''' <summary>
    ''' Generar el XML en base a una Clase con el atributo Serializable
    ''' </summary>
    ''' <typeparam name="T">Clase a serializar</typeparam>
    ''' <param name="request">Instancia de la Clase</param>
    ''' <param name="nombreArchivo">Nombre del archivo resultante</param>
    ''' <returns>Devuelve la ruta del Archivo generado</returns>
    Public Function GenerarXmlFisico(Of T)(request As T, nombreArchivo As String) As String
        Dim serializer = New XmlSerializer(GetType(T))
        Dim filename As String = String.Format("{0}\{1}.xml", Directory.GetCurrentDirectory(), nombreArchivo)

        ' Dim writer As New StreamWriter(filename)
        Using writer = New StreamWriter(filename)
            'writer = New StreamWriter(filename)
            serializer.Serialize(writer, request)
        End Using

        Return filename
    End Function
    ''' <summary>
    ''' Genera el XML basado en una clase con el atributo Serializable
    ''' </summary>
    ''' <typeparam name="T">Clase a serializar</typeparam>
    ''' <param name="objectToSerialize">Instancia de la Clase</param>
    ''' <returns>Devuelve una cadena Base64 del archivo XML</returns>
    ''' 
    Public Function GenerarXml(Of T)(objectToSerialize As T) As String
        Dim serializer = New XmlSerializer(GetType(T))
        Dim resultado As String

        Using memStr = New MemoryStream()
            Using stream = New StreamWriter(memStr, Encoding.GetEncoding("ISO-8859-1"))
                ' Como debemos devolver el XML Firmado aplicamos la firma
                ' Segun el Certificado Digital escogido.
                serializer.Serialize(stream, objectToSerialize)
            End Using
            ' Con firma.
            resultado = Convert.ToBase64String(memStr.ToArray())
            ' Sin Firma.
            'resultado = Convert.ToBase64String(memStr.ToArray())

        End Using
        Return resultado

    End Function
    ''' <summary>
    ''' Genera el ZIP del XML basandose en la trama del XML.
    ''' </summary>
    ''' <param name="tramaXml">Cadena Base64 con el contenido del XML</param>
    ''' <param name="nombreArchivo">Nombre del archivo ZIP</param>
    ''' <returns>Devuelve Cadena Base64 del archizo ZIP</returns>
    Public Function GenerarZip(tramaXml As String, nombreArchivo As String) As String
        Dim memOrigen = New MemoryStream(Convert.FromBase64String(tramaXml))
        Dim memDestino = New MemoryStream()
        Dim resultado As String

        Dim ZIP = New ZipFile("")

        Using fileZip = New ZipFile(String.Format("{0}.zip", nombreArchivo))

            fileZip.AddEntry(String.Format("{0}.xml", nombreArchivo), memOrigen)
            fileZip.Save(memDestino)
            resultado = Convert.ToBase64String(memDestino.ToArray())

        End Using
        ' Liberamos memoria RAM.
        memOrigen.Close()
        memDestino.Close()

        Return resultado
    End Function

    Public Function FirmarXml(tramaXml As String) As String
        ' Vamos a firmar el XML con la ruta del certificado que está como serializado.
        Dim certificate As X509Certificate2 = New X509Certificate2()
        certificate.Import(RutaCertificadoDigital, PasswordCertificado, X509KeyStorageFlags.MachineKeySet)

        Dim xmlDoc As XmlDocument = New XmlDocument()

        Dim resultado As String

        Using documento = New MemoryStream(Convert.FromBase64String(tramaXml))
            xmlDoc.PreserveWhitespace = True
            xmlDoc.Load(documento)
            Dim tipo As Integer

            If TipoDocumento = 1 OrElse TipoDocumento = 2 OrElse TipoDocumento = 3 OrElse TipoDocumento = 4 Then
                tipo = 1
            Else
                tipo = 0
            End If
            ' PEGADO AQUI
            Dim nodoExtension = xmlDoc.GetElementsByTagName("ExtensionContent", EspacioNombres.ext).Item(tipo) ' para comprobantes es 1 
            If nodoExtension Is Nothing Then
                Throw New InvalidOperationException("No se pudo encontrar el nodo ExtensionContent en el XML")
            End If

            nodoExtension.RemoveAll()

            ' Creamos el objeto SignedXml.
            Dim signedXml = New SignedXml(xmlDoc)
            signedXml.SigningKey = certificate.PrivateKey
            'signedXml.SigningKey = DirectCast(certificate.PrivateKey, RSA)
            'signedXml.SigningKey = certificate.PrivateKey
            Dim xmlSignature = signedXml.Signature

            Dim env = New XmlDsigEnvelopedSignatureTransform()

            Dim reference = New Reference(String.Empty)
            reference.AddTransform(env)
            xmlSignature.SignedInfo.AddReference(reference)

            Dim keyInfo = New KeyInfo()
            Dim x509Data = New KeyInfoX509Data(certificate)

            x509Data.AddSubjectName(certificate.Subject)

            keyInfo.AddClause(x509Data)
            xmlSignature.KeyInfo = keyInfo
            xmlSignature.Id = "signatureKG"
            signedXml.ComputeSignature()

            If reference.DigestValue IsNot Nothing Then
                DigestValue = Convert.ToBase64String(reference.DigestValue)
            End If

            'nodoExtension.AppendChild(signature) BORRADO MOMENTANEAMENTE
            nodoExtension.AppendChild(signedXml.GetXml)
            

            Dim settings = New XmlWriterSettings()
            settings.Encoding = Encoding.GetEncoding("ISO-8859-1")


            Using memDoc = New MemoryStream()

                Using writer = XmlWriter.Create(memDoc, settings)
                    xmlDoc.WriteTo(writer)
                End Using


                resultado = Convert.ToBase64String(memDoc.ToArray())
            End Using
        End Using

        Return resultado
    End Function


    'Public Function SerializarDocumento(documento As Object, tipodoc As Integer) As String

    '    'Dim documento As New Object
    '    Dim ruta2 As String = ""
    '    Dim nombrearchivo As String = ""
    '    '  Dim serializador As New Serializador
    '    Select Case tipodoc
    '        Case 1
    '            documento = CType(documento, VoidedDocuments)
    '            'documento = New VoidedDocuments
    '            TipoDocumento = 0
    '        Case 2
    '            documento = CType(documento, SummaryDocuments)
    '            'documento = New SummaryDocuments
    '            TipoDocumento = 0
    '        Case 3
    '            documento = CType(documento, Invoice)
    '            'documento = New Invoice
    '            TipoDocumento = 1
    '    End Select

    '    RutaCertificadoDigital = PATH_certificado
    '    PasswordCertificado = Conf_key

    '    'serializador.GenerarmlFisico(documento, "Carlos")
    '    'serializador.TipoDocumento = 0

    '    Dim tramaXmlFirmado = GenerarXml(documento)
    '    ' Como el texto devuelto es un Base64 lo convertimos a un array de Bytes.
    '    Dim tramaBinaria = New MemoryStream(Convert.FromBase64String(tramaXmlFirmado))
    '    nombrearchivo = Conf_RUC & "-" & documento.ID
    '    Dim ruta = String.Format("{0}\{1}.xml", PATH_xmlGEN, nombrearchivo)
    '    Using fs = New FileStream(ruta, FileMode.Create)
    '        Dim buffer As Byte() = New Byte(tramaBinaria.Length) {}
    '        Dim sourceBytes As Integer
    '        Do
    '            sourceBytes = tramaBinaria.Read(buffer, 0, buffer.Length)
    '            fs.Write(buffer, 0, sourceBytes)
    '        Loop While sourceBytes > 0
    '    End Using

    '    ' Abrir el documento XML con el programa predeterminado de extensiones XML
    '    'System.Diagnostics.Process.Start(ruta)

    '    Dim tramaBinaria2 = New MemoryStream(Convert.FromBase64String(GenerarZip(tramaXmlFirmado, nombrearchivo)))

    '    ruta2 = String.Format("{0}\{1}.zip", PATH_zipGEN, nombrearchivo)
    '    Using fs1 = New FileStream(ruta2, FileMode.Create)
    '        Dim buffer1 As Byte() = New Byte(tramaBinaria2.Length) {}
    '        Dim sourceBytes1 As Integer
    '        Do
    '            sourceBytes1 = tramaBinaria2.Read(buffer1, 0, buffer1.Length)
    '            fs1.Write(buffer1, 0, sourceBytes1)
    '        Loop While sourceBytes1 > 0
    '    End Using
    '    Return nombrearchivo
    'End Function

    Private Function firmar2(tramaxml As String) As String
        Try
            Using local_xmlArchivo As New MemoryStream(Convert.FromBase64String(tramaxml))



                'Dim local_nombreXML As String = System.IO.Path.GetFileName(local_xmlArchivo)

                'Dim local_typoDocumento As String

                'local_typoDocumento = local_nombreXML.Substring(12, 2)

                Dim MiCertificado As X509Certificate2 = New X509Certificate2("E:\ELCENTENARIO\SoftVB.Net\FirmadoCarlosMc\CarlosMc.Firmado.Windows\probar.pfx", "andale22")
                Dim xmlDoc As XmlDocument = New XmlDocument()
                xmlDoc.PreserveWhitespace = True
                xmlDoc.Load(local_xmlArchivo)

                Dim signedXml As SignedXml = New SignedXml(xmlDoc)

                signedXml.SigningKey = MiCertificado.PrivateKey

                Dim KeyInfo As KeyInfo = New KeyInfo()

                Dim Reference As Reference = New Reference()
                Reference.Uri = ""

                Reference.AddTransform(New XmlDsigEnvelopedSignatureTransform())

                signedXml.AddReference(Reference)

                Dim X509Chain As X509Chain = New X509Chain()
                X509Chain.Build(MiCertificado)

                Dim local_element As X509ChainElement = X509Chain.ChainElements(0)
                Dim x509Data As KeyInfoX509Data = New KeyInfoX509Data(local_element.Certificate)
                Dim subjectName As String = local_element.Certificate.Subject

                x509Data.AddSubjectName(subjectName)
                KeyInfo.AddClause(x509Data)

                signedXml.KeyInfo = KeyInfo
                signedXml.ComputeSignature()

                Dim signature As XmlElement = signedXml.GetXml()
                signature.Prefix = "ds"
                signedXml.ComputeSignature()

                For Each node As XmlNode In signature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
                    If node.LocalName = "Signature" Then
                        Dim newAttribute As XmlAttribute = xmlDoc.CreateAttribute("Id")
                        newAttribute.Value = "SignatureSP"
                        node.Attributes.Append(newAttribute)
                        Exit For
                    End If
                Next node

                Dim local_xpath As String
                Dim nsMgr As XmlNamespaceManager
                nsMgr = New XmlNamespaceManager(xmlDoc.NameTable)
                nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
                nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
                nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")

                'Select Case local_typoDocumento
                '    Case "01", "03" 'factura / boleta
                '        nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                '        local_xpath = "/tns:Invoice/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                '    Case "07" 'nota de credito
                '        nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                '        local_xpath = "/tns:CreditNote/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                '    Case "08" 'nota de debito
                '        nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                '        local_xpath = "/tns:DebitNote/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                '    Case "20"  'Retencion
                '        nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1")
                '        local_xpath = "/tns:Retention/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                '    Case "40"  'Percepcion
                '        nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1")
                '        local_xpath = "/tns:Perception/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                '    Case "RA"  'Communicacion de baja
                '        nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
                '        local_xpath = "/tns:VoidedDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                '    Case "RC" 'Resumen de diario
                '        nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")
                '        local_xpath = "/tns:SummaryDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                'End Select

                nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                local_xpath = "/tns:Invoice/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"


                nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
                nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
                nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
                nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
                nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
                nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")

                xmlDoc.SelectSingleNode(local_xpath, nsMgr).AppendChild(xmlDoc.ImportNode(signature, True))
                Dim resultado As String
                Dim settings = New XmlWriterSettings()
                settings.Encoding = Encoding.GetEncoding("ISO-8859-1")


                Using memDoc = New MemoryStream()

                    Using writer = XmlWriter.Create(memDoc, settings)
                        xmlDoc.WriteTo(writer)
                    End Using


                    resultado = Convert.ToBase64String(memDoc.ToArray())
                End Using



                'xmlDoc.Save(local_xmlArchivo)

                Dim nodeList As XmlNodeList = xmlDoc.GetElementsByTagName("ds:Signature")

                'el nodo <ds:Signature> debe existir unicamente 1 vez
                If nodeList.Count <> 1 Then
                    Throw New Exception("Se produjo un error en la firma del documento")
                End If
                signedXml.LoadXml(CType(nodeList(0), XmlElement))

                'verificacion de la firma generada
                If signedXml.CheckSignature() = False Then
                    Throw New Exception("Se produjo un error en la firma del documento")
                End If
                Return resultado
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function GenerarDocumentoRespuesta(constanciaRecepcion As String) As EnviarDocumentoResponse
        Dim response As EnviarDocumentoResponse = New EnviarDocumentoResponse
        Dim returnByte As Byte() = Convert.FromBase64String(constanciaRecepcion)
        Using memRespuesta As New MemoryStream(returnByte)
            Using zip As ZipFile = ZipFile.Read(memRespuesta)
                For Each e As ZipEntry In zip
                    If e.FileName.EndsWith(".xml") Then
                        Using ms As New MemoryStream()
                            e.Extract(ms)
                            ms.Position = 0
                            Dim responseReader = New StreamReader(ms)
                            Dim responseString As String = responseReader.ReadToEnd()
                            Try
                                Dim xmlDoc As New XmlDocument()
                                xmlDoc.LoadXml(responseString)

                                Dim xmlnsManager As XmlNamespaceManager = New System.Xml.XmlNamespaceManager(xmlDoc.NameTable)

                                xmlnsManager.AddNamespace("ar", EspacioNombres.ar)
                                xmlnsManager.AddNamespace("cac", EspacioNombres.cac)
                                xmlnsManager.AddNamespace("cbc", EspacioNombres.cbc)

                                'response.CodigoRespuesta = xmlDoc.SelectSingleNode(EspacioNombres.nodoId, xmlnsManager).InnerText
                                'ResponseDate = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseDate, xmlnsManager).InnerText
                                'ResponseTime = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseTime, xmlnsManager).InnerText

                                response.CodigoRespuesta = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseCode, xmlnsManager).InnerText
                                response.MensajeRespuesta = xmlDoc.SelectSingleNode(EspacioNombres.nodoDescription, xmlnsManager).InnerText

                                If Not IsNothing(xmlDoc.SelectSingleNode(EspacioNombres.nodoNote, xmlnsManager)) Then
                                    response.Nota = xmlDoc.SelectSingleNode(EspacioNombres.nodoNote, xmlnsManager).InnerText
                                End If

                                response.NombreArchivo = e.FileName
                                response.TramaZipCdr = constanciaRecepcion
                                response.Exito = True
                            Catch ex As Exception
                                response.MensajeError = ex.Message
                                response.Pila = ex.StackTrace
                                response.Exito = False
                            End Try
                        End Using
                    End If
                Next
            End Using
            Return response
        End Using
    End Function


End Class


