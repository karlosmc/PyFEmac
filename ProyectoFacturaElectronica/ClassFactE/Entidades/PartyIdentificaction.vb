
<Serializable> _
Public Class PartyIdentification
    Public Property ID() As PartyIdentificationID
        Get
            Return m_ID
        End Get
        Set(value As PartyIdentificationID)
            m_ID = value
        End Set
    End Property
    Private m_ID As PartyIdentificationID

    Public Sub New()
        ID = New PartyIdentificationID()
    End Sub
End Class

