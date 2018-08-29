public class DocumentoBajaEN

   Private vID as Integer
   Private vFechaEmision as Date
   Private vFechaReferencia as Date
   Private vIdBaja as String
   Private vIdContribuyente as String

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
   Public Property pFechaEmision As Date
       Get
           Return vFechaEmision
       End Get
       Set(ByVal value As Date)
           vFechaEmision = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pFechaReferencia As Date
       Get
           Return vFechaReferencia
       End Get
       Set(ByVal value As Date)
           vFechaReferencia = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdBaja As String
       Get
           Return vIdBaja
       End Get
       Set(ByVal value As String)
           vIdBaja = value
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
   Public Sub New()
   End Sub
End Class
