
<Serializable> _
Public Class UBLExtension
    Public Property ExtensionContent() As ExtensionContent
        Get
            Return m_ExtensionContent
        End Get
        Set(value As ExtensionContent)
            m_ExtensionContent = value
        End Set
    End Property

    Public m_ID As String

    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Private m_ExtensionContent As ExtensionContent

    Public Sub New()
        ExtensionContent = New ExtensionContent()
    End Sub
End Class

