
<Serializable> _
Public Class InvoicedQuantity
    Public Property unitCode() As String
        Get
            Return m_unitCode
        End Get
        Set(value As String)
            m_unitCode = value
        End Set
    End Property
    Private m_unitCode As String
    Public Property Value() As Decimal
        Get
            Return m_Value
        End Get
        Set(value As Decimal)
            m_Value = value
        End Set
    End Property
    Private m_Value As Decimal
End Class
