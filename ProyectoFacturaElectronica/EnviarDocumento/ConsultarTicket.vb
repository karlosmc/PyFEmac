Public Class ConsultarTicket

    Dim Serializador As New Serializador
    Dim ServiceConsume As New ServiceConsume
    Public Function ConsultarTicket(request As ConsultaTicketRequest) As EnviarDocumentoResponse
        Dim response = New EnviarDocumentoResponse
        ServiceConsume.Inicializar(New ParametrosConexion With
                                  {
                                      .EndPointUrl = request.EndPointUrl,
                                      .Password = request.ClaveSol,
                                      .Ruc = request.Ruc,
                                      .UserName = request.UsuarioSol
                                  })
        Try

            Dim resultado = ServiceConsume.ConsultarTicket(request.NroTicket)
            If Not resultado.Exito Then
                response.Exito = False
                response.MensajeError = resultado.MensajeError
            Else
                response = Serializador.GenerarDocumentoRespuesta(resultado.ConstanciaDeRecepcion)
            End If
        Catch ex As Exception
            response.MensajeError = IIf(ex.Source = "DotNetZip", "el Ticket no existe", ex.Message)
            response.Pila = ex.StackTrace
            response.Exito = False
        End Try
        Return response
    End Function

End Class
