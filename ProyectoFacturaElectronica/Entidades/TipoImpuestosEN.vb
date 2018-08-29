public class TipoImpuestosEN

   Private vID as Integer
   Private vCodigo as String
   Private vDescripcion as String
   Private vDescripcionCompleta as String

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
   Public Property pCodigo As String
       Get
           Return vCodigo
       End Get
       Set(ByVal value As String)
           vCodigo = value
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
   Public Property pDescripcionCompleta As String
       Get
           Return vDescripcionCompleta
       End Get
       Set(ByVal value As String)
           vDescripcionCompleta = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
