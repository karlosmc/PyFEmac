Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common
Public Class clsHelper

    Protected _adaptador As SqlDataAdapter

    'Trabajaremos con Regiones para odernar nuestro código. 
#Region "Conexion Base de Datos"
    Dim cn As New clsConeccion
#End Region

#Region "Poner Parametros"
    Shared mColComandos As New System.Collections.Hashtable()
    Protected Function Comando(ByVal ProcedimientoAlmacenado As String) As System.Data.IDbCommand
        Dim mComando As System.Data.SqlClient.SqlCommand
        If mColComandos.Contains(ProcedimientoAlmacenado) Then
            mComando = CType(mColComandos.Item(ProcedimientoAlmacenado),  _
            System.Data.SqlClient.SqlCommand)
        Else
            If cn.Conexion.State = ConnectionState.Closed Then
                cn.ConexionOpen()
            End If

            mComando = New System.Data.SqlClient.SqlCommand(ProcedimientoAlmacenado, cn.Conexion)
            Dim mContructor As New System.Data.SqlClient.SqlCommandBuilder()
            mComando.Connection = cn.Conexion
            mComando.CommandType = CommandType.StoredProcedure
            mContructor.DeriveParameters(mComando)
            cn.ConexionClose()
            mColComandos.Add(ProcedimientoAlmacenado, mComando)
        End If
        Return mComando
    End Function

    'con transacciones
    Protected Function CrearComando(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction) As System.Data.IDbCommand
        Dim mComando As System.Data.SqlClient.SqlCommand
        If mColComandos.Contains(ProcedimientoAlmacenado) Then
            mComando = CType(mColComandos.Item(ProcedimientoAlmacenado),  _
            System.Data.SqlClient.SqlCommand)
        Else
            'cn.ConexionOpen()
            mComando = New System.Data.SqlClient.SqlCommand(ProcedimientoAlmacenado, cn.Conexion)
            Dim mContructor As New System.Data.SqlClient.SqlCommandBuilder()

            mComando.Connection = cn.Conexion
            mComando.CommandType = CommandType.StoredProcedure
            mComando.Transaction = trans
            mContructor.DeriveParameters(mComando)
            'cn.ConexionClose()
            mColComandos.Add(ProcedimientoAlmacenado, mComando)
        End If
        Return mComando
    End Function


    Protected Sub CargarParametros(ByVal Comando As System.Data.IDbCommand, ByVal Args() As Object)
        Dim I As Integer
        With Comando
            For I = 0 To Args.GetUpperBound(0)
                Try
                    CType(.Parameters(I + 1), System.Data.SqlClient.SqlParameter).Value = Args(I)
                Catch Qex As Exception
                    Throw (Qex)
                End Try
            Next
        End With
    End Sub
#End Region

#Region "Devolver Parametros"

    Protected Function CrearDataAdapter(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Args() As Object) As System.Data.IDataAdapter
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        If Not Args Is Nothing Then
            CargarParametros(mCom, Args)
        End If
        Return New System.Data.SqlClient.SqlDataAdapter(mCom)
    End Function

    Protected Function CrearDataAdapterComando(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction, ByVal ParamArray Args() As Object) As System.Data.IDataAdapter
        Dim mCom As System.Data.SqlClient.SqlCommand = CrearComando(ProcedimientoAlmacenado, trans)
        If Not Args Is Nothing Then
            CargarParametros(mCom, Args)
        End If
        Return New System.Data.SqlClient.SqlDataAdapter(mCom)
    End Function

    'En este caso trabajaremos con funciones sobrecargadas con la finalidad de poder llamar a la ‘misma function pero con diferentes parametros. 
    Public Overloads Function TraerDatatable(ByVal ProcedimientoAlmacenado As String) As DataTable
        Dim mDataset As New System.Data.DataSet
        Dim mDatatable As New System.Data.DataTable
        CrearDataAdapter(ProcedimientoAlmacenado).Fill(mDataset)
        mDatatable = mDataset.Tables(0)
        Return mDatatable
    End Function

    'Funcion Sobrecargada 
    Public Overloads Function TraerDatatable(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Argumentos() As System.Object) As System.Data.DataTable
        Dim mDataset As New System.Data.DataSet
        Dim mDatatable As New System.Data.DataTable
        CrearDataAdapter(ProcedimientoAlmacenado, Argumentos).Fill(mDataset)
        mDatatable = mDataset.Tables(0)
        Return mDatatable
    End Function

    Public Overloads Function TraerDatatableComando(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction, ByVal ParamArray Argumentos() As System.Object) As System.Data.DataTable
        Dim mDataset As New System.Data.DataSet
        Dim mDatatable As New System.Data.DataTable
        CrearDataAdapterComando(ProcedimientoAlmacenado, trans, Argumentos).Fill(mDataset)
        mDatatable = mDataset.Tables(0)
        Return mDatatable
    End Function

    Public Overloads Function LeerDatoDesdeSQL(ByVal _SQL As String, ByVal ParamReturn As String, ByRef ValueReturn As Object) As Boolean
        Dim oCMD As SqlCommand = Nothing
        Dim oC As SqlCommandBuilder = New SqlCommandBuilder(_adaptador)
        Dim myReader As SqlDataReader = Nothing
        Dim B As Boolean = False
        cn.ConexionOpen()
        Try
            oCMD = New SqlCommand(_SQL, cn.Conexion)
            oCMD.CommandType = CommandType.Text
            myReader = oCMD.ExecuteReader
            If myReader.Read() Then
                If Not IsDBNull(myReader(ParamReturn)) Then
                    ValueReturn = myReader(ParamReturn)
                    B = True
                End If
            End If
        Catch ex As Exception
            B = False
            Throw New ClsErrorExcepcion(ex.Message & " Error de Consulta SQL")
        Finally
            If Not myReader Is Nothing Then myReader.Close()
            myReader = Nothing
            oCMD.Dispose()
            cn.ConexionClose()
        End Try
        Return B
    End Function

    Public Overloads Function CargarDatosATable(ByVal sSQL As String, ByVal _Data As DataTable) As Boolean
        Dim _resultado As Boolean = False
        Call cn.ConexionOpen()
        Try
            _adaptador = New SqlDataAdapter(sSQL, cn.Conexion)
            _Data.Clear()
            _adaptador.Fill(_Data)
            _adaptador.Dispose()
            _resultado = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call cn.ConexionClose()
        Return _resultado
    End Function
#End Region

#Region "Acciones"
    'sin transacciones
    Public Function Ejecutar(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Argumentos() As System.Object) As Integer
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        Dim Resp As Integer
        cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        CargarParametros(mCom, Argumentos)
        Resp = mCom.ExecuteNonQuery
        cn.ConexionClose()
        Return Resp
    End Function

    'con transacciones
    Public Sub EjecutarComando(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction, ByVal ParamArray Argumentos() As System.Object)
        Try
            Dim mCom As System.Data.SqlClient.SqlCommand = CrearComando(ProcedimientoAlmacenado, trans)

            '        cn.ConexionOpen()
            mCom.Connection = cn.Conexion
            mCom.CommandType = CommandType.StoredProcedure
            mCom.Transaction = trans
            CargarParametros(mCom, Argumentos)
            Dim res As String = mCom.ExecuteNonQuery()

        Catch Ex As DbException
            Dim Men As String
            'Configuracion del mensaje de acuerdo al numero de error devuelto por la MRDB
            If Ex.ErrorCode = -2146232060 Then
                If Ex.Message.IndexOf("PRIMARY") <> -1 Then
                    Men = Module1.MensajeErrorPK
                ElseIf Ex.Message.IndexOf("UNIQUE") <> -1 Then
                    Men = Module1.MensajeErrorUN
                Else
                    Men = Ex.Message
                End If
            Else
                Men = Module1.MensajeErrorGN
            End If
            Throw New ClsErrorExcepcion(Men)
        Catch Ex As DBConcurrencyException
            Throw New ClsErrorExcepcion(Module1.MensajeErrorCR)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        Catch Ex As Exception
            Throw New ClsErrorExcepcion(" * Error: " & Ex.Message)
        End Try
    End Sub
    '       cn.ConexionClose()
    'Return Resp



    Public Function EjecutarEscalar(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Argumentos() As System.Object) As String
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        Dim Resp As String
        cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        CargarParametros(mCom, Argumentos)
        Resp = mCom.ExecuteScalar
        cn.ConexionClose()
        Return Resp
    End Function

    Public Function EjecutarComandoEscalar(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction, ByVal ParamArray Argumentos() As System.Object) As String
        Dim mCom As System.Data.SqlClient.SqlCommand = CrearComando(ProcedimientoAlmacenado, trans)
        Dim Resp As String
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        mCom.Transaction = trans
        CargarParametros(mCom, Argumentos)
        Try


            Resp = mCom.ExecuteScalar
            'cn.ConexionClose()
            Return Resp

        Catch ex As InvalidCastException
            Throw New ClsErrorExcepcion(" * Error al Ejecutar Un Escalar.", ex)
        Catch Ex As DbException
            Dim Men As String
            'Configuracion del mensaje de acuerdo al numero de error devuelto por la MRDB
            If Ex.ErrorCode = -2146232060 Then
                If Ex.Message.IndexOf("PRIMARY") <> -1 Then
                    Men = Module1.MensajeErrorPK
                ElseIf Ex.Message.IndexOf("UNIQUE") <> -1 Then
                    Men = Module1.MensajeErrorUN
                Else
                    Men = Ex.Message
                End If
            Else
                Men = Module1.MensajeErrorGN
            End If
            Throw New ClsErrorExcepcion(Men)
        Catch Ex As DBConcurrencyException
            Throw New ClsErrorExcepcion(Module1.MensajeErrorCR)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        Catch Ex As Exception
            Throw New ClsErrorExcepcion(" * Error: " & Ex.Message)
        End Try
    End Function

    Public Function EjecutarEscalarNoArg(ByVal ProcedimientoAlmacenado As String) As String
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        Dim Resp As String
        cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        'CargarParametros(mCom, Argumentos)
        Try


            Resp = mCom.ExecuteScalar
            cn.ConexionClose()
            Return Resp

        Catch ex As InvalidCastException
            Throw New ClsErrorExcepcion(" * Error al Ejecutar Un Escalar.", ex)
        Catch Ex As DbException
            Dim Men As String
            'Configuracion del mensaje de acuerdo al numero de error devuelto por la MRDB
            If Ex.ErrorCode = -2146232060 Then
                If Ex.Message.IndexOf("PRIMARY") <> -1 Then
                    Men = Module1.MensajeErrorPK
                ElseIf Ex.Message.IndexOf("UNIQUE") <> -1 Then
                    Men = Module1.MensajeErrorUN
                Else
                    Men = Ex.Message
                End If
            Else
                Men = Module1.MensajeErrorGN
            End If
            Throw New ClsErrorExcepcion(Men)
        Catch Ex As DBConcurrencyException
            Throw New ClsErrorExcepcion(Module1.MensajeErrorCR)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        Catch Ex As Exception
            Throw New ClsErrorExcepcion(" * Error: " & Ex.Message)
        End Try
    End Function

    Public Function EjecutarComandoEscalarNoArg(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction) As String
        Dim mCom As System.Data.SqlClient.SqlCommand = CrearComando(ProcedimientoAlmacenado, trans)
        Dim Resp As String
        'cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        mCom.Transaction = trans
        Try


            Resp = mCom.ExecuteScalar
            'cn.ConexionClose()
            Return Resp

        Catch ex As InvalidCastException
            Throw New ClsErrorExcepcion(" * Error al Ejecutar Un Escalar.", ex)
        Catch Ex As DbException
            Dim Men As String
            'Configuracion del mensaje de acuerdo al numero de error devuelto por la MRDB
            If Ex.ErrorCode = -2146232060 Then
                If Ex.Message.IndexOf("PRIMARY") <> -1 Then
                    Men = Module1.MensajeErrorPK
                ElseIf Ex.Message.IndexOf("UNIQUE") <> -1 Then
                    Men = Module1.MensajeErrorUN
                Else
                    Men = Ex.Message
                End If
            Else
                Men = Module1.MensajeErrorGN
            End If
            Throw New ClsErrorExcepcion(Men)
        Catch Ex As DBConcurrencyException
            Throw New ClsErrorExcepcion(Module1.MensajeErrorCR)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        Catch Ex As Exception
            Throw New ClsErrorExcepcion(" * Error: " & Ex.Message)
        End Try
    End Function

    Public Function EjecutarReader(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Argumentos() As System.Object) As SqlDataReader
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        Dim Resp As String
        Dim lector As SqlDataReader
        cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        Try
            CargarParametros(mCom, Argumentos)
            lector = mCom.ExecuteReader
            'cn.ConexionClose()
            Return lector
        Catch Ex As DbException
            Throw New ClsErrorExcepcion(" * " + Ex.Message)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        End Try
    End Function

    Public Function EjecutarComandoReader(ByVal ProcedimientoAlmacenado As String, trans As SqlTransaction, ByVal ParamArray Argumentos() As System.Object) As SqlDataReader
        Dim mCom As System.Data.SqlClient.SqlCommand = CrearComando(ProcedimientoAlmacenado, trans)
        Dim Resp As String
        Dim lector As SqlDataReader
        'cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        mCom.Transaction = trans
        Try
            CargarParametros(mCom, Argumentos)
            lector = mCom.ExecuteReader
            'cn.ConexionClose()
            Return lector
        Catch Ex As DbException
            Throw New ClsErrorExcepcion(" * " + Ex.Message)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        End Try
    End Function

    Public Function EjecutarReaderNoArg(ByVal ProcedimientoAlmacenado As String) As SqlDataReader
        Dim mCom As System.Data.SqlClient.SqlCommand = Comando(ProcedimientoAlmacenado)
        Dim Resp As String
        Dim lector As SqlDataReader
        cn.ConexionOpen()
        mCom.Connection = cn.Conexion
        mCom.CommandType = CommandType.StoredProcedure
        Try

            'CargarParametros(mCom, Argumentos)
            lector = mCom.ExecuteReader
            'cn.ConexionClose()
            Return lector
        Catch Ex As DbException
            Throw New ClsErrorExcepcion(" * " + Ex.Message)
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        End Try
    End Function
#End Region



End Class
