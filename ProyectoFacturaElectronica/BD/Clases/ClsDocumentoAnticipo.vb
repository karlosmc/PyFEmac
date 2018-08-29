Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoAnticipo

   Public cmdDocumentoAnticipo As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoAnticipo(ByVal objDocumentoAnticipoE As DocumentoAnticipoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoAnticipo = New SqlCommand
       cmdDocumentoAnticipo.CommandType = CommandType.StoredProcedure
       cmdDocumentoAnticipo.CommandText = "I_DocumentoAnticipo"
       objConexion.ConexionOpen()
       cmdDocumentoAnticipo.Connection = objConexion.Conexion
       With cmdDocumentoAnticipo.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoAnticipoE.pID
           .Add("@NroDocAnticipo", SqlDbType.varchar).Value = objDocumentoAnticipoE.pNroDocAnticipo
           .Add("@IdTipodocumento", SqlDbType.varchar).Value = objDocumentoAnticipoE.pIdTipodocumento
           .Add("@IdMoneda", SqlDbType.varchar).Value = objDocumentoAnticipoE.pIdMoneda
           .Add("@MontoAnticipo", SqlDbType.decimal).Value = objDocumentoAnticipoE.pMontoAnticipo
       End with
       Try
           registro = cmdDocumentoAnticipo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoAnticipo.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoAnticipo(ByVal objDocumentoAnticipoE As DocumentoAnticipoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoAnticipo = New SqlCommand
       cmdDocumentoAnticipo.CommandType = CommandType.StoredProcedure
       cmdDocumentoAnticipo.CommandText = "U_DocumentoAnticipo"
       objConexion.ConexionOpen()
       cmdDocumentoAnticipo.Connection = objConexion.Conexion
       With cmdDocumentoAnticipo.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoAnticipoE.pID
           .Add("@NroDocAnticipo", SqlDbType.varchar).Value = objDocumentoAnticipoE.pNroDocAnticipo
           .Add("@IdTipodocumento", SqlDbType.varchar).Value = objDocumentoAnticipoE.pIdTipodocumento
           .Add("@IdMoneda", SqlDbType.varchar).Value = objDocumentoAnticipoE.pIdMoneda
           .Add("@MontoAnticipo", SqlDbType.decimal).Value = objDocumentoAnticipoE.pMontoAnticipo
       End with
       try
           registro = cmdDocumentoAnticipo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoAnticipo.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoAnticipo(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoAnticipo = New SqlCommand
       cmdDocumentoAnticipo.CommandType = CommandType.StoredProcedure
       cmdDocumentoAnticipo.CommandText = "D_DocumentoAnticipo"
       objConexion.ConexionOpen()
       cmdDocumentoAnticipo.Connection = objConexion.Conexion
       With cmdDocumentoAnticipo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoAnticipo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoAnticipo.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoAnticipo(ID As Integer) As Datatable
       Dim tblDocumentoAnticipo As New Datatable
       Dim daDocumentoAnticipo As New SqlDataAdapter
       cmdDocumentoAnticipo = New SqlCommand
       cmdDocumentoAnticipo.CommandType = CommandType.StoredProcedure
       cmdDocumentoAnticipo.CommandText = "B_DocumentoAnticipoCOD"
       objConexion.ConexionOpen()
       cmdDocumentoAnticipo.Connection = objConexion.Conexion
       With cmdDocumentoAnticipo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoAnticipo.SelectCommand = cmdDocumentoAnticipo
           daDocumentoAnticipo.Fill(tblDocumentoAnticipo)
           objConexion.ConexionClose()
           Return tblDocumentoAnticipo
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoAnticipo.Parameters.Clear()
       End Try
    End Function

    Public Function LoadDocumentoAnticipo() As DataTable
        Dim tblDocumentoAnticipo As New DataTable
        Dim daDocumentoAnticipo As New SqlDataAdapter
        cmdDocumentoAnticipo = New SqlCommand
        cmdDocumentoAnticipo.CommandType = CommandType.StoredProcedure
        cmdDocumentoAnticipo.CommandText = "B_DocumentoAnticipoCOD"
        objConexion.ConexionOpen()
        cmdDocumentoAnticipo.Connection = objConexion.Conexion
       
        Try
            daDocumentoAnticipo.SelectCommand = cmdDocumentoAnticipo
            daDocumentoAnticipo.Fill(tblDocumentoAnticipo)
            objConexion.ConexionClose()
            Return tblDocumentoAnticipo
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al cargar DocumentoAnticipo  **" & ex.Message)
            Return Nothing
        Finally
            cmdDocumentoAnticipo.Parameters.Clear()
        End Try
    End Function

   Public Function ListarDocumentoAnticipo(ByVal ParamArray Argumentos() As System.Object) As DocumentoAnticipoEN
       Dim dtDocumentoAnticipo As New datatable
       Dim objDocumentoAnticipoE As New DocumentoAnticipoEN
       dtDocumentoAnticipo= objHelper.TraerDataTable("L_DocumentoAnticipo", Argumentos)
       If dtDocumentoAnticipo.Rows.Count = 0 Then
           Return objDocumentoAnticipoE
       End If
       For Each lector As DataRow In dtDocumentoAnticipo.Rows
           With objDocumentoAnticipoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pNroDocAnticipo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipodocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pMontoAnticipo= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objDocumentoAnticipoE
   End Function

   Public Function ListarArrayDocumentoAnticipo(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoAnticipoEN)
       Dim dtDocumentoAnticipo As New datatable
       Dim lista As New List(Of DocumentoAnticipoEN)
       Dim objDocumentoAnticipoE As New DocumentoAnticipoEN
       dtDocumentoAnticipo= objHelper.TraerDataTable("L_DocumentoAnticipo", Argumentos)
       If dtDocumentoAnticipo.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoAnticipo.Rows
           objDocumentoAnticipoE = New DocumentoAnticipoEN
           With objDocumentoAnticipoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pNroDocAnticipo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipodocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pMontoAnticipo= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoAnticipoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoAnticipoNoArg() As List(Of DocumentoAnticipoEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoAnticipoEN)
       Dim objDocumentoAnticipoE As New DocumentoAnticipoEN
       While lector.Read
           objDocumentoAnticipoE = New DocumentoAnticipoEN
           With objDocumentoAnticipoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pNroDocAnticipo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipodocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pMontoAnticipo= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objDocumentoAnticipoE)
           End With
       End While
       Return lista
   End Function

End Class
