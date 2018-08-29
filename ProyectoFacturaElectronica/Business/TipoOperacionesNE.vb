Public Class TipoOperacionesNE

    Private objTipoOperaciones As ClsTipoOperaciones
    Private objHelper As clsHelper

    Public Sub New()
        objTipoOperaciones = New ClsTipoOperaciones
        objHelper = New clsHelper
    End Sub
    Public Function AgregarTipoOperaciones(ByVal objTipoOperacionesE As TipoOperacionesEN) As String
        Return objTipoOperaciones.AgregarTipoOperaciones(objTipoOperacionesE)
    End Function
    Public Function ActualizarTipoOperaciones(ByVal objTipoOperacionesE As TipoOperacionesEN) As String
        Return objTipoOperaciones.ActualizarTipoOperaciones(objTipoOperacionesE)
    End Function
    Public Function EliminarTipoOperaciones(ID As Integer) As String
        Return objTipoOperaciones.EliminarTipoOperaciones(ID)
    End Function
    Public Function BuscarxCodTipoOperaciones(ID As Integer) As DataTable
        Return objTipoOperaciones.BuscarXcodTipoOperaciones(ID)
    End Function

    Public Function LoadTipoOperacion() As DataTable
        Return objTipoOperaciones.LoadTipoOperacion()
    End Function
    Public Function listarTipoOperaciones(ByVal ParamArray Argumentos() As System.Object) As TipoOperacionesEN
        Return objTipoOperaciones.ListarTipoOperaciones(Argumentos)
    End Function
    Public Function listarTipoOperaciones2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoOperacionesEN)
        Return objTipoOperaciones.ListarArrayTipoOperaciones(Argumentos)
    End Function
    Public Function listarTipoOperacionesLisNoArg() As List(Of TipoOperacionesEN)
        Return objTipoOperaciones.ListarArrayTipoOperacionesNoArg()
    End Function
    Public Function listarTipoOperacionesTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
