
<Serializable> _
Public Class Country
    Public Property IdentificationCode() As String
        Get
            Return m_IdentificationCode
        End Get
        Set(value As String)
            m_IdentificationCode = value
        End Set
    End Property
    Private m_IdentificationCode As String
End Class
