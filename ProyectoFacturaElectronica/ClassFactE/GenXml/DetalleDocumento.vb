Public Class DetalleDocumento
    Private vId As Integer
    Public Property ID As Integer
        Get
            Return vId
        End Get
        Set(value As Integer)
            vId = value
        End Set
    End Property
    Private vCantidad As Decimal
    Public Property Cantidad As Decimal
        Get
            Return vCantidad
        End Get
        Set(value As Decimal)
            vCantidad = value
        End Set
    End Property

    Private vUnidadMedida As String
    Public Property UnidadMedida As String
        Get
            Return vUnidadMedida
        End Get
        Set(value As String)
            vUnidadMedida = value
        End Set
    End Property

    Private vCodigoItem As String
    Public Property CodigoItem As String
        Get
            Return vCodigoItem
        End Get
        Set(value As String)
            vCodigoItem = value
        End Set
    End Property
    Private vDescripcion As String
    Public Property Descripcion As String
        Get
            Return vDescripcion
        End Get
        Set(value As String)
            vDescripcion = value
        End Set
    End Property

    Private vPrecioUnitario As Decimal
    Public Property PrecioUnitario As Decimal
        Get
            Return vPrecioUnitario
        End Get
        Set(value As Decimal)
            vPrecioUnitario = value
        End Set
    End Property

    Private vValorUnitario As Decimal
    Public Property ValorUnitario As Decimal
        Get
            Return vValorUnitario
        End Get
        Set(value As Decimal)
            vValorUnitario = value
        End Set
    End Property

    Private vPrecioReferencial As String
    Public Property PrecioReferencial As String
        Get
            Return vPrecioReferencial
        End Get
        Set(value As String)
            vPrecioReferencial = value
        End Set
    End Property

    Private vTipoPrecio As String
    Public Property TipoPrecio As String
        Get
            Return vTipoPrecio
        End Get
        Set(value As String)
            vTipoPrecio = value
        End Set
    End Property
    Private vTipoImpuesto As String
    Public Property TipoImpuesto As String
        Get
            Return vTipoImpuesto
        End Get
        Set(value As String)
            vTipoImpuesto = value
        End Set
    End Property

    Private vImpuesto As Decimal
    Public Property Impuesto As Decimal
        Get
            Return vImpuesto
        End Get
        Set(value As Decimal)
            vImpuesto = value
        End Set
    End Property

    Private vImpuestoSelectivo As Decimal
    Public Property ImpuestoSelectivo As Decimal
        Get
            Return vImpuestoSelectivo
        End Get
        Set(value As Decimal)
            vImpuestoSelectivo = value
        End Set
    End Property
    Private vOtroImpuesto As Decimal
    Public Property OtroImpuesto As Decimal
        Get
            Return vOtroImpuesto
        End Get
        Set(value As Decimal)
            vOtroImpuesto = value
        End Set
    End Property

    Private vDescuento As Decimal
    Public Property Descuento As Decimal
        Get
            Return vDescuento
        End Get
        Set(value As Decimal)
            vDescuento = value
        End Set
    End Property

    Private vValorTotal As Decimal
    Public Property ValorTotal As Decimal
        Get
            Return vValorTotal
        End Get
        Set(value As Decimal)
            vValorTotal = value
        End Set
    End Property

    Private vTotalVenta As Decimal
    Public Property TotalVenta As Decimal
        Get
            Return vTotalVenta
        End Get
        Set(value As Decimal)
            vTotalVenta = value
        End Set
    End Property

    Private vSuma As Decimal
    Public Property Suma As Decimal
        Get
            Return vSuma
        End Get
        Set(value As Decimal)
            vSuma = value
        End Set
    End Property

    Public Sub New()
        ID = 1
        UnidadMedida = "NIU"
        TipoPrecio = "01"
        TipoImpuesto = "10"
    End Sub

End Class
