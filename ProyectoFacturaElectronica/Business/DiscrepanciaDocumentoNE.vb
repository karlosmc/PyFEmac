
public class DiscrepanciaDocumentoNE

   Private objDiscrepanciaDocumento As clsDiscrepanciaDocumento
   Private objHelper As clsHelper

   Public Sub New()
       objDiscrepanciaDocumento = New clsDiscrepanciaDocumento
       objHelper = New clsHelper
   End Sub
   Public Function AgregarDiscrepanciaDocumento(ByVal objDiscrepanciaDocumentoE As DiscrepanciaDocumentoEN) As String
       Return objDiscrepanciaDocumento.AgregarDiscrepanciaDocumento(objDiscrepanciaDocumentoE)
   End Function
   Public Function ActualizarDiscrepanciaDocumento(ByVal objDiscrepanciaDocumentoE As DiscrepanciaDocumentoEN) As String
       Return objDiscrepanciaDocumento.ActualizarDiscrepanciaDocumento(objDiscrepanciaDocumentoE)
   End Function
   Public Function EliminarDiscrepanciaDocumento(ID As Integer) As String
       Return objDiscrepanciaDocumento.EliminarDiscrepanciaDocumento(ID)
   End Function
   Public Function BuscarxCodDiscrepanciaDocumento(ID As Integer) As DataTable
       Return objDiscrepanciaDocumento.BuscarxCodDiscrepanciaDocumento(ID)
   End Function
   Public Function listarDiscrepanciaDocumento(ByVal ParamArray Argumentos() As System.Object) As DiscrepanciaDocumentoEN
       Return objDiscrepanciaDocumento.ListarDiscrepanciaDocumento(Argumentos)
   End Function
   Public Function listarDiscrepanciaDocumento2(ByVal ParamArray Argumentos() As System.Object) As List(Of DiscrepanciaDocumentoEN)
       Return objDiscrepanciaDocumento.ListarArrayDiscrepanciaDocumento(Argumentos)
   End Function
   Public Function listarDiscrepanciaDocumentoLisNoArg() As List(Of DiscrepanciaDocumentoEN)
       Return objDiscrepanciaDocumento.ListarArrayDiscrepanciaDocumentoNoArg()
   End Function
   Public Function listarDiscrepanciaDocumentoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
