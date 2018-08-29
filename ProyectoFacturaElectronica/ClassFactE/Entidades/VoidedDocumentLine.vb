Imports System.Collections.Generic

<Serializable> _
Public Class VoidedDocumentsLine

    Public vLineId As Integer
    Public Property LineId As Integer
        Get
            Return vLineId
        End Get
        Set(value As Integer)
            vLineId = value
        End Set
    End Property

    Public VDocumentTypeCode As String
    Public Property DocumentTypeCode As String
        Get
            Return VDocumentTypeCode
        End Get
        Set(value As String)
            VDocumentTypeCode = value
        End Set
    End Property

    Public vDocumentSerialId As String
    Public Property DocumentSerialId As String
        Get
            Return vDocumentSerialId
        End Get
        Set(value As String)
            vDocumentSerialId = value
        End Set
    End Property

    Public vDocumentNumberId As Integer
    Public Property DocumentNumberId As Integer
        Get
            Return vDocumentNumberId
        End Get
        Set(value As Integer)
            vDocumentNumberId = value
        End Set
    End Property

    Public vVoidReasonDescription As String
    Public Property VoidReasonDescription As String
        Get
            Return vVoidReasonDescription
        End Get
        Set(value As String)
            vVoidReasonDescription = value
        End Set
    End Property

    Public vId As String

    Public Property Id As String
        Get
            Return vId
        End Get
        Set(value As String)
            vId = value
        End Set
    End Property

    Public vStartDocumentNumberId As Integer
    Public Property StartDocumentNumberId As Integer
        Get
            Return vStartDocumentNumberId
        End Get
        Set(value As Integer)
            vStartDocumentNumberId = value
        End Set
    End Property

    Public vEndDocumentNumberId As Integer
    Public Property EndDocumentNumberId As Integer
        Get
            Return vEndDocumentNumberId
        End Get
        Set(value As Integer)
            vEndDocumentNumberId = value
        End Set
    End Property


    Public vTotalAmount As PayableAmount
    Public Property TotalAmount As PayableAmount
        Get
            Return vTotalAmount
        End Get
        Set(value As PayableAmount)
            vTotalAmount = value
        End Set
    End Property

    Public vBillingPayments As List(Of BillingPayment)

    Public Property BillingPayments As List(Of BillingPayment)
        Get
            Return vBillingPayments
        End Get
        Set(value As List(Of BillingPayment))
            vBillingPayments = value
        End Set
    End Property
    Public vAllowanceCharge As AllowanceCharge

    Public Property AllowanceCharge As AllowanceCharge
        Get
            Return vAllowanceCharge
        End Get
        Set(value As AllowanceCharge)
            vAllowanceCharge = value
        End Set
    End Property

    Public vTaxTotals As List(Of TaxTotal)

    Public Property TaxTotals As List(Of TaxTotal)
        Get
            Return vTaxTotals
        End Get
        Set(value As List(Of TaxTotal))
            vTaxTotals = value
        End Set
    End Property

    Public vAccountingCustomerParty As AccountingSupplierParty
    Public Property AccountingCustomerParty As AccountingSupplierParty
        Get
            Return vAccountingCustomerParty
        End Get
        Set(value As AccountingSupplierParty)
            vAccountingCustomerParty = value
        End Set
    End Property

    Public vBillingReference As BillingReference
    Public Property BillingReference As BillingReference
        Get
            Return vBillingReference
        End Get
        Set(value As BillingReference)
            vBillingReference = value
        End Set
    End Property

    Public vConditionCode As Integer?

    Public Property ConditionCode As Integer?
        Get
            Return vConditionCode
        End Get
        Set(value As Integer?)
            vConditionCode = value
        End Set
    End Property

    Public Sub New()
        TotalAmount = New PayableAmount()
        BillingPayments = New List(Of BillingPayment)()
        AllowanceCharge = New AllowanceCharge()
        TaxTotals = New List(Of TaxTotal)()
        AccountingCustomerParty = New AccountingSupplierParty()
        BillingReference = New BillingReference()
    End Sub
End Class