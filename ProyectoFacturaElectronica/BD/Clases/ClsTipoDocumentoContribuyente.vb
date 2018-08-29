Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDocumentoContribuyente

   Public cmdTipoDocumentoContribuyente As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDocumentoContribuyente(ByVal objTipoDocumentoContribuyenteE As TipoDocumentoContribuyenteEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoContribuyente = New SqlCommand
       cmdTipoDocumentoContribuyente.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoContribuyente.CommandText = "I_TipoDocumentoContribuyente"
       objConexion.ConexionOpen()
       cmdTipoDocumentoContribuyente.Connection = objConexion.Conexion
       With cmdTipoDocumentoContribuyente.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoContribuyenteE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoDocumentoContribuyente.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoContribuyente.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDocumentoContribuyente(ByVal objTipoDocumentoContribuyenteE As TipoDocumentoContribuyenteEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoContribuyente = New SqlCommand
       cmdTipoDocumentoContribuyente.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoContribuyente.CommandText = "U_TipoDocumentoContribuyente"
       objConexion.ConexionOpen()
       cmdTipoDocumentoContribuyente.Connection = objConexion.Conexion
       With cmdTipoDocumentoContribuyente.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoContribuyenteE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoContribuyenteE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoDocumentoContribuyente.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoContribuyente.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDocumentoContribuyente(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoContribuyente = New SqlCommand
       cmdTipoDocumentoContribuyente.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoContribuyente.CommandText = "D_TipoDocumentoContribuyente"
       objConexion.ConexionOpen()
       cmdTipoDocumentoContribuyente.Connection = objConexion.Conexion
       With cmdTipoDocumentoContribuyente.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDocumentoContribuyente.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoContribuyente.Parameters.Clear()
       End Try
   End Function

    Public Function LoadTipoDocumentoContribuyente() As DataTable
        Dim tblTipoDocumentoContribuyente As New DataTable
        Dim daTipoDocumentoContribuyente As New SqlDataAdapter
        cmdTipoDocumentoContribuyente = New SqlCommand
        cmdTipoDocumentoContribuyente.CommandType = CommandType.StoredProcedure
        cmdTipoDocumentoContribuyente.CommandText = "S_TipoDocumentoContribuyente"
        objConexion.ConexionOpen()
        cmdTipoDocumentoContribuyente.Connection = objConexion.Conexion
        Try
            daTipoDocumentoContribuyente.SelectCommand = cmdTipoDocumentoContribuyente
            daTipoDocumentoContribuyente.Fill(tblTipoDocumentoContribuyente)

            Return tblTipoDocumentoContribuyente
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al cargar Tipo de Documento de Contribuyente  **" & ex.Message)
            Return Nothing
        Finally
            objConexion.ConexionClose()
            cmdTipoDocumentoContribuyente.Parameters.Clear()
        End Try
    End Function

    Public Function BuscarXcodTipoDocumentoContribuyente(ID As Integer) As DataTable
        Dim tblTipoDocumentoContribuyente As New Datatable
        Dim daTipoDocumentoContribuyente As New SqlDataAdapter
        cmdTipoDocumentoContribuyente = New SqlCommand
        cmdTipoDocumentoContribuyente.CommandType = CommandType.StoredProcedure
        cmdTipoDocumentoContribuyente.CommandText = "B_TipoDocumentoContribuyenteCOD"
        objConexion.ConexionOpen()
        cmdTipoDocumentoContribuyente.Connection = objConexion.Conexion
        With cmdTipoDocumentoContribuyente.Parameters
            .Add("@ID", SqlDbType.int).Value = ID
        End With
        Try
            daTipoDocumentoContribuyente.SelectCommand = cmdTipoDocumentoContribuyente
            daTipoDocumentoContribuyente.Fill(tblTipoDocumentoContribuyente)
            objConexion.ConexionClose()
            Return tblTipoDocumentoContribuyente
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            cmdTipoDocumentoContribuyente.Parameters.Clear()
        End Try
    End Function

   Public Function ListarTipoDocumentoContribuyente(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoContribuyenteEN
       Dim dtTipoDocumentoContribuyente As New datatable
       Dim objTipoDocumentoContribuyenteE As New TipoDocumentoContribuyenteEN
       dtTipoDocumentoContribuyente= objHelper.TraerDataTable("L_TipoDocumentoContribuyente", Argumentos)
       If dtTipoDocumentoContribuyente.Rows.Count = 0 Then
           Return objTipoDocumentoContribuyenteE
       End If
       For Each lector As DataRow In dtTipoDocumentoContribuyente.Rows
           With objTipoDocumentoContribuyenteE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoDocumentoContribuyenteE
   End Function

   Public Function ListarArrayTipoDocumentoContribuyente(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoContribuyenteEN)
       Dim dtTipoDocumentoContribuyente As New datatable
       Dim lista As New List(Of TipoDocumentoContribuyenteEN)
       Dim objTipoDocumentoContribuyenteE As New TipoDocumentoContribuyenteEN
       dtTipoDocumentoContribuyente= objHelper.TraerDataTable("L_TipoDocumentoContribuyente", Argumentos)
       If dtTipoDocumentoContribuyente.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDocumentoContribuyente.Rows
           objTipoDocumentoContribuyenteE = New TipoDocumentoContribuyenteEN
           With objTipoDocumentoContribuyenteE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoDocumentoContribuyenteE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoDocumentoContribuyenteNoArg() As List(Of TipoDocumentoContribuyenteEN)
        'Dim lector As SqlDataReader
        Dim lista As New List(Of TipoDocumentoContribuyenteEN)
        Dim dtTipoDocumentoContribuyente As New DataTable
        dtTipoDocumentoContribuyente = objHelper.TraerDatatable("S_TipoDocumentoContribuyente")
        If dtTipoDocumentoContribuyente.Rows.Count = 0 Then
            Return lista
        End If
       Dim objTipoDocumentoContribuyenteE As New TipoDocumentoContribuyenteEN
        For Each lector As DataRow In dtTipoDocumentoContribuyente.Rows
            objTipoDocumentoContribuyenteE = New TipoDocumentoContribuyenteEN
            With objTipoDocumentoContribuyenteE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoDocumentoContribuyenteE)
            End With
        Next
        Return lista
    End Function

End Class
