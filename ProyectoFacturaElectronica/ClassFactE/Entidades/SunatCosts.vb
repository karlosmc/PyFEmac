
<Serializable> _
Public Class SunatCosts
    Public vRoadTransport As SunatRoadTransport
    Public Property RoadTransport As SunatRoadTransport
        Get
            Return vRoadTransport
        End Get
        Set(value As SunatRoadTransport)
            vRoadTransport = value
        End Set
    End Property
    Public Sub New()
        RoadTransport = New SunatRoadTransport
    End Sub

End Class
