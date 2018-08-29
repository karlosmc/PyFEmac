Public Class EnviarDocumento

    'Dim Serializador As New Serializador
    'Dim ServiceConsume As New ServiceConsume
    Public Function EnviarDocumentoResponse(request As EnviarDocumentoRequest) As EnviarDocumentoResponse
        Dim Serializador As New Serializador
        Dim ServiceConsume As New ServiceConsume
        Dim response = New EnviarDocumentoResponse
        Dim nombreArchivo As String = request.Ruc & "-" & request.TipoDocumento & "-" & request.IdDocumento
        Dim tramaZip = Serializador.GenerarZip(request.TramaXmlFirmado, nombreArchivo)

        ServiceConsume.Inicializar(New ParametrosConexion With
                                   {
                                       .EndPointUrl = request.EndPointUrl,
                                       .Password = request.ClaveSol,
                                       .Ruc = request.Ruc,
                                       .UserName = request.UsuarioSol
                                   })

        Dim docSunat As New DocumentoSunat
        docSunat.TramaXml = tramaZip
        docSunat.NombreArchivo = nombreArchivo & ".zip"
        Dim resultado = ServiceConsume.EnviarDocumento(docSunat)

        If Not resultado.Exito Then
            response.Exito = False
            response.MensajeError = resultado.MensajeError
        Else

            response = Serializador.GenerarDocumentoRespuesta(resultado.ConstanciaDeRecepcion)
            response.NombreArchivo = docSunat.NombreArchivo
            'response.TramaZipCdr = resultado.ConstanciaDeRecepcion
        End If
        Return response
    End Function
End Class
