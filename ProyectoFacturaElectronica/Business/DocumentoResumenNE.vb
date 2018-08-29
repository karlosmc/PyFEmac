Public Class DocumentoResumenNE

    Private objDocumentoResumen As ClsDocumentoResumen
    Private objHelper As clsHelper

    Public Sub New()
        objDocumentoResumen = New ClsDocumentoResumen
        objHelper = New clsHelper
    End Sub
    Public Function AgregarDocumentoResumen(ByVal objDocumentoResumenE As DocumentoResumenEN) As String
        Return objDocumentoResumen.AgregarDocumentoResumen(objDocumentoResumenE)
    End Function
    Public Function ActualizarDocumentoResumen(ByVal objDocumentoResumenE As DocumentoResumenEN) As String
        Return objDocumentoResumen.ActualizarDocumentoResumen(objDocumentoResumenE)
    End Function
    Public Function EliminarDocumentoResumen(ID As Integer) As String
        Return objDocumentoResumen.EliminarDocumentoResumen(ID)
    End Function
    Public Function BuscarxCodDocumentoResumen(ID As Integer) As DataTable
        Return objDocumentoResumen.BuscarXcodDocumentoResumen(ID)
    End Function
    Public Function listarDocumentoResumen(ByVal ParamArray Argumentos() As System.Object) As DocumentoResumenEN
        Return objDocumentoResumen.ListarDocumentoResumen(Argumentos)
    End Function
    Public Function listarDocumentoResumen2(ByVal ParamArray Argumentos() As System.Object) As List(Of DocumentoResumenEN)
        Return objDocumentoResumen.ListarArrayDocumentoResumen(Argumentos)
    End Function
    Public Function listarDocumentoResumenLisNoArg() As List(Of DocumentoResumenEN)
        Return objDocumentoResumen.ListarArrayDocumentoResumenNoArg()
    End Function
    Public Function listarDocumentoResumenTableNoArg(procedimiento As String) As DataTable
        Return objHelper.TraerDataTable(procedimiento)
    End Function

End Class
