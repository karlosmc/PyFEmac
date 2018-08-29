

public class DocumentoDetalleNE

   Private objDocumentoDetalle As clsDocumentoDetalle
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoDetalle = New clsDocumentoDetalle
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoDetalle(ByVal objDocumentoDetalleE As DocumentoDetalleEN) As String
       Return objDocumentoDetalle.AgregarDocumentoDetalle(objDocumentoDetalleE)
   End Function
   Public Function ActualizarDocumentoDetalle(ByVal objDocumentoDetalleE As DocumentoDetalleEN) As String
       Return objDocumentoDetalle.ActualizarDocumentoDetalle(objDocumentoDetalleE)
   End Function
   Public Function EliminarDocumentoDetalle(ID As Integer) As String
       Return objDocumentoDetalle.EliminarDocumentoDetalle(ID)
   End Function
   Public Function BuscarxCodDocumentoDetalle(ID As Integer) As DataTable
       Return objDocumentoDetalle.BuscarxCodDocumentoDetalle(ID)
   End Function
   Public Function listarDocumentoDetalle(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleEN
       Return objDocumentoDetalle.ListarDocumentoDetalle(Argumentos)
   End Function
   Public Function listarDocumentoDetalle2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleEN)
       Return objDocumentoDetalle.ListarArrayDocumentoDetalle(Argumentos)
   End Function
   Public Function listarDocumentoDetalleLisNoArg() As List(Of DocumentoDetalleEN)
       Return objDocumentoDetalle.ListarArrayDocumentoDetalleNoArg()
   End Function
   Public Function listarDocumentoDetalleTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
