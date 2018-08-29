
<Serializable> _
Public Class Item
    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property
    Private m_Description As String
    Public Property SellersItemIdentification() As SellersItemIdentification
        Get
            Return m_SellersItemIdentification
        End Get
        Set(value As SellersItemIdentification)
            m_SellersItemIdentification = value
        End Set
    End Property
    Private m_SellersItemIdentification As SellersItemIdentification

    Public Sub New()
        SellersItemIdentification = New SellersItemIdentification()
    End Sub
End Class

<Serializable> _
Public Class SellersItemIdentification
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
End Class
