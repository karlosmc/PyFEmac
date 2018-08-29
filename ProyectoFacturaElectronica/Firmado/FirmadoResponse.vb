Public Class FirmadoResponse
    Inherits RespuestaComun

    Private vTramaXmlFirmado As String
    Private vResumenFirma As String
    Private vValorFirma As String

    Public Property TramaXmlFirmado As String
        Get
            Return vTramaXmlFirmado
        End Get
        Set(value As String)
            vTramaXmlFirmado = value
        End Set
    End Property
    Public Property ResumenFirma As String
        Get
            Return vResumenFirma
        End Get
        Set(value As String)
            vResumenFirma = value
        End Set
    End Property
    Public Property ValorFirma As String
        Get
            Return vValorFirma
        End Get
        Set(value As String)
            vValorFirma = value
        End Set
    End Property

End Class
