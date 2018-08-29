Public Class DocumentoResponse
    Inherits RespuestaComun

    Private vTramaXmlSinFirma As String
    Public Property TramaXmlSinFirma As String
        Get
            Return vTramaXmlSinFirma
        End Get
        Set(value As String)
            vTramaXmlSinFirma = value
        End Set
    End Property

End Class
