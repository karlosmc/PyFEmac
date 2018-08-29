
<Serializable> _
Public Class BillingPayment

    Private vId As PartyIdentificationID
    Public Property Id As PartyIdentificationID
        Get
            Return vId
        End Get
        Set(value As PartyIdentificationID)
            vId = value
        End Set
    End Property
    Public Property PaidAmount() As PayableAmount
        Get
            Return m_PaidAmount
        End Get
        Set(value As PayableAmount)
            m_PaidAmount = value
        End Set
    End Property
    Private m_PaidAmount As PayableAmount
    Public Property InstructionID() As String
        Get
            Return m_InstructionID
        End Get
        Set(value As String)
            m_InstructionID = value
        End Set
    End Property
    Private m_InstructionID As String

    Public Sub New()
        PaidAmount = New PayableAmount()
    End Sub
End Class
