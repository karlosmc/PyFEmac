
public class UbigeoNE

   Private objUbigeo As clsUbigeo
   Private objHelper As clsHelper

   Public Sub New()
       objUbigeo = New clsUbigeo
       objHelper = New clsHelper
   End Sub
   Public Function AgregarUbigeo(ByVal objUbigeoE As UbigeoEN) As String
       Return objUbigeo.AgregarUbigeo(objUbigeoE)
   End Function
   Public Function ActualizarUbigeo(ByVal objUbigeoE As UbigeoEN) As String
       Return objUbigeo.ActualizarUbigeo(objUbigeoE)
   End Function
   Public Function EliminarUbigeo(ID As Integer) As String
       Return objUbigeo.EliminarUbigeo(ID)
   End Function
   Public Function BuscarxCodUbigeo(ID As Integer) As DataTable
       Return objUbigeo.BuscarxCodUbigeo(ID)
   End Function
   Public Function listarUbigeo(ByVal ParamArray Argumentos() As System.Object) As UbigeoEN
       Return objUbigeo.ListarUbigeo(Argumentos)
   End Function
   Public Function listarUbigeo2(ByVal ParamArray Argumentos() As System.Object) As List(Of UbigeoEN)
       Return objUbigeo.ListarArrayUbigeo(Argumentos)
   End Function
   Public Function listarUbigeoLisNoArg() As List(Of UbigeoEN)
       Return objUbigeo.ListarArrayUbigeoNoArg()
   End Function
   Public Function listarUbigeoTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
