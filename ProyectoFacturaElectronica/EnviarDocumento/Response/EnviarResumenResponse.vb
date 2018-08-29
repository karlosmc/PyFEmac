Public Class EnviarResumenResponse
    Inherits RespuestaComunConArchivo

    Private vNroTicket As String
    Public Property NroTicket As String
        Get
            Return vNroTicket
        End Get
        Set(value As String)
            vNroTicket = value
        End Set
    End Property
End Class
