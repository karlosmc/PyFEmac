Imports System.Data.SqlClient
Imports System.Reflection

public class ClsUbigeo

   Public cmdUbigeo As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarUbigeo(ByVal objUbigeoE As UbigeoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUbigeo = New SqlCommand
       cmdUbigeo.CommandType = CommandType.StoredProcedure
       cmdUbigeo.CommandText = "I_Ubigeo"
       objConexion.ConexionOpen()
       cmdUbigeo.Connection = objConexion.Conexion
       With cmdUbigeo.Parameters
           .Add("@ID", SqlDbType.int).Value = objUbigeoE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objUbigeoE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objUbigeoE.pDescripcion
       End with
       Try
           registro = cmdUbigeo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUbigeo.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarUbigeo(ByVal objUbigeoE As UbigeoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUbigeo = New SqlCommand
       cmdUbigeo.CommandType = CommandType.StoredProcedure
       cmdUbigeo.CommandText = "U_Ubigeo"
       objConexion.ConexionOpen()
       cmdUbigeo.Connection = objConexion.Conexion
       With cmdUbigeo.Parameters
           .Add("@ID", SqlDbType.int).Value = objUbigeoE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objUbigeoE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objUbigeoE.pDescripcion
       End with
       try
           registro = cmdUbigeo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUbigeo.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarUbigeo(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdUbigeo = New SqlCommand
       cmdUbigeo.CommandType = CommandType.StoredProcedure
       cmdUbigeo.CommandText = "D_Ubigeo"
       objConexion.ConexionOpen()
       cmdUbigeo.Connection = objConexion.Conexion
       With cmdUbigeo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdUbigeo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdUbigeo.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodUbigeo(ID As Integer) As Datatable
       Dim tblUbigeo As New Datatable
       Dim daUbigeo As New SqlDataAdapter
       cmdUbigeo = New SqlCommand
       cmdUbigeo.CommandType = CommandType.StoredProcedure
       cmdUbigeo.CommandText = "B_UbigeoCOD"
       objConexion.ConexionOpen()
       cmdUbigeo.Connection = objConexion.Conexion
       With cmdUbigeo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daUbigeo.SelectCommand = cmdUbigeo
           daUbigeo.Fill(tblUbigeo)
           objConexion.ConexionClose()
           Return tblUbigeo
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdUbigeo.Parameters.Clear()
       End Try
   End Function

   Public Function ListarUbigeo(ByVal ParamArray Argumentos() As System.Object) As UbigeoEN
       Dim dtUbigeo As New datatable
       Dim objUbigeoE As New UbigeoEN
       dtUbigeo= objHelper.TraerDataTable("L_Ubigeo", Argumentos)
       If dtUbigeo.Rows.Count = 0 Then
           Return objUbigeoE
       End If
       For Each lector As DataRow In dtUbigeo.Rows
           With objUbigeoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
           End With
       Next
       Return objUbigeoE
   End Function

   Public Function ListarArrayUbigeo(ByVal ParamArray Argumentos() As System.Object) As List(Of UbigeoEN)
       Dim dtUbigeo As New datatable
       Dim lista As New List(Of UbigeoEN)
       Dim objUbigeoE As New UbigeoEN
       dtUbigeo= objHelper.TraerDataTable("L_Ubigeo", Argumentos)
       If dtUbigeo.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtUbigeo.Rows
           objUbigeoE = New UbigeoEN
           With objUbigeoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
           lista.Add(objUbigeoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayUbigeoNoArg() As List(Of UbigeoEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of UbigeoEN)
       Dim objUbigeoE As New UbigeoEN
       While lector.Read
           objUbigeoE = New UbigeoEN
           With objUbigeoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
           lista.Add(objUbigeoE)
           End With
       End While
       Return lista
   End Function

End Class
