Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDocumento

   Public cmdTipoDocumento As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDocumento(ByVal objTipoDocumentoE As TipoDocumentoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumento = New SqlCommand
       cmdTipoDocumento.CommandType = CommandType.StoredProcedure
       cmdTipoDocumento.CommandText = "I_TipoDocumento"
       objConexion.ConexionOpen()
       cmdTipoDocumento.Connection = objConexion.Conexion
       With cmdTipoDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDocumento(ByVal objTipoDocumentoE As TipoDocumentoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumento = New SqlCommand
       cmdTipoDocumento.CommandType = CommandType.StoredProcedure
       cmdTipoDocumento.CommandText = "U_TipoDocumento"
       objConexion.ConexionOpen()
       cmdTipoDocumento.Connection = objConexion.Conexion
       With cmdTipoDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDocumento(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumento = New SqlCommand
       cmdTipoDocumento.CommandType = CommandType.StoredProcedure
       cmdTipoDocumento.CommandText = "D_TipoDocumento"
       objConexion.ConexionOpen()
       cmdTipoDocumento.Connection = objConexion.Conexion
       With cmdTipoDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDocumento.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumento.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoDocumento(ID As Integer) As Datatable
       Dim tblTipoDocumento As New Datatable
       Dim daTipoDocumento As New SqlDataAdapter
       cmdTipoDocumento = New SqlCommand
       cmdTipoDocumento.CommandType = CommandType.StoredProcedure
       cmdTipoDocumento.CommandText = "B_TipoDocumentoCOD"
       objConexion.ConexionOpen()
       cmdTipoDocumento.Connection = objConexion.Conexion
       With cmdTipoDocumento.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoDocumento.SelectCommand = cmdTipoDocumento
           daTipoDocumento.Fill(tblTipoDocumento)
           objConexion.ConexionClose()
           Return tblTipoDocumento
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoDocumento.Parameters.Clear()
       End Try
    End Function

    Public Function ListarTipoDocumentos() As DataTable
        Dim tblTipoDocumento As New DataTable
        Dim daTipoDocumento As New SqlDataAdapter
        cmdTipoDocumento = New SqlCommand
        cmdTipoDocumento.CommandType = CommandType.StoredProcedure
        cmdTipoDocumento.CommandText = "S_TipoDocumento"
        objConexion.ConexionOpen()
        cmdTipoDocumento.Connection = objConexion.Conexion
        Try
            daTipoDocumento.SelectCommand = cmdTipoDocumento
            daTipoDocumento.Fill(tblTipoDocumento)

            Return tblTipoDocumento
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error el listar Tipos de documento ** " & ex.Message)
            Return Nothing
        Finally
            objConexion.ConexionClose()
            cmdTipoDocumento.Dispose()
        End Try
    End Function

   Public Function ListarTipoDocumento(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoEN
       Dim dtTipoDocumento As New datatable
       Dim objTipoDocumentoE As New TipoDocumentoEN
       dtTipoDocumento= objHelper.TraerDataTable("L_TipoDocumento", Argumentos)
       If dtTipoDocumento.Rows.Count = 0 Then
           Return objTipoDocumentoE
       End If
       For Each lector As DataRow In dtTipoDocumento.Rows
           With objTipoDocumentoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoDocumentoE
   End Function

   Public Function ListarArrayTipoDocumento(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoEN)
       Dim dtTipoDocumento As New datatable
       Dim lista As New List(Of TipoDocumentoEN)
       Dim objTipoDocumentoE As New TipoDocumentoEN
       dtTipoDocumento= objHelper.TraerDataTable("L_TipoDocumento", Argumentos)
       If dtTipoDocumento.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDocumento.Rows
           objTipoDocumentoE = New TipoDocumentoEN
           With objTipoDocumentoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoDocumentoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoDocumentoNoArg() As List(Of TipoDocumentoEN)
        Dim dtTipoDocumento As New DataTable
        Dim lista As New List(Of TipoDocumentoEN)
        Dim objTipoDocumentoE As New TipoDocumentoEN
        dtTipoDocumento = objHelper.TraerDatatable("S_TipoDocumento")
        If dtTipoDocumento.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoDocumento.Rows
            objTipoDocumentoE = New TipoDocumentoEN
            With objTipoDocumentoE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoDocumentoE)
            End With
        Next
        Return lista
   End Function

End Class
