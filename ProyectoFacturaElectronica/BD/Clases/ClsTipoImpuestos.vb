Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoImpuestos

   Public cmdTipoImpuestos As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoImpuestos(ByVal objTipoImpuestosE As TipoImpuestosEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoImpuestos = New SqlCommand
       cmdTipoImpuestos.CommandType = CommandType.StoredProcedure
       cmdTipoImpuestos.CommandText = "I_TipoImpuestos"
       objConexion.ConexionOpen()
       cmdTipoImpuestos.Connection = objConexion.Conexion
       With cmdTipoImpuestos.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoImpuestosE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoImpuestosE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoImpuestosE.pDescripcion
           .Add("@DescripcionCompleta", SqlDbType.varchar).Value = objTipoImpuestosE.pDescripcionCompleta
       End with
       Try
           registro = cmdTipoImpuestos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoImpuestos.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoImpuestos(ByVal objTipoImpuestosE As TipoImpuestosEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoImpuestos = New SqlCommand
       cmdTipoImpuestos.CommandType = CommandType.StoredProcedure
       cmdTipoImpuestos.CommandText = "U_TipoImpuestos"
       objConexion.ConexionOpen()
       cmdTipoImpuestos.Connection = objConexion.Conexion
       With cmdTipoImpuestos.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoImpuestosE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoImpuestosE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoImpuestosE.pDescripcion
           .Add("@DescripcionCompleta", SqlDbType.varchar).Value = objTipoImpuestosE.pDescripcionCompleta
       End with
       try
           registro = cmdTipoImpuestos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoImpuestos.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoImpuestos(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoImpuestos = New SqlCommand
       cmdTipoImpuestos.CommandType = CommandType.StoredProcedure
       cmdTipoImpuestos.CommandText = "D_TipoImpuestos"
       objConexion.ConexionOpen()
       cmdTipoImpuestos.Connection = objConexion.Conexion
       With cmdTipoImpuestos.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoImpuestos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoImpuestos.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoImpuestos(ID As Integer) As Datatable
       Dim tblTipoImpuestos As New Datatable
       Dim daTipoImpuestos As New SqlDataAdapter
       cmdTipoImpuestos = New SqlCommand
       cmdTipoImpuestos.CommandType = CommandType.StoredProcedure
       cmdTipoImpuestos.CommandText = "B_TipoImpuestosCOD"
       objConexion.ConexionOpen()
       cmdTipoImpuestos.Connection = objConexion.Conexion
       With cmdTipoImpuestos.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoImpuestos.SelectCommand = cmdTipoImpuestos
           daTipoImpuestos.Fill(tblTipoImpuestos)
           objConexion.ConexionClose()
           Return tblTipoImpuestos
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoImpuestos.Parameters.Clear()
       End Try
    End Function

    Public Function LoadTipoImpuestos() As DataTable
        Dim tblTipoImpuestos As New DataTable
        Dim daTipoImpuestos As New SqlDataAdapter
        cmdTipoImpuestos = New SqlCommand
        cmdTipoImpuestos.CommandType = CommandType.StoredProcedure
        cmdTipoImpuestos.CommandText = "S_TipoImpuestos"
        objConexion.ConexionOpen()
        cmdTipoImpuestos.Connection = objConexion.Conexion
        Try
            daTipoImpuestos.SelectCommand = cmdTipoImpuestos
            daTipoImpuestos.Fill(tblTipoImpuestos)

            Return tblTipoImpuestos
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al listar Tipo de impuestos *** " & ex.Message)
            Return Nothing
        Finally
            objConexion.ConexionClose()
            cmdTipoImpuestos.Parameters.Clear()
        End Try
    End Function

   Public Function ListarTipoImpuestos(ByVal ParamArray Argumentos() As System.Object) As TipoImpuestosEN
       Dim dtTipoImpuestos As New datatable
       Dim objTipoImpuestosE As New TipoImpuestosEN
       dtTipoImpuestos= objHelper.TraerDataTable("L_TipoImpuestos", Argumentos)
       If dtTipoImpuestos.Rows.Count = 0 Then
           Return objTipoImpuestosE
       End If
       For Each lector As DataRow In dtTipoImpuestos.Rows
           With objTipoImpuestosE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleta= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoImpuestosE
   End Function

   Public Function ListarArrayTipoImpuestos(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoImpuestosEN)
       Dim dtTipoImpuestos As New datatable
       Dim lista As New List(Of TipoImpuestosEN)
       Dim objTipoImpuestosE As New TipoImpuestosEN
       dtTipoImpuestos= objHelper.TraerDataTable("L_TipoImpuestos", Argumentos)
       If dtTipoImpuestos.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoImpuestos.Rows
           objTipoImpuestosE = New TipoImpuestosEN
           With objTipoImpuestosE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleta= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoImpuestosE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoImpuestosNoArg() As List(Of TipoImpuestosEN)
        Dim dtTipoImpuestos As New DataTable
        Dim lista As New List(Of TipoImpuestosEN)
        Dim objTipoImpuestosE As New TipoImpuestosEN
        dtTipoImpuestos = objHelper.TraerDatatable("S_TipoImpuestos")
        If dtTipoImpuestos.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoImpuestos.Rows
            objTipoImpuestosE = New TipoImpuestosEN
            With objTipoImpuestosE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleta = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoImpuestosE)
            End With
        Next
        Return lista
   End Function

End Class
