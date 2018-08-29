Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDocumentoAnticipos

   Public cmdTipoDocumentoAnticipos As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDocumentoAnticipos(ByVal objTipoDocumentoAnticiposE As TipoDocumentoAnticiposEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoAnticipos = New SqlCommand
       cmdTipoDocumentoAnticipos.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoAnticipos.CommandText = "I_TipoDocumentoAnticipos"
       objConexion.ConexionOpen()
       cmdTipoDocumentoAnticipos.Connection = objConexion.Conexion
       With cmdTipoDocumentoAnticipos.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoAnticiposE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoDocumentoAnticipos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoAnticipos.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDocumentoAnticipos(ByVal objTipoDocumentoAnticiposE As TipoDocumentoAnticiposEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoAnticipos = New SqlCommand
       cmdTipoDocumentoAnticipos.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoAnticipos.CommandText = "U_TipoDocumentoAnticipos"
       objConexion.ConexionOpen()
       cmdTipoDocumentoAnticipos.Connection = objConexion.Conexion
       With cmdTipoDocumentoAnticipos.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDocumentoAnticiposE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDocumentoAnticiposE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoDocumentoAnticipos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoAnticipos.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDocumentoAnticipos(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDocumentoAnticipos = New SqlCommand
       cmdTipoDocumentoAnticipos.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoAnticipos.CommandText = "D_TipoDocumentoAnticipos"
       objConexion.ConexionOpen()
       cmdTipoDocumentoAnticipos.Connection = objConexion.Conexion
       With cmdTipoDocumentoAnticipos.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDocumentoAnticipos.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDocumentoAnticipos.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoDocumentoAnticipos(ID As Integer) As Datatable
       Dim tblTipoDocumentoAnticipos As New Datatable
       Dim daTipoDocumentoAnticipos As New SqlDataAdapter
       cmdTipoDocumentoAnticipos = New SqlCommand
       cmdTipoDocumentoAnticipos.CommandType = CommandType.StoredProcedure
       cmdTipoDocumentoAnticipos.CommandText = "B_TipoDocumentoAnticiposCOD"
       objConexion.ConexionOpen()
       cmdTipoDocumentoAnticipos.Connection = objConexion.Conexion
       With cmdTipoDocumentoAnticipos.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoDocumentoAnticipos.SelectCommand = cmdTipoDocumentoAnticipos
           daTipoDocumentoAnticipos.Fill(tblTipoDocumentoAnticipos)
           objConexion.ConexionClose()
           Return tblTipoDocumentoAnticipos
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoDocumentoAnticipos.Parameters.Clear()
       End Try
   End Function

   Public Function ListarTipoDocumentoAnticipos(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoAnticiposEN
       Dim dtTipoDocumentoAnticipos As New datatable
       Dim objTipoDocumentoAnticiposE As New TipoDocumentoAnticiposEN
       dtTipoDocumentoAnticipos= objHelper.TraerDataTable("L_TipoDocumentoAnticipos", Argumentos)
       If dtTipoDocumentoAnticipos.Rows.Count = 0 Then
           Return objTipoDocumentoAnticiposE
       End If
       For Each lector As DataRow In dtTipoDocumentoAnticipos.Rows
           With objTipoDocumentoAnticiposE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoDocumentoAnticiposE
   End Function
    Public Function LoadDocumentoAnticipo() As DataTable
        Dim tblDocumentoAnticipo As New DataTable
        Dim daDocumentoAnticipo As New SqlDataAdapter
        cmdTipoDocumentoAnticipos = New SqlCommand
        cmdTipoDocumentoAnticipos.CommandType = CommandType.StoredProcedure
        cmdTipoDocumentoAnticipos.CommandText = "S_TipoDocumentoAnticipos"
        objConexion.ConexionOpen()
        cmdTipoDocumentoAnticipos.Connection = objConexion.Conexion

        Try
            daDocumentoAnticipo.SelectCommand = cmdTipoDocumentoAnticipos
            daDocumentoAnticipo.Fill(tblDocumentoAnticipo)

            Return tblDocumentoAnticipo
        Catch ex As Exception
            Throw New ClsErrorExcepcion("Error al cargar Tipo de Documento Anticipo  **" & ex.Message)
            Return Nothing
        Finally
            cmdTipoDocumentoAnticipos.Parameters.Clear()
            objConexion.ConexionClose()
        End Try
    End Function
   Public Function ListarArrayTipoDocumentoAnticipos(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoAnticiposEN)
       Dim dtTipoDocumentoAnticipos As New datatable
       Dim lista As New List(Of TipoDocumentoAnticiposEN)
       Dim objTipoDocumentoAnticiposE As New TipoDocumentoAnticiposEN
       dtTipoDocumentoAnticipos= objHelper.TraerDataTable("L_TipoDocumentoAnticipos", Argumentos)
       If dtTipoDocumentoAnticipos.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDocumentoAnticipos.Rows
           objTipoDocumentoAnticiposE = New TipoDocumentoAnticiposEN
           With objTipoDocumentoAnticiposE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoDocumentoAnticiposE)
           End With
       Next
       Return lista
   End Function

    Public Function ListarArrayTipoDocumentoAnticiposNoArg() As List(Of TipoDocumentoAnticiposEN)
        Dim dtTipoDocumentoAnticipos As New DataTable
        'Dim lector As SqlDataReader
        dtTipoDocumentoAnticipos = objHelper.TraerDatatable("S_TipoDocumentoAnticipos")
        Dim lista As New List(Of TipoDocumentoAnticiposEN)
        If dtTipoDocumentoAnticipos.Rows.Count = 0 Then
            Return lista
        End If
        Dim objTipoDocumentoAnticiposE As New TipoDocumentoAnticiposEN
        For Each lector As DataRow In dtTipoDocumentoAnticipos.Rows
            objTipoDocumentoAnticiposE = New TipoDocumentoAnticiposEN
            With objTipoDocumentoAnticiposE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoDocumentoAnticiposE)
            End With
        Next
        Return lista
    End Function

End Class
