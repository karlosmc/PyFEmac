Imports System.Data.SqlClient
Imports System.Reflection

public class ClsUnidadMedida

   Public cmdUnidadMedida As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarUnidadMedida(ByVal objUnidadMedidaE As UnidadMedidaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUnidadMedida = New SqlCommand
       cmdUnidadMedida.CommandType = CommandType.StoredProcedure
       cmdUnidadMedida.CommandText = "I_UnidadMedida"
       objConexion.ConexionOpen()
       cmdUnidadMedida.Connection = objConexion.Conexion
       With cmdUnidadMedida.Parameters
           .Add("@ID", SqlDbType.int).Value = objUnidadMedidaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objUnidadMedidaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objUnidadMedidaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objUnidadMedidaE.pDescripcionCompleja
       End with
       Try
           registro = cmdUnidadMedida.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUnidadMedida.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarUnidadMedida(ByVal objUnidadMedidaE As UnidadMedidaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUnidadMedida = New SqlCommand
       cmdUnidadMedida.CommandType = CommandType.StoredProcedure
       cmdUnidadMedida.CommandText = "U_UnidadMedida"
       objConexion.ConexionOpen()
       cmdUnidadMedida.Connection = objConexion.Conexion
       With cmdUnidadMedida.Parameters
           .Add("@ID", SqlDbType.int).Value = objUnidadMedidaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objUnidadMedidaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objUnidadMedidaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objUnidadMedidaE.pDescripcionCompleja
       End with
       try
           registro = cmdUnidadMedida.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUnidadMedida.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarUnidadMedida(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUnidadMedida = New SqlCommand
       cmdUnidadMedida.CommandType = CommandType.StoredProcedure
       cmdUnidadMedida.CommandText = "D_UnidadMedida"
       objConexion.ConexionOpen()
       cmdUnidadMedida.Connection = objConexion.Conexion
       With cmdUnidadMedida.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdUnidadMedida.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUnidadMedida.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodUnidadMedida(ID As Integer) As Datatable
       Dim tblUnidadMedida As New Datatable
       Dim daUnidadMedida As New SqlDataAdapter
       cmdUnidadMedida = New SqlCommand
       cmdUnidadMedida.CommandType = CommandType.StoredProcedure
       cmdUnidadMedida.CommandText = "B_UnidadMedidaCOD"
       objConexion.ConexionOpen()
       cmdUnidadMedida.Connection = objConexion.Conexion
       With cmdUnidadMedida.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daUnidadMedida.SelectCommand = cmdUnidadMedida
           daUnidadMedida.Fill(tblUnidadMedida)
           objConexion.ConexionClose()
           Return tblUnidadMedida
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdUnidadMedida.Parameters.Clear()
       End Try
   End Function

   Public Function ListarUnidadMedida(ByVal ParamArray Argumentos() As System.Object) As UnidadMedidaEN
       Dim dtUnidadMedida As New datatable
       Dim objUnidadMedidaE As New UnidadMedidaEN
       dtUnidadMedida= objHelper.TraerDataTable("L_UnidadMedida", Argumentos)
       If dtUnidadMedida.Rows.Count = 0 Then
           Return objUnidadMedidaE
       End If
       For Each lector As DataRow In dtUnidadMedida.Rows
           With objUnidadMedidaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objUnidadMedidaE
   End Function

   Public Function ListarArrayUnidadMedida(ByVal ParamArray Argumentos() As System.Object) As List(Of UnidadMedidaEN)
       Dim dtUnidadMedida As New datatable
       Dim lista As New List(Of UnidadMedidaEN)
       Dim objUnidadMedidaE As New UnidadMedidaEN
       dtUnidadMedida= objHelper.TraerDataTable("L_UnidadMedida", Argumentos)
       If dtUnidadMedida.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtUnidadMedida.Rows
           objUnidadMedidaE = New UnidadMedidaEN
           With objUnidadMedidaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objUnidadMedidaE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayUnidadMedidaNoArg() As List(Of UnidadMedidaEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of UnidadMedidaEN)
       Dim objUnidadMedidaE As New UnidadMedidaEN
       While lector.Read
           objUnidadMedidaE = New UnidadMedidaEN
           With objUnidadMedidaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objUnidadMedidaE)
           End With
       End While
       Return lista
   End Function

End Class
