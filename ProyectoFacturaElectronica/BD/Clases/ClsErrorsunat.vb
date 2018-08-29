Imports System.Data.SqlClient
Imports System.Reflection

public class ClsErrorsunat

   Public cmdErrorsunat As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarErrorsunat(ByVal objErrorsunatE As ErrorsunatEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdErrorsunat = New SqlCommand
       cmdErrorsunat.CommandType = CommandType.StoredProcedure
       cmdErrorsunat.CommandText = "I_Errorsunat"
       objConexion.ConexionOpen()
       cmdErrorsunat.Connection = objConexion.Conexion
       With cmdErrorsunat.Parameters
           .Add("@codigo", SqlDbType.varchar).Value = objErrorsunatE.pcodigo
           .Add("@descripcion", SqlDbType.varchar).Value = objErrorsunatE.pdescripcion
           .Add("@excepcion", SqlDbType.varchar).Value = objErrorsunatE.pexcepcion
           .Add("@rechazo", SqlDbType.varchar).Value = objErrorsunatE.prechazo
           .Add("@observaciones", SqlDbType.varchar).Value = objErrorsunatE.pobservaciones
           .Add("@estado", SqlDbType.int).Value = objErrorsunatE.pestado
       End with
       Try
           registro = cmdErrorsunat.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdErrorsunat.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarErrorsunat(ByVal objErrorsunatE As ErrorsunatEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdErrorsunat = New SqlCommand
       cmdErrorsunat.CommandType = CommandType.StoredProcedure
       cmdErrorsunat.CommandText = "U_Errorsunat"
       objConexion.ConexionOpen()
       cmdErrorsunat.Connection = objConexion.Conexion
       With cmdErrorsunat.Parameters
           .Add("@codigo", SqlDbType.varchar).Value = objErrorsunatE.pcodigo
           .Add("@descripcion", SqlDbType.varchar).Value = objErrorsunatE.pdescripcion
           .Add("@excepcion", SqlDbType.varchar).Value = objErrorsunatE.pexcepcion
           .Add("@rechazo", SqlDbType.varchar).Value = objErrorsunatE.prechazo
           .Add("@observaciones", SqlDbType.varchar).Value = objErrorsunatE.pobservaciones
           .Add("@estado", SqlDbType.int).Value = objErrorsunatE.pestado
       End with
       try
           registro = cmdErrorsunat.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdErrorsunat.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarErrorsunat(codigo As String) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdErrorsunat = New SqlCommand
       cmdErrorsunat.CommandType = CommandType.StoredProcedure
       cmdErrorsunat.CommandText = "D_Errorsunat"
       objConexion.ConexionOpen()
       cmdErrorsunat.Connection = objConexion.Conexion
       With cmdErrorsunat.Parameters
           .Add("@codigo", SqlDbType.varchar).Value =codigo
       End with
       Try
           registro = cmdErrorsunat.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdErrorsunat.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodErrorsunat(codigo As String) As Datatable
       Dim tblErrorsunat As New Datatable
       Dim daErrorsunat As New SqlDataAdapter
       cmdErrorsunat = New SqlCommand
       cmdErrorsunat.CommandType = CommandType.StoredProcedure
       cmdErrorsunat.CommandText = "B_ErrorsunatCOD"
       objConexion.ConexionOpen()
       cmdErrorsunat.Connection = objConexion.Conexion
       With cmdErrorsunat.Parameters
           .Add("@codigo", SqlDbType.varchar).Value =codigo
       End with
       Try
           daErrorsunat.SelectCommand = cmdErrorsunat
           daErrorsunat.Fill(tblErrorsunat)
           objConexion.ConexionClose()
           Return tblErrorsunat
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdErrorsunat.Parameters.Clear()
       End Try
   End Function

   Public Function ListarErrorsunat(ByVal ParamArray Argumentos() As System.Object) As ErrorsunatEN
       Dim dtErrorsunat As New datatable
       Dim objErrorsunatE As New ErrorsunatEN
       dtErrorsunat= objHelper.TraerDataTable("L_Errorsunat", Argumentos)
       If dtErrorsunat.Rows.Count = 0 Then
           Return objErrorsunatE
       End If
       For Each lector As DataRow In dtErrorsunat.Rows
           With objErrorsunatE
               .pcodigo= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pdescripcion= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pexcepcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .prechazo= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pobservaciones= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pestado= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
           End With
       Next
       Return objErrorsunatE
   End Function

   Public Function ListarArrayErrorsunat(ByVal ParamArray Argumentos() As System.Object) As List(Of ErrorsunatEN)
       Dim dtErrorsunat As New datatable
       Dim lista As New List(Of ErrorsunatEN)
       Dim objErrorsunatE As New ErrorsunatEN
       dtErrorsunat= objHelper.TraerDataTable("L_Errorsunat", Argumentos)
       If dtErrorsunat.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtErrorsunat.Rows
           objErrorsunatE = New ErrorsunatEN
           With objErrorsunatE
               .pcodigo= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pdescripcion= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pexcepcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .prechazo= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pobservaciones= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pestado= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
           lista.Add(objErrorsunatE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayErrorsunatNoArg() As List(Of ErrorsunatEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of ErrorsunatEN)
       Dim objErrorsunatE As New ErrorsunatEN
       While lector.Read
           objErrorsunatE = New ErrorsunatEN
           With objErrorsunatE
               .pcodigo= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pdescripcion= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pexcepcion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .prechazo= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pobservaciones= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pestado= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
           lista.Add(objErrorsunatE)
           End With
       End While
       Return lista
   End Function

End Class
