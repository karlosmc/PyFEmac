

public class DocumentoRelacionadoNE

   Private objDocumentoRelacionado As clsDocumentoRelacionado
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoRelacionado = New clsDocumentoRelacionado
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoRelacionado(ByVal objDocumentoRelacionadoE As DocumentoRelacionadoEN) As String
       Return objDocumentoRelacionado.AgregarDocumentoRelacionado(objDocumentoRelacionadoE)
   End Function
   Public Function ActualizarDocumentoRelacionado(ByVal objDocumentoRelacionadoE As DocumentoRelacionadoEN) As String
       Return objDocumentoRelacionado.ActualizarDocumentoRelacionado(objDocumentoRelacionadoE)
   End Function
   Public Function EliminarDocumentoRelacionado(ID As Integer) As String
       Return objDocumentoRelacionado.EliminarDocumentoRelacionado(ID)
   End Function
   Public Function BuscarxCodDocumentoRelacionado(ID As Integer) As DataTable
       Return objDocumentoRelacionado.BuscarxCodDocumentoRelacionado(ID)
   End Function
   Public Function listarDocumentoRelacionado(ByVal ParamArray Argumentos() As System.Object) As DocumentoRelacionadoEN
       Return objDocumentoRelacionado.ListarDocumentoRelacionado(Argumentos)
   End Function
   Public Function listarDocumentoRelacionado2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoRelacionadoEN)
       Return objDocumentoRelacionado.ListarArrayDocumentoRelacionado(Argumentos)
   End Function
   Public Function listarDocumentoRelacionadoLisNoArg() As List(Of DocumentoRelacionadoEN)
       Return objDocumentoRelacionado.ListarArrayDocumentoRelacionadoNoArg()
   End Function
   Public Function listarDocumentoRelacionadoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
