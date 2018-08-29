Imports System.Data.SqlClient
Imports System.Reflection

public class ClsAnexo

   Public cmdAnexo As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarAnexo(ByVal objAnexoE As AnexoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdAnexo = New SqlCommand
       cmdAnexo.CommandType = CommandType.StoredProcedure
       cmdAnexo.CommandText = "I_Anexo"
       objConexion.ConexionOpen()
       cmdAnexo.Connection = objConexion.Conexion
       With cmdAnexo.Parameters
           .Add("@ID", SqlDbType.int).Value = objAnexoE.pID
           .Add("@IdDocumento", SqlDbType.varchar).Value = objAnexoE.pIdDocumento
           .Add("@FechaGeneracion", SqlDbType.Date).Value = objAnexoE.pFechaGeneracion
           .Add("@FechaRespuesta", SqlDbType.Date).Value = objAnexoE.pFechaRespuesta
           .Add("@XmlFirmado", SqlDbType.varchar).Value = objAnexoE.pXmlFirmado
           .Add("@RepresentacionImpresa", SqlDbType.varchar).Value = objAnexoE.pRepresentacionImpresa
           .Add("@EstadoEnvio", SqlDbType.smallint).Value = objAnexoE.pEstadoEnvio
           .Add("@CodigoEstado", SqlDbType.varchar).Value = objAnexoE.pCodigoEstado
           .Add("@DescripcionEstado", SqlDbType.varchar).Value = objAnexoE.pDescripcionEstado
           .Add("@CdrSunat", SqlDbType.varchar).Value = objAnexoE.pCdrSunat
           .Add("@Mensaje", SqlDbType.varchar).Value = objAnexoE.pMensaje
       End with
       Try
           registro = cmdAnexo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdAnexo.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarAnexo(ByVal objAnexoE As AnexoEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdAnexo = New SqlCommand
       cmdAnexo.CommandType = CommandType.StoredProcedure
       cmdAnexo.CommandText = "U_Anexo"
       objConexion.ConexionOpen()
       cmdAnexo.Connection = objConexion.Conexion
       With cmdAnexo.Parameters
           .Add("@ID", SqlDbType.int).Value = objAnexoE.pID
           .Add("@IdDocumento", SqlDbType.varchar).Value = objAnexoE.pIdDocumento
           .Add("@FechaGeneracion", SqlDbType.Date).Value = objAnexoE.pFechaGeneracion
           .Add("@FechaRespuesta", SqlDbType.Date).Value = objAnexoE.pFechaRespuesta
           .Add("@XmlFirmado", SqlDbType.varchar).Value = objAnexoE.pXmlFirmado
           .Add("@RepresentacionImpresa", SqlDbType.varchar).Value = objAnexoE.pRepresentacionImpresa
           .Add("@EstadoEnvio", SqlDbType.smallint).Value = objAnexoE.pEstadoEnvio
           .Add("@CodigoEstado", SqlDbType.varchar).Value = objAnexoE.pCodigoEstado
           .Add("@DescripcionEstado", SqlDbType.varchar).Value = objAnexoE.pDescripcionEstado
           .Add("@CdrSunat", SqlDbType.varchar).Value = objAnexoE.pCdrSunat
           .Add("@Mensaje", SqlDbType.varchar).Value = objAnexoE.pMensaje
       End with
       try
           registro = cmdAnexo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdAnexo.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarAnexo(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdAnexo = New SqlCommand
       cmdAnexo.CommandType = CommandType.StoredProcedure
       cmdAnexo.CommandText = "D_Anexo"
       objConexion.ConexionOpen()
       cmdAnexo.Connection = objConexion.Conexion
       With cmdAnexo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdAnexo.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdAnexo.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodAnexo(ID As Integer) As Datatable
       Dim tblAnexo As New Datatable
       Dim daAnexo As New SqlDataAdapter
       cmdAnexo = New SqlCommand
       cmdAnexo.CommandType = CommandType.StoredProcedure
       cmdAnexo.CommandText = "B_AnexoCOD"
       objConexion.ConexionOpen()
       cmdAnexo.Connection = objConexion.Conexion
       With cmdAnexo.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daAnexo.SelectCommand = cmdAnexo
           daAnexo.Fill(tblAnexo)
           objConexion.ConexionClose()
           Return tblAnexo
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdAnexo.Parameters.Clear()
       End Try
   End Function

   Public Function ListarAnexo(ByVal ParamArray Argumentos() As System.Object) As AnexoEN
       Dim dtAnexo As New datatable
       Dim objAnexoE As New AnexoEN
       dtAnexo= objHelper.TraerDataTable("L_Anexo", Argumentos)
       If dtAnexo.Rows.Count = 0 Then
           Return objAnexoE
       End If
       For Each lector As DataRow In dtAnexo.Rows
           With objAnexoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaGeneracion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pFechaRespuesta= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pXmlFirmado= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pRepresentacionImpresa= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pEstadoEnvio= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pDescripcionEstado= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pCdrSunat= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pMensaje= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
           End With
       Next
       Return objAnexoE
   End Function

   Public Function ListarArrayAnexo(ByVal ParamArray Argumentos() As System.Object) As List(Of AnexoEN)
       Dim dtAnexo As New datatable
       Dim lista As New List(Of AnexoEN)
       Dim objAnexoE As New AnexoEN
       dtAnexo= objHelper.TraerDataTable("L_Anexo", Argumentos)
       If dtAnexo.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtAnexo.Rows
           objAnexoE = New AnexoEN
           With objAnexoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaGeneracion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pFechaRespuesta= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pXmlFirmado= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pRepresentacionImpresa= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pEstadoEnvio= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pDescripcionEstado= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pCdrSunat= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pMensaje= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
           lista.Add(objAnexoE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayAnexoNoArg() As List(Of AnexoEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of AnexoEN)
       Dim objAnexoE As New AnexoEN
       While lector.Read
           objAnexoE = New AnexoEN
           With objAnexoE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pFechaGeneracion= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pFechaRespuesta= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pXmlFirmado= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pRepresentacionImpresa= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pEstadoEnvio= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pDescripcionEstado= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pCdrSunat= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pMensaje= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
           lista.Add(objAnexoE)
           End With
       End While
       Return lista
   End Function

End Class
