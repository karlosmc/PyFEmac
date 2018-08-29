Imports System.Linq
public class EmpresaNE

   Private objEmpresa As clsEmpresa
   Private objHelper As clsHelper

   Public Sub New()
       objEmpresa = New clsEmpresa
       objHelper = New clsHelper
   End Sub
   Public Function AgregarEmpresa(ByVal objEmpresaE As EmpresaEN) As String
       Return objEmpresa.AgregarEmpresa(objEmpresaE)
   End Function
   Public Function ActualizarEmpresa(ByVal objEmpresaE As EmpresaEN) As String
       Return objEmpresa.ActualizarEmpresa(objEmpresaE)
   End Function
   Public Function EliminarEmpresa(ID As Integer) As String
       Return objEmpresa.EliminarEmpresa(ID)
   End Function
   Public Function BuscarxCodEmpresa(ID As Integer) As DataTable
       Return objEmpresa.BuscarxCodEmpresa(ID)
    End Function
    Public Function BuscarEmpresaPorRUC(ruc As String) As DataTable

    End Function

   Public Function listarEmpresa(ByVal ParamArray Argumentos() As System.Object) As EmpresaEN
       Return objEmpresa.ListarEmpresa(Argumentos)
   End Function
    Public Function listarEmpresa2(ByVal ParamArray Argumentos() As System.Object) As List(Of EmpresaEN)

        Return objEmpresa.ListarArrayEmpresa(Argumentos)

    End Function
    Public Function LoadEmpresa() As List(Of EmpresaEN)
        'Dim listEmpresa As New List(Of EmpresaEN)
        'Dim resultados As New List(Of EmpresaEN)
        '        listEmpresa = objEmpresa.LoadEmpresa()
        Return objEmpresa.LoadEmpresa()
        'Dim query = listEmpresa.Where(Function(p) p.pNombreLegal.Contains(param))
        'If query.Count <= 0 Then
        '    query = listEmpresa.Where(Function(p) p.pNroDocumento.Contains(param))
        'End If
        'For Each result In query
        '    resultados.Add(result)
        'Next
        'Return resultados
    End Function
   Public Function listarEmpresaTableNoArg(procedimiento as string) As DataTable
       Return objHelper.TraerDataTable(procedimiento)
   End Function

End Class
