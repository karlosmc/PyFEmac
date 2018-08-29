
<Serializable> _
Public Class AccountingSupplierParty
    Public Property CustomerAssignedAccountID() As String
        Get
            Return m_CustomerAssignedAccountID
        End Get
        Set(value As String)
            m_CustomerAssignedAccountID = value
        End Set
    End Property
    Private m_CustomerAssignedAccountID As String
    Public Property AdditionalAccountID() As String
        Get
            Return m_AdditionalAccountID
        End Get
        Set(value As String)
            m_AdditionalAccountID = value
        End Set
    End Property
    Private m_AdditionalAccountID As String
    Public Property Party() As Party
        Get
            Return m_Party
        End Get
        Set(value As Party)
            m_Party = value
        End Set
    End Property
    Private m_Party As Party


End Class
