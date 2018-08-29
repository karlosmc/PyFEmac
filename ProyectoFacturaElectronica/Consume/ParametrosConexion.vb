Public Class ParametrosConexion

    Private vRuc As String
    Private vUserName As String
    Private vPassword As String
    Private vEndPointUrl As String


    Public Property Ruc As String
        Get
            Return vRuc
        End Get
        Set(value As String)
            vRuc = value
        End Set
    End Property
    Public Property UserName As String
        Get
            Return vUserName
        End Get
        Set(value As String)
            vUserName = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return vPassword
        End Get
        Set(value As String)
            vPassword = value
        End Set
    End Property
    Public Property EndPointUrl As String
        Get
            Return vEndPointUrl
        End Get
        Set(value As String)
            vEndPointUrl = value
        End Set
    End Property


End Class
