
<Serializable> _
Public Class SignatoryParty
    Public Property PartyIdentification() As PartyIdentification
        Get
            Return m_PartyIdentification
        End Get
        Set(value As PartyIdentification)
            m_PartyIdentification = value
        End Set
    End Property
    Private m_PartyIdentification As PartyIdentification
    Public Property PartyName() As PartyName
        Get
            Return m_PartyName
        End Get
        Set(value As PartyName)
            m_PartyName = value
        End Set
    End Property
    Private m_PartyName As PartyName


    Public Sub New()
        PartyIdentification = New PartyIdentification()
        PartyName = New PartyName()
    End Sub
End Class

