
Public MustInherit Class DocumentoResumenDetalle

    Private vID As Integer
    Public Property ID As Integer
        Get
            Return vID
        End Get
        Set(value As Integer)
            vID = value
        End Set
    End Property

    Private vTipoDocumento As String
    Public Property TipoDocumento As String
        Get
            Return vTipoDocumento
        End Get
        Set(value As String)
            vTipoDocumento = value
        End Set
    End Property


    Private vSerie As String
    Public Property Serie As String
        Get
            Return vSerie
        End Get
        Set(value As String)
            vSerie = value
        End Set
    End Property


End Class
