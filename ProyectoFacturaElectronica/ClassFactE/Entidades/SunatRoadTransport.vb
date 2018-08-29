<Serializable> _
Public Class SunatRoadTransport
    Public Property LicensePlateId() As String
        Get
            Return m_LicensePlateId
        End Get
        Set(value As String)
            m_LicensePlateId = Value
        End Set
    End Property
    Private m_LicensePlateId As String
    Public Property TransportAuthorizationCode() As String
        Get
            Return m_TransportAuthorizationCode
        End Get
        Set(value As String)
            m_TransportAuthorizationCode = Value
        End Set
    End Property
    Private m_TransportAuthorizationCode As String
    Public Property BrandName() As String
        Get
            Return m_BrandName
        End Get
        Set(value As String)
            m_BrandName = Value
        End Set
    End Property
    Private m_BrandName As String
End Class