public class ErrorsunatEN

   Private vcodigo as String
   Private vdescripcion as String
   Private vexcepcion as String
   Private vrechazo as String
   Private vobservaciones as String
   Private vestado as Integer

   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pcodigo As String
       Get
           Return vcodigo
       End Get
       Set(ByVal value As String)
           vcodigo = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pdescripcion As String
       Get
           Return vdescripcion
       End Get
       Set(ByVal value As String)
           vdescripcion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pexcepcion As String
       Get
           Return vexcepcion
       End Get
       Set(ByVal value As String)
           vexcepcion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property prechazo As String
       Get
           Return vrechazo
       End Get
       Set(ByVal value As String)
           vrechazo = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pobservaciones As String
       Get
           Return vobservaciones
       End Get
       Set(ByVal value As String)
           vobservaciones = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pestado As Integer
       Get
           Return vestado
       End Get
       Set(ByVal value As Integer)
           vestado = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
