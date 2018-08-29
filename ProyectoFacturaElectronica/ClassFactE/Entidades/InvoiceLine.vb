
Imports System.Collections.Generic


<Serializable> _
Public Class InvoiceLine
    Public Property ID() As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
            m_ID = value
        End Set
    End Property
    Private m_ID As Integer
    Public Property CreditedQuantity() As InvoicedQuantity
        Get
            Return m_CreditedQuantity
        End Get
        Set(value As InvoicedQuantity)
            m_CreditedQuantity = value
        End Set
    End Property
    Private m_CreditedQuantity As InvoicedQuantity
    Public Property InvoicedQuantity() As InvoicedQuantity
        Get
            Return m_InvoicedQuantity
        End Get
        Set(value As InvoicedQuantity)
            m_InvoicedQuantity = value
        End Set
    End Property
    Private m_InvoicedQuantity As InvoicedQuantity
    Public Property DebitedQuantity() As InvoicedQuantity
        Get
            Return m_DebitedQuantity
        End Get
        Set(value As InvoicedQuantity)
            m_DebitedQuantity = value
        End Set
    End Property
    Private m_DebitedQuantity As InvoicedQuantity
    Public Property LineExtensionAmount() As PayableAmount
        Get
            Return m_LineExtensionAmount
        End Get
        Set(value As PayableAmount)
            m_LineExtensionAmount = value
        End Set
    End Property
    Private m_LineExtensionAmount As PayableAmount
    Public Property PricingReference() As PricingReference
        Get
            Return m_PricingReference
        End Get
        Set(value As PricingReference)
            m_PricingReference = value
        End Set
    End Property
    Private m_PricingReference As PricingReference
    Public Property AllowanceCharge() As AllowanceCharge
        Get
            Return m_AllowanceCharge
        End Get
        Set(value As AllowanceCharge)
            m_AllowanceCharge = value
        End Set
    End Property
    Private m_AllowanceCharge As AllowanceCharge
    Public Property TaxTotals() As List(Of TaxTotal)
        Get
            Return m_TaxTotals
        End Get
        Set(value As List(Of TaxTotal))
            m_TaxTotals = value
        End Set
    End Property
    Private m_TaxTotals As List(Of TaxTotal)
    Public Property Item() As Item
        Get
            Return m_Item
        End Get
        Set(value As Item)
            m_Item = value
        End Set
    End Property
    Private m_Item As Item
    Public Property Price() As Price
        Get
            Return m_Price
        End Get
        Set(value As Price)
            m_Price = value
        End Set
    End Property
    Private m_Price As Price

    Public Sub New()
        CreditedQuantity = New InvoicedQuantity()
        InvoicedQuantity = New InvoicedQuantity()
        DebitedQuantity = New InvoicedQuantity()
        LineExtensionAmount = New PayableAmount()
        PricingReference = New PricingReference()
        AllowanceCharge = New AllowanceCharge()
        TaxTotals = New List(Of TaxTotal)()
        Item = New Item()
        Price = New Price()
    End Sub
End Class
