
public class DocumentoAnticipoNE

   Private objDocumentoAnticipo As clsDocumentoAnticipo
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoAnticipo = New clsDocumentoAnticipo
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoAnticipo(ByVal objDocumentoAnticipoE As DocumentoAnticipoEN) As String
       Return objDocumentoAnticipo.AgregarDocumentoAnticipo(objDocumentoAnticipoE)
   End Function
   Public Function ActualizarDocumentoAnticipo(ByVal objDocumentoAnticipoE As DocumentoAnticipoEN) As String
       Return objDocumentoAnticipo.ActualizarDocumentoAnticipo(objDocumentoAnticipoE)
   End Function
   Public Function EliminarDocumentoAnticipo(ID As Integer) As String
       Return objDocumentoAnticipo.EliminarDocumentoAnticipo(ID)
   End Function
   Public Function BuscarxCodDocumentoAnticipo(ID As Integer) As DataTable
       Return objDocumentoAnticipo.BuscarxCodDocumentoAnticipo(ID)
    End Function

    Public Function LoadDocumentoAnticipo() As DataTable
        Return objDocumentoAnticipo.LoadDocumentoAnticipo()
    End Function
   Public Function listarDocumentoAnticipo(ByVal ParamArray Argumentos() As System.Object) As DocumentoAnticipoEN
       Return objDocumentoAnticipo.ListarDocumentoAnticipo(Argumentos)
   End Function
   Public Function listarDocumentoAnticipo2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoAnticipoEN)
       Return objDocumentoAnticipo.ListarArrayDocumentoAnticipo(Argumentos)
   End Function
   Public Function listarDocumentoAnticipoLisNoArg() As List(Of DocumentoAnticipoEN)
       Return objDocumentoAnticipo.ListarArrayDocumentoAnticipoNoArg()
   End Function
   Public Function listarDocumentoAnticipoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
