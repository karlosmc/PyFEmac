
public class TipoDocumentoContribuyenteNE

   Private objTipoDocumentoContribuyente As clsTipoDocumentoContribuyente
   Private objHelper As clsHelper

   Public Sub New()
       objTipoDocumentoContribuyente = New clsTipoDocumentoContribuyente
       objHelper = New clsHelper
   End Sub
   Public Function AgregarTipoDocumentoContribuyente(ByVal objTipoDocumentoContribuyenteE As TipoDocumentoContribuyenteEN) As String
       Return objTipoDocumentoContribuyente.AgregarTipoDocumentoContribuyente(objTipoDocumentoContribuyenteE)
   End Function
   Public Function ActualizarTipoDocumentoContribuyente(ByVal objTipoDocumentoContribuyenteE As TipoDocumentoContribuyenteEN) As String
       Return objTipoDocumentoContribuyente.ActualizarTipoDocumentoContribuyente(objTipoDocumentoContribuyenteE)
   End Function
   Public Function EliminarTipoDocumentoContribuyente(ID As Integer) As String
       Return objTipoDocumentoContribuyente.EliminarTipoDocumentoContribuyente(ID)
   End Function
   Public Function BuscarxCodTipoDocumentoContribuyente(ID As Integer) As DataTable
       Return objTipoDocumentoContribuyente.BuscarxCodTipoDocumentoContribuyente(ID)
    End Function

    Public Function LoadTipoDocumentoContribuyente() As DataTable
        Return objTipoDocumentoContribuyente.LoadTipoDocumentoContribuyente()
    End Function
   Public Function listarTipoDocumentoContribuyente(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoContribuyenteEN
       Return objTipoDocumentoContribuyente.ListarTipoDocumentoContribuyente(Argumentos)
   End Function
   Public Function listarTipoDocumentoContribuyente2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoContribuyenteEN)
       Return objTipoDocumentoContribuyente.ListarArrayTipoDocumentoContribuyente(Argumentos)
   End Function
   Public Function listarTipoDocumentoContribuyenteLisNoArg() As List(Of TipoDocumentoContribuyenteEN)
       Return objTipoDocumentoContribuyente.ListarArrayTipoDocumentoContribuyenteNoArg()
   End Function
   Public Function listarTipoDocumentoContribuyenteTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
