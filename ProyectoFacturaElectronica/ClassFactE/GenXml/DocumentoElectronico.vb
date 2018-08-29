Public Class DocumentoElectronico

    Private vIdDocumento As String
    Private vTipoDocumento As String
    Private vEmisor As Contribuyente
    Private vReceptor As Contribuyente
    Private vFechaEmision As String
    Private vMoneda As String
    Private vTipoOperacion As String
    Private vGravadas As Decimal
    Private vGratuitas As Decimal
    Private vInafectas As Decimal
    Private vExoneradas As Decimal
    Private vDescuentoGlobal As Decimal
    Private vItems As List(Of DetalleDocumento)
    Private vTotalVenta As Decimal
    Private vTotalIgv As Decimal
    Private vTotalIsc As Decimal
    Private vTotalOtrosTributos As Decimal
    Private vMontoEnLetras As String
    Private vPlacaVehiculo As String
    Private vMontoPercepcion As Decimal
    Private vMontoDetraccion As Decimal
    Private vDatoAdicionales As List(Of DatoAdicional)
    Private vTipoDocAnticipo As String
    Private vDocAnticipo As String
    Private vMonedaAnticipo As String
    Private vMontoAnticipo As Decimal
    Private vDatosGuiaTransportista As DatosGuia
    Private vRelacionados As List(Of DocumentoRelacionado)
    Private vOtrosDocumentosRelacionados As List(Of DocumentoRelacionado)
    Private vDiscrepancias As List(Of Discrepancia)
    Private vCalculoIgv As Decimal
    Private vCalculoIsc As Decimal
    Private vCalculoDetraccion As Decimal

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
    Public Property Emisor As Contribuyente
        Get
            Return vEmisor
        End Get
        Set(value As Contribuyente)
            vEmisor = value
        End Set
    End Property
    Public Property Receptor As Contribuyente
        Get
            Return vReceptor
        End Get
        Set(value As Contribuyente)
            vReceptor = value
        End Set
    End Property
    Public Property FechaEmision As String
        Get
            Return vFechaEmision
        End Get
        Set(value As String)
            vFechaEmision = value
        End Set
    End Property
    Public Property Moneda As String
        Get
            Return vMoneda
        End Get
        Set(value As String)
            vMoneda = value
        End Set
    End Property
    Public Property TipoOperacion As String
        Get
            Return vTipoOperacion
        End Get
        Set(value As String)
            vTipoOperacion = value
        End Set
    End Property
    Public Property Gravadas As Decimal
        Get
            Return vGravadas
        End Get
        Set(value As Decimal)
            vGravadas = value
        End Set
    End Property
    Public Property Gratuitas As Decimal
        Get
            Return vGratuitas
        End Get
        Set(value As Decimal)
            vGratuitas = value
        End Set
    End Property
    Public Property Inafectas As Decimal
        Get
            Return vInafectas
        End Get
        Set(value As Decimal)
            vInafectas = value
        End Set
    End Property
    Public Property Exoneradas As Decimal
        Get
            Return vExoneradas
        End Get
        Set(value As Decimal)
            vExoneradas = value
        End Set
    End Property
    Public Property DescuentoGlobal As Decimal
        Get
            Return vDescuentoGlobal
        End Get
        Set(value As Decimal)
            vDescuentoGlobal = value
        End Set
    End Property
    Public Property Items As List(Of DetalleDocumento)
        Get
            Return vItems
        End Get
        Set(value As List(Of DetalleDocumento))
            vItems = value
        End Set
    End Property
    Public Property TotalVenta As Decimal
        Get
            Return vTotalVenta
        End Get
        Set(value As Decimal)
            vTotalVenta = value
        End Set
    End Property
    Public Property TotalIgv As Decimal
        Get
            Return vTotalIgv
        End Get
        Set(value As Decimal)
            vTotalIgv = value
        End Set
    End Property
    Public Property TotalIsc As Decimal
        Get
            Return vTotalIsc
        End Get
        Set(value As Decimal)
            vTotalIsc = value
        End Set
    End Property
    Public Property TotalOtrosTributos As Decimal
        Get
            Return vTotalOtrosTributos
        End Get
        Set(value As Decimal)
            vTotalOtrosTributos = value
        End Set
    End Property
    Public Property MontoEnLetras As String
        Get
            Return vMontoEnLetras
        End Get
        Set(value As String)
            vMontoEnLetras = value
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
    Public Property MontoPercepcion As Decimal
        Get
            Return vMontoPercepcion
        End Get
        Set(value As Decimal)
            vMontoPercepcion = value
        End Set
    End Property
    Public Property MontoDetraccion As Decimal
        Get
            Return vMontoDetraccion
        End Get
        Set(value As Decimal)
            vMontoDetraccion = value
        End Set
    End Property
    Public Property DatoAdicionales As List(Of DatoAdicional)
        Get
            Return vDatoAdicionales
        End Get
        Set(value As List(Of DatoAdicional))
            vDatoAdicionales = value
        End Set
    End Property

    Public Property TipoDocAnticipo As String
        Get
            Return vTipoDocAnticipo
        End Get
        Set(value As String)
            vTipoDocAnticipo = value
        End Set
    End Property
    Public Property DocAnticipo As String
        Get
            Return vDocAnticipo
        End Get
        Set(value As String)
            vDocAnticipo = value
        End Set
    End Property
    Public Property MonedaAnticipo As String
        Get
            Return vMonedaAnticipo
        End Get
        Set(value As String)
            vMonedaAnticipo = value
        End Set
    End Property
    Public Property MontoAnticipo As Decimal
        Get
            Return vMontoAnticipo
        End Get
        Set(value As Decimal)
            vMontoAnticipo = value
        End Set
    End Property
    Public Property DatosGuiaTransportista As DatosGuia
        Get
            Return vDatosGuiaTransportista
        End Get
        Set(value As DatosGuia)
            vDatosGuiaTransportista = value
        End Set
    End Property
    Public Property Relacionados As List(Of DocumentoRelacionado)
        Get
            Return vRelacionados
        End Get
        Set(value As List(Of DocumentoRelacionado))
            vRelacionados = value
        End Set
    End Property
    Public Property OtrosDocumentosRelacionados As List(Of DocumentoRelacionado)
        Get
            Return vOtrosDocumentosRelacionados
        End Get
        Set(value As List(Of DocumentoRelacionado))
            vOtrosDocumentosRelacionados = value
        End Set
    End Property
    Public Property Discrepancias As List(Of Discrepancia)
        Get
            Return vDiscrepancias

        End Get
        Set(value As List(Of Discrepancia))
            vDiscrepancias = value
        End Set
    End Property
    Public Property CalculoIgv As Decimal
        Get
            Return vCalculoIgv
        End Get
        Set(value As Decimal)
            vCalculoIgv = value
        End Set
    End Property
    Public Property CalculoIsc As Decimal
        Get
            Return vCalculoIsc
        End Get
        Set(value As Decimal)
            vCalculoIsc = value
        End Set
    End Property
    Public Property CalculoDetraccion As Decimal
        Get
            Return vCalculoDetraccion
        End Get
        Set(value As Decimal)
            vCalculoDetraccion = value
        End Set
    End Property
    Public Sub New()
        Emisor = New Contribuyente
        Emisor.TipoDocumento = "6"
        Receptor = New Contribuyente
        Receptor.TipoDocumento = "6"
        CalculoIgv = 0.18
        CalculoIsc = 0
        CalculoDetraccion = 10
        Items = New List(Of DetalleDocumento)
        DatoAdicionales = New List(Of DatoAdicional)
        Relacionados = New List(Of DocumentoRelacionado)
        OtrosDocumentosRelacionados = New List(Of DocumentoRelacionado)
        DatosGuiaTransportista = New DatosGuia
        Discrepancias = New List(Of Discrepancia)
        TipoDocumento = "01"
        TipoOperacion = "01"
        Moneda = "PEN"
        MontoAnticipo = 0
        TotalIgv = 0
        TotalIsc = 0
        TotalVenta = 0
        TotalOtrosTributos = 0
        Gravadas = 0
        Gratuitas = 0
        Exoneradas = 0
        Inafectas = 0
        Me.MontoDetraccion = 0
        Me.MontoPercepcion = 0
    End Sub

End Class
