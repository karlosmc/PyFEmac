Public Class DocumentoResumen

    Private vIdDocumento As String
    Public Property IdDocumento As String
        Get
            Return vIdDocumento
        End Get
        Set(value As String)
            vIdDocumento = value
        End Set
    End Property


    Private vFechaEmision As String
    Public Property FechaEmision As String
        Get
            Return vFechaEmision
        End Get
        Set(value As String)
            vFechaEmision = value
        End Set
    End Property

    Private vFechaReferencia As String

    Public Property FechaReferencia As String
        Get
            Return vFechaReferencia
        End Get
        Set(value As String)
            vFechaReferencia = value
        End Set
    End Property

    Private vEmisor As Contribuyente
    Public Property Emisor As Contribuyente
        Get
            Return vEmisor
        End Get
        Set(value As Contribuyente)
            vEmisor = value
        End Set
    End Property

    '[JsonProperty(Required = Required.Always)]
    'public Contribuyente Emisor { get; set; }

    Public Sub New()
        Emisor = New Contribuyente
    End Sub


End Class
