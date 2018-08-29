
public class DatoAdicionalNE

   Private objDatoAdicional As clsDatoAdicional
   Private objHelper As clsHelper

   Public Sub New()
       objDatoAdicional = New clsDatoAdicional
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDatoAdicional(ByVal objDatoAdicionalE As DatoAdicionalEN) As String
       Return objDatoAdicional.AgregarDatoAdicional(objDatoAdicionalE)
   End Function
   Public Function ActualizarDatoAdicional(ByVal objDatoAdicionalE As DatoAdicionalEN) As String
       Return objDatoAdicional.ActualizarDatoAdicional(objDatoAdicionalE)
   End Function
   Public Function EliminarDatoAdicional(ID As Integer) As String
       Return objDatoAdicional.EliminarDatoAdicional(ID)
   End Function
   Public Function BuscarxCodDatoAdicional(ID As Integer) As DataTable
       Return objDatoAdicional.BuscarxCodDatoAdicional(ID)
   End Function
   Public Function listarDatoAdicional(ByVal ParamArray Argumentos() As System.Object) As DatoAdicionalEN
       Return objDatoAdicional.ListarDatoAdicional(Argumentos)
   End Function
   Public Function listarDatoAdicional2(ByVal ParamArray Argumentos() As System.Object) As List(Of DatoAdicionalEN)
       Return objDatoAdicional.ListarArrayDatoAdicional(Argumentos)
   End Function
   Public Function listarDatoAdicionalLisNoArg() As List(Of DatoAdicionalEN)
       Return objDatoAdicional.ListarArrayDatoAdicionalNoArg()
   End Function
   Public Function listarDatoAdicionalTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
