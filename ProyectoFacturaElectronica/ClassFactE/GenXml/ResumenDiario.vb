
Public Class ResumenDiario
    Inherits DocumentoResumen

    Private vResumenes As List(Of GrupoResumenNuevo)
    Public Property Resumenes As List(Of GrupoResumenNuevo)
        Get
            Return vResumenes
        End Get
        Set(value As List(Of GrupoResumenNuevo))
            vResumenes = value
        End Set
    End Property

    Public Sub New()
        Resumenes = New List(Of GrupoResumenNuevo)
    End Sub


End Class
