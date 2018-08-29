Imports System.Data.SqlClient
Imports System.Reflection

public class ClsResumenDiario

   Public cmdResumenDiario As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarResumenDiario(ByVal objResumenDiarioE As ResumenDiarioEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdResumenDiario = New SqlCommand
       cmdResumenDiario.CommandType = CommandType.StoredProcedure
       cmdResumenDiario.CommandText = "I_ResumenDiario"
       objConexion.ConexionOpen()
       cmdResumenDiario.Connection = objConexion.Conexion
       With cmdResumenDiario.Parameters
           .Add("@ID", SqlDbType.int).Value = objResumenDiarioE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objResumenDiarioE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objResumenDiarioE.pFechaReferencia
           .Add("@IdResumen", SqlDbType.varchar).Value = objResumenDiarioE.pIdResumen
           .Add("@IDcontribuyente", SqlDbType.varchar).Value = objResumenDiarioE.pIDcontribuyente
       End with
       Try
           registro = cmdResumenDiario.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdResumenDiario.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarResumenDiario(ByVal objResumenDiarioE As ResumenDiarioEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdResumenDiario = New SqlCommand
       cmdResumenDiario.CommandType = CommandType.StoredProcedure
       cmdResumenDiario.CommandText = "U_ResumenDiario"
       objConexion.ConexionOpen()
       cmdResumenDiario.Connection = objConexion.Conexion
       With cmdResumenDiario.Parameters
           .Add("@ID", SqlDbType.int).Value = objResumenDiarioE.pID
           .Add("@FechaEmision", SqlDbType.date).Value = objResumenDiarioE.pFechaEmision
           .Add("@FechaReferencia", SqlDbType.date).Value = objResumenDiarioE.pFechaReferencia
           .Add("@IdResumen", SqlDbType.varchar).Value = objResumenDiarioE.pIdResumen
           .Add("@IDcontribuyente", SqlDbType.varchar).Value = objResumenDiarioE.pIDcontribuyente
       End with
       try
           registro = cmdResumenDiario.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdResumenDiario.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarResumenDiario(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdResumenDiario = New SqlCommand
       cmdResumenDiario.CommandType = CommandType.StoredProcedure
       cmdResumenDiario.CommandText = "D_ResumenDiario"
       objConexion.ConexionOpen()
       cmdResumenDiario.Connection = objConexion.Conexion
       With cmdResumenDiario.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdResumenDiario.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdResumenDiario.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodResumenDiario(ID As Integer) As Datatable
       Dim tblResumenDiario As New Datatable
       Dim daResumenDiario As New SqlDataAdapter
       cmdResumenDiario = New SqlCommand
       cmdResumenDiario.CommandType = CommandType.StoredProcedure
       cmdResumenDiario.CommandText = "B_ResumenDiarioCOD"
       objConexion.ConexionOpen()
       cmdResumenDiario.Connection = objConexion.Conexion
       With cmdResumenDiario.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daResumenDiario.SelectCommand = cmdResumenDiario
           daResumenDiario.Fill(tblResumenDiario)
           objConexion.ConexionClose()
           Return tblResumenDiario
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdResumenDiario.Parameters.Clear()
       End Try
   End Function

   Public Function ListarResumenDiario(ByVal ParamArray Argumentos() As System.Object) As ResumenDiarioEN
       Dim dtResumenDiario As New datatable
       Dim objResumenDiarioE As New ResumenDiarioEN
       dtResumenDiario= objHelper.TraerDataTable("L_ResumenDiario", Argumentos)
       If dtResumenDiario.Rows.Count = 0 Then
           Return objResumenDiarioE
       End If
       For Each lector As DataRow In dtResumenDiario.Rows
           With objResumenDiarioE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIDcontribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           End With
       Next
       Return objResumenDiarioE
   End Function

   Public Function ListarArrayResumenDiario(ByVal ParamArray Argumentos() As System.Object) As List(Of ResumenDiarioEN)
       Dim dtResumenDiario As New datatable
       Dim lista As New List(Of ResumenDiarioEN)
       Dim objResumenDiarioE As New ResumenDiarioEN
       dtResumenDiario= objHelper.TraerDataTable("L_ResumenDiario", Argumentos)
       If dtResumenDiario.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtResumenDiario.Rows
           objResumenDiarioE = New ResumenDiarioEN
           With objResumenDiarioE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIDcontribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objResumenDiarioE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayResumenDiarioNoArg() As List(Of ResumenDiarioEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of ResumenDiarioEN)
       Dim objResumenDiarioE As New ResumenDiarioEN
       While lector.Read
           objResumenDiarioE = New ResumenDiarioEN
           With objResumenDiarioE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pFechaEmision= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaReferencia= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdResumen= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pIDcontribuyente= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
           lista.Add(objResumenDiarioE)
           End With
       End While
       Return lista
   End Function

End Class
