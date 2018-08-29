Public Class FirmadoRequest

    Private vCertificadoDigital As String
    Private vPasswordCertificado As String
    Private vTramaXmlSinFirma As String
    Private vUnSoloNodoExtension As String

    Public Property CertificadoDigital As String
        Get
            Return vCertificadoDigital
        End Get
        Set(value As String)
            vCertificadoDigital = value
        End Set
    End Property
    Public Property PasswordCertificado As String
        Get
            Return vPasswordCertificado
        End Get
        Set(value As String)
            vPasswordCertificado = value
        End Set
    End Property
    Public Property TramaXmlSinFirma As String
        Get
            Return vTramaXmlSinFirma
        End Get
        Set(value As String)
            vTramaXmlSinFirma = value
        End Set
    End Property
    Public Property UnSoloNodoExtension As Integer
        Get
            Return vUnSoloNodoExtension
        End Get
        Set(value As Integer)
            vUnSoloNodoExtension = value
        End Set
    End Property

End Class
