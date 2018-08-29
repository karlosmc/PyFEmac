
<Serializable> _
Public Class PayableAmount
    Public Property currencyID() As String
        Get
            Return m_currencyID
        End Get
        Set(value As String)
            m_currencyID = value
        End Set
    End Property
    Private m_currencyID As String
    Public Property value() As Decimal
        Get
            Return m_value
        End Get
        Set(value As Decimal)
            m_value = value
        End Set
    End Property
    Private m_value As Decimal
End Class
