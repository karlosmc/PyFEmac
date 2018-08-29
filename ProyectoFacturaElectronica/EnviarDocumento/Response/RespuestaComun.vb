Public Class RespuestaComun

    Private vExito As Boolean
    Private vMensajeError As String
    Private vPila As String


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
    Public Property Pila As String
        Get
            Return vPila
        End Get
        Set(value As String)
            vPila = value
        End Set
    End Property



End Class
