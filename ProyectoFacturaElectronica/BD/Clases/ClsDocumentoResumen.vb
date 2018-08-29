Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoResumen

   Public cmdDocumentoResumen As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoResumen(ByVal objDocumentoResumenE As DocumentoResumenEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoResumen = New SqlCommand
       cmdDocumentoResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoResumen.CommandText = "I_DocumentoResumen"
       objConexion.ConexionOpen()
       cmdDocumentoResumen.Connection = objConexion.Conexion
       With cmdDocumentoResumen.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoResumenE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objDocumentoResumenE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objDocumentoResumenE.pFechaReferencia
           .Add("@IdResumen", SqlDbType.varchar).Value = objDocumentoResumenE.pIdResumen
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objDocumentoResumenE.pIdContribuyente
       End with
       Try
           registro = cmdDocumentoResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoResumen.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoResumen(ByVal objDocumentoResumenE As DocumentoResumenEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoResumen = New SqlCommand
       cmdDocumentoResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoResumen.CommandText = "U_DocumentoResumen"
       objConexion.ConexionOpen()
       cmdDocumentoResumen.Connection = objConexion.Conexion
       With cmdDocumentoResumen.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoResumenE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objDocumentoResumenE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objDocumentoResumenE.pFechaReferencia
           .Add("@IdResumen", SqlDbType.varchar).Value = objDocumentoResumenE.pIdResumen
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objDocumentoResumenE.pIdContribuyente
       End with
       try
           registro = cmdDocumentoResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoResumen.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoResumen(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoResumen = New SqlCommand
       cmdDocumentoResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoResumen.CommandText = "D_DocumentoResumen"
       objConexion.ConexionOpen()
       cmdDocumentoResumen.Connection = objConexion.Conexion
       With cmdDocumentoResumen.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoResumen.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoResumen(ID As Integer) As Datatable
       Dim tblDocumentoResumen As New Datatable
       Dim daDocumentoResumen As New SqlDataAdapter
       cmdDocumentoResumen = New SqlCommand
       cmdDocumentoResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoResumen.CommandText = "B_DocumentoResumenCOD"
       objConexion.ConexionOpen()
       cmdDocumentoResumen.Connection = objConexion.Conexion
       With cmdDocumentoResumen.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoResumen.SelectCommand = cmdDocumentoResumen
           daDocumentoResumen.Fill(tblDocumentoResumen)
           objConexion.ConexionClose()
           Return tblDocumentoResumen
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoResumen.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoResumen(ByVal ParamArray Argumentos() As System.Object) As DocumentoResumenEN
       Dim dtDocumentoResumen As New datatable
       Dim objDocumentoResumenE As New DocumentoResumenEN
       dtDocumentoResumen= objHelper.TraerDataTable("L_DocumentoResumen", Argumentos)
       If dtDocumentoResumen.Rows.Count = 0 Then
           Return objDocumentoResumenE
       End If
       For Each lector As DataRow In dtDocumentoResumen.Rows
           With objDocumentoResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objDocumentoResumenE
   End Function

   Public Function ListarArrayDocumentoResumen(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoResumenEN)
       Dim dtDocumentoResumen As New datatable
       Dim lista As New List(Of DocumentoResumenEN)
       Dim objDocumentoResumenE As New DocumentoResumenEN
       dtDocumentoResumen= objHelper.TraerDataTable("L_DocumentoResumen", Argumentos)
       If dtDocumentoResumen.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoResumen.Rows
           objDocumentoResumenE = New DocumentoResumenEN
           With objDocumentoResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoResumenE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoResumenNoArg() As List(Of DocumentoResumenEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoResumenEN)
       Dim objDocumentoResumenE As New DocumentoResumenEN
       While lector.Read
           objDocumentoResumenE = New DocumentoResumenEN
           With objDocumentoResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoResumenE)
           End With
       End While
       Return lista
   End Function

End Class
