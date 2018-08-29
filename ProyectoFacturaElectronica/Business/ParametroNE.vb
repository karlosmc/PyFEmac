Public Class ParametroNE

    Private objParametro As ClsParametro
    Private objHelper As clsHelper

    Public Sub New()
        objParametro = New ClsParametro
        objHelper = New clsHelper
    End Sub
    Public Function AgregarParametro(ByVal objParametroE As ParametroEN) As String
        Return objParametro.AgregarParametro(objParametroE)
    End Function
    Public Function ActualizarParametro(ByVal objParametroE As ParametroEN) As String
        Return objParametro.ActualizarParametro(objParametroE)
    End Function
    Public Function EliminarParametro(ID As Integer) As String
        Return objParametro.EliminarParametro(ID)
    End Function
    Public Function BuscarxCodParametro(ID As Integer) As DataTable
        Return objParametro.BuscarXcodParametro(ID)
    End Function
    Public Function listarParametro(ByVal ParamArray Argumentos() As System.Object) As ParametroEN
        Return objParametro.ListarParametro(Argumentos)
    End Function
    Public Function listarParametro2(ByVal ParamArray Argumentos() As System.Object) As List(Of ParametroEN)
        Return objParametro.ListarArrayParametro(Argumentos)
    End Function
    Public Function listarParametroLisNoArg() As List(Of ParametroEN)
        Return objParametro.ListarArrayParametroNoArg()
    End Function
    Public Function listarParametroTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
