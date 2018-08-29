
<Serializable> _
Public Class LegalMonetaryTotal
    Public Property PayableAmount() As PayableAmount
        Get
            Return m_PayableAmount
        End Get
        Set(value As PayableAmount)
            m_PayableAmount = value
        End Set
    End Property
    Private m_PayableAmount As PayableAmount
    Public Property AllowanceTotalAmount() As PayableAmount
        Get
            Return m_AllowanceTotalAmount
        End Get
        Set(value As PayableAmount)
            m_AllowanceTotalAmount = value
        End Set
    End Property
    Private m_AllowanceTotalAmount As PayableAmount
    Public Property ChargeTotalAmount() As PayableAmount
        Get
            Return m_ChargeTotalAmount
        End Get
        Set(value As PayableAmount)
            m_ChargeTotalAmount = value
        End Set
    End Property
    Private m_ChargeTotalAmount As PayableAmount

    Public Property PrepaidAmount As PayableAmount
        Get
            Return m_PrepaidAmount
        End Get
        Set(value As PayableAmount)
            m_PrepaidAmount = value
        End Set
    End Property
    Private m_PrepaidAmount As PayableAmount


    Public Sub New()
        PayableAmount = New PayableAmount()
        AllowanceTotalAmount = New PayableAmount()
        ChargeTotalAmount = New PayableAmount()
    End Sub
End Class

