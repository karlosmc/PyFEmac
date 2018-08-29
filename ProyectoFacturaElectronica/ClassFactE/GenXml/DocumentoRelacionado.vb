Public Class DocumentoRelacionado

    Private vNroDocumento As String
    Private vTipoDocumento As String

    Public Property NroDocumento As String
        Get
            Return vNroDocumento
        End Get
        Set(value As String)
            vNroDocumento = value
        End Set
    End Property
    Public Property TipoDocumento As String
        Get
            Return vTipoDocumento
        End Get
        Set(value As String)
            vTipoDocumento = value
        End Set
    End Property

End Class
