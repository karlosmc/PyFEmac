
public class TipoDocumentoAnticiposNE

   Private objTipoDocumentoAnticipos As clsTipoDocumentoAnticipos
   Private objHelper As clsHelper

   Public Sub New()
       objTipoDocumentoAnticipos = New clsTipoDocumentoAnticipos
       objHelper = New clsHelper
   End Sub
   Public Function AgregarTipoDocumentoAnticipos(ByVal objTipoDocumentoAnticiposE As TipoDocumentoAnticiposEN) As String
       Return objTipoDocumentoAnticipos.AgregarTipoDocumentoAnticipos(objTipoDocumentoAnticiposE)
   End Function
   Public Function ActualizarTipoDocumentoAnticipos(ByVal objTipoDocumentoAnticiposE As TipoDocumentoAnticiposEN) As String
       Return objTipoDocumentoAnticipos.ActualizarTipoDocumentoAnticipos(objTipoDocumentoAnticiposE)
   End Function
   Public Function EliminarTipoDocumentoAnticipos(ID As Integer) As String
       Return objTipoDocumentoAnticipos.EliminarTipoDocumentoAnticipos(ID)
   End Function
   Public Function BuscarxCodTipoDocumentoAnticipos(ID As Integer) As DataTable
       Return objTipoDocumentoAnticipos.BuscarxCodTipoDocumentoAnticipos(ID)
    End Function

    Public Function LoadTipoDocumentoAnticipos() As DataTable
        Return objTipoDocumentoAnticipos.LoadDocumentoAnticipo()
    End Function
   Public Function listarTipoDocumentoAnticipos(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoAnticiposEN
       Return objTipoDocumentoAnticipos.ListarTipoDocumentoAnticipos(Argumentos)
   End Function
   Public Function listarTipoDocumentoAnticipos2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoAnticiposEN)
       Return objTipoDocumentoAnticipos.ListarArrayTipoDocumentoAnticipos(Argumentos)
   End Function
   Public Function listarTipoDocumentoAnticiposLisNoArg() As List(Of TipoDocumentoAnticiposEN)
       Return objTipoDocumentoAnticipos.ListarArrayTipoDocumentoAnticiposNoArg()
   End Function
   Public Function listarTipoDocumentoAnticiposTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
