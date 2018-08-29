public class DocumentoDetalleBajaEN

   Private vID as Integer
   Private vIdDocumentoBaja as String
   Private vlinea as Integer
   Private vIdTipoDocumento as String
   Private vDocumentoSerie as String
   Private vDocumentoNumero as String
   Private vMotivoBaja as String

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
   Public Property pIdDocumentoBaja As String
       Get
           Return vIdDocumentoBaja
       End Get
       Set(ByVal value As String)
           vIdDocumentoBaja = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property plinea As Integer
       Get
           Return vlinea
       End Get
       Set(ByVal value As Integer)
           vlinea = value
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
   Public Property pDocumentoSerie As String
       Get
           Return vDocumentoSerie
       End Get
       Set(ByVal value As String)
           vDocumentoSerie = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pDocumentoNumero As String
       Get
           Return vDocumentoNumero
       End Get
       Set(ByVal value As String)
           vDocumentoNumero = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pMotivoBaja As String
       Get
           Return vMotivoBaja
       End Get
       Set(ByVal value As String)
           vMotivoBaja = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
