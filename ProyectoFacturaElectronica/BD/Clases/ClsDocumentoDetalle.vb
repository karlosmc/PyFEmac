Imports System.Data.SqlClient
Imports System.Reflection

public class ClsDocumentoDetalle

   Public cmdDocumentoDetalle As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarDocumentoDetalle(ByVal objDocumentoDetalleE As DocumentoDetalleEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalle = New SqlCommand
       cmdDocumentoDetalle.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalle.CommandText = "I_DocumentoDetalle"
       objConexion.ConexionOpen()
       cmdDocumentoDetalle.Connection = objConexion.Conexion
       With cmdDocumentoDetalle.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdCabeceraDocumento
           .Add("@Cantidad", SqlDbType.decimal).Value = objDocumentoDetalleE.pCantidad
           .Add("@IdUnidadMedida", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdUnidadMedida
           .Add("@CodigoItem", SqlDbType.varchar).Value = objDocumentoDetalleE.pCodigoItem
           .Add("@Descripcion", SqlDbType.varchar).Value = objDocumentoDetalleE.pDescripcion
           .Add("@PrecioUnitario", SqlDbType.decimal).Value = objDocumentoDetalleE.pPrecioUnitario
           .Add("@PrecioReferencial", SqlDbType.decimal).Value = objDocumentoDetalleE.pPrecioReferencial
           .Add("@IdTipoPrecio", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdTipoPrecio
           .Add("@IdTipoImpuesto", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdTipoImpuesto
           .Add("@Impuesto", SqlDbType.decimal).Value = objDocumentoDetalleE.pImpuesto
           .Add("@ImpuestoSelectivo", SqlDbType.decimal).Value = objDocumentoDetalleE.pImpuestoSelectivo
           .Add("@OtroImpuesto", SqlDbType.decimal).Value = objDocumentoDetalleE.pOtroImpuesto
           .Add("@Descuento", SqlDbType.decimal).Value = objDocumentoDetalleE.pDescuento
           .Add("@TotalVenta", SqlDbType.decimal).Value = objDocumentoDetalleE.pTotalVenta
       End with
       Try
           registro = cmdDocumentoDetalle.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalle.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarDocumentoDetalle(ByVal objDocumentoDetalleE As DocumentoDetalleEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalle = New SqlCommand
       cmdDocumentoDetalle.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalle.CommandText = "U_DocumentoDetalle"
       objConexion.ConexionOpen()
       cmdDocumentoDetalle.Connection = objConexion.Conexion
       With cmdDocumentoDetalle.Parameters
           .Add("@ID", SqlDbType.int).Value = objDocumentoDetalleE.pID
           .Add("@IdCabeceraDocumento", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdCabeceraDocumento
           .Add("@Cantidad", SqlDbType.decimal).Value = objDocumentoDetalleE.pCantidad
           .Add("@IdUnidadMedida", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdUnidadMedida
           .Add("@CodigoItem", SqlDbType.varchar).Value = objDocumentoDetalleE.pCodigoItem
           .Add("@Descripcion", SqlDbType.varchar).Value = objDocumentoDetalleE.pDescripcion
           .Add("@PrecioUnitario", SqlDbType.decimal).Value = objDocumentoDetalleE.pPrecioUnitario
           .Add("@PrecioReferencial", SqlDbType.decimal).Value = objDocumentoDetalleE.pPrecioReferencial
           .Add("@IdTipoPrecio", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdTipoPrecio
           .Add("@IdTipoImpuesto", SqlDbType.varchar).Value = objDocumentoDetalleE.pIdTipoImpuesto
           .Add("@Impuesto", SqlDbType.decimal).Value = objDocumentoDetalleE.pImpuesto
           .Add("@ImpuestoSelectivo", SqlDbType.decimal).Value = objDocumentoDetalleE.pImpuestoSelectivo
           .Add("@OtroImpuesto", SqlDbType.decimal).Value = objDocumentoDetalleE.pOtroImpuesto
           .Add("@Descuento", SqlDbType.decimal).Value = objDocumentoDetalleE.pDescuento
           .Add("@TotalVenta", SqlDbType.decimal).Value = objDocumentoDetalleE.pTotalVenta
       End with
       try
           registro = cmdDocumentoDetalle.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalle.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarDocumentoDetalle(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdDocumentoDetalle = New SqlCommand
       cmdDocumentoDetalle.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalle.CommandText = "D_DocumentoDetalle"
       objConexion.ConexionOpen()
       cmdDocumentoDetalle.Connection = objConexion.Conexion
       With cmdDocumentoDetalle.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdDocumentoDetalle.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdDocumentoDetalle.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodDocumentoDetalle(ID As Integer) As Datatable
       Dim tblDocumentoDetalle As New Datatable
       Dim daDocumentoDetalle As New SqlDataAdapter
       cmdDocumentoDetalle = New SqlCommand
       cmdDocumentoDetalle.CommandType = CommandType.StoredProcedure
       cmdDocumentoDetalle.CommandText = "B_DocumentoDetalleCOD"
       objConexion.ConexionOpen()
       cmdDocumentoDetalle.Connection = objConexion.Conexion
       With cmdDocumentoDetalle.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daDocumentoDetalle.SelectCommand = cmdDocumentoDetalle
           daDocumentoDetalle.Fill(tblDocumentoDetalle)
           objConexion.ConexionClose()
           Return tblDocumentoDetalle
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdDocumentoDetalle.Parameters.Clear()
       End Try
   End Function

   Public Function ListarDocumentoDetalle(ByVal ParamArray Argumentos() As System.Object) As DocumentoDetalleEN
       Dim dtDocumentoDetalle As New datatable
       Dim objDocumentoDetalleE As New DocumentoDetalleEN
       dtDocumentoDetalle= objHelper.TraerDataTable("L_DocumentoDetalle", Argumentos)
       If dtDocumentoDetalle.Rows.Count = 0 Then
           Return objDocumentoDetalleE
       End If
       For Each lector As DataRow In dtDocumentoDetalle.Rows
           With objDocumentoDetalleE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pCantidad= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdUnidadMedida= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pCodigoItem= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pPrecioUnitario= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pPrecioReferencial= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pIdTipoPrecio= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pIdTipoImpuesto= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pImpuesto= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pImpuestoSelectivo= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pOtroImpuesto= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pDescuento= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
           End With
       Next
       Return objDocumentoDetalleE
   End Function

   Public Function ListarArrayDocumentoDetalle(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoDetalleEN)
       Dim dtDocumentoDetalle As New datatable
       Dim lista As New List(Of DocumentoDetalleEN)
       Dim objDocumentoDetalleE As New DocumentoDetalleEN
       dtDocumentoDetalle= objHelper.TraerDataTable("L_DocumentoDetalle", Argumentos)
       If dtDocumentoDetalle.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtDocumentoDetalle.Rows
           objDocumentoDetalleE = New DocumentoDetalleEN
           With objDocumentoDetalleE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pCantidad= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdUnidadMedida= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pCodigoItem= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pPrecioUnitario= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pPrecioReferencial= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pIdTipoPrecio= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pIdTipoImpuesto= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pImpuesto= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pImpuestoSelectivo= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pOtroImpuesto= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pDescuento= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
           lista.Add(objDocumentoDetalleE)
           End With
       Next
       Return lista
   End Function

   Public Function ListarArrayDocumentoDetalleNoArg() As List(Of DocumentoDetalleEN)
       Dim lector As SqlDataReader
       Dim lista As New List(Of DocumentoDetalleEN)
       Dim objDocumentoDetalleE As New DocumentoDetalleEN
       While lector.Read
           objDocumentoDetalleE = New DocumentoDetalleEN
           With objDocumentoDetalleE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pIdCabeceraDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pCantidad= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pIdUnidadMedida= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pCodigoItem= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDescripcion= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pPrecioUnitario= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pPrecioReferencial= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pIdTipoPrecio= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pIdTipoImpuesto= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
               .pImpuesto= Iif(String.IsNullOrEmpty(lector(10)),"",lector(10))
               .pImpuestoSelectivo= Iif(String.IsNullOrEmpty(lector(11)),"",lector(11))
               .pOtroImpuesto= Iif(String.IsNullOrEmpty(lector(12)),"",lector(12))
               .pDescuento= Iif(String.IsNullOrEmpty(lector(13)),"",lector(13))
               .pTotalVenta= Iif(String.IsNullOrEmpty(lector(14)),"",lector(14))
           lista.Add(objDocumentoDetalleE)
           End With
       End While
       Return lista
   End Function

End Class
