
public class UnidadMedidaNE

   Private objUnidadMedida As clsUnidadMedida
   Private objHelper As clsHelper

   Public Sub New()
       objUnidadMedida = New clsUnidadMedida
       objHelper = New clsHelper
   End Sub
   Public Function AgregarUnidadMedida(ByVal objUnidadMedidaE As UnidadMedidaEN) As String
       Return objUnidadMedida.AgregarUnidadMedida(objUnidadMedidaE)
   End Function
   Public Function ActualizarUnidadMedida(ByVal objUnidadMedidaE As UnidadMedidaEN) As String
       Return objUnidadMedida.ActualizarUnidadMedida(objUnidadMedidaE)
   End Function
   Public Function EliminarUnidadMedida(ID As Integer) As String
       Return objUnidadMedida.EliminarUnidadMedida(ID)
   End Function
   Public Function BuscarxCodUnidadMedida(ID As Integer) As DataTable
       Return objUnidadMedida.BuscarxCodUnidadMedida(ID)
   End Function
   Public Function listarUnidadMedida(ByVal ParamArray Argumentos() As System.Object) As UnidadMedidaEN
       Return objUnidadMedida.ListarUnidadMedida(Argumentos)
   End Function
   Public Function listarUnidadMedida2(ByVal ParamArray Argumentos() As System.Object) As List(Of UnidadMedidaEN)
       Return objUnidadMedida.ListarArrayUnidadMedida(Argumentos)
   End Function
   Public Function listarUnidadMedidaLisNoArg() As List(Of UnidadMedidaEN)
       Return objUnidadMedida.ListarArrayUnidadMedidaNoArg()
   End Function
   Public Function listarUnidadMedidaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
