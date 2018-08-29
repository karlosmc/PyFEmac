public class EmpresaEN

   Private vID as Integer
   Private vNroDocumento as String
   Private vIdTipoDocumento as String
   Private vNombreLegal as String
   Private vNombreComercial as String
   Private vDireccion as String
   Private vUrbanizacion as String
   Private vCorreoElectronico as String
   Private vIdUbigeo as Integer
   Private vUbigeo as String

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
   Public Property pNroDocumento As String
       Get
           Return vNroDocumento
       End Get
       Set(ByVal value As String)
           vNroDocumento = value
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
   Public Property pNombreLegal As String
       Get
           Return vNombreLegal
       End Get
       Set(ByVal value As String)
           vNombreLegal = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pNombreComercial As String
       Get
           Return vNombreComercial
       End Get
       Set(ByVal value As String)
           vNombreComercial = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pDireccion As String
       Get
           Return vDireccion
       End Get
       Set(ByVal value As String)
           vDireccion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pUrbanizacion As String
       Get
           Return vUrbanizacion
       End Get
       Set(ByVal value As String)
           vUrbanizacion = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pCorreoElectronico As String
       Get
           Return vCorreoElectronico
       End Get
       Set(ByVal value As String)
           vCorreoElectronico = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pIdUbigeo As Integer
       Get
           Return vIdUbigeo
       End Get
       Set(ByVal value As Integer)
           vIdUbigeo = value
       End Set
   End Property
   <System.Diagnostics.DebuggerNonUserCode()> _
   Public Property pUbigeo As String
       Get
           Return vUbigeo
       End Get
       Set(ByVal value As String)
           vUbigeo = value
       End Set
   End Property
    Public Sub New()
        pIdTipoDocumento = "1"
        pUrbanizacion = "-"
        pIdUbigeo = Nothing
        pUbigeo = ""
        pCorreoElectronico = ""
        pNombreComercial = ""
    End Sub
End Class
