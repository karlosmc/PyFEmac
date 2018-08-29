
public class TipoDiscrepanciaNE

   Private objTipoDiscrepancia As clsTipoDiscrepancia
   Private objHelper As clsHelper

   Public Sub New()
       objTipoDiscrepancia = New clsTipoDiscrepancia
       objHelper = New clsHelper
   End Sub
   Public Function AgregarTipoDiscrepancia(ByVal objTipoDiscrepanciaE As TipoDiscrepanciaEN) As String
       Return objTipoDiscrepancia.AgregarTipoDiscrepancia(objTipoDiscrepanciaE)
   End Function
   Public Function ActualizarTipoDiscrepancia(ByVal objTipoDiscrepanciaE As TipoDiscrepanciaEN) As String
       Return objTipoDiscrepancia.ActualizarTipoDiscrepancia(objTipoDiscrepanciaE)
   End Function
   Public Function EliminarTipoDiscrepancia(ID As Integer) As String
       Return objTipoDiscrepancia.EliminarTipoDiscrepancia(ID)
   End Function
   Public Function BuscarxCodTipoDiscrepancia(ID As Integer) As DataTable
       Return objTipoDiscrepancia.BuscarxCodTipoDiscrepancia(ID)
   End Function
   Public Function listarTipoDiscrepancia(ByVal ParamArray Argumentos() As System.Object) As TipoDiscrepanciaEN
       Return objTipoDiscrepancia.ListarTipoDiscrepancia(Argumentos)
   End Function
   Public Function listarTipoDiscrepancia2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDiscrepanciaEN)
       Return objTipoDiscrepancia.ListarArrayTipoDiscrepancia(Argumentos)
   End Function
   Public Function listarTipoDiscrepanciaLisNoArg() As List(Of TipoDiscrepanciaEN)
       Return objTipoDiscrepancia.ListarArrayTipoDiscrepanciaNoArg()
   End Function
   Public Function listarTipoDiscrepanciaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
