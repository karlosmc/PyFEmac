Imports System
Imports System.Xml
Imports System.Text
Imports System.Runtime.InteropServices

Imports System.Xml.Schema
Imports System.Windows.Forms


Namespace validarxml
    <ClassInterface(ClassInterfaceType.AutoDual)> _
    <ProgId("validarxml")> _
    Public Class validarxml

        Public Resultado As Boolean
        Public txtresultado As String
        Private Sub AdminEventoValidacion(sender As Object, args As ValidationEventArgs)
            Resultado = False
        End Sub
        Public Function validarXML(ByVal txtxml As String, ByVal txtxsd As String) As String
            Resultado = True
            txtresultado = "OK"
            'DESDE EL LLAMADO SE DEBERA VALIDAR LA EXISTENCIA DE LOS ARCHIVOS ENVIADOS COMO PARAMETROS
            'Dim xmlR As New XmlTextReader(txtxml)
            'Dim xsdR As New XmlValidatingReader(xmlR)
            Dim xsdR1 As New XmlReaderSettings
            Try
                xsdR1.Schemas.Add(Nothing, txtxsd)
                xsdR1.ValidationType = ValidationType.Schema
                'xsdR1.ValidationType = ValidationType.Schema

                AddHandler xsdR1.ValidationEventHandler, New ValidationEventHandler(AddressOf AdminEventoValidacion)

                Dim reader As XmlReader = XmlReader.Create(New XmlTextReader(txtxml), xsdR1)

                While reader.Read
                    Application.DoEvents()
                End While
                reader.Close()
                'xsdR.Close()
            Catch ex As Exception
                txtresultado = ex.Message
            End Try
            ' SI NO HAY NINGUN ERROR REVOLVERA OK  DE LO CONTRARIO DEVOLVERA ERROR
            'ReaderOptions.clo
            Return txtresultado
        End Function

    End Class
End Namespace