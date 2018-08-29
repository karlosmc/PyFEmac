
public class MonedaNE

   Private objMoneda As clsMoneda
   Private objHelper As clsHelper

   Public Sub New()
       objMoneda = New clsMoneda
       objHelper = New clsHelper
   End Sub
   Public Function AgregarMoneda(ByVal objMonedaE As MonedaEN) As String
       Return objMoneda.AgregarMoneda(objMonedaE)
   End Function
   Public Function ActualizarMoneda(ByVal objMonedaE As MonedaEN) As String
       Return objMoneda.ActualizarMoneda(objMonedaE)
   End Function
   Public Function EliminarMoneda(ID As Integer) As String
       Return objMoneda.EliminarMoneda(ID)
   End Function
   Public Function BuscarxCodMoneda(ID As Integer) As DataTable
       Return objMoneda.BuscarxCodMoneda(ID)
    End Function

    Public Function ListarMonedas() As DataTable
        Return objMoneda.ListarMonedas()
    End Function
   Public Function listarMoneda(ByVal ParamArray Argumentos() As System.Object) As MonedaEN
       Return objMoneda.ListarMoneda(Argumentos)
   End Function
   Public Function listarMoneda2(ByVal ParamArray Argumentos() As System.Object) As List(Of MonedaEN)
       Return objMoneda.ListarArrayMoneda(Argumentos)
   End Function
   Public Function listarMonedaLisNoArg() As List(Of MonedaEN)
       Return objMoneda.ListarArrayMonedaNoArg()
   End Function
   Public Function listarMonedaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
