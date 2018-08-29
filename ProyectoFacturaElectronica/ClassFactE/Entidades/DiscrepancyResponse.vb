
<Serializable> _
Public Class DiscrepancyResponse
    Implements IEquatable(Of DiscrepancyResponse)
    Public Property ReferenceID() As String
        Get
            Return m_ReferenceID
        End Get
        Set(value As String)
            m_ReferenceID = value
        End Set
    End Property
    Private m_ReferenceID As String
    Public Property ResponseCode() As String
        Get
            Return m_ResponseCode
        End Get
        Set(value As String)
            m_ResponseCode = value
        End Set
    End Property
    Private m_ResponseCode As String
    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property
    Private m_Description As String

    Public Sub New()
        ReferenceID = String.Empty
    End Sub
    Public Overloads Function Equals(other As DiscrepancyResponse) As Boolean _
        Implements IEquatable(Of DiscrepancyResponse).Equals
        If String.IsNullOrEmpty(ReferenceID) Then
            Return False
        End If
        Return ReferenceID.Equals(other.ReferenceID)
    End Function

    Public Overrides Function GetHashCode() As Integer
        If String.IsNullOrEmpty(ReferenceID) Then
            Return MyBase.GetHashCode()
        End If

        Return ReferenceID.GetHashCode()
    End Function
End Class
