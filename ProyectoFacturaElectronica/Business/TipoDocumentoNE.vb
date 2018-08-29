Public Class TipoDocumentoNE

    Private objTipoDocumento As ClsTipoDocumento
    Private objHelper As clsHelper

    Public Sub New()
        objTipoDocumento = New ClsTipoDocumento
        objHelper = New clsHelper
    End Sub
    Public Function AgregarTipoDocumento(ByVal objTipoDocumentoE As TipoDocumentoEN) As String
        Return objTipoDocumento.AgregarTipoDocumento(objTipoDocumentoE)
    End Function
    Public Function ActualizarTipoDocumento(ByVal objTipoDocumentoE As TipoDocumentoEN) As String
        Return objTipoDocumento.ActualizarTipoDocumento(objTipoDocumentoE)
    End Function
    Public Function EliminarTipoDocumento(ID As Integer) As String
        Return objTipoDocumento.EliminarTipoDocumento(ID)
    End Function
    Public Function BuscarxCodTipoDocumento(ID As Integer) As DataTable
        Return objTipoDocumento.BuscarXcodTipoDocumento(ID)
    End Function

    Public Function ListarTipoDocumentos() As DataTable
        Return objTipoDocumento.ListarTipoDocumentos()
    End Function
    Public Function listarTipoDocumento(ByVal ParamArray Argumentos() As System.Object) As TipoDocumentoEN
        Return objTipoDocumento.ListarTipoDocumento(Argumentos)
    End Function
    Public Function listarTipoDocumento2(ByVal ParamArray Argumentos() As System.Object) As List(Of TipoDocumentoEN)
        Return objTipoDocumento.ListarArrayTipoDocumento(Argumentos)
    End Function
    Public Function listarTipoDocumentoLisNoArg() As List(Of TipoDocumentoEN)
        Return objTipoDocumento.ListarArrayTipoDocumentoNoArg()
    End Function
    Public Function listarTipoDocumentoTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
