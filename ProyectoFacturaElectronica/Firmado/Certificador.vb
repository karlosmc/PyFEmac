Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Configuration
Imports Ionic.Zip
Imports System.Threading.Tasks
Public Class Certificador

    Public Function FirmarXML(envio As FirmadoRequest) As FirmadoResponse


        Dim response As FirmadoResponse = New FirmadoResponse

        Dim certificate As X509Certificate2 = New X509Certificate2()
        certificate.Import(Convert.FromBase64String(envio.CertificadoDigital), envio.PasswordCertificado, X509KeyStorageFlags.MachineKeySet)

        Dim xmlDoc As XmlDocument = New XmlDocument()

        Dim resultado As String
        Dim betterBytes = Convert.FromBase64String(envio.TramaXmlSinFirma)

        Using documento = New MemoryStream(betterBytes)
            xmlDoc.PreserveWhitespace = True
            xmlDoc.Load(documento)
            Dim indicenodo As Integer = envio.UnSoloNodoExtension

            ' PEGADO AQUI
            Dim nodoExtension = xmlDoc.GetElementsByTagName("ExtensionContent", EspacioNombres.ext).Item(indicenodo) ' para comprobantes es 1 
            If nodoExtension Is Nothing Then
                response.Exito = False
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
            xmlSignature.Id = ""
            signedXml.ComputeSignature()

            If reference.DigestValue IsNot Nothing Then
                response.ResumenFirma = Convert.ToBase64String(reference.DigestValue)
                response.ValorFirma = Convert.ToBase64String(signedXml.SignatureValue)
            End If

            'Dim signature As XmlElement = signedXml.GetXml()
            'For Each node As XmlNode In Signature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
            '    node.Prefix = "ds"
            '    If node.LocalName = "Signature" Then
            '        Dim newAttribute As XmlAttribute = xmlDoc.CreateAttribute("Id")
            '        newAttribute.Value = "SignatureSP"
            '        node.Attributes.Append(newAttribute)
            '    End If
            'Next node


            nodoExtension.AppendChild(signedXml.GetXml)

            Dim sal As Boolean = False
            Dim signature As XmlElement = xmlDoc.DocumentElement
            For Each node As XmlNode In signature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
                For Each n As XmlNode In node
                    If n.LocalName = "X509SubjectName" Then
                        node.RemoveChild(n)
                        sal = True
                        Exit For
                    End If
                Next
                If sal = True Then Exit For
            Next node


            'Dim xmlDigitalSignature As XmlElement = xmlDoc.DocumentElement
            'xmlDigitalSignature.Prefix = "ds"
            'For Each node As XmlNode In xmlDigitalSignature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
            '    If node.LocalName = "Signature" Then

            '        Dim newAttribute As XmlAttribute = xmlDoc.CreateAttribute("Id")
            '        newAttribute.Value = "SignatureSP"
            '        node.Attributes.Append(newAttribute)

            '    End If
            '    node.Prefix = "ds"
            '    AgregaPrefijo(node)

            'Next node

            'For Each node As XmlNode In xmlDigitalSignature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
            '    If node.LocalName = "Signature" Then
            '        If node.LocalName = "Signature" Then
            '            Dim atrrcoll As XmlAttributeCollection = node.Attributes
            '            For i = 0 To atrrcoll.Count - 1
            '                MsgBox(atrrcoll.ItemOf(i).Name)
            '                MsgBox(atrrcoll.ItemOf(i).Value)
            '            Next

            '        End If
            '        'Dim newAttribute As XmlAttribute = xmlDoc.CreateAttribute("Id")
            '        'newAttribute.Value = "SignatureSP"
            '        'node.Attributes.Append(newAttribute)

            '    End If

            'Next node


            Dim settings = New XmlWriterSettings()
            settings.Encoding = Encoding.GetEncoding("ISO-8859-1")


            Using memDoc = New MemoryStream()

                Using writer = XmlWriter.Create(memDoc, settings)
                    xmlDoc.WriteTo(writer)
                End Using
                resultado = Convert.ToBase64String(memDoc.ToArray())
            End Using
        End Using
        response.Exito = True
        response.TramaXmlFirmado = resultado
        Return response
      
    End Function

    'Private Sub AgregaPrefijo(ByVal n As XmlNode)
    '    Dim nodos As String() = {"SignedInfo", "KeyInfo", "CanonicalizationMethod", "SignatureMethod", "Reference", "Transforms", "Transform" & _
    '                            "DigestMethod", "DigestValue"}
    '    Dim reference As Integer = 0
    '    Try
    '        For Each item As XmlElement In n.Cast(Of XmlNode)().Where(Function(e) e.NodeType = XmlNodeType.Element)
    '            Dim nombre As String = item.Name
    '            '   If nodos.Contains(nombre) Then
    '            item.Prefix = "ds"
    '            If item.HasChildNodes Then
    '                AgregaPrefijo(item)
    '            End If
    '            'End If
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

End Class
