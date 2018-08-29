Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoDetalleResumen

   Public cmdDocumentoDetalleResumen As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoDetalleResumen(ByVal objDocumentoDetalleResumenE As DocumentoDetalleResumenEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleResumen = New SqlCommand
       cmdDocumentoDetalleResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleResumen.CommandText = "I_DocumentoDetalleResumen"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleResumen.Connection = objConexion.Conexion
       With cmdDocumentoDetalleResumen.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleResumenE.pID
           .Add("@IdDocumentoResumen", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdDocumentoResumen
           .Add("@line", SqlDbType.int).Value = objDocumentoDetalleResumenE.pline
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdTipoDocumento
           .Add("@TipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pTipoDocumento
           .Add("@NroDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pNroDocumento
           .Add("@CodigoEstado", SqlDbType.int).Value = objDocumentoDetalleResumenE.pCodigoEstado
           .Add("@IdMoneda", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdMoneda
           .Add("@TotalVenta", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalVenta
           .Add("@Gravadas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pGravadas
           .Add("@Exoneradas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pExoneradas
           .Add("@Inafectas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pInafectas
           .Add("@TotalIgv", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalIgv
           .Add("@TotalIsc", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalIsc
           .Add("@TotalDescuentos", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalDescuentos
           .Add("@TotalOtrosImpuestos", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalOtrosImpuestos
       End with
       Try
           registro = cmdDocumentoDetalleResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleResumen.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoDetalleResumen(ByVal objDocumentoDetalleResumenE As DocumentoDetalleResumenEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleResumen = New SqlCommand
       cmdDocumentoDetalleResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleResumen.CommandText = "U_DocumentoDetalleResumen"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleResumen.Connection = objConexion.Conexion
       With cmdDocumentoDetalleResumen.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleResumenE.pID
           .Add("@IdDocumentoResumen", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdDocumentoResumen
           .Add("@line", SqlDbType.int).Value = objDocumentoDetalleResumenE.pline
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdTipoDocumento
           .Add("@TipoDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pTipoDocumento
           .Add("@NroDocumento", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pNroDocumento
           .Add("@CodigoEstado", SqlDbType.int).Value = objDocumentoDetalleResumenE.pCodigoEstado
           .Add("@IdMoneda", SqlDbType.varchar).Value = objDocumentoDetalleResumenE.pIdMoneda
           .Add("@TotalVenta", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalVenta
           .Add("@Gravadas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pGravadas
           .Add("@Exoneradas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pExoneradas
           .Add("@Inafectas", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pInafectas
           .Add("@TotalIgv", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalIgv
           .Add("@TotalIsc", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalIsc
           .Add("@TotalDescuentos", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalDescuentos
           .Add("@TotalOtrosImpuestos", SqlDbType.decimal).Value = objDocumentoDetalleResumenE.pTotalOtrosImpuestos
       End with
       try
           registro = cmdDocumentoDetalleResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleResumen.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoDetalleResumen(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalleResumen = New SqlCommand
       cmdDocumentoDetalleResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleResumen.CommandText = "D_DocumentoDetalleResumen"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleResumen.Connection = objConexion.Conexion
       With cmdDocumentoDetalleResumen.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoDetalleResumen.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalleResumen.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoDetalleResumen(ID As Integer) As Datatable
       Dim tblDocumentoDetalleResumen As New Datatable
       Dim daDocumentoDetalleResumen As New SqlDataAdapter
       cmdDocumentoDetalleResumen = New SqlCommand
       cmdDocumentoDetalleResumen.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalleResumen.CommandText = "B_DocumentoDetalleResumenCOD"
       objConexion.ConexionOpen()
       cmdDocumentoDetalleResumen.Connection = objConexion.Conexion
       With cmdDocumentoDetalleResumen.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoDetalleResumen.SelectCommand = cmdDocumentoDetalleResumen
           daDocumentoDetalleResumen.Fill(tblDocumentoDetalleResumen)
           objConexion.ConexionClose()
           Return tblDocumentoDetalleResumen
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoDetalleResumen.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoDetalleResumen(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleResumenEN
       Dim dtDocumentoDetalleResumen As New datatable
       Dim objDocumentoDetalleResumenE As New DocumentoDetalleResumenEN
       dtDocumentoDetalleResumen= objHelper.TraerDataTable("L_DocumentoDetalleResumen", Argumentos)
       If dtDocumentoDetalleResumen.Rows.Count = 0 Then
           Return objDocumentoDetalleResumenE
       End If
       For Each lector As DataRow In dtDocumentoDetalleResumen.Rows
           With objDocumentoDetalleResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoResumen= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pline= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pGravadas= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pExoneradas= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pInafectas= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pTotalIgv= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pTotalIsc= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalDescuentos= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
               .pTotalOtrosImpuestos= Iif(String.IsNullOrEmpty(lector(15)),"",lector(15))
           End With
       Next
       Return objDocumentoDetalleResumenE
   End Function

   Public Function ListarArrayDocumentoDetalleResumen(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleResumenEN)
       Dim dtDocumentoDetalleResumen As New datatable
       Dim lista As New List(Of DocumentoDetalleResumenEN)
       Dim objDocumentoDetalleResumenE As New DocumentoDetalleResumenEN
       dtDocumentoDetalleResumen= objHelper.TraerDataTable("L_DocumentoDetalleResumen", Argumentos)
       If dtDocumentoDetalleResumen.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoDetalleResumen.Rows
           objDocumentoDetalleResumenE = New DocumentoDetalleResumenEN
           With objDocumentoDetalleResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoResumen= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pline= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pGravadas= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pExoneradas= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pInafectas= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pTotalIgv= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pTotalIsc= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalDescuentos= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
               .pTotalOtrosImpuestos= Iif(String.IsNullOrEmpty(lector(15)),"",lector(15))
           lista.Add(objDocumentoDetalleResumenE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoDetalleResumenNoArg() As List(Of DocumentoDetalleResumenEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoDetalleResumenEN)
       Dim objDocumentoDetalleResumenE As New DocumentoDetalleResumenEN
       While lector.Read
           objDocumentoDetalleResumenE = New DocumentoDetalleResumenEN
           With objDocumentoDetalleResumenE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdDocumentoResumen= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pline= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pTipoDocumento= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pCodigoEstado= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pIdMoneda= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pGravadas= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pExoneradas= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pInafectas= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pTotalIgv= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pTotalIsc= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalDescuentos= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
               .pTotalOtrosImpuestos= Iif(String.IsNullOrEmpty(lector(15)),"",lector(15))
           lista.Add(objDocumentoDetalleResumenE)
           End With
       End While
       Return lista
   End Function

End Class
