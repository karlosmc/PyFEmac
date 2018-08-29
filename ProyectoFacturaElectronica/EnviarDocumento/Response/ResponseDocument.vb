Imports Ionic.Zip
Imports System.IO

Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Public Class ResponseDocument

    Public Function responder(rutaarchivo As String)
        Dim node_ID As String = ""
        Dim ResponseDate As String = ""
        Dim ResponseTime As String = ""

        Dim ResponseCode As String = ""
        Dim Description As String = ""

        Using zip As ZipFile = ZipFile.Read(rutaarchivo)
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

                            node_ID = xmlDoc.SelectSingleNode(EspacioNombres.nodoId, xmlnsManager).InnerText
                            ResponseDate = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseDate, xmlnsManager).InnerText
                            ResponseTime = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseTime, xmlnsManager).InnerText

                            ResponseCode = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseCode, xmlnsManager).InnerText

                            Description = xmlDoc.SelectSingleNode(EspacioNombres.nodoDescription, xmlnsManager).InnerText
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    End Using
                    Return Description
                End If
            Next
        End Using
    End Function

End Class
