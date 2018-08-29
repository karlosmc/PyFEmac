
<Serializable> _
Public Class PartyIdentificationID
    Public Property SchemeId() As String
        Get
            Return m_schemeID
        End Get
        Set(value As String)
            m_schemeID = value
        End Set
    End Property
    Private m_SchemeId As String
    Public Property Value() As String
        Get
            Return m_Value
        End Get
        Set(value As String)
            m_Value = value
        End Set
    End Property
    Private m_Value As String
End Class

