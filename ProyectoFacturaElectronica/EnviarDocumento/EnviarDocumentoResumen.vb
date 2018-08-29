Public Class EnviarDocumentoResumen

    Dim Serializador As New Serializador
    Dim ServiceConsume As New ServiceConsume


    Public Function EnviarResumenResponse(request As EnviarDocumentoRequest) As EnviarResumenResponse
        Dim response = New EnviarResumenResponse
        Dim nombreArchivo As String = request.Ruc & "-" & request.IdDocumento

        ServiceConsume.Inicializar(New ParametrosConexion With
                                   {
                                       .EndPointUrl = request.EndPointUrl,
                                       .Password = request.ClaveSol,
                                       .Ruc = request.Ruc,
                                       .UserName = request.UsuarioSol
                                   })
        Try
            Dim tramaZip = Serializador.GenerarZip(request.TramaXmlFirmado, nombreArchivo)
            Dim docSunat As New DocumentoSunat
            docSunat.TramaXml = tramaZip
            docSunat.NombreArchivo = nombreArchivo & ".zip"
            Dim resultado = ServiceConsume.EnviarResumen(docSunat)

            If resultado.Exito Then
                response.NroTicket = resultado.NumeroTicket
                response.Exito = True
                response.NombreArchivo = nombreArchivo
            Else
                response.MensajeError = resultado.MensajeError
                response.Exito = False
            End If
        Catch ex As Exception
            response.MensajeError = ex.Message
            response.Pila = ex.StackTrace
            response.Exito = False
        End Try
        Return response
    End Function

End Class
