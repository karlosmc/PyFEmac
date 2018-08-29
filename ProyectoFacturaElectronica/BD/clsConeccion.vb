Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Data.Common

Public Class clsConeccion
    Public encrip As New clsEncriptacion
    Dim servidor, base, usuario, pass As String

    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub Obtener_cadena()
        servidor = ConfigurationManager.AppSettings("server").ToString
        base = ConfigurationManager.AppSettings("base").ToString
        usuario = ConfigurationManager.AppSettings("user").ToString
        pass = ConfigurationManager.AppSettings("pass").ToString
    End Sub

    Private Shared MiConexion As New SqlConnection()

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public ReadOnly Property Conexion() As SqlConnection
        Get
            Return MiConexion
        End Get
    End Property

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Function ConexionOpen() As Boolean
        Try
            Obtener_cadena()
            Conexion.ConnectionString = "data source=" & servidor & "; user id=" & usuario & "; pwd=" & pass & "; initial catalog=" & base & ";"
            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If
        Catch ex As System.Reflection.TargetInvocationException
            Throw New ClsErrorExcepcion(" * " + ex.Message)
        Catch ex As DataException
            Throw New ClsErrorExcepcion(" * Error Al Conectarse, Se Produjo en los Componentes de ADO.NET.")
        Catch ex As DbException
            Throw New ClsErrorExcepcion(" * Error Al Conectarse, en el Origen de Datos " + Chr(10) _
            + " DbException.GetType: {0}" + ex.GetType().ToString + Chr(10) _
            + " DbException.Source: {0}" + ex.Source + Chr(10) _
            + " DbException.ErrorCode: {0}" + ex.ErrorCode.ToString + Chr(10) _
            + " DbException.Message: {0}" + ex.Message)
        Catch ex As ArgumentException
            Throw New ClsErrorExcepcion(" * Error Al Conectarse, Corregir La Cadena Conexión")
        Catch ex As InvalidOperationException
            Throw New ClsErrorExcepcion(" * Error Al Conectarse, La Cadena de Conexión está vacía" & ex.Message)
        Catch ex As NullReferenceException
            Throw New ClsErrorExcepcion(" * Error Al Conectarse, La Cadena de Conexión es nula")
        End Try
    End Function

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Function ConexionClose() As Boolean

        Try
            'modificar en conexionclose
            If Not IsNothing(Conexion) Then
                If Conexion.State.Equals(ConnectionState.Open) Then
                    Conexion.Close()
                End If
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            'Return (Conexion.State = ConnectionState.Closed)
        End Try
    End Function
End Class
