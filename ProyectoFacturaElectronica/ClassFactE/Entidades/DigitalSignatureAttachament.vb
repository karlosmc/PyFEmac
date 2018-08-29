
<Serializable> _
Public Class DigitalSignatureAttachment
    Public Property ExternalReference() As ExternalReference
        Get
            Return m_ExternalReference
        End Get
        Set(value As ExternalReference)
            m_ExternalReference = value
        End Set
    End Property
    Private m_ExternalReference As ExternalReference

    Public Sub New()
        ExternalReference = New ExternalReference()
    End Sub
End Class

