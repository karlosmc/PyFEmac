public class CabeceraDocumentoEN

   Private vID as Integer
   Private vIdTipodocumento as String
   Private vIdEmisor as String
   Private vIdReceptor as String
   Private vIdMoneda as String
   Private vIdTipoOperacion as String
   Private vIdDocumentoAnticipo as String
   Private vIdGuiaTransportista as String
   Private vIdDocumento as String
   Private vGravadas as Decimal
   Private vGratuitas as Decimal
   Private vInafectas as Decimal
   Private vExoneradas as Decimal
   Private vDescuentoGlobal as Decimal
   Private vTotalVenta as Decimal
   Private vTotalIgv as Decimal
   Private vTotalIsc as Decimal
   Private vTotalOtrosTributos as Decimal
   Private vMontoEnLetras as String
   Private vPlacaVehiculo as String
   Private vMontoPercepcion as Decimal
   Private vMontoDetraccion as Decimal
    Private vEstadoDocumento As String

    Private vCalculoDetraccion As Decimal

    Private vDetalles As List(Of DocumentoDetalleEN)
    Private vDiscrepancias As List(Of DiscrepanciaDocumentoEN)
    Private vAdicionales As List(Of DatoAdicionalEN)
    Private vRelacionados As List(Of DocumentoRelacionadoEN)

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pID As Integer
        Get
            Return vID
        End Get
        Set(ByVal value As Integer)
            vID = value
        End Set
    End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipodocumento As String
       Get
           Return vIdTipodocumento
       End Get
       Set(ByVal value As String)
           vIdTipodocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdEmisor As String
       Get
           Return vIdEmisor
       End Get
       Set(ByVal value As String)
           vIdEmisor = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdReceptor As String
       Get
           Return vIdReceptor
       End Get
       Set(ByVal value As String)
           vIdReceptor = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdMoneda As String
       Get
           Return vIdMoneda
       End Get
       Set(ByVal value As String)
           vIdMoneda = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipoOperacion As String
       Get
           Return vIdTipoOperacion
       End Get
       Set(ByVal value As String)
           vIdTipoOperacion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdDocumentoAnticipo As String
       Get
           Return vIdDocumentoAnticipo
       End Get
       Set(ByVal value As String)
           vIdDocumentoAnticipo = value
       End Set
   End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pIdGuiaTransportista As String
        Get
            Return vIdGuiaTransportista
        End Get
        Set(ByVal value As String)
            vIdGuiaTransportista = value
        End Set
    End Property
   
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pIdDocumento As String
        Get
            Return vIdDocumento
        End Get
        Set(ByVal value As String)
            vIdDocumento = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pGravadas As Decimal
        Get
            Return vGravadas
        End Get
        Set(ByVal value As Decimal)
            vGravadas = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pGratuitas As Decimal
        Get
            Return vGratuitas
        End Get
        Set(ByVal value As Decimal)
            vGratuitas = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pInafectas As Decimal
        Get
            Return vInafectas
        End Get
        Set(ByVal value As Decimal)
            vInafectas = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pExoneradas As Decimal
        Get
            Return vExoneradas
        End Get
        Set(ByVal value As Decimal)
            vExoneradas = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pDescuentoGlobal As Decimal
        Get
            Return vDescuentoGlobal
        End Get
        Set(ByVal value As Decimal)
            vDescuentoGlobal = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pTotalVenta As Decimal
        Get
            Return vTotalVenta
        End Get
        Set(ByVal value As Decimal)
            vTotalVenta = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pTotalIgv As Decimal
        Get
            Return vTotalIgv
        End Get
        Set(ByVal value As Decimal)
            vTotalIgv = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pTotalIsc As Decimal
        Get
            Return vTotalIsc
        End Get
        Set(ByVal value As Decimal)
            vTotalIsc = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pTotalOtrosTributos As Decimal
        Get
            Return vTotalOtrosTributos
        End Get
        Set(ByVal value As Decimal)
            vTotalOtrosTributos = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pMontoEnLetras As String
        Get
            Return vMontoEnLetras
        End Get
        Set(ByVal value As String)
            vMontoEnLetras = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pPlacaVehiculo As String
        Get
            Return vPlacaVehiculo
        End Get
        Set(ByVal value As String)
            vPlacaVehiculo = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pMontoPercepcion As Decimal
        Get
            Return vMontoPercepcion
        End Get
        Set(ByVal value As Decimal)
            vMontoPercepcion = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pMontoDetraccion As Decimal
        Get
            Return vMontoDetraccion
        End Get
        Set(ByVal value As Decimal)
            vMontoDetraccion = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pEstadoDocumento As String
        Get
            Return vEstadoDocumento
        End Get
        Set(ByVal value As String)
            vEstadoDocumento = value
        End Set
    End Property

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pDetalles As List(Of DocumentoDetalleEN)
        Get
            Return vDetalles
        End Get
        Set(value As List(Of DocumentoDetalleEN))
            vDetalles = value
        End Set
    End Property

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pDiscrepancias As List(Of DiscrepanciaDocumentoEN)
        Get
            Return vDiscrepancias
        End Get
        Set(value As List(Of DiscrepanciaDocumentoEN))
            vDiscrepancias = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pAdicionales As List(Of DatoAdicionalEN)
        Get
            Return vAdicionales
        End Get
        Set(value As List(Of DatoAdicionalEN))
            vAdicionales = value
        End Set
    End Property
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Property pRelacionados As List(Of DocumentoRelacionadoEN)
        Get
            Return vRelacionados
        End Get
        Set(value As List(Of DocumentoRelacionadoEN))
            vRelacionados = value
        End Set
    End Property

    Public Property pCalculoDetraccion As Decimal
        Get
            Return vCalculoDetraccion
        End Get
        Set(value As Decimal)
            vCalculoDetraccion = value
        End Set
    End Property

    Public Sub New()
        pDetalles = New List(Of DocumentoDetalleEN)
        pAdicionales = New List(Of DatoAdicionalEN)
        pRelacionados = New List(Of DocumentoRelacionadoEN)
        pDiscrepancias = New List(Of DiscrepanciaDocumentoEN)
        pIdMoneda = "PEN"
        pIdTipoOperacion = "01" ' venta normal
        pMontoDetraccion = 0
        pMontoPercepcion = 0
        pCalculoDetraccion = 0
    End Sub
End Class
