
public class TipoPrecioNE

   Private objTipoPrecio As clsTipoPrecio
   Private objHelper As clsHelper

   Public Sub New()
       objTipoPrecio = New clsTipoPrecio
       objHelper = New clsHelper
   End Sub
   Public Function AgregarTipoPrecio(ByVal objTipoPrecioE As TipoPrecioEN) As String
       Return objTipoPrecio.AgregarTipoPrecio(objTipoPrecioE)
   End Function
   Public Function ActualizarTipoPrecio(ByVal objTipoPrecioE As TipoPrecioEN) As String
       Return objTipoPrecio.ActualizarTipoPrecio(objTipoPrecioE)
   End Function
   Public Function EliminarTipoPrecio(ID As Integer) As String
       Return objTipoPrecio.EliminarTipoPrecio(ID)
   End Function
   Public Function BuscarxCodTipoPrecio(ID As Integer) As DataTable
       Return objTipoPrecio.BuscarxCodTipoPrecio(ID)
    End Function

    Public Function LoadTipoPrecio() As DataTable
        Return objTipoPrecio.LoadTipoPrecio
    End Function
   Public Function listarTipoPrecio(ByVal ParamArray Argumentos() As System.Object) As TipoPrecioEN
       Return objTipoPrecio.ListarTipoPrecio(Argumentos)
   End Function
   Public Function listarTipoPrecio2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoPrecioEN)
       Return objTipoPrecio.ListarArrayTipoPrecio(Argumentos)
   End Function
   Public Function listarTipoPrecioLisNoArg() As List(Of TipoPrecioEN)
       Return objTipoPrecio.ListarArrayTipoPrecioNoArg()
   End Function
   Public Function listarTipoPrecioTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
