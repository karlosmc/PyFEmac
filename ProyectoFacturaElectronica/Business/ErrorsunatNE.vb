
public class ErrorsunatNE

   Private objErrorsunat As clsErrorsunat
   Private objHelper As clsHelper

   Public Sub New()
       objErrorsunat = New clsErrorsunat
       objHelper = New clsHelper
   End Sub
   Public Function AgregarErrorsunat(ByVal objErrorsunatE As ErrorsunatEN) As String
       Return objErrorsunat.AgregarErrorsunat(objErrorsunatE)
   End Function
   Public Function ActualizarErrorsunat(ByVal objErrorsunatE As ErrorsunatEN) As String
       Return objErrorsunat.ActualizarErrorsunat(objErrorsunatE)
   End Function
   Public Function EliminarErrorsunat(codigo As String) As String
       Return objErrorsunat.EliminarErrorsunat(codigo)
   End Function
   Public Function BuscarxCodErrorsunat(codigo As String) As DataTable
       Return objErrorsunat.BuscarxCodErrorsunat(codigo)
   End Function
   Public Function listarErrorsunat(ByVal ParamArray Argumentos() As System.Object) As ErrorsunatEN
       Return objErrorsunat.ListarErrorsunat(Argumentos)
   End Function
   Public Function listarErrorsunat2(ByVal ParamArray Argumentos() As System.Object) As List(Of ErrorsunatEN)
       Return objErrorsunat.ListarArrayErrorsunat(Argumentos)
   End Function
   Public Function listarErrorsunatLisNoArg() As List(Of ErrorsunatEN)
       Return objErrorsunat.ListarArrayErrorsunatNoArg()
   End Function
   Public Function listarErrorsunatTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
