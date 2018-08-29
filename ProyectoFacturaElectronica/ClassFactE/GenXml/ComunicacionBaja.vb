Public Class ComunicacionBaja
    Inherits DocumentoResumen

    Private vBajas As List(Of DocumentoBaja)
    Public Property Bajas As List(Of DocumentoBaja)
        Get
            Return vBajas
        End Get
        Set(value As List(Of DocumentoBaja))
            vBajas = value
        End Set
    End Property
    Public Sub New()
        Bajas = New List(Of DocumentoBaja)
    End Sub
End Class
