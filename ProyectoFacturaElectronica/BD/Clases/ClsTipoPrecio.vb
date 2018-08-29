Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoPrecio

   Public cmdTipoPrecio As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoPrecio(ByVal objTipoPrecioE As TipoPrecioEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoPrecio = New SqlCommand
       cmdTipoPrecio.CommandType = CommandType.StoredProcedure
       cmdTipoPrecio.CommandText = "I_TipoPrecio"
       objConexion.ConexionOpen()
       cmdTipoPrecio.Connection = objConexion.Conexion
       With cmdTipoPrecio.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoPrecioE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoPrecioE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoPrecioE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoPrecioE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoPrecio.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoPrecio.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoPrecio(ByVal objTipoPrecioE As TipoPrecioEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoPrecio = New SqlCommand
       cmdTipoPrecio.CommandType = CommandType.StoredProcedure
       cmdTipoPrecio.CommandText = "U_TipoPrecio"
       objConexion.ConexionOpen()
       cmdTipoPrecio.Connection = objConexion.Conexion
       With cmdTipoPrecio.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoPrecioE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoPrecioE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoPrecioE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoPrecioE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoPrecio.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoPrecio.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoPrecio(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoPrecio = New SqlCommand
       cmdTipoPrecio.CommandType = CommandType.StoredProcedure
       cmdTipoPrecio.CommandText = "D_TipoPrecio"
       objConexion.ConexionOpen()
       cmdTipoPrecio.Connection = objConexion.Conexion
       With cmdTipoPrecio.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoPrecio.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoPrecio.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoPrecio(ID As Integer) As Datatable
       Dim tblTipoPrecio As New Datatable
       Dim daTipoPrecio As New SqlDataAdapter
       cmdTipoPrecio = New SqlCommand
       cmdTipoPrecio.CommandType = CommandType.StoredProcedure
       cmdTipoPrecio.CommandText = "B_TipoPrecioCOD"
       objConexion.ConexionOpen()
       cmdTipoPrecio.Connection = objConexion.Conexion
       With cmdTipoPrecio.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoPrecio.SelectCommand = cmdTipoPrecio
           daTipoPrecio.Fill(tblTipoPrecio)
           objConexion.ConexionClose()
           Return tblTipoPrecio
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoPrecio.Parameters.Clear()
       End Try
    End Function

    Public Function LoadTipoPrecio() As DataTable
        Dim tblTipoPrecio As New DataTable
        Dim daTipoPrecio As New SqlDataAdapter
        cmdTipoPrecio = New SqlCommand
        cmdTipoPrecio.CommandType = CommandType.StoredProcedure
        cmdTipoPrecio.CommandText = "S_TipoPrecio"
        objConexion.ConexionOpen()
        cmdTipoPrecio.Connection = objConexion.Conexion
        Try
            daTipoPrecio.SelectCommand = cmdTipoPrecio
            daTipoPrecio.Fill(tblTipoPrecio)

            Return tblTipoPrecio
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al listar Tipo de precio *** " & ex.Message)
            Return Nothing
        Finally
            objConexion.ConexionClose()
            cmdTipoPrecio.Parameters.Clear()
        End Try
    End Function

   Public Function ListarTipoPrecio(ByVal ParamArray Argumentos() As System.Object) As TipoPrecioEN
       Dim dtTipoPrecio As New datatable
       Dim objTipoPrecioE As New TipoPrecioEN
       dtTipoPrecio= objHelper.TraerDataTable("L_TipoPrecio", Argumentos)
       If dtTipoPrecio.Rows.Count = 0 Then
           Return objTipoPrecioE
       End If
       For Each lector As DataRow In dtTipoPrecio.Rows
           With objTipoPrecioE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoPrecioE
   End Function

   Public Function ListarArrayTipoPrecio(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoPrecioEN)
       Dim dtTipoPrecio As New datatable
       Dim lista As New List(Of TipoPrecioEN)
       Dim objTipoPrecioE As New TipoPrecioEN
       dtTipoPrecio= objHelper.TraerDataTable("L_TipoPrecio", Argumentos)
       If dtTipoPrecio.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoPrecio.Rows
           objTipoPrecioE = New TipoPrecioEN
           With objTipoPrecioE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoPrecioE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoPrecioNoArg() As List(Of TipoPrecioEN)
        Dim dtTipoPrecio As New DataTable
        Dim lista As New List(Of TipoPrecioEN)
        Dim objTipoPrecioE As New TipoPrecioEN
        dtTipoPrecio = objHelper.TraerDatatable("S_TipoPrecio")
        If dtTipoPrecio.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoPrecio.Rows
            objTipoPrecioE = New TipoPrecioEN
            With objTipoPrecioE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoPrecioE)
            End With
        Next
        Return lista
   End Function

End Class
