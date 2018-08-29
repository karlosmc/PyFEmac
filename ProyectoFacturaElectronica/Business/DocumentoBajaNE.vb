

public class DocumentoBajaNE

   Private objDocumentoBaja As clsDocumentoBaja
   Private objHelper As clsHelper

   Public Sub New()
       objDocumentoBaja = New clsDocumentoBaja
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDocumentoBaja(ByVal objDocumentoBajaE As DocumentoBajaEN) As String
       Return objDocumentoBaja.AgregarDocumentoBaja(objDocumentoBajaE)
   End Function
   Public Function ActualizarDocumentoBaja(ByVal objDocumentoBajaE As DocumentoBajaEN) As String
       Return objDocumentoBaja.ActualizarDocumentoBaja(objDocumentoBajaE)
   End Function
   Public Function EliminarDocumentoBaja(ID As Integer) As String
       Return objDocumentoBaja.EliminarDocumentoBaja(ID)
   End Function
   Public Function BuscarxCodDocumentoBaja(ID As Integer) As DataTable
       Return objDocumentoBaja.BuscarxCodDocumentoBaja(ID)
   End Function
   Public Function listarDocumentoBaja(ByVal ParamArray Argumentos() As System.Object) As DocumentoBajaEN
       Return objDocumentoBaja.ListarDocumentoBaja(Argumentos)
   End Function
   Public Function listarDocumentoBaja2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoBajaEN)
       Return objDocumentoBaja.ListarArrayDocumentoBaja(Argumentos)
   End Function
   Public Function listarDocumentoBajaLisNoArg() As List(Of DocumentoBajaEN)
       Return objDocumentoBaja.ListarArrayDocumentoBajaNoArg()
   End Function
   Public Function listarDocumentoBajaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
