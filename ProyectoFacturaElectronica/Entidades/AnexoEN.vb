public class AnexoEN

   Private vID as Integer
   Private vIdDocumento as String
   Private vFechaGeneracion as Date
   Private vFechaRespuesta as Date
   Private vXmlFirmado as String
   Private vRepresentacionImpresa as String
   Private vEstadoEnvio as Int16
   Private vCodigoEstado as String
   Private vDescripcionEstado as String
   Private vCdrSunat as String
   Private vMensaje as String

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
   Public Property pIdDocumento As String
       Get
           Return vIdDocumento
       End Get
       Set(ByVal value As String)
           vIdDocumento = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pFechaGeneracion As Date
       Get
           Return vFechaGeneracion
       End Get
       Set(ByVal value As Date)
           vFechaGeneracion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pFechaRespuesta As Date
       Get
           Return vFechaRespuesta
       End Get
       Set(ByVal value As Date)
           vFechaRespuesta = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pXmlFirmado As String
       Get
           Return vXmlFirmado
       End Get
       Set(ByVal value As String)
           vXmlFirmado = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pRepresentacionImpresa As String
       Get
           Return vRepresentacionImpresa
       End Get
       Set(ByVal value As String)
           vRepresentacionImpresa = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pEstadoEnvio As Int16
       Get
           Return vEstadoEnvio
       End Get
       Set(ByVal value As Int16)
           vEstadoEnvio = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCodigoEstado As String
       Get
           Return vCodigoEstado
       End Get
       Set(ByVal value As String)
           vCodigoEstado = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pDescripcionEstado As String
       Get
           Return vDescripcionEstado
       End Get
       Set(ByVal value As String)
           vDescripcionEstado = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCdrSunat As String
       Get
           Return vCdrSunat
       End Get
       Set(ByVal value As String)
           vCdrSunat = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pMensaje As String
       Get
           Return vMensaje
       End Get
       Set(ByVal value As String)
           vMensaje = value
       End Set
   End Property
   Public Sub New()
   End Sub
End Class
