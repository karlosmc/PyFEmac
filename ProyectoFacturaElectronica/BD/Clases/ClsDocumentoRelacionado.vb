Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoRelacionado

   Public cmdDocumentoRelacionado As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoRelacionado(ByVal objDocumentoRelacionadoE As DocumentoRelacionadoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoRelacionado = New SqlCommand
       cmdDocumentoRelacionado.CommandType = CommandType.StoredProcedure
       cmdDocumentoRelacionado.CommandText = "I_DocumentoRelacionado"
       objConexion.ConexionOpen()
       cmdDocumentoRelacionado.Connection = objConexion.Conexion
       With cmdDocumentoRelacionado.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoRelacionadoE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pIdCabeceraDocumento
           .Add("@NroDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pNroDocumento
           .Add("@TipoDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pTipoDocumento
       End with
       Try
           registro = cmdDocumentoRelacionado.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoRelacionado.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoRelacionado(ByVal objDocumentoRelacionadoE As DocumentoRelacionadoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoRelacionado = New SqlCommand
       cmdDocumentoRelacionado.CommandType = CommandType.StoredProcedure
       cmdDocumentoRelacionado.CommandText = "U_DocumentoRelacionado"
       objConexion.ConexionOpen()
       cmdDocumentoRelacionado.Connection = objConexion.Conexion
       With cmdDocumentoRelacionado.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoRelacionadoE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pIdCabeceraDocumento
           .Add("@NroDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pNroDocumento
           .Add("@TipoDocumento", SqlDbType.varchar).Value = objDocumentoRelacionadoE.pTipoDocumento
       End with
       try
           registro = cmdDocumentoRelacionado.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoRelacionado.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoRelacionado(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoRelacionado = New SqlCommand
       cmdDocumentoRelacionado.CommandType = CommandType.StoredProcedure
       cmdDocumentoRelacionado.CommandText = "D_DocumentoRelacionado"
       objConexion.ConexionOpen()
       cmdDocumentoRelacionado.Connection = objConexion.Conexion
       With cmdDocumentoRelacionado.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoRelacionado.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoRelacionado.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoRelacionado(ID As Integer) As Datatable
       Dim tblDocumentoRelacionado As New Datatable
       Dim daDocumentoRelacionado As New SqlDataAdapter
       cmdDocumentoRelacionado = New SqlCommand
       cmdDocumentoRelacionado.CommandType = CommandType.StoredProcedure
       cmdDocumentoRelacionado.CommandText = "B_DocumentoRelacionadoCOD"
       objConexion.ConexionOpen()
       cmdDocumentoRelacionado.Connection = objConexion.Conexion
       With cmdDocumentoRelacionado.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoRelacionado.SelectCommand = cmdDocumentoRelacionado
           daDocumentoRelacionado.Fill(tblDocumentoRelacionado)
           objConexion.ConexionClose()
           Return tblDocumentoRelacionado
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoRelacionado.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoRelacionado(ByVal ParamArray Argumentos() As System.Object) As DocumentoRelacionadoEN
       Dim dtDocumentoRelacionado As New datatable
       Dim objDocumentoRelacionadoE As New DocumentoRelacionadoEN
       dtDocumentoRelacionado= objHelper.TraerDataTable("L_DocumentoRelacionado", Argumentos)
       If dtDocumentoRelacionado.Rows.Count = 0 Then
           Return objDocumentoRelacionadoE
       End If
       For Each lector As DataRow In dtDocumentoRelacionado.Rows
           With objDocumentoRelacionadoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objDocumentoRelacionadoE
   End Function

   Public Function ListarArrayDocumentoRelacionado(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoRelacionadoEN)
       Dim dtDocumentoRelacionado As New datatable
       Dim lista As New List(Of DocumentoRelacionadoEN)
       Dim objDocumentoRelacionadoE As New DocumentoRelacionadoEN
       dtDocumentoRelacionado= objHelper.TraerDataTable("L_DocumentoRelacionado", Argumentos)
       If dtDocumentoRelacionado.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoRelacionado.Rows
           objDocumentoRelacionadoE = New DocumentoRelacionadoEN
           With objDocumentoRelacionadoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objDocumentoRelacionadoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoRelacionadoNoArg() As List(Of DocumentoRelacionadoEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoRelacionadoEN)
       Dim objDocumentoRelacionadoE As New DocumentoRelacionadoEN
       While lector.Read
           objDocumentoRelacionadoE = New DocumentoRelacionadoEN
           With objDocumentoRelacionadoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objDocumentoRelacionadoE)
           End With
       End While
       Return lista
   End Function

End Class
