Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDiscrepanciaDocumento

   Public cmdDiscrepanciaDocumento As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDiscrepanciaDocumento(ByVal objDiscrepanciaDocumentoE As DiscrepanciaDocumentoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDiscrepanciaDocumento = New SqlCommand
       cmdDiscrepanciaDocumento.CommandType = CommandType.StoredProcedure
       cmdDiscrepanciaDocumento.CommandText = "I_DiscrepanciaDocumento"
       objConexion.ConexionOpen()
       cmdDiscrepanciaDocumento.Connection = objConexion.Conexion
       With cmdDiscrepanciaDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value = objDiscrepanciaDocumentoE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pIdCabeceraDocumento
           .Add("@NroReferencia", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pNroReferencia
           .Add("@IdTipoDiscrepancia", SqlDbType.int).Value = objDiscrepanciaDocumentoE.pIdTipoDiscrepancia
           .Add("@TipoDiscrepancia", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pTipoDiscrepancia
       End with
       Try
           registro = cmdDiscrepanciaDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDiscrepanciaDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDiscrepanciaDocumento(ByVal objDiscrepanciaDocumentoE As DiscrepanciaDocumentoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDiscrepanciaDocumento = New SqlCommand
       cmdDiscrepanciaDocumento.CommandType = CommandType.StoredProcedure
       cmdDiscrepanciaDocumento.CommandText = "U_DiscrepanciaDocumento"
       objConexion.ConexionOpen()
       cmdDiscrepanciaDocumento.Connection = objConexion.Conexion
       With cmdDiscrepanciaDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value = objDiscrepanciaDocumentoE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pIdCabeceraDocumento
           .Add("@NroReferencia", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pNroReferencia
           .Add("@IdTipoDiscrepancia", SqlDbType.int).Value = objDiscrepanciaDocumentoE.pIdTipoDiscrepancia
           .Add("@TipoDiscrepancia", SqlDbType.varchar).Value = objDiscrepanciaDocumentoE.pTipoDiscrepancia
       End with
       try
           registro = cmdDiscrepanciaDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDiscrepanciaDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDiscrepanciaDocumento(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDiscrepanciaDocumento = New SqlCommand
       cmdDiscrepanciaDocumento.CommandType = CommandType.StoredProcedure
       cmdDiscrepanciaDocumento.CommandText = "D_DiscrepanciaDocumento"
       objConexion.ConexionOpen()
       cmdDiscrepanciaDocumento.Connection = objConexion.Conexion
       With cmdDiscrepanciaDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDiscrepanciaDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDiscrepanciaDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDiscrepanciaDocumento(ID As Integer) As Datatable
       Dim tblDiscrepanciaDocumento As New Datatable
       Dim daDiscrepanciaDocumento As New SqlDataAdapter
       cmdDiscrepanciaDocumento = New SqlCommand
       cmdDiscrepanciaDocumento.CommandType = CommandType.StoredProcedure
       cmdDiscrepanciaDocumento.CommandText = "B_DiscrepanciaDocumentoCOD"
       objConexion.ConexionOpen()
       cmdDiscrepanciaDocumento.Connection = objConexion.Conexion
       With cmdDiscrepanciaDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDiscrepanciaDocumento.SelectCommand = cmdDiscrepanciaDocumento
           daDiscrepanciaDocumento.Fill(tblDiscrepanciaDocumento)
           objConexion.ConexionClose()
           Return tblDiscrepanciaDocumento
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDiscrepanciaDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDiscrepanciaDocumento(ByVal ParamArray Argumentos() As System.Object) As DiscrepanciaDocumentoEN
       Dim dtDiscrepanciaDocumento As New datatable
       Dim objDiscrepanciaDocumentoE As New DiscrepanciaDocumentoEN
       dtDiscrepanciaDocumento= objHelper.TraerDataTable("L_DiscrepanciaDocumento", Argumentos)
       If dtDiscrepanciaDocumento.Rows.Count = 0 Then
           Return objDiscrepanciaDocumentoE
       End If
       For Each lector As DataRow In dtDiscrepanciaDocumento.Rows
           With objDiscrepanciaDocumentoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objDiscrepanciaDocumentoE
   End Function

   Public Function ListarArrayDiscrepanciaDocumento(ByVal ParamArray Argumentos() As System.Object) As List(Of DiscrepanciaDocumentoEN)
       Dim dtDiscrepanciaDocumento As New datatable
       Dim lista As New List(Of DiscrepanciaDocumentoEN)
       Dim objDiscrepanciaDocumentoE As New DiscrepanciaDocumentoEN
       dtDiscrepanciaDocumento= objHelper.TraerDataTable("L_DiscrepanciaDocumento", Argumentos)
       If dtDiscrepanciaDocumento.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDiscrepanciaDocumento.Rows
           objDiscrepanciaDocumentoE = New DiscrepanciaDocumentoEN
           With objDiscrepanciaDocumentoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDiscrepanciaDocumentoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDiscrepanciaDocumentoNoArg() As List(Of DiscrepanciaDocumentoEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DiscrepanciaDocumentoEN)
       Dim objDiscrepanciaDocumentoE As New DiscrepanciaDocumentoEN
       While lector.Read
           objDiscrepanciaDocumentoE = New DiscrepanciaDocumentoEN
           With objDiscrepanciaDocumentoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDiscrepancia= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDiscrepanciaDocumentoE)
           End With
       End While
       Return lista
   End Function

End Class
