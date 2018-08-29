Public Class DocumentoBaja
    Inherits DocumentoResumenDetalle

    Private vCorrelativo As String
    Public Property Correlativo As String
        Get
            Return vCorrelativo
        End Get
        Set(value As String)
            vCorrelativo = value
        End Set
    End Property
    Private vMotivoBaja As String
    Public Property MotivoBaja As String
        Get
            Return vMotivoBaja
        End Get
        Set(value As String)
            vMotivoBaja = value
        End Set
    End Property

End Class
