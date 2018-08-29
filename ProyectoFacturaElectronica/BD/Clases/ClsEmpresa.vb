Imports System.Data.SqlClient
Imports System.Reflection


public class ClsEmpresa

   Public cmdEmpresa As SqlCommand
   Dim objConexion As New clsConeccion
   Dim objHelper As New clsHelper

   Public Function AgregarEmpresa(ByVal objEmpresaE As EmpresaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdEmpresa = New SqlCommand
       cmdEmpresa.CommandType = CommandType.StoredProcedure
       cmdEmpresa.CommandText = "I_Empresa"
       objConexion.ConexionOpen()
       cmdEmpresa.Connection = objConexion.Conexion
       With cmdEmpresa.Parameters
           .Add("@ID", SqlDbType.int).Value = objEmpresaE.pID
           .Add("@NroDocumento", SqlDbType.varchar).Value = objEmpresaE.pNroDocumento
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objEmpresaE.pIdTipoDocumento
           .Add("@NombreLegal", SqlDbType.varchar).Value = objEmpresaE.pNombreLegal
           .Add("@NombreComercial", SqlDbType.varchar).Value = objEmpresaE.pNombreComercial
           .Add("@Direccion", SqlDbType.varchar).Value = objEmpresaE.pDireccion
           .Add("@Urbanizacion", SqlDbType.varchar).Value = objEmpresaE.pUrbanizacion
           .Add("@CorreoElectronico", SqlDbType.varchar).Value = objEmpresaE.pCorreoElectronico
           .Add("@IdUbigeo", SqlDbType.int).Value = objEmpresaE.pIdUbigeo
           .Add("@Ubigeo", SqlDbType.varchar).Value = objEmpresaE.pUbigeo
       End with
       Try
           registro = cmdEmpresa.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdEmpresa.Parameters.Clear()
       End Try
   End Function

   Public Function ActualizarEmpresa(ByVal objEmpresaE As EmpresaEN) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdEmpresa = New SqlCommand
       cmdEmpresa.CommandType = CommandType.StoredProcedure
       cmdEmpresa.CommandText = "U_Empresa"
       objConexion.ConexionOpen()
       cmdEmpresa.Connection = objConexion.Conexion
       With cmdEmpresa.Parameters
           .Add("@ID", SqlDbType.int).Value = objEmpresaE.pID
           .Add("@NroDocumento", SqlDbType.varchar).Value = objEmpresaE.pNroDocumento
           .Add("@IdTipoDocumento", SqlDbType.varchar).Value = objEmpresaE.pIdTipoDocumento
           .Add("@NombreLegal", SqlDbType.varchar).Value = objEmpresaE.pNombreLegal
           .Add("@NombreComercial", SqlDbType.varchar).Value = objEmpresaE.pNombreComercial
           .Add("@Direccion", SqlDbType.varchar).Value = objEmpresaE.pDireccion
           .Add("@Urbanizacion", SqlDbType.varchar).Value = objEmpresaE.pUrbanizacion
           .Add("@CorreoElectronico", SqlDbType.varchar).Value = objEmpresaE.pCorreoElectronico
           .Add("@IdUbigeo", SqlDbType.int).Value = objEmpresaE.pIdUbigeo
           .Add("@Ubigeo", SqlDbType.varchar).Value = objEmpresaE.pUbigeo
       End with
       try
           registro = cmdEmpresa.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdEmpresa.Parameters.Clear()
       End Try
   End Function

   Public Function EliminarEmpresa(ID As Integer) As String
       Dim registro As Integer
       Dim mensaje As String = ""
       cmdEmpresa = New SqlCommand
       cmdEmpresa.CommandType = CommandType.StoredProcedure
       cmdEmpresa.CommandText = "D_Empresa"
       objConexion.ConexionOpen()
       cmdEmpresa.Connection = objConexion.Conexion
       With cmdEmpresa.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           registro = cmdEmpresa.ExecuteNonQuery
           objConexion.ConexionClose()
           mensaje = "Operación completa"
           Return mensaje
       Catch ex As Exception
           mensaje = ex.Message
           Return mensaje
       Finally
           cmdEmpresa.Parameters.Clear()
       End Try
   End Function

   Public Function BuscarXcodEmpresa(ID As Integer) As Datatable
       Dim tblEmpresa As New Datatable
       Dim daEmpresa As New SqlDataAdapter
       cmdEmpresa = New SqlCommand
       cmdEmpresa.CommandType = CommandType.StoredProcedure
       cmdEmpresa.CommandText = "B_EmpresaCOD"
       objConexion.ConexionOpen()
       cmdEmpresa.Connection = objConexion.Conexion
       With cmdEmpresa.Parameters
           .Add("@ID", SqlDbType.int).Value =ID
       End with
       Try
           daEmpresa.SelectCommand = cmdEmpresa
           daEmpresa.Fill(tblEmpresa)
           objConexion.ConexionClose()
           Return tblEmpresa
       Catch ex As Exception
           MsgBox(ex.Message)
           Return Nothing
       Finally
           cmdEmpresa.Parameters.Clear()
       End Try
    End Function

    'Public Function LoadEmpresa() As DataTable
    '    Dim tblEmpresa As New DataTable
    '    Dim daEmpresa As New SqlDataAdapter
    '    cmdEmpresa = New SqlCommand
    '    cmdEmpresa.CommandType = CommandType.StoredProcedure
    '    cmdEmpresa.CommandText = "S_Empresa"
    '    objConexion.ConexionOpen()
    '    cmdEmpresa.Connection = objConexion.Conexion
    '    Try
    '        daEmpresa.SelectCommand = cmdEmpresa
    '        daEmpresa.Fill(tblEmpresa)
    '        objConexion.ConexionClose()
    '        Return tblEmpresa
    '    Catch ex As Exception
    '        Throw New ClsErrorExcepcion("Error al listar Empresas")
    '        Return Nothing
    '    Finally
    '        cmdEmpresa.Parameters.Clear()
    '    End Try
    'End Function

   Public Function ListarEmpresa(ByVal ParamArray Argumentos() As System.Object) As EmpresaEN
       Dim dtEmpresa As New datatable
       Dim objEmpresaE As New EmpresaEN
        dtEmpresa = objHelper.TraerDatatable("B_Empresa", Argumentos)
       If dtEmpresa.Rows.Count = 0 Then
           Return objEmpresaE
       End If
       For Each lector As DataRow In dtEmpresa.Rows
           With objEmpresaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pNombreLegal= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pNombreComercial= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDireccion= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pUrbanizacion= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pCorreoElectronico= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
                .pIdUbigeo = IIf(IsDBNull(lector(8)), 0, lector(8))
                .pUbigeo = IIf(IsDBNull(lector(9)), "", lector(9))
           End With
       Next
       Return objEmpresaE
   End Function

   Public Function ListarArrayEmpresa(ByVal ParamArray Argumentos() As System.Object) As List(Of EmpresaEN)
       Dim dtEmpresa As New datatable
       Dim lista As New List(Of EmpresaEN)
       Dim objEmpresaE As New EmpresaEN
       dtEmpresa= objHelper.TraerDataTable("L_Empresa", Argumentos)
       If dtEmpresa.Rows.Count = 0 Then
           Return lista
       End If
       For Each lector As DataRow In dtEmpresa.Rows
           objEmpresaE = New EmpresaEN
           With objEmpresaE
               .pID= Iif(String.IsNullOrEmpty(lector(0)),"",lector(0))
               .pNroDocumento= Iif(String.IsNullOrEmpty(lector(1)),"",lector(1))
               .pIdTipoDocumento= Iif(String.IsNullOrEmpty(lector(2)),"",lector(2))
               .pNombreLegal= Iif(String.IsNullOrEmpty(lector(3)),"",lector(3))
               .pNombreComercial= Iif(String.IsNullOrEmpty(lector(4)),"",lector(4))
               .pDireccion= Iif(String.IsNullOrEmpty(lector(5)),"",lector(5))
               .pUrbanizacion= Iif(String.IsNullOrEmpty(lector(6)),"",lector(6))
               .pCorreoElectronico= Iif(String.IsNullOrEmpty(lector(7)),"",lector(7))
               .pIdUbigeo= Iif(String.IsNullOrEmpty(lector(8)),"",lector(8))
               .pUbigeo= Iif(String.IsNullOrEmpty(lector(9)),"",lector(9))
           lista.Add(objEmpresaE)
           End With
       Next
       Return lista
   End Function

    Public Function LoadEmpresa() As List(Of EmpresaEN)
        Dim dtEmpresa As New DataTable
        Dim lista As New List(Of EmpresaEN)
        Dim objEmpresaE As New EmpresaEN
        dtEmpresa = objHelper.TraerDatatable("S_Empresa")
        If dtEmpresa.Rows.Count = 0 Then
            Return lista
        End If
        For Each lector As DataRow In dtEmpresa.Rows
            objEmpresaE = New EmpresaEN
            With objEmpresaE
                .pID = IIf(String.IsNullOrEmpty(lector(0)), "", lector(0))
                .pNroDocumento = IIf(String.IsNullOrEmpty(lector(1)), "", lector(1))
                .pIdTipoDocumento = IIf(String.IsNullOrEmpty(lector(2)), "", lector(2))
                .pNombreLegal = IIf(String.IsNullOrEmpty(lector(3)), "", lector(3))
                .pNombreComercial = IIf(String.IsNullOrEmpty(lector(4)), "", lector(4))
                .pDireccion = IIf(String.IsNullOrEmpty(lector(5)), "", lector(5))
                .pUrbanizacion = IIf(String.IsNullOrEmpty(lector(6)), "", lector(6))
                .pCorreoElectronico = IIf(String.IsNullOrEmpty(lector(7)), "", lector(7))
                .pIdUbigeo = IIf(IsDBNull(lector(8)), 0, lector(8))
                .pUbigeo = IIf(IsDBNull(lector(9)), "-", lector(9))
                lista.Add(objEmpresaE)
            End With
        Next
        Return lista
    End Function

End Class
