Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDatoAdicional

   Public cmdDatoAdicional As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDatoAdicional(ByVal objDatoAdicionalE As DatoAdicionalEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDatoAdicional = New SqlCommand
       cmdDatoAdicional.CommandType = CommandType.StoredProcedure
       cmdDatoAdicional.CommandText = "I_DatoAdicional"
       objConexion.ConexionOpen()
       cmdDatoAdicional.Connection = objConexion.Conexion
       With cmdDatoAdicional.Parameters
           .Add("@ID", SqlDbType.int).Value = objDatoAdicionalE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDatoAdicionalE.pIdCabeceraDocumento
           .Add("@IdTipoDatoAdicional", SqlDbType.varchar).Value = objDatoAdicionalE.pIdTipoDatoAdicional
           .Add("@Contenido", SqlDbType.varchar).Value = objDatoAdicionalE.pContenido
       End with
       Try
           registro = cmdDatoAdicional.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDatoAdicional.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDatoAdicional(ByVal objDatoAdicionalE As DatoAdicionalEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDatoAdicional = New SqlCommand
       cmdDatoAdicional.CommandType = CommandType.StoredProcedure
       cmdDatoAdicional.CommandText = "U_DatoAdicional"
       objConexion.ConexionOpen()
       cmdDatoAdicional.Connection = objConexion.Conexion
       With cmdDatoAdicional.Parameters
           .Add("@ID", SqlDbType.int).Value = objDatoAdicionalE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDatoAdicionalE.pIdCabeceraDocumento
           .Add("@IdTipoDatoAdicional", SqlDbType.varchar).Value = objDatoAdicionalE.pIdTipoDatoAdicional
           .Add("@Contenido", SqlDbType.varchar).Value = objDatoAdicionalE.pContenido
       End with
       try
           registro = cmdDatoAdicional.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDatoAdicional.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDatoAdicional(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDatoAdicional = New SqlCommand
       cmdDatoAdicional.CommandType = CommandType.StoredProcedure
       cmdDatoAdicional.CommandText = "D_DatoAdicional"
       objConexion.ConexionOpen()
       cmdDatoAdicional.Connection = objConexion.Conexion
       With cmdDatoAdicional.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDatoAdicional.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDatoAdicional.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDatoAdicional(ID As Integer) As Datatable
       Dim tblDatoAdicional As New Datatable
       Dim daDatoAdicional As New SqlDataAdapter
       cmdDatoAdicional = New SqlCommand
       cmdDatoAdicional.CommandType = CommandType.StoredProcedure
       cmdDatoAdicional.CommandText = "B_DatoAdicionalCOD"
       objConexion.ConexionOpen()
       cmdDatoAdicional.Connection = objConexion.Conexion
       With cmdDatoAdicional.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDatoAdicional.SelectCommand = cmdDatoAdicional
           daDatoAdicional.Fill(tblDatoAdicional)
           objConexion.ConexionClose()
           Return tblDatoAdicional
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDatoAdicional.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDatoAdicional(ByVal ParamArray Argumentos() As System.Object) As DatoAdicionalEN
       Dim dtDatoAdicional As New datatable
       Dim objDatoAdicionalE As New DatoAdicionalEN
       dtDatoAdicional= objHelper.TraerDataTable("L_DatoAdicional", Argumentos)
       If dtDatoAdicional.Rows.Count = 0 Then
           Return objDatoAdicionalE
       End If
       For Each lector As DataRow In dtDatoAdicional.Rows
           With objDatoAdicionalE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipoDatoAdicional= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pContenido= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objDatoAdicionalE
   End Function

   Public Function ListarArrayDatoAdicional(ByVal ParamArray Argumentos() As System.Object) As List(Of DatoAdicionalEN)
       Dim dtDatoAdicional As New datatable
       Dim lista As New List(Of DatoAdicionalEN)
       Dim objDatoAdicionalE As New DatoAdicionalEN
       dtDatoAdicional= objHelper.TraerDataTable("L_DatoAdicional", Argumentos)
       If dtDatoAdicional.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDatoAdicional.Rows
           objDatoAdicionalE = New DatoAdicionalEN
           With objDatoAdicionalE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipoDatoAdicional= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pContenido= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objDatoAdicionalE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDatoAdicionalNoArg() As List(Of DatoAdicionalEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DatoAdicionalEN)
       Dim objDatoAdicionalE As New DatoAdicionalEN
       While lector.Read
           objDatoAdicionalE = New DatoAdicionalEN
           With objDatoAdicionalE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipoDatoAdicional= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pContenido= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objDatoAdicionalE)
           End With
       End While
       Return lista
   End Function

End Class
