Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDiscrepancia

   Public cmdTipoDiscrepancia As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDiscrepancia(ByVal objTipoDiscrepanciaE As TipoDiscrepanciaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDiscrepancia = New SqlCommand
       cmdTipoDiscrepancia.CommandType = CommandType.StoredProcedure
       cmdTipoDiscrepancia.CommandText = "I_TipoDiscrepancia"
       objConexion.ConexionOpen()
       cmdTipoDiscrepancia.Connection = objConexion.Conexion
       With cmdTipoDiscrepancia.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDiscrepanciaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pDescripcionCompleja
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pIdTipoDocumento
       End with
       Try
           registro = cmdTipoDiscrepancia.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDiscrepancia.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDiscrepancia(ByVal objTipoDiscrepanciaE As TipoDiscrepanciaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDiscrepancia = New SqlCommand
       cmdTipoDiscrepancia.CommandType = CommandType.StoredProcedure
       cmdTipoDiscrepancia.CommandText = "U_TipoDiscrepancia"
       objConexion.ConexionOpen()
       cmdTipoDiscrepancia.Connection = objConexion.Conexion
       With cmdTipoDiscrepancia.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDiscrepanciaE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pDescripcionCompleja
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objTipoDiscrepanciaE.pIdTipoDocumento
       End with
       try
           registro = cmdTipoDiscrepancia.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDiscrepancia.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDiscrepancia(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDiscrepancia = New SqlCommand
       cmdTipoDiscrepancia.CommandType = CommandType.StoredProcedure
       cmdTipoDiscrepancia.CommandText = "D_TipoDiscrepancia"
       objConexion.ConexionOpen()
       cmdTipoDiscrepancia.Connection = objConexion.Conexion
       With cmdTipoDiscrepancia.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDiscrepancia.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDiscrepancia.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoDiscrepancia(ID As Integer) As Datatable
       Dim tblTipoDiscrepancia As New Datatable
       Dim daTipoDiscrepancia As New SqlDataAdapter
       cmdTipoDiscrepancia = New SqlCommand
       cmdTipoDiscrepancia.CommandType = CommandType.StoredProcedure
       cmdTipoDiscrepancia.CommandText = "B_TipoDiscrepanciaCOD"
       objConexion.ConexionOpen()
       cmdTipoDiscrepancia.Connection = objConexion.Conexion
       With cmdTipoDiscrepancia.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoDiscrepancia.SelectCommand = cmdTipoDiscrepancia
           daTipoDiscrepancia.Fill(tblTipoDiscrepancia)
           objConexion.ConexionClose()
           Return tblTipoDiscrepancia
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoDiscrepancia.Parameters.Clear()
       End Try
   End Function

   Public Function ListarTipoDiscrepancia(ByVal ParamArray Argumentos() As System.Object) As TipoDiscrepanciaEN
       Dim dtTipoDiscrepancia As New datatable
       Dim objTipoDiscrepanciaE As New TipoDiscrepanciaEN
       dtTipoDiscrepancia= objHelper.TraerDataTable("L_TipoDiscrepancia", Argumentos)
       If dtTipoDiscrepancia.Rows.Count = 0 Then
           Return objTipoDiscrepanciaE
       End If
       For Each lector As DataRow In dtTipoDiscrepancia.Rows
           With objTipoDiscrepanciaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objTipoDiscrepanciaE
   End Function

   Public Function ListarArrayTipoDiscrepancia(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDiscrepanciaEN)
       Dim dtTipoDiscrepancia As New datatable
       Dim lista As New List(Of TipoDiscrepanciaEN)
       Dim objTipoDiscrepanciaE As New TipoDiscrepanciaEN
       dtTipoDiscrepancia= objHelper.TraerDataTable("L_TipoDiscrepancia", Argumentos)
       If dtTipoDiscrepancia.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDiscrepancia.Rows
           objTipoDiscrepanciaE = New TipoDiscrepanciaEN
           With objTipoDiscrepanciaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objTipoDiscrepanciaE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoDiscrepanciaNoArg() As List(Of TipoDiscrepanciaEN)
        Dim dtTipoDiscrepancia As New DataTable
        Dim lista As New List(Of TipoDiscrepanciaEN)
        Dim objTipoDiscrepanciaE As New TipoDiscrepanciaEN
        dtTipoDiscrepancia = objHelper.TraerDatatable("S_TipoDiscrepancia")
        If dtTipoDiscrepancia.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoDiscrepancia.Rows
            objTipoDiscrepanciaE = New TipoDiscrepanciaEN
            With objTipoDiscrepanciaE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                .pIdTipoDocumento = IIf(String.IsNullOrEmpty(lector(4)), "", lector(4))
                lista.Add(objTipoDiscrepanciaE)
            End With
        Next
        Return lista
   End Function

End Class
