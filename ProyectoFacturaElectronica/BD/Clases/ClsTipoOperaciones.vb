Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoOperaciones

   Public cmdTipoOperaciones As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoOperaciones(ByVal objTipoOperacionesE As TipoOperacionesEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoOperaciones = New SqlCommand
       cmdTipoOperaciones.CommandType = CommandType.StoredProcedure
       cmdTipoOperaciones.CommandText = "I_TipoOperaciones"
       objConexion.ConexionOpen()
       cmdTipoOperaciones.Connection = objConexion.Conexion
       With cmdTipoOperaciones.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoOperacionesE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoOperacionesE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoOperacionesE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoOperacionesE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoOperaciones.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoOperaciones.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoOperaciones(ByVal objTipoOperacionesE As TipoOperacionesEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoOperaciones = New SqlCommand
       cmdTipoOperaciones.CommandType = CommandType.StoredProcedure
       cmdTipoOperaciones.CommandText = "U_TipoOperaciones"
       objConexion.ConexionOpen()
       cmdTipoOperaciones.Connection = objConexion.Conexion
       With cmdTipoOperaciones.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoOperacionesE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoOperacionesE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoOperacionesE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoOperacionesE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoOperaciones.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoOperaciones.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoOperaciones(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoOperaciones = New SqlCommand
       cmdTipoOperaciones.CommandType = CommandType.StoredProcedure
       cmdTipoOperaciones.CommandText = "D_TipoOperaciones"
       objConexion.ConexionOpen()
       cmdTipoOperaciones.Connection = objConexion.Conexion
       With cmdTipoOperaciones.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoOperaciones.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoOperaciones.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoOperaciones(ID As Integer) As Datatable
       Dim tblTipoOperaciones As New Datatable
       Dim daTipoOperaciones As New SqlDataAdapter
       cmdTipoOperaciones = New SqlCommand
       cmdTipoOperaciones.CommandType = CommandType.StoredProcedure
       cmdTipoOperaciones.CommandText = "B_TipoOperacionesCOD"
       objConexion.ConexionOpen()
       cmdTipoOperaciones.Connection = objConexion.Conexion
       With cmdTipoOperaciones.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoOperaciones.SelectCommand = cmdTipoOperaciones
           daTipoOperaciones.Fill(tblTipoOperaciones)
           objConexion.ConexionClose()
           Return tblTipoOperaciones
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoOperaciones.Parameters.Clear()
       End Try
    End Function

    Public Function LoadTipoOperacion() As DataTable
        Dim tblTipoOperaciones As New DataTable
        Dim daTipoOperaciones As New SqlDataAdapter
        cmdTipoOperaciones = New SqlCommand
        cmdTipoOperaciones.CommandType = CommandType.StoredProcedure
        cmdTipoOperaciones.CommandText = "S_TipoOperaciones"
        objConexion.ConexionOpen()
        cmdTipoOperaciones.Connection = objConexion.Conexion
        Try
            daTipoOperaciones.SelectCommand = cmdTipoOperaciones
            daTipoOperaciones.Fill(tblTipoOperaciones)
            Return tblTipoOperaciones
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al cargar Tipo de operacion **" & ex.Message)
            Return Nothing
        Finally
            cmdTipoOperaciones.Parameters.Clear()
            objConexion.ConexionClose()
        End Try
    End Function

   Public Function ListarTipoOperaciones(ByVal ParamArray Argumentos() As System.Object) As TipoOperacionesEN
       Dim dtTipoOperaciones As New datatable
       Dim objTipoOperacionesE As New TipoOperacionesEN
       dtTipoOperaciones= objHelper.TraerDataTable("L_TipoOperaciones", Argumentos)
       If dtTipoOperaciones.Rows.Count = 0 Then
           Return objTipoOperacionesE
       End If
       For Each lector As DataRow In dtTipoOperaciones.Rows
           With objTipoOperacionesE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoOperacionesE
   End Function

   Public Function ListarArrayTipoOperaciones(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoOperacionesEN)
       Dim dtTipoOperaciones As New datatable
       Dim lista As New List(Of TipoOperacionesEN)
       Dim objTipoOperacionesE As New TipoOperacionesEN
       dtTipoOperaciones= objHelper.TraerDataTable("L_TipoOperaciones", Argumentos)
       If dtTipoOperaciones.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoOperaciones.Rows
           objTipoOperacionesE = New TipoOperacionesEN
           With objTipoOperacionesE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoOperacionesE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoOperacionesNoArg() As List(Of TipoOperacionesEN)
        Dim dtTipoOperaciones As New DataTable
        Dim lista As New List(Of TipoOperacionesEN)
        Dim objTipoOperacionesE As New TipoOperacionesEN
        dtTipoOperaciones = objHelper.TraerDatatable("S_TipoOperaciones")
        If dtTipoOperaciones.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoOperaciones.Rows
            objTipoOperacionesE = New TipoOperacionesEN
            With objTipoOperacionesE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoOperacionesE)
            End With
        Next
        Return lista
   End Function

End Class
