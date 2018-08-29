Public Class TipoDocumentoRelacionadosNE

    Private objTipoDocumentoRelacionados As ClsTipoDocumentoRelacionados
    Private objHelper As clsHelper

    Public Sub New()
        objTipoDocumentoRelacionados = New ClsTipoDocumentoRelacionados
        objHelper = New clsHelper
    End Sub
    Public Function AgregarTipoDocumentoRelacionados(ByVal objTipoDocumentoRelacionadosE As TipoDocumentoRelacionadosEN) As String
        Return objTipoDocumentoRelacionados.AgregarTipoDocumentoRelacionados(objTipoDocumentoRelacionadosE)
    End Function
    Public Function ActualizarTipoDocumentoRelacionados(ByVal objTipoDocumentoRelacionadosE As TipoDocumentoRelacionadosEN) As String
        Return objTipoDocumentoRelacionados.ActualizarTipoDocumentoRelacionados(objTipoDocumentoRelacionadosE)
    End Function
    Public Function EliminarTipoDocumentoRelacionados(ID As Integer) As String
        Return objTipoDocumentoRelacionados.EliminarTipoDocumentoRelacionados(ID)
    End Function
    Public Function BuscarxCodTipoDocumentoRelacionados(ID As Integer) As DataTable
        Return objTipoDocumentoRelacionados.BuscarXcodTipoDocumentoRelacionados(ID)
    End Function
    Public Function listarTipoDocumentoRelacionados(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoRelacionadosEN
        Return objTipoDocumentoRelacionados.ListarTipoDocumentoRelacionados(Argumentos)
    End Function
    Public Function listarTipoDocumentoRelacionados2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoRelacionadosEN)
        Return objTipoDocumentoRelacionados.ListarArrayTipoDocumentoRelacionados(Argumentos)
    End Function
    Public Function listarTipoDocumentoRelacionadosLisNoArg() As List(Of TipoDocumentoRelacionadosEN)
        Return objTipoDocumentoRelacionados.ListarArrayTipoDocumentoRelacionadosNoArg()
    End Function
    Public Function listarTipoDocumentoRelacionadosTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
