
public class CabeceraDocumentoNE

   Private objCabeceraDocumento As clsCabeceraDocumento
   Private objHelper As clsHelper

   Public Sub New()
       objCabeceraDocumento = New clsCabeceraDocumento
       objHelper = New clsHelper
   End Sub
    Public Function AgregarCabeceraDocumento(ByVal objCabeceraDocumentoE As CabeceraDocumentoEN) As String
        Dim mensaje As String = "Insertado con Exito"
        Try
            If objCabeceraDocumento.AgregarCabeceraDocumento(objCabeceraDocumentoE) Then
                Return mensaje
            End If
        Catch ex As Exception
            mensaje = ex.Message
        End Try
        Return mensaje
    End Function

   Public Function ActualizarCabeceraDocumento(ByVal objCabeceraDocumentoE As CabeceraDocumentoEN) As String
       Return objCabeceraDocumento.ActualizarCabeceraDocumento(objCabeceraDocumentoE)
   End Function
   Public Function EliminarCabeceraDocumento(ID As Integer) As String
       Return objCabeceraDocumento.EliminarCabeceraDocumento(ID)
   End Function
   Public Function BuscarxCodCabeceraDocumento(ID As Integer) As DataTable
       Return objCabeceraDocumento.BuscarxCodCabeceraDocumento(ID)
   End Function
   Public Function listarCabeceraDocumento(ByVal ParamArray Argumentos() As System.Object) As CabeceraDocumentoEN
       Return objCabeceraDocumento.ListarCabeceraDocumento(Argumentos)
   End Function
   Public Function listarCabeceraDocumento2(ByVal ParamArray Argumentos() As System.Object) As List(Of CabeceraDocumentoEN)
       Return objCabeceraDocumento.ListarArrayCabeceraDocumento(Argumentos)
   End Function
   Public Function listarCabeceraDocumentoLisNoArg() As List(Of CabeceraDocumentoEN)
       Return objCabeceraDocumento.ListarArrayCabeceraDocumentoNoArg()
   End Function
   Public Function listarCabeceraDocumentoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
