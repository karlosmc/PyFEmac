
<Serializable> _
Public Class AlternativeConditionPrice
    Public Property PriceAmount() As PayableAmount
        Get
            Return m_PriceAmount
        End Get
        Set(value As PayableAmount)
            m_PriceAmount = value
        End Set
    End Property
    Private m_PriceAmount As PayableAmount
    Public Property PriceTypeCode() As String
        Get
            Return m_PriceTypeCode
        End Get
        Set(value As String)
            m_PriceTypeCode = value
        End Set
    End Property
    Private m_PriceTypeCode As String

    Public Sub New()
        PriceAmount = New PayableAmount()
    End Sub
End Class
