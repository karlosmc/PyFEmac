public class ParametroEN

   Private vID as Integer
   Private vIdContribuyente as String
   Private vTasaIgv as Decimal
   Private vTasaIsc as Decimal
   Private vTasaDetraccion as Decimal
   Private vCertificadoDigital as String
   Private vClaveCertificado as String
   Private vUsuarioSol as String
   Private vClaveSol as String

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
   Public Property pIdContribuyente As String
       Get
           Return vIdContribuyente
       End Get
       Set(ByVal value As String)
           vIdContribuyente = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTasaIgv As Decimal
       Get
           Return vTasaIgv
       End Get
       Set(ByVal value As Decimal)
           vTasaIgv = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTasaIsc As Decimal
       Get
           Return vTasaIsc
       End Get
       Set(ByVal value As Decimal)
           vTasaIsc = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTasaDetraccion As Decimal
       Get
           Return vTasaDetraccion
       End Get
       Set(ByVal value As Decimal)
           vTasaDetraccion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCertificadoDigital As String
       Get
           Return vCertificadoDigital
       End Get
       Set(ByVal value As String)
           vCertificadoDigital = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pClaveCertificado As String
       Get
           Return vClaveCertificado
       End Get
       Set(ByVal value As String)
           vClaveCertificado = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pUsuarioSol As String
       Get
           Return vUsuarioSol
       End Get
       Set(ByVal value As String)
           vUsuarioSol = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pClaveSol As String
       Get
           Return vClaveSol
       End Get
       Set(ByVal value As String)
           vClaveSol = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
