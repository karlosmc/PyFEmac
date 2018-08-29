Public Class GrupoResumenNuevo
    Inherits GrupoResumen

    Private vIdDocumento As String
    Public Property IdDocumento As String
        Get
            Return vIdDocumento
        End Get
        Set(value As String)
            vIdDocumento = value
        End Set
    End Property


    Private vTipoDocumentoReceptor As String

    Public Property TipoDocumentoReceptor As String
        Get
            Return vTipoDocumentoReceptor
        End Get
        Set(value As String)
            vTipoDocumentoReceptor = value
        End Set
    End Property

    Private vNroDocumentoReceptor As String

    Public Property NroDocumentoReceptor As String
        Get
            Return vNroDocumentoReceptor
        End Get
        Set(value As String)
            vNroDocumentoReceptor = value
        End Set
    End Property


    Private vCodigoEstadoItem As Integer
    Public Property CodigoEstadoItem As Integer
        Get
            Return vCodigoEstadoItem
        End Get
        Set(value As Integer)
            vCodigoEstadoItem = value
        End Set
    End Property

    Private vDocumentorelacionado As String

    Public Property DocumentoRelacionado As String
        Get
            Return vDocumentorelacionado
        End Get
        Set(value As String)
            vDocumentorelacionado = value
        End Set
    End Property

    Private vTipoDocumentoRelacionado As String
    Public Property TipoDocumentoRelacionado As String
        Get
            Return vTipoDocumentoRelacionado
        End Get
        Set(value As String)
            vTipoDocumentoRelacionado = value
        End Set
    End Property

End Class
