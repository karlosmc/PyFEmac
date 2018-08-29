Imports System.Collections.Generic
Imports System.Text.RegularExpressions

<Serializable> _
Public Class BillingReference

    Implements IEquatable(Of BillingReference)
    Public Property InvoiceDocumentReference() As InvoiceDocumentReference
        Get
            Return m_InvoiceDocumentReference
        End Get
        Set(value As InvoiceDocumentReference)
            m_InvoiceDocumentReference = value
        End Set
    End Property
    Private m_InvoiceDocumentReference As InvoiceDocumentReference

    Public Sub New()
        InvoiceDocumentReference = New InvoiceDocumentReference()
    End Sub

    Public Overloads Function Equals(other As BillingReference) As Boolean _
    Implements IEquatable(Of BillingReference).Equals

        Return InvoiceDocumentReference.Equals(other.InvoiceDocumentReference)
    End Function


    Public Overrides Function GetHashCode() As Integer
        Return InvoiceDocumentReference.GetHashCode()
    End Function
End Class
