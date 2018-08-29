


Public NotInheritable Class ErrorGenerico
    Private Sub New()
    End Sub

    Public Const Codigo As String = "10101"
    Public Const Mensaje As String = "Error Genérico detectado"

End Class

Public NotInheritable Class ErrorBaseDatos
    Private Sub New()
    End Sub

    Public Const Codigo As String = "10102"
    Public Const Mensaje As String = "Error de Base de Datos"

End Class

Public NotInheritable Class ErrorSUNAT
    Private Sub New()
    End Sub

    Public Const Codigo As String = "10103"
    Public Const Mensaje As String = "Error con WebService SUNAT"
End Class

Public NotInheritable Class ErrorValidacion
    Private Sub New()
    End Sub
    Public Const Codigo As String = "10104"
    Public Const Mensaje As String = "Error de Validación"
End Class

Public NotInheritable Class MensajeExitoso
    Private Sub New()
    End Sub
    Public Const Codigo As String = "10200"
    Public Const Mensaje As String = "Enviado Correctamente"
End Class

Public Class Constantes
    Public Const FormatoFecha As String = "yyyy-MM-dd"
    Public Const FormatoNumerico As String = "###0.#0"
End Class
