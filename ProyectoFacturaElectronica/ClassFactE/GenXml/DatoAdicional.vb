Public Class DatoAdicional

    Private vCodigo As String
    Public Property Codigo As String
        Get
            Return vCodigo
        End Get
        Set(value As String)
            vCodigo = value
        End Set
    End Property

    Private vContenido As String
    Public Property Contenido As String
        Get
            Return vContenido
        End Get
        Set(value As String)
            vContenido = value
        End Set
    End Property

End Class
