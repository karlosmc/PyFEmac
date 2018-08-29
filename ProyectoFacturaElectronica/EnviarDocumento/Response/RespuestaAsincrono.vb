Public Class RespuestaAsincrono

    Private vNumeroTicket As String
    Private vExito As Boolean
    Private vMensajeError As String


    Public Property NumeroTicket As String
        Get
            Return vNumeroTicket
        End Get
        Set(value As String)
            vNumeroTicket = value
        End Set
    End Property
    Public Property Exito As Boolean
        Get
            Return vExito
        End Get
        Set(value As Boolean)
            vExito = value
        End Set
    End Property
    Public Property MensajeError As String
        Get
            Return vMensajeError
        End Get
        Set(value As String)
            vMensajeError = value
        End Set
    End Property


End Class
