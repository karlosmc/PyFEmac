Imports System.Data.SqlClient
Imports System.Reflection

public class ClsMoneda

   Public cmdMoneda As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarMoneda(ByVal objMonedaE As MonedaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdMoneda = New SqlCommand
       cmdMoneda.CommandType = CommandType.StoredProcedure
       cmdMoneda.CommandText = "I_Moneda"
       objConexion.ConexionOpen()
       cmdMoneda.Connection = objConexion.Conexion
       With cmdMoneda.Parameters
           .Add("@ID", SqlDbType.int).Value = objMonedaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objMonedaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objMonedaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objMonedaE.pDescripcionCompleja
       End with
       Try
           registro = cmdMoneda.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdMoneda.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarMoneda(ByVal objMonedaE As MonedaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdMoneda = New SqlCommand
       cmdMoneda.CommandType = CommandType.StoredProcedure
       cmdMoneda.CommandText = "U_Moneda"
       objConexion.ConexionOpen()
       cmdMoneda.Connection = objConexion.Conexion
       With cmdMoneda.Parameters
           .Add("@ID", SqlDbType.int).Value = objMonedaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objMonedaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objMonedaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objMonedaE.pDescripcionCompleja
       End with
       try
           registro = cmdMoneda.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdMoneda.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarMoneda(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdMoneda = New SqlCommand
       cmdMoneda.CommandType = CommandType.StoredProcedure
       cmdMoneda.CommandText = "D_Moneda"
       objConexion.ConexionOpen()
       cmdMoneda.Connection = objConexion.Conexion
       With cmdMoneda.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdMoneda.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdMoneda.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodMoneda(ID As Integer) As Datatable
       Dim tblMoneda As New Datatable
       Dim daMoneda As New SqlDataAdapter
       cmdMoneda = New SqlCommand
       cmdMoneda.CommandType = CommandType.StoredProcedure
       cmdMoneda.CommandText = "B_MonedaCOD"
       objConexion.ConexionOpen()
       cmdMoneda.Connection = objConexion.Conexion
       With cmdMoneda.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daMoneda.SelectCommand = cmdMoneda
           daMoneda.Fill(tblMoneda)
           objConexion.ConexionClose()
           Return tblMoneda
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdMoneda.Parameters.Clear()
       End Try
    End Function

    Public Function ListarMonedas() As DataTable
        Dim tblMoneda As New DataTable
        Dim daMoneda As New SqlDataAdapter
        cmdMoneda = New SqlCommand
        cmdMoneda.CommandType = CommandType.StoredProcedure
        cmdMoneda.CommandText = "S_Moneda"
        objConexion.ConexionOpen()
        cmdMoneda.Connection = objConexion.Conexion
        Try
            daMoneda.SelectCommand = cmdMoneda
            daMoneda.Fill(tblMoneda)

            Return tblMoneda
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error en cargar las monedas " & ex.Message)
            Return Nothing
        Finally
            cmdMoneda.Dispose()
            objConexion.ConexionClose()
        End Try
    End Function

   Public Function ListarMoneda(ByVal ParamArray Argumentos() As System.Object) As MonedaEN
       Dim dtMoneda As New datatable
       Dim objMonedaE As New MonedaEN
        dtMoneda = objHelper.TraerDatatable("B_Moneda", Argumentos)
       If dtMoneda.Rows.Count = 0 Then
           Return objMonedaE
       End If
       For Each lector As DataRow In dtMoneda.Rows
           With objMonedaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objMonedaE
   End Function

   Public Function ListarArrayMoneda(ByVal ParamArray Argumentos() As System.Object) As List(Of MonedaEN)
       Dim dtMoneda As New datatable
       Dim lista As New List(Of MonedaEN)
       Dim objMonedaE As New MonedaEN
       dtMoneda= objHelper.TraerDataTable("L_Moneda", Argumentos)
       If dtMoneda.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtMoneda.Rows
           objMonedaE = New MonedaEN
           With objMonedaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objMonedaE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayMonedaNoArg() As List(Of MonedaEN)
        Dim dtMoneda As New DataTable
        Dim lista As New List(Of MonedaEN)
        Dim objMonedaE As New MonedaEN
        dtMoneda = objHelper.TraerDatatable("S_Moneda")
        If dtMoneda.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtMoneda.Rows
            objMonedaE = New MonedaEN
            With objMonedaE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objMonedaE)
            End With
        Next
        Return lista
   End Function

End Class
