
public class AnexoNE

   Private objAnexo As clsAnexo
   Private objHelper As clsHelper

   Public Sub New()
       objAnexo = New clsAnexo
       objHelper = New clsHelper
   End Sub
   Public Function AgregarAnexo(ByVal objAnexoE As AnexoEN) As String
       Return objAnexo.AgregarAnexo(objAnexoE)
   End Function
   Public Function ActualizarAnexo(ByVal objAnexoE As AnexoEN) As String
       Return objAnexo.ActualizarAnexo(objAnexoE)
   End Function
   Public Function EliminarAnexo(ID As Integer) As String
       Return objAnexo.EliminarAnexo(ID)
   End Function
   Public Function BuscarxCodAnexo(ID As Integer) As DataTable
       Return objAnexo.BuscarxCodAnexo(ID)
   End Function
   Public Function listarAnexo(ByVal ParamArray Argumentos() As System.Object) As AnexoEN
       Return objAnexo.ListarAnexo(Argumentos)
   End Function
   Public Function listarAnexo2(ByVal ParamArray Argumentos() As System.Object) As List(Of AnexoEN)
       Return objAnexo.ListarArrayAnexo(Argumentos)
   End Function
   Public Function listarAnexoLisNoArg() As List(Of AnexoEN)
       Return objAnexo.ListarArrayAnexoNoArg()
   End Function
   Public Function listarAnexoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
