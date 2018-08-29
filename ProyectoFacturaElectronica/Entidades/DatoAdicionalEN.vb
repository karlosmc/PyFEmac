public class DatoAdicionalEN

   Private vID as Integer
   Private vIdCabeceraDocumento as String
   Private vIdTipoDatoAdicional as String
   Private vContenido as String

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
   Public Property pIdTipoDatoAdicional As String
       Get
           Return vIdTipoDatoAdicional
       End Get
       Set(ByVal value As String)
           vIdTipoDatoAdicional = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pContenido As String
       Get
           Return vContenido
       End Get
       Set(ByVal value As String)
           vContenido = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
