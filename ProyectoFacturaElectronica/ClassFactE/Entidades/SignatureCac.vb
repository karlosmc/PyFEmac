
<Serializable> _
Public Class SignatureCac
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property SignatoryParty() As SignatoryParty
        Get
            Return m_SignatoryParty
        End Get
        Set(value As SignatoryParty)
            m_SignatoryParty = value
        End Set
    End Property
    Private m_SignatoryParty As SignatoryParty
    Public Property DigitalSignatureAttachment() As DigitalSignatureAttachment
        Get
            Return m_DigitalSignatureAttachment
        End Get
        Set(value As DigitalSignatureAttachment)
            m_DigitalSignatureAttachment = value
        End Set
    End Property
    Private m_DigitalSignatureAttachment As DigitalSignatureAttachment

    Public Sub New()
        SignatoryParty = New SignatoryParty()
        DigitalSignatureAttachment = New DigitalSignatureAttachment()
    End Sub
End Class
