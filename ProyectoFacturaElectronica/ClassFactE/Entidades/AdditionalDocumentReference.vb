<Serializable>
Public Class AdditionalDocumentReference
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property DocumentTypeCode() As String
        Get
            Return m_DocumentTypeCode
        End Get
        Set(value As String)
            m_DocumentTypeCode = value
        End Set
    End Property
    Private m_DocumentTypeCode As String

End Class
