public class DiscrepanciaDocumentoEN

   Private vID as Integer
   Private vIdCabeceraDocumento as String
   Private vNroReferencia as String
   Private vIdTipoDiscrepancia as Integer
   Private vTipoDiscrepancia as String

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
   Public Property pNroReferencia As String
       Get
           Return vNroReferencia
       End Get
       Set(ByVal value As String)
           vNroReferencia = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdTipoDiscrepancia As Integer
       Get
           Return vIdTipoDiscrepancia
       End Get
       Set(ByVal value As Integer)
           vIdTipoDiscrepancia = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pTipoDiscrepancia As String
       Get
           Return vTipoDiscrepancia
       End Get
       Set(ByVal value As String)
           vTipoDiscrepancia = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
