Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoBaja

   Public cmdDocumentoBaja As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoBaja(ByVal objDocumentoBajaE As DocumentoBajaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoBaja = New SqlCommand
       cmdDocumentoBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoBaja.CommandText = "I_DocumentoBaja"
       objConexion.ConexionOpen()
       cmdDocumentoBaja.Connection = objConexion.Conexion
       With cmdDocumentoBaja.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoBajaE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objDocumentoBajaE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objDocumentoBajaE.pFechaReferencia
           .Add("@IdBaja", SqlDbType.varchar).Value = objDocumentoBajaE.pIdBaja
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objDocumentoBajaE.pIdContribuyente
       End with
       Try
           registro = cmdDocumentoBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoBaja.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoBaja(ByVal objDocumentoBajaE As DocumentoBajaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoBaja = New SqlCommand
       cmdDocumentoBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoBaja.CommandText = "U_DocumentoBaja"
       objConexion.ConexionOpen()
       cmdDocumentoBaja.Connection = objConexion.Conexion
       With cmdDocumentoBaja.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoBajaE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objDocumentoBajaE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objDocumentoBajaE.pFechaReferencia
           .Add("@IdBaja", SqlDbType.varchar).Value = objDocumentoBajaE.pIdBaja
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objDocumentoBajaE.pIdContribuyente
       End with
       try
           registro = cmdDocumentoBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoBaja.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoBaja(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoBaja = New SqlCommand
       cmdDocumentoBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoBaja.CommandText = "D_DocumentoBaja"
       objConexion.ConexionOpen()
       cmdDocumentoBaja.Connection = objConexion.Conexion
       With cmdDocumentoBaja.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoBaja.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoBaja(ID As Integer) As Datatable
       Dim tblDocumentoBaja As New Datatable
       Dim daDocumentoBaja As New SqlDataAdapter
       cmdDocumentoBaja = New SqlCommand
       cmdDocumentoBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoBaja.CommandText = "B_DocumentoBajaCOD"
       objConexion.ConexionOpen()
       cmdDocumentoBaja.Connection = objConexion.Conexion
       With cmdDocumentoBaja.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoBaja.SelectCommand = cmdDocumentoBaja
           daDocumentoBaja.Fill(tblDocumentoBaja)
           objConexion.ConexionClose()
           Return tblDocumentoBaja
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoBaja.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoBaja(ByVal ParamArray Argumentos() As System.Object) As DocumentoBajaEN
       Dim dtDocumentoBaja As New datatable
       Dim objDocumentoBajaE As New DocumentoBajaEN
       dtDocumentoBaja= objHelper.TraerDataTable("L_DocumentoBaja", Argumentos)
       If dtDocumentoBaja.Rows.Count = 0 Then
           Return objDocumentoBajaE
       End If
       For Each lector As DataRow In dtDocumentoBaja.Rows
           With objDocumentoBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdBaja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objDocumentoBajaE
   End Function

   Public Function ListarArrayDocumentoBaja(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoBajaEN)
       Dim dtDocumentoBaja As New datatable
       Dim lista As New List(Of DocumentoBajaEN)
       Dim objDocumentoBajaE As New DocumentoBajaEN
       dtDocumentoBaja= objHelper.TraerDataTable("L_DocumentoBaja", Argumentos)
       If dtDocumentoBaja.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoBaja.Rows
           objDocumentoBajaE = New DocumentoBajaEN
           With objDocumentoBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdBaja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoBajaE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoBajaNoArg() As List(Of DocumentoBajaEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoBajaEN)
       Dim objDocumentoBajaE As New DocumentoBajaEN
       While lector.Read
           objDocumentoBajaE = New DocumentoBajaEN
           With objDocumentoBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdBaja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoBajaE)
           End With
       End While
       Return lista
   End Function

End Class
