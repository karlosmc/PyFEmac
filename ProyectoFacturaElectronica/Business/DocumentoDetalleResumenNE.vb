
public class DocumentoDetalleResumenNE

   Private objDocumentoDetalleResumen As clsDocumentoDetalleResumen
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoDetalleResumen = New clsDocumentoDetalleResumen
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoDetalleResumen(ByVal objDocumentoDetalleResumenE As DocumentoDetalleResumenEN) As String
       Return objDocumentoDetalleResumen.AgregarDocumentoDetalleResumen(objDocumentoDetalleResumenE)
   End Function
   Public Function ActualizarDocumentoDetalleResumen(ByVal objDocumentoDetalleResumenE As DocumentoDetalleResumenEN) As String
       Return objDocumentoDetalleResumen.ActualizarDocumentoDetalleResumen(objDocumentoDetalleResumenE)
   End Function
   Public Function EliminarDocumentoDetalleResumen(ID As Integer) As String
       Return objDocumentoDetalleResumen.EliminarDocumentoDetalleResumen(ID)
   End Function
   Public Function BuscarxCodDocumentoDetalleResumen(ID As Integer) As DataTable
       Return objDocumentoDetalleResumen.BuscarxCodDocumentoDetalleResumen(ID)
   End Function
   Public Function listarDocumentoDetalleResumen(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleResumenEN
       Return objDocumentoDetalleResumen.ListarDocumentoDetalleResumen(Argumentos)
   End Function
   Public Function listarDocumentoDetalleResumen2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleResumenEN)
       Return objDocumentoDetalleResumen.ListarArrayDocumentoDetalleResumen(Argumentos)
   End Function
   Public Function listarDocumentoDetalleResumenLisNoArg() As List(Of DocumentoDetalleResumenEN)
       Return objDocumentoDetalleResumen.ListarArrayDocumentoDetalleResumenNoArg()
   End Function
   Public Function listarDocumentoDetalleResumenTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
