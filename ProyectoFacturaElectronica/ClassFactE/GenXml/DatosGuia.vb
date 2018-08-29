Public Class DatosGuia
    Private vDireccionDestino As Contribuyente
    Public Property DireccionDestino As Contribuyente
        Get
            Return vDireccionDestino
        End Get
        Set(value As Contribuyente)
            vDireccionDestino = value
        End Set
    End Property

    Private vDireccionOrigen As Contribuyente
    Public Property DireccionOrigen As Contribuyente
        Get
            Return vDireccionOrigen
        End Get
        Set(value As Contribuyente)
            vDireccionOrigen = value
        End Set
    End Property

    Private vRucTransportista As String
    Public Property RucTransportista As String
        Get
            Return vRucTransportista
        End Get
        Set(value As String)
            vRucTransportista = value
        End Set
    End Property

    Private vTipoDocTransportista As String
    Private vNombreTransportista As String
    Private vNroLicenciaConducir As String
    Private vPlacaVehiculo As String
    Private vCodigoAutorizacion As String
    Private vMarcaVehiculo As String
    Private vModoTransporte As String
    Private vUnidadMedida As String
    Private vPesoBruto As Decimal

    Public Property TipoDocTransportista As String
        Get
            Return vTipoDocTransportista
        End Get
        Set(value As String)
            vTipoDocTransportista = value
        End Set
    End Property
    Public Property NombreTransportista As String
        Get
            Return vNombreTransportista
        End Get
        Set(value As String)
            vNombreTransportista = value
        End Set
    End Property
    Public Property NroLicenciaConducir As String
        Get
            Return vNroLicenciaConducir
        End Get
        Set(value As String)
            vNroLicenciaConducir = value
        End Set
    End Property
    Public Property PlacaVehiculo As String
        Get
            Return vPlacaVehiculo
        End Get
        Set(value As String)
            vPlacaVehiculo = value
        End Set
    End Property
    Public Property CodigoAutorizacion As String
        Get
            Return vCodigoAutorizacion
        End Get
        Set(value As String)
            vCodigoAutorizacion = value
        End Set
    End Property
    Public Property MarcaVehiculo As String
        Get
            Return vMarcaVehiculo
        End Get
        Set(value As String)
            vMarcaVehiculo = value
        End Set
    End Property
    Public Property ModoTransporte As String
        Get
            Return vModoTransporte
        End Get
        Set(value As String)
            vModoTransporte = value
        End Set
    End Property
    Public Property UnidadMedida As String
        Get
            Return vUnidadMedida
        End Get
        Set(value As String)
            vUnidadMedida = value
        End Set
    End Property
    Public Property PesoBruto As Decimal
        Get
            Return vPesoBruto
        End Get
        Set(value As Decimal)
            vPesoBruto = value
        End Set
    End Property

    Public Sub New()
        DireccionDestino = New Contribuyente
        DireccionOrigen = New Contribuyente
    End Sub

End Class
