
<Serializable> _
Public Class AdditionalMonetaryTotal

    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set

    End Property
    Private m_ID As String
    Public Property PayableAmount() As PayableAmount
        Get
            Return m_PayableAmount
        End Get
        Set(value As PayableAmount)
            m_PayableAmount = value
        End Set
    End Property
    Private m_PayableAmount As PayableAmount
    Public Property ReferenceAmount() As PayableAmount
        Get
            Return m_ReferenceAmount
        End Get
        Set(value As PayableAmount)
            m_ReferenceAmount = value
        End Set
    End Property
    Private m_ReferenceAmount As PayableAmount
    Public Property TotalAmount() As PayableAmount
        Get
            Return m_TotalAmount
        End Get
        Set(value As PayableAmount)
            m_TotalAmount = value
        End Set
    End Property
    Private m_TotalAmount As PayableAmount
    ''' <summary>
    ''' Para el porcentaje de Detraccion.
    ''' </summary>
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
        PayableAmount = New PayableAmount()
        ReferenceAmount = New PayableAmount()
        TotalAmount = New PayableAmount()
    End Sub
End Class
