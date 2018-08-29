
Public Class GrupoResumen
    Inherits DocumentoResumenDetalle

    Private vCorrelativoInicio As Integer
    Public Property CorrelativoInicio As Integer
        Get
            Return vCorrelativoInicio
        End Get
        Set(value As Integer)
            vCorrelativoInicio = value
        End Set
    End Property

    Private vCorrelativoFin As Integer
    Public Property CorrelativoFin As Integer
        Get
            Return vCorrelativoFin
        End Get
        Set(value As Integer)
            vCorrelativoFin = value
        End Set
    End Property

    Private vMoneda As String
    Public Property Moneda As String
        Get
            Return vMoneda
        End Get
        Set(value As String)
            vMoneda = value
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


    Private vTotalDescuentos As Decimal
    Public Property TotalDescuentos As Decimal
        Get
            Return vTotalDescuentos
        End Get
        Set(value As Decimal)
            vTotalDescuentos = value
        End Set
    End Property

    Private vTotalIgv As Decimal
    Public Property TotalIgv As Decimal
        Get
            Return vTotalIgv
        End Get
        Set(value As Decimal)
            vTotalIgv = value
        End Set
    End Property

    Private vTotalIsc As Decimal
    Public Property TotalIsc As Decimal
        Get
            Return vTotalIsc
        End Get
        Set(value As Decimal)
            vTotalIsc = value
        End Set
    End Property

    Private vTotalOtrosImpuestos As Decimal
    Public Property TotalOtrosImpuestos As Decimal
        Get
            Return vTotalOtrosImpuestos
        End Get
        Set(value As Decimal)
            vTotalOtrosImpuestos = value
        End Set
    End Property

    Private vGravadas As Decimal

    Public Property Gravadas As Decimal
        Get
            Return vGravadas
        End Get
        Set(value As Decimal)
            vGravadas = value
        End Set
    End Property

    Private vExoneradas As Decimal

    Public Property Exoneradas As Decimal
        Get
            Return vExoneradas
        End Get
        Set(value As Decimal)
            vExoneradas = value
        End Set
    End Property

    Private vInafectas As Decimal
    Public Property Inafectas As Decimal
        Get
            Return vInafectas
        End Get
        Set(value As Decimal)
            vInafectas = value
        End Set
    End Property

    Private vExportacion As Decimal
    Public Property Exportacion As Decimal
        Get
            Return vExportacion
        End Get
        Set(value As Decimal)
            vExportacion = value
        End Set
    End Property

    Private vGratuitas As Decimal
    Public Property Gratuitas As Decimal
        Get
            Return vGratuitas
        End Get
        Set(value As Decimal)
            vGratuitas = value
        End Set
    End Property

End Class
