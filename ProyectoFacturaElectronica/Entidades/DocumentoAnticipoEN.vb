public class DocumentoAnticipoEN

   Private vID as Integer
   Private vNroDocAnticipo as String
   Private vIdTipodocumento as String
   Private vIdMoneda as String
   Private vMontoAnticipo as Decimal

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
   Public Property pNroDocAnticipo As String
       Get
           Return vNroDocAnticipo
       End Get
       Set(ByVal value As String)
           vNroDocAnticipo = value
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
   Public Property pIdMoneda As String
       Get
           Return vIdMoneda
       End Get
       Set(ByVal value As String)
           vIdMoneda = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pMontoAnticipo As Decimal
       Get
           Return vMontoAnticipo
       End Get
       Set(ByVal value As Decimal)
           vMontoAnticipo = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
