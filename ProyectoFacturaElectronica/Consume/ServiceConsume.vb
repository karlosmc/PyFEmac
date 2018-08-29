Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ProyectoFacturaElectronica.Beta1
Imports System.ServiceModel.Description
Imports System.ServiceModel.Security

Public Class ServiceConsume
    'Dim wService As New Beta.billServiceClient("BillServicePort")
    Dim wService As New Beta1.billServiceClient
    Sub New()
        'wService = New Beta1.billServiceClient
        'ServicePointManager.UseNagleAlgorithm = True
        'ServicePointManager.Expect100Continue = False
        'ServicePointManager.CheckCertificateRevocationList = True
        '        wService.b()
    End Sub

    Private Function CreateBinding() As Binding
        Dim binding = New BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential)
        Dim elements = binding.CreateBindingElements
        elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
        Return New CustomBinding(elements)
    End Function

    Public Sub Inicializar(parametros As ParametrosConexion)
        ServicePointManager.UseNagleAlgorithm = True
        ServicePointManager.Expect100Continue = False
        ServicePointManager.CheckCertificateRevocationList = True
        wService = New billServiceClient(CreateBinding, New EndpointAddress(parametros.EndPointUrl))
        wService.ClientCredentials.UserName.UserName = parametros.Ruc & parametros.UserName
        wService.ClientCredentials.UserName.Password = parametros.Password
    End Sub
    Public Function EnviarDocumento(Documento As DocumentoSunat) As RespuestaSincrono
        Dim dataOrigen = Convert.FromBase64String(Documento.TramaXml)
        Dim response As New RespuestaSincrono
        Try
            wService.Open()
            Dim returnbyte() As Byte = wService.sendBill(Documento.NombreArchivo, dataOrigen, "")
            wService.Close()

            response.ConstanciaDeRecepcion = Convert.ToBase64String(returnbyte)
            response.Exito = True

        Catch ex As System.ServiceModel.FaultException
            response.Exito = False
            response.MensajeError = String.Concat(ex.Code.Name, ex.Code, ex.Message)
        Catch ex As Exception
            response.MensajeError = ex.Message
            response.Exito = False
        End Try
        Return response
    End Function

    Public Function EnviarResumen(Documento As DocumentoSunat) As RespuestaAsincrono

        Dim dataOrigen = Convert.FromBase64String(Documento.TramaXml)

        Dim respuesta As New RespuestaAsincrono
        Try
            wService.Open()
            Dim ticket As String = wService.sendSummary(Documento.NombreArchivo, dataOrigen, "")
            wService.Close()
            respuesta.NumeroTicket = ticket
            respuesta.Exito = True
        Catch ex As System.ServiceModel.FaultException
            respuesta.MensajeError = String.Concat(ex.Code.Name, ex.Message)
        End Try
        Return respuesta
    End Function

    Public Function ConsultarTicket(ByVal pticket As String) As RespuestaSincrono
        '  Dim Ruta As String = System.IO.Directory.GetCurrentDirectory()
        Dim respuesta As New RespuestaSincrono
        Try
            wService.Open()
            Dim returnstring As Beta1.statusResponse = wService.getStatus(pticket)
            wService.Close()

            'MsgBox(returnstring)
            Dim retorno = (returnstring.statusCode <> "98")

            respuesta.ConstanciaDeRecepcion = IIf(retorno, Convert.ToBase64String(returnstring.content), "Aún en proceso")
            respuesta.Exito = True

        Catch ex As System.ServiceModel.FaultException
            respuesta.MensajeError = ex.Message
            respuesta.Exito = False
        End Try
        Return respuesta
    End Function
End Class
