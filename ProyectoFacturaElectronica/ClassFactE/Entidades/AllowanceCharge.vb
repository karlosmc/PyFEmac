
<Serializable> _
Public Class AllowanceCharge
    Public Property ChargeIndicator() As Boolean
        Get
            Return m_ChargeIndicator
        End Get
        Set(value As Boolean)
            m_ChargeIndicator = value
        End Set
    End Property
    Private m_ChargeIndicator As Boolean
    Public Property Amount() As PayableAmount
        Get
            Return m_Amount
        End Get
        Set(value As PayableAmount)
            m_Amount = value
        End Set
    End Property
    Private m_Amount As PayableAmount

    Public Sub New()
        Amount = New PayableAmount()
    End Sub
End Class

