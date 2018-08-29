Public Class ResumenDiarioNE

    Private objResumenDiario As ClsResumenDiario
    Private objHelper As clsHelper

    Public Sub New()
        objResumenDiario = New ClsResumenDiario
        objHelper = New clsHelper
    End Sub
    Public Function AgregarResumenDiario(ByVal objResumenDiarioE As ResumenDiarioEN) As String
        Return objResumenDiario.AgregarResumenDiario(objResumenDiarioE)
    End Function
    Public Function ActualizarResumenDiario(ByVal objResumenDiarioE As ResumenDiarioEN) As String
        Return objResumenDiario.ActualizarResumenDiario(objResumenDiarioE)
    End Function
    Public Function EliminarResumenDiario(ID As Integer) As String
        Return objResumenDiario.EliminarResumenDiario(ID)
    End Function
    Public Function BuscarxCodResumenDiario(ID As Integer) As DataTable
        Return objResumenDiario.BuscarXcodResumenDiario(ID)
    End Function
    Public Function listarResumenDiario(ByVal ParamArray Argumentos() As System.Object) As ResumenDiarioEN
        Return objResumenDiario.ListarResumenDiario(Argumentos)
    End Function
    Public Function listarResumenDiario2(ByVal ParamArray Argumentos() As System.Object) As List(Of ResumenDiarioEN)
        Return objResumenDiario.ListarArrayResumenDiario(Argumentos)
    End Function
    Public Function listarResumenDiarioLisNoArg() As List(Of ResumenDiarioEN)
        Return objResumenDiario.ListarArrayResumenDiarioNoArg()
    End Function
    Public Function listarResumenDiarioTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
