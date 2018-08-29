Public Class TipoDatoAdicionalesNE

    Private objTipoDatoAdicionales As ClsTipoDatoAdicionales
    Private objHelper As clsHelper

    Public Sub New()
        objTipoDatoAdicionales = New ClsTipoDatoAdicionales
        objHelper = New clsHelper
    End Sub
    Public Function AgregarTipoDatoAdicionales(ByVal objTipoDatoAdicionalesE As TipoDatoAdicionalesEN) As String
        Return objTipoDatoAdicionales.AgregarTipoDatoAdicionales(objTipoDatoAdicionalesE)
    End Function
    Public Function ActualizarTipoDatoAdicionales(ByVal objTipoDatoAdicionalesE As TipoDatoAdicionalesEN) As String
        Return objTipoDatoAdicionales.ActualizarTipoDatoAdicionales(objTipoDatoAdicionalesE)
    End Function
    Public Function EliminarTipoDatoAdicionales(ID As Integer) As String
        Return objTipoDatoAdicionales.EliminarTipoDatoAdicionales(ID)
    End Function
    Public Function BuscarxCodTipoDatoAdicionales(ID As Integer) As DataTable
        Return objTipoDatoAdicionales.BuscarXcodTipoDatoAdicionales(ID)
    End Function
    Public Function listarTipoDatoAdicionales(ByVal ParamArray Argumentos() As System.Object) As TipoDatoAdicionalesEN
        Return objTipoDatoAdicionales.ListarTipoDatoAdicionales(Argumentos)
    End Function
    Public Function listarTipoDatoAdicionales2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDatoAdicionalesEN)
        Return objTipoDatoAdicionales.ListarArrayTipoDatoAdicionales(Argumentos)
    End Function
    Public Function listarTipoDatoAdicionalesLisNoArg() As List(Of TipoDatoAdicionalesEN)
        Return objTipoDatoAdicionales.ListarArrayTipoDatoAdicionalesNoArg()
    End Function
    Public Function listarTipoDatoAdicionalesTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
