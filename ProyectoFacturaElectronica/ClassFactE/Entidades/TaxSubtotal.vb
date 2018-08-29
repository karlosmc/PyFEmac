
<Serializable> _
Public Class TaxSubtotal
    Public Property TaxAmount() As PayableAmount
        Get
            Return m_TaxAmount
        End Get
        Set(value As PayableAmount)
            m_TaxAmount = value
        End Set
    End Property
    Private m_TaxAmount As PayableAmount
    Public Property TaxCategory() As TaxCategory
        Get
            Return m_TaxCategory
        End Get
        Set(value As TaxCategory)
            m_TaxCategory = value
        End Set
    End Property
    Private m_TaxCategory As TaxCategory
    Public Property Percent() As Decimal
        Get
            Return m_Percent
        End Get
        Set(value As Decimal)
            m_Percent = value
        End Set
    End Property
    Private m_Percent As Decimal

    Public Sub New()
        TaxAmount = New PayableAmount()
        TaxCategory = New TaxCategory()
    End Sub
End Class
