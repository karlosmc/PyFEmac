Public Class Contribuyente


    Private vNroDocumento As String
    Public Property NroDocumento As String
        Get
            Return vNroDocumento
        End Get
        Set(value As String)
            vNroDocumento = value
        End Set
    End Property

    Private vTipoDocumento As String
    Public Property TipoDocumento As String
        Get
            Return vTipoDocumento
        End Get
        Set(value As String)
            vTipoDocumento = value
        End Set
    End Property

    Private vNombreLegal As String
    Public Property NombreLegal As String
        Get
            Return vNombreLegal
        End Get
        Set(value As String)
            vNombreLegal = value
        End Set
    End Property

    Private vNombreComercial As String
    Public Property NombreComercial As String
        Get
            Return vNombreComercial
        End Get
        Set(value As String)
            vNombreComercial = value
        End Set
    End Property


    Private vUbigeo As String
    Public Property Ubigeo As String
        Get
            Return vUbigeo
        End Get
        Set(value As String)
            vUbigeo = value
        End Set
    End Property


    Private vDireccion As String
    Public Property Direccion As String
        Get
            Return vDireccion
        End Get
        Set(value As String)
            vDireccion = value
        End Set
    End Property

    Private vUrbanizacion As String
    Public Property Urbanizacion As String
        Get
            Return vUrbanizacion
        End Get
        Set(value As String)
            vUrbanizacion = value
        End Set
    End Property


    Private vDepartamento As String
    Public Property Departamento As String
        Get
            Return vDepartamento
        End Get
        Set(value As String)
            vDepartamento = value
        End Set
    End Property


    Private vProvincia As String
    Public Property Provincia As String
        Get
            Return vProvincia
        End Get
        Set(value As String)
            vProvincia = value
        End Set
    End Property

    Private vDistrito As String
    Public Property Distrito As String
        Get
            Return vDistrito
        End Get
        Set(value As String)
            vDistrito = value
        End Set
    End Property
    Sub New()
        Me.Departamento = ""
        Me.Direccion = ""
        Me.Distrito = ""
        Me.NombreComercial = ""
        Me.NombreLegal = "CLIENTES VARIOS"
        Me.NroDocumento = ""
        Me.Provincia = ""
        Me.TipoDocumento = 6
        Me.Ubigeo = ""
        Me.Urbanizacion = "-"
    End Sub

End Class
