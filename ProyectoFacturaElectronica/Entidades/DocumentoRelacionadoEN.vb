public class DocumentoRelacionadoEN

   Private vID as Integer
   Private vIdCabeceraDocumento as String
   Private vNroDocumento as String
   Private vTipoDocumento as String

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
   Public Property pNroDocumento As String
       Get
           Return vNroDocumento
       End Get
       Set(ByVal value As String)
           vNroDocumento = value
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
   Public Sub New()
   End Sub
End Class
