Imports System.Collections.Generic
Imports System.Text.RegularExpressions

<Serializable> _
Public Class InvoiceDocumentReference : Implements IEquatable(Of InvoiceDocumentReference)


    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Private m_ID As String
    Public Property DocumentTypeCode() As String
        Get
            Return m_DocumentTypeCode
        End Get
        Set(value As String)
            m_DocumentTypeCode = value
        End Set
    End Property
    Private m_DocumentTypeCode As String

    Public Sub New()
        ID = String.Empty
    End Sub
    Public Overloads Function Equals(other As InvoiceDocumentReference) As Boolean _
        Implements IEquatable(Of InvoiceDocumentReference).Equals
        If String.IsNullOrEmpty(ID) Then
            Return False
        End If
        Return ID.Equals(other.ID)
    End Function

    Public Overrides Function GetHashCode() As Integer
        If String.IsNullOrEmpty(ID) Then
            Return MyBase.GetHashCode()
        End If

        Return ID.GetHashCode()
    End Function
End Class
