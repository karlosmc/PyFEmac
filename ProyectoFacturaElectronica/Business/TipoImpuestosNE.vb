Imports CapaDatos

public class TipoImpuestosNE

   Private objTipoImpuestos As clsTipoImpuestos
   Private objHelper As clsHelper

   Public Sub New()
       objTipoImpuestos = New clsTipoImpuestos
       objHelper = New clsHelper
   End Sub
   Public Function AgregarTipoImpuestos(ByVal objTipoImpuestosE As TipoImpuestosEN) As String
       Return objTipoImpuestos.AgregarTipoImpuestos(objTipoImpuestosE)
   End Function
   Public Function ActualizarTipoImpuestos(ByVal objTipoImpuestosE As TipoImpuestosEN) As String
       Return objTipoImpuestos.ActualizarTipoImpuestos(objTipoImpuestosE)
   End Function
   Public Function EliminarTipoImpuestos(ID As Integer) As String
       Return objTipoImpuestos.EliminarTipoImpuestos(ID)
   End Function
    Public Function LoadTipoImpuestos() As DataTable
        Return objTipoImpuestos.LoadTipoImpuestos
    End Function

    Public Function BuscarxCodTipoImpuestos(ID As Integer) As DataTable
        Return objTipoImpuestos.BuscarxCodTipoImpuestos(ID)
    End Function
   Public Function listarTipoImpuestos(ByVal ParamArray Argumentos() As System.Object) As TipoImpuestosEN
       Return objTipoImpuestos.ListarTipoImpuestos(Argumentos)
   End Function
   Public Function listarTipoImpuestos2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoImpuestosEN)
       Return objTipoImpuestos.ListarArrayTipoImpuestos(Argumentos)
   End Function
   Public Function listarTipoImpuestosLisNoArg() As List(Of TipoImpuestosEN)
       Return objTipoImpuestos.ListarArrayTipoImpuestosNoArg()
   End Function
   Public Function listarTipoImpuestosTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
