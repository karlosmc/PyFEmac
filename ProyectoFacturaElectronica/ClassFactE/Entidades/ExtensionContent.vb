
<Serializable> _
Public Class ExtensionContent
    Public Property AdditionalInformation() As AdditionalInformation
        Get
            Return m_AdditionalInformation
        End Get
        Set(value As AdditionalInformation)
            m_AdditionalInformation = value
        End Set
    End Property
    Private m_AdditionalInformation As AdditionalInformation

    Public Sub New()
        AdditionalInformation = New AdditionalInformation()
    End Sub
End Class
