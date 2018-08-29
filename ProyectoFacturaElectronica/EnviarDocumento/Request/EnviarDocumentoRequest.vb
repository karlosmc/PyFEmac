Public Class EnviarDocumentoRequest
    Inherits EnvioDocumentoComun

    Private vTramaXmlFirmado As String
    Public Property TramaXmlFirmado As String
        Get
            Return vTramaXmlFirmado
        End Get
        Set(value As String)
            vTramaXmlFirmado = value
        End Set
    End Property

End Class
