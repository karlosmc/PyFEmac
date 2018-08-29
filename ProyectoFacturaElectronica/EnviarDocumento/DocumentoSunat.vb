Public Class DocumentoSunat

    Private vTramaXml As String
    Public Property TramaXml As String
        Get
            Return vTramaXml
        End Get
        Set(value As String)
            vTramaXml = value
        End Set
    End Property

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
