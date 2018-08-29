
<Serializable> _
Public Class PartyLegalEntity
    Public Property RegistrationName() As String
        Get
            Return m_RegistrationName
        End Get
        Set(value As String)
            m_RegistrationName = value
        End Set
    End Property
    Private m_RegistrationName As String
End Class
