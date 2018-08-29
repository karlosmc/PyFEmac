Public Class EnvioDocumentoComun

    Private vRuc As String
    Private vIdDocumento As String
    Private vTipoDocumento As String
    Private vUsuarioSol As String
    Private vClaveSol As String
    Private vEndPointUrl As String
    Public Property Ruc As String
        Get
            Return vRuc
        End Get
        Set(value As String)
            vRuc = value
        End Set
    End Property
    Public Property IdDocumento As String
        Get
            Return vIdDocumento
        End Get
        Set(value As String)
            vIdDocumento = value
        End Set
    End Property
    Public Property TipoDocumento As String
        Get
            Return vTipoDocumento
        End Get
        Set(value As String)
            vTipoDocumento = value
        End Set
    End Property

    Public Property UsuarioSol As String
        Get
            Return vUsuarioSol
        End Get
        Set(value As String)
            vUsuarioSol = value
        End Set
    End Property
    Public Property ClaveSol As String
        Get
            Return vClaveSol
        End Get
        Set(value As String)
            vClaveSol = value
        End Set
    End Property
    Public Property EndPointUrl As String
        Get
            Return vEndPointUrl
        End Get
        Set(value As String)
            vEndPointUrl = value
        End Set
    End Property
End Class
