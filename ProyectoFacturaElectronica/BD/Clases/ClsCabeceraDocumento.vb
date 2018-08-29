Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Transactions
Imports System.Data.Common

Public Class ClsCabeceraDocumento

    Public cmdCabeceraDocumento As SqlCommand
    Dim objConexion As New clsConeccion
    Dim objHelper As New clsHelper

    Public Function AgregarCabeceraDocumento(ByVal objCabeceraDocumentoE As CabeceraDocumentoEN) As Boolean
        'Dim registro As Integer
        Dim mensaje As String = "INSERTADO CON EXITO"
        cmdCabeceraDocumento = New SqlCommand
        Using tran As New TransactionScope

            Try
                objConexion.ConexionOpen()
                cmdCabeceraDocumento.CommandType = CommandType.StoredProcedure
                cmdCabeceraDocumento.CommandText = "I_CabeceraDocumento"
                cmdCabeceraDocumento.Connection = objConexion.Conexion

                With cmdCabeceraDocumento.Parameters
                    .Add("@ID", SqlDbType.Int).Value = objCabeceraDocumentoE.pID
                    .Add("@IdTipodocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdTipodocumento
                    .Add("@IdEmisor", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdEmisor
                    .Add("@IdReceptor", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdReceptor
                    .Add("@IdMoneda", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdMoneda
                    .Add("@IdTipoOperacion", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdTipoOperacion
                    .Add("@IdDocumentoAnticipo", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdDocumentoAnticipo
                    .Add("@IdGuiaTransportista", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdGuiaTransportista
                    .Add("@IdDocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdDocumento
                    .Add("@Gravadas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pGravadas
                    .Add("@Gratuitas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pGratuitas
                    .Add("@Inafectas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pInafectas
                    .Add("@Exoneradas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pExoneradas
                    .Add("@DescuentoGlobal", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pDescuentoGlobal
                    .Add("@TotalVenta", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalVenta
                    .Add("@TotalIgv", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalIgv
                    .Add("@TotalIsc", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalIsc
                    .Add("@TotalOtrosTributos", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalOtrosTributos
                    .Add("@MontoEnLetras", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pMontoEnLetras
                    .Add("@PlacaVehiculo", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pPlacaVehiculo
                    .Add("@MontoPercepcion", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pMontoPercepcion
                    .Add("@MontoDetraccion", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pMontoDetraccion
                    .Add("@EstadoDocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pEstadoDocumento
                End With
                Dim res As Integer = 0
                res = cmdCabeceraDocumento.ExecuteNonQuery()
                If res = 0 Then
                    Throw New ClsErrorExcepcion("Hubo un error al insertar Cabecera")
                End If

                cmdCabeceraDocumento.Parameters.Clear()

                For Each detail As DocumentoDetalleEN In objCabeceraDocumentoE.pDetalles
                    cmdCabeceraDocumento.CommandText = "I_DocumentoDetalle"
                    cmdCabeceraDocumento.Connection = objConexion.Conexion
                    With cmdCabeceraDocumento.Parameters
                        .Add("@ID", SqlDbType.Int).Value = detail.pID
                        .Add("@IdCabeceraDocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdDocumento
                        .Add("@Cantidad", SqlDbType.Decimal).Value = detail.pCantidad
                        .Add("@IdUnidadMedida", SqlDbType.VarChar).Value = detail.pIdUnidadMedida
                        .Add("@CodigoItem", SqlDbType.VarChar).Value = detail.pCodigoItem
                        .Add("@Descripcion", SqlDbType.VarChar).Value = detail.pDescripcion
                        .Add("@PrecioUnitario", SqlDbType.Decimal).Value = detail.pPrecioUnitario
                        .Add("@PrecioReferencial", SqlDbType.Decimal).Value = detail.pPrecioReferencial
                        .Add("@IdTipoPrecio", SqlDbType.VarChar).Value = detail.pIdTipoPrecio
                        .Add("@IdTipoImpuesto", SqlDbType.VarChar).Value = detail.pIdTipoImpuesto
                        .Add("@Impuesto", SqlDbType.Decimal).Value = detail.pImpuesto
                        .Add("@ImpuestoSelectivo", SqlDbType.Decimal).Value = detail.pImpuestoSelectivo
                        .Add("@OtroImpuesto", SqlDbType.Decimal).Value = detail.pOtroImpuesto
                        .Add("@Descuento", SqlDbType.Decimal).Value = detail.pDescuento
                        .Add("@TotalVenta", SqlDbType.Decimal).Value = detail.pTotalVenta
                    End With

                    Dim res1 As Integer = 0
                    res1 = cmdCabeceraDocumento.ExecuteNonQuery()
                    If res = 0 Then
                        Throw New ClsErrorExcepcion("Hubo un error al insertar detalles")
                    End If
                    'cmdCabeceraDocumento.ExecuteNonQuery()
                    cmdCabeceraDocumento.Parameters.Clear()
                Next

                For Each discre As DiscrepanciaDocumentoEN In objCabeceraDocumentoE.pDiscrepancias
                    cmdCabeceraDocumento.CommandText = "I_DiscrepanciaDocumento"
                    cmdCabeceraDocumento.Connection = objConexion.Conexion
                    With cmdCabeceraDocumento.Parameters
                        .Add("@ID", SqlDbType.Int).Value = discre.pID
                        .Add("@IdCabeceraDocumento", SqlDbType.VarChar).Value = discre.pIdCabeceraDocumento
                        .Add("@NroReferencia", SqlDbType.VarChar).Value = discre.pNroReferencia
                        .Add("@IdTipoDiscrepancia", SqlDbType.Int).Value = discre.pIdTipoDiscrepancia
                        .Add("@TipoDiscrepancia", SqlDbType.VarChar).Value = discre.pTipoDiscrepancia
                    End With
                    Dim res1 As Integer = 0
                    res1 = cmdCabeceraDocumento.ExecuteNonQuery()
                    If res = 0 Then
                        Throw New ClsErrorExcepcion("Hubo un error al insertar Discrepancias")
                    End If
                    cmdCabeceraDocumento.Parameters.Clear()
                Next

                For Each adicional As DatoAdicionalEN In objCabeceraDocumentoE.pAdicionales
                    cmdCabeceraDocumento.CommandText = "I_DatoAdicional"
                    cmdCabeceraDocumento.Connection = objConexion.Conexion
                    With cmdCabeceraDocumento.Parameters
                        .Add("@ID", SqlDbType.Int).Value = adicional.pID
                        .Add("@IdCabeceraDocumento", SqlDbType.VarChar).Value = adicional.pIdCabeceraDocumento
                        .Add("@IdTipoDatoAdicional", SqlDbType.VarChar).Value = adicional.pIdTipoDatoAdicional
                        .Add("@Contenido", SqlDbType.VarChar).Value = adicional.pContenido
                    End With

                    Dim res1 As Integer = 0
                    res1 = cmdCabeceraDocumento.ExecuteNonQuery()
                    If res = 0 Then
                        Throw New ClsErrorExcepcion("Hubo un error al insertar Adicionales")
                    End If
                    cmdCabeceraDocumento.Parameters.Clear()
                Next

                For Each relacionado As DocumentoRelacionadoEN In objCabeceraDocumentoE.pRelacionados
                    cmdCabeceraDocumento.CommandText = "I_DocumentoRelacionado"
                    cmdCabeceraDocumento.Connection = objConexion.Conexion
                    With cmdCabeceraDocumento.Parameters
                        .Add("@ID", SqlDbType.Int).Value = relacionado.pID
                        .Add("@IdCabeceraDocumento", SqlDbType.VarChar).Value = relacionado.pIdCabeceraDocumento
                        .Add("@NroDocumento", SqlDbType.VarChar).Value = relacionado.pNroDocumento
                        .Add("@TipoDocumento", SqlDbType.VarChar).Value = relacionado.pTipoDocumento
                    End With
                    Dim res1 As Integer = 0
                    res1 = cmdCabeceraDocumento.ExecuteNonQuery()
                    If res = 0 Then
                        Throw New ClsErrorExcepcion("Hubo un error al insertar Relacionados")
                    End If
                    cmdCabeceraDocumento.Parameters.Clear()
                Next
                tran.Complete()
                Return True

            Catch Ex As SqlException
                Throw New ClsErrorExcepcion(Ex.Number & ": " & Ex.Message)
                'Configuracion del mensaje de acuerdo al numero de error devuelto por la MRDB
                'If Ex.Number = 2627 Then
                '    If Ex.Message.IndexOf("PRIMARY") <> -1 Then
                '        Men = Module1.MensajeErrorPK
                '    ElseIf Ex.Message.IndexOf("UNIQUE") <> -1 Then
                '        Men = Module1.MensajeErrorUN
                '    Else
                '        Men = Ex.Message
                '    End If
                'Else
                '    Men = Module1.MensajeErrorGN
                'End If
                'Throw New ClsErrorExcepcion(Men)
            Catch Ex As DBConcurrencyException
                Throw New ClsErrorExcepcion(Module1.MensajeErrorCR)
                Return False
            Catch ex As System.Reflection.TargetInvocationException
                Throw New ClsErrorExcepcion(" * " + ex.Message)
                Return False
            Catch ex As NullReferenceException
                Throw New ClsErrorExcepcion("REFERENCIA NULA")
                Return False
            Catch ex As Exception
                Throw New ClsErrorExcepcion(" * Error: " & ex.Message)
                Return False
            Finally
                If objConexion.Conexion.State = ConnectionState.Open Then objConexion.ConexionClose()
                cmdCabeceraDocumento.Parameters.Clear()
                cmdCabeceraDocumento.Dispose()
            End Try
        End Using
    End Function

    Public Function ActualizarCabeceraDocumento(ByVal objCabeceraDocumentoE As CabeceraDocumentoEN) As String
        Dim registro As Integer
        Dim mensaje As String = ""
        cmdCabeceraDocumento = New SqlCommand
        cmdCabeceraDocumento.CommandType = CommandType.StoredProcedure
        cmdCabeceraDocumento.CommandText = "U_CabeceraDocumento"
        objConexion.ConexionOpen()
        cmdCabeceraDocumento.Connection = objConexion.Conexion
        With cmdCabeceraDocumento.Parameters
            .Add("@ID", SqlDbType.Int).Value = objCabeceraDocumentoE.pID
            .Add("@IdTipodocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdTipodocumento
            .Add("@IdEmisor", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdEmisor
            .Add("@IdReceptor", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdReceptor
            .Add("@IdMoneda", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdMoneda
            .Add("@IdTipoOperacion", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdTipoOperacion
            .Add("@IdDocumentoAnticipo", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdDocumentoAnticipo
            .Add("@IdGuiaTransportista", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdGuiaTransportista
            .Add("@IdDocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pIdDocumento
            .Add("@Gravadas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pGravadas
            .Add("@Gratuitas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pGratuitas
            .Add("@Inafectas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pInafectas
            .Add("@Exoneradas", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pExoneradas
            .Add("@DescuentoGlobal", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pDescuentoGlobal
            .Add("@TotalVenta", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalVenta
            .Add("@TotalIgv", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalIgv
            .Add("@TotalIsc", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalIsc
            .Add("@TotalOtrosTributos", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pTotalOtrosTributos
            .Add("@MontoEnLetras", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pMontoEnLetras
            .Add("@PlacaVehiculo", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pPlacaVehiculo
            .Add("@MontoPercepcion", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pMontoPercepcion
            .Add("@MontoDetraccion", SqlDbType.Decimal).Value = objCabeceraDocumentoE.pMontoDetraccion
            .Add("@EstadoDocumento", SqlDbType.VarChar).Value = objCabeceraDocumentoE.pEstadoDocumento
        End With
        Try
            registro = cmdCabeceraDocumento.ExecuteNonQuery
            objConexion.ConexionClose()
            mensaje = "Operación completa"
            Return mensaje
        Catch ex As Exception
            mensaje = ex.Message
            Return mensaje
        Finally
            cmdCabeceraDocumento.Parameters.Clear()
        End Try
    End Function

    Public Function EliminarCabeceraDocumento(ID As Integer) As String
        Dim registro As Integer
        Dim mensaje As String = ""
        cmdCabeceraDocumento = New SqlCommand
        cmdCabeceraDocumento.CommandType = CommandType.StoredProcedure
        cmdCabeceraDocumento.CommandText = "D_CabeceraDocumento"
        objConexion.ConexionOpen()
        cmdCabeceraDocumento.Connection = objConexion.Conexion
        With cmdCabeceraDocumento.Parameters
            .Add("@ID", SqlDbType.Int).Value = ID
        End With
        Try
            registro = cmdCabeceraDocumento.ExecuteNonQuery
            objConexion.ConexionClose()
            mensaje = "Operación completa"
            Return mensaje
        Catch ex As Exception
            mensaje = ex.Message
            Return mensaje
        Finally
            cmdCabeceraDocumento.Parameters.Clear()
        End Try
    End Function

    Public Function BuscarXcodCabeceraDocumento(ID As Integer) As DataTable
        Dim tblCabeceraDocumento As New DataTable
        Dim daCabeceraDocumento As New SqlDataAdapter
        cmdCabeceraDocumento = New SqlCommand
        cmdCabeceraDocumento.CommandType = CommandType.StoredProcedure
        cmdCabeceraDocumento.CommandText = "B_CabeceraDocumentoCOD"
        objConexion.ConexionOpen()
        cmdCabeceraDocumento.Connection = objConexion.Conexion
        With cmdCabeceraDocumento.Parameters
            .Add("@ID", SqlDbType.Int).Value = ID
        End With
        Try
            daCabeceraDocumento.SelectCommand = cmdCabeceraDocumento
            daCabeceraDocumento.Fill(tblCabeceraDocumento)
            objConexion.ConexionClose()
            Return tblCabeceraDocumento
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            cmdCabeceraDocumento.Parameters.Clear()
        End Try
    End Function

    Public Function ListarCabeceraDocumento(ByVal ParamArray Argumentos() As System.Object) As CabeceraDocumentoEN
        Dim dtCabeceraDocumento As New DataTable
        Dim objCabeceraDocumentoE As New CabeceraDocumentoEN
        dtCabeceraDocumento = objHelper.TraerDatatable("L_CabeceraDocumento", Argumentos)
        If dtCabeceraDocumento.Rows.Count = 0 Then
            Return objCabeceraDocumentoE
        End If
        For Each lector As DataRow In dtCabeceraDocumento.Rows
            With objCabeceraDocumentoE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pIdTipodocumento = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pIdEmisor = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pIdReceptor = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                .pIdMoneda = IIf(String.IsNullOrEmpty(lector(4)), "", lector(4))
                .pIdTipoOperacion = IIf(String.IsNullOrEmpty(lector(5)), "", lector(5))
                .pIdDocumentoAnticipo = IIf(String.IsNullOrEmpty(lector(6)), "", lector(6))
                .pIdGuiaTransportista = IIf(String.IsNullOrEmpty(lector(7)), "", lector(7))
                .pIdDocumento = IIf(String.IsNullOrEmpty(lector(9)), "", lector(9))
                .pGravadas = IIf(String.IsNullOrEmpty(lector(10)), "", lector(10))
                .pGratuitas = IIf(String.IsNullOrEmpty(lector(11)), "", lector(11))
                .pInafectas = IIf(String.IsNullOrEmpty(lector(12)), "", lector(12))
                .pExoneradas = IIf(String.IsNullOrEmpty(lector(13)), "", lector(13))
                .pDescuentoGlobal = IIf(String.IsNullOrEmpty(lector(14)), "", lector(14))
                .pTotalVenta = IIf(String.IsNullOrEmpty(lector(15)), "", lector(15))
                .pTotalIgv = IIf(String.IsNullOrEmpty(lector(16)), "", lector(16))
                .pTotalIsc = IIf(String.IsNullOrEmpty(lector(17)), "", lector(17))
                .pTotalOtrosTributos = IIf(String.IsNullOrEmpty(lector(18)), "", lector(18))
                .pMontoEnLetras = IIf(String.IsNullOrEmpty(lector(19)), "", lector(19))
                .pPlacaVehiculo = IIf(String.IsNullOrEmpty(lector(20)), "", lector(20))
                .pMontoPercepcion = IIf(String.IsNullOrEmpty(lector(21)), "", lector(21))
                .pMontoDetraccion = IIf(String.IsNullOrEmpty(lector(22)), "", lector(22))
                .pEstadoDocumento = IIf(String.IsNullOrEmpty(lector(23)), "", lector(23))
            End With
        Next
        Return objCabeceraDocumentoE
    End Function

    Public Function ListarArrayCabeceraDocumento(ByVal ParamArray Argumentos() As System.Object) As List(Of CabeceraDocumentoEN)
        Dim dtCabeceraDocumento As New DataTable
        Dim lista As New List(Of CabeceraDocumentoEN)
        Dim objCabeceraDocumentoE As New CabeceraDocumentoEN
        dtCabeceraDocumento = objHelper.TraerDatatable("L_CabeceraDocumento", Argumentos)
        If dtCabeceraDocumento.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtCabeceraDocumento.Rows
            objCabeceraDocumentoE = New CabeceraDocumentoEN
            With objCabeceraDocumentoE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pIdTipodocumento = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pIdEmisor = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pIdReceptor = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                .pIdMoneda = IIf(String.IsNullOrEmpty(lector(4)), "", lector(4))
                .pIdTipoOperacion = IIf(String.IsNullOrEmpty(lector(5)), "", lector(5))
                .pIdDocumentoAnticipo = IIf(String.IsNullOrEmpty(lector(6)), "", lector(6))
                .pIdGuiaTransportista = IIf(String.IsNullOrEmpty(lector(7)), "", lector(7))

                .pIdDocumento = IIf(String.IsNullOrEmpty(lector(9)), "", lector(9))
                .pGravadas = IIf(String.IsNullOrEmpty(lector(10)), "", lector(10))
                .pGratuitas = IIf(String.IsNullOrEmpty(lector(11)), "", lector(11))
                .pInafectas = IIf(String.IsNullOrEmpty(lector(12)), "", lector(12))
                .pExoneradas = IIf(String.IsNullOrEmpty(lector(13)), "", lector(13))
                .pDescuentoGlobal = IIf(String.IsNullOrEmpty(lector(14)), "", lector(14))
                .pTotalVenta = IIf(String.IsNullOrEmpty(lector(15)), "", lector(15))
                .pTotalIgv = IIf(String.IsNullOrEmpty(lector(16)), "", lector(16))
                .pTotalIsc = IIf(String.IsNullOrEmpty(lector(17)), "", lector(17))
                .pTotalOtrosTributos = IIf(String.IsNullOrEmpty(lector(18)), "", lector(18))
                .pMontoEnLetras = IIf(String.IsNullOrEmpty(lector(19)), "", lector(19))
                .pPlacaVehiculo = IIf(String.IsNullOrEmpty(lector(20)), "", lector(20))
                .pMontoPercepcion = IIf(String.IsNullOrEmpty(lector(21)), "", lector(21))
                .pMontoDetraccion = IIf(String.IsNullOrEmpty(lector(22)), "", lector(22))
                .pEstadoDocumento = IIf(String.IsNullOrEmpty(lector(23)), "", lector(23))
                lista.Add(objCabeceraDocumentoE)
            End With
        Next
        Return lista
    End Function

    Public Function ListarArrayCabeceraDocumentoNoArg() As List(Of CabeceraDocumentoEN)
        Dim lector As SqlDataReader
        Dim lista As New List(Of CabeceraDocumentoEN)
        Dim objCabeceraDocumentoE As New CabeceraDocumentoEN
        While lector.Read
            objCabeceraDocumentoE = New CabeceraDocumentoEN
            With objCabeceraDocumentoE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pIdTipodocumento = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pIdEmisor = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pIdReceptor = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                .pIdMoneda = IIf(String.IsNullOrEmpty(lector(4)), "", lector(4))
                .pIdTipoOperacion = IIf(String.IsNullOrEmpty(lector(5)), "", lector(5))
                .pIdDocumentoAnticipo = IIf(String.IsNullOrEmpty(lector(6)), "", lector(6))
                .pIdGuiaTransportista = IIf(String.IsNullOrEmpty(lector(7)), "", lector(7))
                .pIdDocumento = IIf(String.IsNullOrEmpty(lector(9)), "", lector(9))
                .pGravadas = IIf(String.IsNullOrEmpty(lector(10)), "", lector(10))
                .pGratuitas = IIf(String.IsNullOrEmpty(lector(11)), "", lector(11))
                .pInafectas = IIf(String.IsNullOrEmpty(lector(12)), "", lector(12))
                .pExoneradas = IIf(String.IsNullOrEmpty(lector(13)), "", lector(13))
                .pDescuentoGlobal = IIf(String.IsNullOrEmpty(lector(14)), "", lector(14))
                .pTotalVenta = IIf(String.IsNullOrEmpty(lector(15)), "", lector(15))
                .pTotalIgv = IIf(String.IsNullOrEmpty(lector(16)), "", lector(16))
                .pTotalIsc = IIf(String.IsNullOrEmpty(lector(17)), "", lector(17))
                .pTotalOtrosTributos = IIf(String.IsNullOrEmpty(lector(18)), "", lector(18))
                .pMontoEnLetras = IIf(String.IsNullOrEmpty(lector(19)), "", lector(19))
                .pPlacaVehiculo = IIf(String.IsNullOrEmpty(lector(20)), "", lector(20))
                .pMontoPercepcion = IIf(String.IsNullOrEmpty(lector(21)), "", lector(21))
                .pMontoDetraccion = IIf(String.IsNullOrEmpty(lector(22)), "", lector(22))
                .pEstadoDocumento = IIf(String.IsNullOrEmpty(lector(23)), "", lector(23))
                lista.Add(objCabeceraDocumentoE)
            End With
        End While
        Return lista
    End Function

End Class
