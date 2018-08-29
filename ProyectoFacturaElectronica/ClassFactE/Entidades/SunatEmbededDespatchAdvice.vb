<Serializable>
Public Class SunatEmbededDespatchAdvice
    Public Property DeliveryAddress() As PostalAddress
        Get
            Return m_DeliveryAddress
        End Get
        Set(value As PostalAddress)
            m_DeliveryAddress = Value
        End Set
    End Property
    Private m_DeliveryAddress As PostalAddress
    Public Property OriginAddress() As PostalAddress
        Get
            Return m_OriginAddress
        End Get
        Set(value As PostalAddress)
            m_OriginAddress = Value
        End Set
    End Property
    Private m_OriginAddress As PostalAddress
    Public Property SunatCarrierParty() As AccountingSupplierParty
        Get
            Return m_SunatCarrierParty
        End Get
        Set(value As AccountingSupplierParty)
            m_SunatCarrierParty = Value
        End Set
    End Property
    Private m_SunatCarrierParty As AccountingSupplierParty
    Public Property DriverParty() As AgentParty
        Get
            Return m_DriverParty
        End Get
        Set(value As AgentParty)
            m_DriverParty = Value
        End Set
    End Property
    Private m_DriverParty As AgentParty
    Public Property SunatRoadTransport() As SunatRoadTransport
        Get
            Return m_SunatRoadTransport
        End Get
        Set(value As SunatRoadTransport)
            m_SunatRoadTransport = Value
        End Set
    End Property
    Private m_SunatRoadTransport As SunatRoadTransport
    Public Property TransportModeCode() As String
        Get
            Return m_TransportModeCode
        End Get
        Set(value As String)
            m_TransportModeCode = Value
        End Set
    End Property
    Private m_TransportModeCode As String
    Public Property GrossWeightMeasure() As InvoicedQuantity
        Get
            Return m_GrossWeightMeasure
        End Get
        Set(value As InvoicedQuantity)
            m_GrossWeightMeasure = Value
        End Set
    End Property
    Private m_GrossWeightMeasure As InvoicedQuantity

    Public Sub New()
        DeliveryAddress = New PostalAddress()
        OriginAddress = New PostalAddress()
        SunatCarrierParty = New AccountingSupplierParty()
        DriverParty = New AgentParty()
        SunatRoadTransport = New SunatRoadTransport()
        GrossWeightMeasure = New InvoicedQuantity()
    End Sub
End Class
