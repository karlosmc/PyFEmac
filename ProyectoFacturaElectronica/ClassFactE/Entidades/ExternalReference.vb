
<Serializable> _
Public Class ExternalReference
    Public Property URI() As String
        Get
            Return m_URI
        End Get
        Set(value As String)
            m_URI = value
        End Set
    End Property
    Private m_URI As String
End Class

