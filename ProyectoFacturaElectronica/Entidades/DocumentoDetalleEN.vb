public class DocumentoDetalleEN

   Private vID as Integer
   Private vIdCabeceraDocumento as String
   Private vCantidad as Decimal
   Private vIdUnidadMedida as String
   Private vCodigoItem as String
   Private vDescripcion as String
   Private vPrecioUnitario as Decimal
   Private vPrecioReferencial as Decimal
   Private vIdTipoPrecio as String
   Private vIdTipoImpuesto as String
   Private vImpuesto as Decimal
   Private vImpuestoSelectivo as Decimal
   Private vOtroImpuesto as Decimal
   Private vDescuento as Decimal
   Private vTotalVenta as Decimal

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
   Public Property pIdCabeceraDocumento As String
       Get
           Return vIdCabeceraDocumento
       End Get
       Set(ByVal value As String)
           vIdCabeceraDocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCantidad As Decimal
       Get
           Return vCantidad
       End Get
       Set(ByVal value As Decimal)
           vCantidad = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdUnidadMedida As String
       Get
           Return vIdUnidadMedida
       End Get
       Set(ByVal value As String)
           vIdUnidadMedida = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCodigoItem As String
       Get
           Return vCodigoItem
       End Get
       Set(ByVal value As String)
           vCodigoItem = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pDescripcion As String
       Get
           Return vDescripcion
       End Get
       Set(ByVal value As String)
           vDescripcion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pPrecioUnitario As Decimal
       Get
           Return vPrecioUnitario
       End Get
       Set(ByVal value As Decimal)
           vPrecioUnitario = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pPrecioReferencial As Decimal
       Get
           Return vPrecioReferencial
       End Get
       Set(ByVal value As Decimal)
           vPrecioReferencial = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipoPrecio As String
       Get
           Return vIdTipoPrecio
       End Get
       Set(ByVal value As String)
           vIdTipoPrecio = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipoImpuesto As String
       Get
           Return vIdTipoImpuesto
       End Get
       Set(ByVal value As String)
           vIdTipoImpuesto = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pImpuesto As Decimal
       Get
           Return vImpuesto
       End Get
       Set(ByVal value As Decimal)
           vImpuesto = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pImpuestoSelectivo As Decimal
       Get
           Return vImpuestoSelectivo
       End Get
       Set(ByVal value As Decimal)
           vImpuestoSelectivo = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pOtroImpuesto As Decimal
       Get
           Return vOtroImpuesto
       End Get
       Set(ByVal value As Decimal)
           vOtroImpuesto = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pDescuento As Decimal
       Get
           Return vDescuento
       End Get
       Set(ByVal value As Decimal)
           vDescuento = value
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
   Public Sub New()
   End Sub
End Class
