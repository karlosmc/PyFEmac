
<Serializable> _
Public Class Price
    Public Property PriceAmount() As PayableAmount
        Get
            Return m_PriceAmount
        End Get
        Set(value As PayableAmount)
            m_PriceAmount = value
        End Set
    End Property
    Private m_PriceAmount As PayableAmount

    Public Sub New()
        PriceAmount = New PayableAmount()
    End Sub
End Class
