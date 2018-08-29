Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDocumentoRelacionados

   Public cmdTipoDocumentoRelacionados As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDocumentoRelacionados(ByVal objTipoDocumentoRelacionadosE As TipoDocumentoRelacionadosEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoRelacionados = New SqlCommand
       cmdTipoDocumentoRelacionados.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoRelacionados.CommandText = "I_TipoDocumentoRelacionados"
       objConexion.ConexionOpen()
       cmdTipoDocumentoRelacionados.Connection = objConexion.Conexion
       With cmdTipoDocumentoRelacionados.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoRelacionadosE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoDocumentoRelacionados.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoRelacionados.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDocumentoRelacionados(ByVal objTipoDocumentoRelacionadosE As TipoDocumentoRelacionadosEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoRelacionados = New SqlCommand
       cmdTipoDocumentoRelacionados.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoRelacionados.CommandText = "U_TipoDocumentoRelacionados"
       objConexion.ConexionOpen()
       cmdTipoDocumentoRelacionados.Connection = objConexion.Conexion
       With cmdTipoDocumentoRelacionados.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoRelacionadosE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoRelacionadosE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoDocumentoRelacionados.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoRelacionados.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDocumentoRelacionados(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoRelacionados = New SqlCommand
       cmdTipoDocumentoRelacionados.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoRelacionados.CommandText = "D_TipoDocumentoRelacionados"
       objConexion.ConexionOpen()
       cmdTipoDocumentoRelacionados.Connection = objConexion.Conexion
       With cmdTipoDocumentoRelacionados.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDocumentoRelacionados.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoRelacionados.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoDocumentoRelacionados(ID As Integer) As Datatable
       Dim tblTipoDocumentoRelacionados As New Datatable
       Dim daTipoDocumentoRelacionados As New SqlDataAdapter
       cmdTipoDocumentoRelacionados = New SqlCommand
       cmdTipoDocumentoRelacionados.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoRelacionados.CommandText = "B_TipoDocumentoRelacionadosCOD"
       objConexion.ConexionOpen()
       cmdTipoDocumentoRelacionados.Connection = objConexion.Conexion
       With cmdTipoDocumentoRelacionados.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoDocumentoRelacionados.SelectCommand = cmdTipoDocumentoRelacionados
           daTipoDocumentoRelacionados.Fill(tblTipoDocumentoRelacionados)
           objConexion.ConexionClose()
           Return tblTipoDocumentoRelacionados
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoDocumentoRelacionados.Parameters.Clear()
       End Try
   End Function

   Public Function ListarTipoDocumentoRelacionados(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoRelacionadosEN
       Dim dtTipoDocumentoRelacionados As New datatable
       Dim objTipoDocumentoRelacionadosE As New TipoDocumentoRelacionadosEN
       dtTipoDocumentoRelacionados= objHelper.TraerDataTable("L_TipoDocumentoRelacionados", Argumentos)
       If dtTipoDocumentoRelacionados.Rows.Count = 0 Then
           Return objTipoDocumentoRelacionadosE
       End If
       For Each lector As DataRow In dtTipoDocumentoRelacionados.Rows
           With objTipoDocumentoRelacionadosE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoDocumentoRelacionadosE
   End Function

   Public Function ListarArrayTipoDocumentoRelacionados(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoRelacionadosEN)
       Dim dtTipoDocumentoRelacionados As New datatable
       Dim lista As New List(Of TipoDocumentoRelacionadosEN)
       Dim objTipoDocumentoRelacionadosE As New TipoDocumentoRelacionadosEN
       dtTipoDocumentoRelacionados= objHelper.TraerDataTable("L_TipoDocumentoRelacionados", Argumentos)
       If dtTipoDocumentoRelacionados.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDocumentoRelacionados.Rows
           objTipoDocumentoRelacionadosE = New TipoDocumentoRelacionadosEN
           With objTipoDocumentoRelacionadosE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoDocumentoRelacionadosE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoDocumentoRelacionadosNoArg() As List(Of TipoDocumentoRelacionadosEN)
        Dim dtTipoDocumentoRelacionados As New DataTable
        Dim lista As New List(Of TipoDocumentoRelacionadosEN)
        Dim objTipoDocumentoRelacionadosE As New TipoDocumentoRelacionadosEN
        dtTipoDocumentoRelacionados = objHelper.TraerDatatable("S_TipoDocumentoRelacionados")
        If dtTipoDocumentoRelacionados.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoDocumentoRelacionados.Rows
            objTipoDocumentoRelacionadosE = New TipoDocumentoRelacionadosEN
            With objTipoDocumentoRelacionadosE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoDocumentoRelacionadosE)
            End With
        Next
        Return lista
   End Function

End Class
