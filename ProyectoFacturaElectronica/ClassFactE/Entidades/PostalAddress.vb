
<Serializable> _
Public Class PostalAddress
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property StreetName() As String
        Get
            Return m_StreetName
        End Get
        Set(value As String)
            m_StreetName = value
        End Set
    End Property
    Private m_StreetName As String
    Public Property CitySubdivisionName() As String
        Get
            Return m_CitySubdivisionName
        End Get
        Set(value As String)
            m_CitySubdivisionName = value
        End Set
    End Property
    Private m_CitySubdivisionName As String
    Public Property CityName() As String
        Get
            Return m_CityName
        End Get
        Set(value As String)
            m_CityName = value
        End Set
    End Property
    Private m_CityName As String
    Public Property CountrySubentity() As String
        Get
            Return m_CountrySubentity
        End Get
        Set(value As String)
            m_CountrySubentity = value
        End Set
    End Property
    Private m_CountrySubentity As String
    Public Property District() As String
        Get
            Return m_District
        End Get
        Set(value As String)
            m_District = value
        End Set
    End Property
    Private m_District As String
    Public Property Country() As Country
        Get
            Return m_Country
        End Get
        Set(value As Country)
            m_Country = value
        End Set
    End Property
    Private m_Country As Country

    Public Sub New()
        Country = New Country()
    End Sub
End Class

