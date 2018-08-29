Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoDetalleBaja

   Public cmdDocumentoDetalleBaja As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoDetalleBaja(ByVal objDocumentoDetalleBajaE As DocumentoDetalleBajaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleBaja = New SqlCommand
       cmdDocumentoDetalleBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleBaja.CommandText = "I_DocumentoDetalleBaja"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleBaja.Connection = objConexion.Conexion
       With cmdDocumentoDetalleBaja.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleBajaE.pID
           .Add("@IdDocumentoBaja", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pIdDocumentoBaja
           .Add("@linea", SqlDbType.int).Value = objDocumentoDetalleBajaE.plinea
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pIdTipoDocumento
           .Add("@DocumentoSerie", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pDocumentoSerie
           .Add("@DocumentoNumero", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pDocumentoNumero
           .Add("@MotivoBaja", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pMotivoBaja
       End with
       Try
           registro = cmdDocumentoDetalleBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleBaja.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoDetalleBaja(ByVal objDocumentoDetalleBajaE As DocumentoDetalleBajaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleBaja = New SqlCommand
       cmdDocumentoDetalleBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleBaja.CommandText = "U_DocumentoDetalleBaja"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleBaja.Connection = objConexion.Conexion
       With cmdDocumentoDetalleBaja.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleBajaE.pID
           .Add("@IdDocumentoBaja", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pIdDocumentoBaja
           .Add("@linea", SqlDbType.int).Value = objDocumentoDetalleBajaE.plinea
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pIdTipoDocumento
           .Add("@DocumentoSerie", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pDocumentoSerie
           .Add("@DocumentoNumero", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pDocumentoNumero
           .Add("@MotivoBaja", SqlDbType.varchar).Value = objDocumentoDetalleBajaE.pMotivoBaja
       End with
       try
           registro = cmdDocumentoDetalleBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleBaja.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoDetalleBaja(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleBaja = New SqlCommand
       cmdDocumentoDetalleBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleBaja.CommandText = "D_DocumentoDetalleBaja"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleBaja.Connection = objConexion.Conexion
       With cmdDocumentoDetalleBaja.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoDetalleBaja.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleBaja.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoDetalleBaja(ID As Integer) As Datatable
       Dim tblDocumentoDetalleBaja As New Datatable
       Dim daDocumentoDetalleBaja As New SqlDataAdapter
       cmdDocumentoDetalleBaja = New SqlCommand
       cmdDocumentoDetalleBaja.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleBaja.CommandText = "B_DocumentoDetalleBajaCOD"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleBaja.Connection = objConexion.Conexion
       With cmdDocumentoDetalleBaja.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoDetalleBaja.SelectCommand = cmdDocumentoDetalleBaja
           daDocumentoDetalleBaja.Fill(tblDocumentoDetalleBaja)
           objConexion.ConexionClose()
           Return tblDocumentoDetalleBaja
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoDetalleBaja.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoDetalleBaja(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleBajaEN
       Dim dtDocumentoDetalleBaja As New datatable
       Dim objDocumentoDetalleBajaE As New DocumentoDetalleBajaEN
       dtDocumentoDetalleBaja= objHelper.TraerDataTable("L_DocumentoDetalleBaja", Argumentos)
       If dtDocumentoDetalleBaja.Rows.Count = 0 Then
           Return objDocumentoDetalleBajaE
       End If
       For Each lector As DataRow In dtDocumentoDetalleBaja.Rows
           With objDocumentoDetalleBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoBaja= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .plinea= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pDocumentoSerie= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDocumentoNumero= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pMotivoBaja= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
           End With
       Next
       Return objDocumentoDetalleBajaE
   End Function

   Public Function ListarArrayDocumentoDetalleBaja(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleBajaEN)
       Dim dtDocumentoDetalleBaja As New datatable
       Dim lista As New List(Of DocumentoDetalleBajaEN)
       Dim objDocumentoDetalleBajaE As New DocumentoDetalleBajaEN
       dtDocumentoDetalleBaja= objHelper.TraerDataTable("L_DocumentoDetalleBaja", Argumentos)
       If dtDocumentoDetalleBaja.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoDetalleBaja.Rows
           objDocumentoDetalleBajaE = New DocumentoDetalleBajaEN
           With objDocumentoDetalleBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoBaja= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .plinea= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pDocumentoSerie= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDocumentoNumero= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pMotivoBaja= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
           lista.Add(objDocumentoDetalleBajaE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoDetalleBajaNoArg() As List(Of DocumentoDetalleBajaEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoDetalleBajaEN)
       Dim objDocumentoDetalleBajaE As New DocumentoDetalleBajaEN
       While lector.Read
           objDocumentoDetalleBajaE = New DocumentoDetalleBajaEN
           With objDocumentoDetalleBajaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoBaja= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .plinea= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pDocumentoSerie= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDocumentoNumero= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pMotivoBaja= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
           lista.Add(objDocumentoDetalleBajaE)
           End With
       End While
       Return lista
   End Function

End Class
