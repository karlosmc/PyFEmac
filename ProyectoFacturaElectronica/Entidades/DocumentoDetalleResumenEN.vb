public class DocumentoDetalleResumenEN

   Private vID as Integer
   Private vIdDocumentoResumen as String
   Private vline as Integer
   Private vIdTipoDocumento as String
   Private vTipoDocumento as String
   Private vNroDocumento as String
   Private vCodigoEstado as Integer
   Private vIdMoneda as String
   Private vTotalVenta as Decimal
   Private vGravadas as Decimal
   Private vExoneradas as Decimal
   Private vInafectas as Decimal
   Private vTotalIgv as Decimal
   Private vTotalIsc as Decimal
   Private vTotalDescuentos as Decimal
   Private vTotalOtrosImpuestos as Decimal

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
   Public Property pIdDocumentoResumen As String
       Get
           Return vIdDocumentoResumen
       End Get
       Set(ByVal value As String)
           vIdDocumentoResumen = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pline As Integer
       Get
           Return vline
       End Get
       Set(ByVal value As Integer)
           vline = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipoDocumento As String
       Get
           Return vIdTipoDocumento
       End Get
       Set(ByVal value As String)
           vIdTipoDocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTipoDocumento As String
       Get
           Return vTipoDocumento
       End Get
       Set(ByVal value As String)
           vTipoDocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pNroDocumento As String
       Get
           Return vNroDocumento
       End Get
       Set(ByVal value As String)
           vNroDocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCodigoEstado As Integer
       Get
           Return vCodigoEstado
       End Get
       Set(ByVal value As Integer)
           vCodigoEstado = value
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
   Public Property pTotalVenta As Decimal
       Get
           Return vTotalVenta
       End Get
       Set(ByVal value As Decimal)
           vTotalVenta = value
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
   Public Property pExoneradas As Decimal
       Get
           Return vExoneradas
       End Get
       Set(ByVal value As Decimal)
           vExoneradas = value
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
   Public Property pTotalDescuentos As Decimal
       Get
           Return vTotalDescuentos
       End Get
       Set(ByVal value As Decimal)
           vTotalDescuentos = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTotalOtrosImpuestos As Decimal
       Get
           Return vTotalOtrosImpuestos
       End Get
       Set(ByVal value As Decimal)
           vTotalOtrosImpuestos = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
