Imports System.Data.SqlClient
Imports System.Reflection

public class ClsTipoDatoAdicionales

   Public cmdTipoDatoAdicionales As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarTipoDatoAdicionales(ByVal objTipoDatoAdicionalesE As TipoDatoAdicionalesEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDatoAdicionales = New SqlCommand
       cmdTipoDatoAdicionales.CommandType = CommandType.StoredProcedure
       cmdTipoDatoAdicionales.CommandText = "I_TipoDatoAdicionales"
       objConexion.ConexionOpen()
       cmdTipoDatoAdicionales.Connection = objConexion.Conexion
       With cmdTipoDatoAdicionales.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDatoAdicionalesE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pDescripcionCompleja
       End with
       Try
           registro = cmdTipoDatoAdicionales.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDatoAdicionales.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarTipoDatoAdicionales(ByVal objTipoDatoAdicionalesE As TipoDatoAdicionalesEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDatoAdicionales = New SqlCommand
       cmdTipoDatoAdicionales.CommandType = CommandType.StoredProcedure
       cmdTipoDatoAdicionales.CommandText = "U_TipoDatoAdicionales"
       objConexion.ConexionOpen()
       cmdTipoDatoAdicionales.Connection = objConexion.Conexion
       With cmdTipoDatoAdicionales.Parameters
           .Add("@ID", SqlDbType.int).Value = objTipoDatoAdicionalesE.pID
           .Add("@Codigo", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pCodigo
           .Add("@Descripcion", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pDescripcion
           .Add("@DescripcionCompleja", SqlDbType.varchar).Value = objTipoDatoAdicionalesE.pDescripcionCompleja
       End with
       try
           registro = cmdTipoDatoAdicionales.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDatoAdicionales.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarTipoDatoAdicionales(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdTipoDatoAdicionales = New SqlCommand
       cmdTipoDatoAdicionales.CommandType = CommandType.StoredProcedure
       cmdTipoDatoAdicionales.CommandText = "D_TipoDatoAdicionales"
       objConexion.ConexionOpen()
       cmdTipoDatoAdicionales.Connection = objConexion.Conexion
       With cmdTipoDatoAdicionales.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdTipoDatoAdicionales.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdTipoDatoAdicionales.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodTipoDatoAdicionales(ID As Integer) As Datatable
       Dim tblTipoDatoAdicionales As New Datatable
       Dim daTipoDatoAdicionales As New SqlDataAdapter
       cmdTipoDatoAdicionales = New SqlCommand
       cmdTipoDatoAdicionales.CommandType = CommandType.StoredProcedure
       cmdTipoDatoAdicionales.CommandText = "B_TipoDatoAdicionalesCOD"
       objConexion.ConexionOpen()
       cmdTipoDatoAdicionales.Connection = objConexion.Conexion
       With cmdTipoDatoAdicionales.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daTipoDatoAdicionales.SelectCommand = cmdTipoDatoAdicionales
           daTipoDatoAdicionales.Fill(tblTipoDatoAdicionales)
           objConexion.ConexionClose()
           Return tblTipoDatoAdicionales
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdTipoDatoAdicionales.Parameters.Clear()
       End Try
   End Function

   Public Function ListarTipoDatoAdicionales(ByVal ParamArray Argumentos() As System.Object) As TipoDatoAdicionalesEN
       Dim dtTipoDatoAdicionales As New datatable
       Dim objTipoDatoAdicionalesE As New TipoDatoAdicionalesEN
       dtTipoDatoAdicionales= objHelper.TraerDataTable("L_TipoDatoAdicionales", Argumentos)
       If dtTipoDatoAdicionales.Rows.Count = 0 Then
           Return objTipoDatoAdicionalesE
       End If
       For Each lector As DataRow In dtTipoDatoAdicionales.Rows
           With objTipoDatoAdicionalesE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           End With
       Next
       Return objTipoDatoAdicionalesE
   End Function

   Public Function ListarArrayTipoDatoAdicionales(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDatoAdicionalesEN)
       Dim dtTipoDatoAdicionales As New datatable
       Dim lista As New List(Of TipoDatoAdicionalesEN)
       Dim objTipoDatoAdicionalesE As New TipoDatoAdicionalesEN
       dtTipoDatoAdicionales= objHelper.TraerDataTable("L_TipoDatoAdicionales", Argumentos)
       If dtTipoDatoAdicionales.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtTipoDatoAdicionales.Rows
           objTipoDatoAdicionalesE = New TipoDatoAdicionalesEN
           With objTipoDatoAdicionalesE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pCodigo= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pDescripcionCompleja= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
           lista.Add(objTipoDatoAdicionalesE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayTipoDatoAdicionalesNoArg() As List(Of TipoDatoAdicionalesEN)
        Dim dtTipoDatoAdicionales As New DataTable
        Dim lista As New List(Of TipoDatoAdicionalesEN)
        Dim objTipoDatoAdicionalesE As New TipoDatoAdicionalesEN
        dtTipoDatoAdicionales = objHelper.TraerDatatable("S_TipoDatoAdicionales")
        If dtTipoDatoAdicionales.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtTipoDatoAdicionales.Rows
            objTipoDatoAdicionalesE = New TipoDatoAdicionalesEN
            With objTipoDatoAdicionalesE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pCodigo = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pDescripcion = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pDescripcionCompleja = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                lista.Add(objTipoDatoAdicionalesE)
            End With
        Next
        Return lista
   End Function

End Class
