Public Class EnviarDocumentoResponse
    Inherits RespuestaComunConArchivo

    Private vCodigoRespuesta As String
    Public Property CodigoRespuesta As String
        Get
            Return vCodigoRespuesta
        End Get
        Set(value As String)
            vCodigoRespuesta = value
        End Set
    End Property
    Private vMensajeRespuesta As String

    Public Property MensajeRespuesta As String
        Get
            Return vMensajeRespuesta
        End Get
        Set(value As String)
            vMensajeRespuesta = value
        End Set
    End Property
    Private vTramaZipCdr As String
    Public Property TramaZipCdr As String
        Get
            Return vTramaZipCdr
        End Get
        Set(value As String)
            vTramaZipCdr = value
        End Set
    End Property

    Private vNota As String
    Public Property Nota As String
        Get
            Return vNota
        End Get
        Set(value As String)
            vNota = value
        End Set
    End Property



End Class
