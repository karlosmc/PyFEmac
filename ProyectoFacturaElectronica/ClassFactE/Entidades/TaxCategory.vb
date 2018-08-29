
<Serializable> _
Public Class TaxCategory
    Public Property TaxExemptionReasonCode() As Integer
        Get
            Return m_TaxExemptionReasonCode
        End Get
        Set(value As Integer)
            m_TaxExemptionReasonCode = value
        End Set
    End Property
    Public m_TaxExemptionReasonCode As Integer
    Public Property TierRange() As String
        Get
            Return m_TierRange
        End Get
        Set(value As String)
            m_TierRange = value
        End Set
    End Property
    Public m_TierRange As String
    Public Property TaxScheme() As TaxScheme
        Get
            Return m_TaxScheme
        End Get
        Set(value As TaxScheme)
            m_TaxScheme = value
        End Set
    End Property
    Public m_TaxScheme As TaxScheme
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Public m_ID As String

    Public Sub New()
        TaxScheme = New TaxScheme()
        
    End Sub
End Class
