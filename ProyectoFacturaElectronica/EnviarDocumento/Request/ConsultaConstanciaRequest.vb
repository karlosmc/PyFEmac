Public Class ConsultaConstanciaRequest
    Inherits EnvioDocumentoComun

    Private vSerie As String
    Private vNumero As String

    Public Property Serie As String
        Get
            Return vSerie
        End Get
        Set(value As String)
            vSerie = value
        End Set
    End Property
    Public Property Numero As String
        Get
            Return vNumero
        End Get
        Set(value As String)
            vNumero = value
        End Set
    End Property

End Class
