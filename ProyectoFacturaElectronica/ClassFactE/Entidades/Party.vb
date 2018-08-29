

<Serializable> _
Public Class Party
    Public Property PartyName() As PartyName
        Get
            Return m_PartyName
        End Get
        Set(value As PartyName)
            m_PartyName = value
        End Set
    End Property
    Private m_PartyName As PartyName
    Public Property PostalAddress() As PostalAddress
        Get
            Return m_PostalAddress
        End Get
        Set(value As PostalAddress)
            m_PostalAddress = value
        End Set
    End Property
    Private m_PostalAddress As PostalAddress
    Public Property PartyLegalEntity() As PartyLegalEntity
        Get
            Return m_PartyLegalEntity
        End Get
        Set(value As PartyLegalEntity)
            m_PartyLegalEntity = value
        End Set
    End Property
    Private m_PartyLegalEntity As PartyLegalEntity


    Public Sub New()
        PartyName = New PartyName()
        PostalAddress = New PostalAddress()
        PartyLegalEntity = New PartyLegalEntity()
    End Sub
End Class
