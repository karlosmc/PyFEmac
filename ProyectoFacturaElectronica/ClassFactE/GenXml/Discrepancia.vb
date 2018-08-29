Public Class Discrepancia

    Private vNroReferencia As String
    Private vTipo As String
    Private vDescripcion As String

    Public Property NroReferencia As String
        Get
            Return vNroReferencia
        End Get
        Set(value As String)
            vNroReferencia = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return vTipo
        End Get
        Set(value As String)
            vTipo = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return vDescripcion
        End Get
        Set(value As String)
            vDescripcion = value
        End Set
    End Property
End Class
