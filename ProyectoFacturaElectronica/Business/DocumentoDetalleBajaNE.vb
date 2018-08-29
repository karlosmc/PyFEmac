
public class DocumentoDetalleBajaNE

   Private objDocumentoDetalleBaja As clsDocumentoDetalleBaja
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoDetalleBaja = New clsDocumentoDetalleBaja
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoDetalleBaja(ByVal objDocumentoDetalleBajaE As DocumentoDetalleBajaEN) As String
       Return objDocumentoDetalleBaja.AgregarDocumentoDetalleBaja(objDocumentoDetalleBajaE)
   End Function
   Public Function ActualizarDocumentoDetalleBaja(ByVal objDocumentoDetalleBajaE As DocumentoDetalleBajaEN) As String
       Return objDocumentoDetalleBaja.ActualizarDocumentoDetalleBaja(objDocumentoDetalleBajaE)
   End Function
   Public Function EliminarDocumentoDetalleBaja(ID As Integer) As String
       Return objDocumentoDetalleBaja.EliminarDocumentoDetalleBaja(ID)
   End Function
   Public Function BuscarxCodDocumentoDetalleBaja(ID As Integer) As DataTable
       Return objDocumentoDetalleBaja.BuscarxCodDocumentoDetalleBaja(ID)
   End Function
   Public Function listarDocumentoDetalleBaja(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleBajaEN
       Return objDocumentoDetalleBaja.ListarDocumentoDetalleBaja(Argumentos)
   End Function
   Public Function listarDocumentoDetalleBaja2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleBajaEN)
       Return objDocumentoDetalleBaja.ListarArrayDocumentoDetalleBaja(Argumentos)
   End Function
   Public Function listarDocumentoDetalleBajaLisNoArg() As List(Of DocumentoDetalleBajaEN)
       Return objDocumentoDetalleBaja.ListarArrayDocumentoDetalleBajaNoArg()
   End Function
   Public Function listarDocumentoDetalleBajaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
