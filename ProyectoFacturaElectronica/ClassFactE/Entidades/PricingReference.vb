Imports System.Collections.Generic


<Serializable> _
Public Class PricingReference
    Public Property AlternativeConditionPrices() As List(Of AlternativeConditionPrice)
        Get
            Return m_AlternativeConditionPrices
        End Get
        Set(value As List(Of AlternativeConditionPrice))
            m_AlternativeConditionPrices = value
        End Set
    End Property
    Private m_AlternativeConditionPrices As List(Of AlternativeConditionPrice)

    Public Sub New()
        AlternativeConditionPrices = New List(Of AlternativeConditionPrice)()
    End Sub
End Class
