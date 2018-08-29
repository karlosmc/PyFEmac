Public Class RespuestaComunConArchivo
    Inherits RespuestaComun

    Private vNombreArchivo As String
    Public Property NombreArchivo As String
        Get
            Return vNombreArchivo
        End Get
        Set(value As String)
            vNombreArchivo = value
        End Set
    End Property


End Class
