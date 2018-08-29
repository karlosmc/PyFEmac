
<Serializable> _
Public Class TaxScheme
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property TaxTypeCode() As String
        Get
            Return m_TaxTypeCode
        End Get
        Set(value As String)
            m_TaxTypeCode = value
        End Set
    End Property
    Private m_TaxTypeCode As String
End Class
