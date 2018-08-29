Imports System.Data.SqlClient
Imports System.Reflection

public class ClsParametro

   Public cmdParametro As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarParametro(ByVal objParametroE As ParametroEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdParametro = New SqlCommand
       cmdParametro.CommandType = CommandType.StoredProcedure
       cmdParametro.CommandText = "I_Parametro"
       objConexion.ConexionOpen()
       cmdParametro.Connection = objConexion.Conexion
       With cmdParametro.Parameters
           .Add("@ID", SqlDbType.int).Value = objParametroE.pID
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objParametroE.pIdContribuyente
           .Add("@TasaIgv", SqlDbType.decimal).Value = objParametroE.pTasaIgv
           .Add("@TasaIsc", SqlDbType.decimal).Value = objParametroE.pTasaIsc
           .Add("@TasaDetraccion", SqlDbType.decimal).Value = objParametroE.pTasaDetraccion
           .Add("@CertificadoDigital", SqlDbType.varchar).Value = objParametroE.pCertificadoDigital
           .Add("@ClaveCertificado", SqlDbType.varchar).Value = objParametroE.pClaveCertificado
           .Add("@UsuarioSol", SqlDbType.varchar).Value = objParametroE.pUsuarioSol
           .Add("@ClaveSol", SqlDbType.varchar).Value = objParametroE.pClaveSol
       End with
       Try
           registro = cmdParametro.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdParametro.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarParametro(ByVal objParametroE As ParametroEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdParametro = New SqlCommand
       cmdParametro.CommandType = CommandType.StoredProcedure
       cmdParametro.CommandText = "U_Parametro"
       objConexion.ConexionOpen()
       cmdParametro.Connection = objConexion.Conexion
       With cmdParametro.Parameters
           .Add("@ID", SqlDbType.int).Value = objParametroE.pID
           .Add("@IdContribuyente", SqlDbType.varchar).Value = objParametroE.pIdContribuyente
           .Add("@TasaIgv", SqlDbType.decimal).Value = objParametroE.pTasaIgv
           .Add("@TasaIsc", SqlDbType.decimal).Value = objParametroE.pTasaIsc
           .Add("@TasaDetraccion", SqlDbType.decimal).Value = objParametroE.pTasaDetraccion
           .Add("@CertificadoDigital", SqlDbType.varchar).Value = objParametroE.pCertificadoDigital
           .Add("@ClaveCertificado", SqlDbType.varchar).Value = objParametroE.pClaveCertificado
           .Add("@UsuarioSol", SqlDbType.varchar).Value = objParametroE.pUsuarioSol
           .Add("@ClaveSol", SqlDbType.varchar).Value = objParametroE.pClaveSol
       End with
       try
           registro = cmdParametro.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdParametro.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarParametro(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdParametro = New SqlCommand
       cmdParametro.CommandType = CommandType.StoredProcedure
       cmdParametro.CommandText = "D_Parametro"
       objConexion.ConexionOpen()
       cmdParametro.Connection = objConexion.Conexion
       With cmdParametro.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdParametro.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdParametro.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodParametro(ID As Integer) As Datatable
       Dim tblParametro As New Datatable
       Dim daParametro As New SqlDataAdapter
       cmdParametro = New SqlCommand
       cmdParametro.CommandType = CommandType.StoredProcedure
       cmdParametro.CommandText = "B_ParametroCOD"
       objConexion.ConexionOpen()
       cmdParametro.Connection = objConexion.Conexion
       With cmdParametro.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daParametro.SelectCommand = cmdParametro
           daParametro.Fill(tblParametro)
           objConexion.ConexionClose()
           Return tblParametro
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdParametro.Parameters.Clear()
       End Try
   End Function

   Public Function ListarParametro(ByVal ParamArray Argumentos() As System.Object) As ParametroEN
       Dim dtParametro As New datatable
       Dim objParametroE As New ParametroEN
       dtParametro= objHelper.TraerDataTable("L_Parametro", Argumentos)
       If dtParametro.Rows.Count = 0 Then
           Return objParametroE
       End If
       For Each lector As DataRow In dtParametro.Rows
           With objParametroE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pTasaIgv= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTasaIsc= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTasaDetraccion= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pCertificadoDigital= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pClaveCertificado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pUsuarioSol= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pClaveSol= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
           End With
       Next
       Return objParametroE
   End Function

   Public Function ListarArrayParametro(ByVal ParamArray Argumentos() As System.Object) As List(Of ParametroEN)
       Dim dtParametro As New datatable
       Dim lista As New List(Of ParametroEN)
       Dim objParametroE As New ParametroEN
       dtParametro= objHelper.TraerDataTable("L_Parametro", Argumentos)
       If dtParametro.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtParametro.Rows
           objParametroE = New ParametroEN
           With objParametroE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pTasaIgv= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTasaIsc= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTasaDetraccion= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pCertificadoDigital= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pClaveCertificado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pUsuarioSol= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pClaveSol= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
           lista.Add(objParametroE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayParametroNoArg() As List(Of ParametroEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of ParametroEN)
       Dim objParametroE As New ParametroEN
       While lector.Read
           objParametroE = New ParametroEN
           With objParametroE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdContribuyente= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pTasaIgv= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pTasaIsc= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTasaDetraccion= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pCertificadoDigital= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pClaveCertificado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pUsuarioSol= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pClaveSol= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
           lista.Add(objParametroE)
           End With
       End While
       Return lista
   End Function

End Class
