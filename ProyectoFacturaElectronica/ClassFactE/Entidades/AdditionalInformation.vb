Imports System.Collections.Generic


<Serializable> _
Public Class AdditionalInformation
    Public Property AdditionalMonetaryTotals() As List(Of AdditionalMonetaryTotal)
        Get
            Return m_AdditionalMonetaryTotals
        End Get
        Set(value As List(Of AdditionalMonetaryTotal))
            m_AdditionalMonetaryTotals = value
        End Set
    End Property
    Private m_AdditionalMonetaryTotals As List(Of AdditionalMonetaryTotal)
    Public Property AdditionalProperties() As List(Of AdditionalProperty)
        Get
            Return m_AdditionalProperties
        End Get
        Set(value As List(Of AdditionalProperty))
            m_AdditionalProperties = value
        End Set
    End Property
    Private m_AdditionalProperties As List(Of AdditionalProperty)

    Private m_SunatCosts As SunatCosts
    Public Property SunatCosts As SunatCosts
        Get
            Return m_SunatCosts
        End Get
        Set(value As SunatCosts)
            m_SunatCosts = value
        End Set
    End Property

    Public Property SunatTransaction() As SunatTransaction
        Get
            Return m_SunatTransaction
        End Get
        Set(value As SunatTransaction)
            m_SunatTransaction = value
        End Set
    End Property
    Private m_SunatTransaction As SunatTransaction


    Public Property SunatEmbededDespatchAdvice As SunatEmbededDespatchAdvice
        Get
            Return m_SunatEmbededDespatchAdvice
        End Get
        Set(value As SunatEmbededDespatchAdvice)
            m_SunatEmbededDespatchAdvice = value
        End Set
    End Property
    Private m_SunatEmbededDespatchAdvice As SunatEmbededDespatchAdvice


    Public Sub New()
        AdditionalMonetaryTotals = New List(Of AdditionalMonetaryTotal)()
        AdditionalProperties = New List(Of AdditionalProperty)()
        SunatTransaction = New SunatTransaction()
    End Sub
End Class

Public Class SunatTransaction
    Public Property Id() As String
        Get
            Return m_Id
        End Get
        Set(value As String)
            m_Id = value
        End Set
    End Property
    Private m_Id As String
End Class


