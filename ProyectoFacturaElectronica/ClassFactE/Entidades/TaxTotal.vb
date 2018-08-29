
<Serializable> _
Public Class TaxTotal
    Public Property TaxableAmount() As PayableAmount
        Get
            Return m_TaxableAmount
        End Get
        Set(value As PayableAmount)
            m_TaxableAmount = value
        End Set
    End Property
    Private m_TaxableAmount As PayableAmount
    Public Property TaxAmount() As PayableAmount
        Get
            Return m_TaxAmount
        End Get
        Set(value As PayableAmount)
            m_TaxAmount = value
        End Set
    End Property
    Private m_TaxAmount As PayableAmount
    Public Property TaxSubtotal() As TaxSubtotal
        Get
            Return m_TaxSubtotal
        End Get
        Set(value As TaxSubtotal)
            m_TaxSubtotal = value
        End Set
    End Property
    Private m_TaxSubtotal As TaxSubtotal

    Public Sub New()
        TaxableAmount = New PayableAmount()
        TaxAmount = New PayableAmount()
        TaxSubtotal = New TaxSubtotal()
    End Sub
End Class

