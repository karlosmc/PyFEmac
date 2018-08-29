

Namespace CarlosMc.Firmado.Entidades
    <Serializable> _
    Public Class ExchangeRate
        Public Property SourceCurrencyCode() As String
            Get
                Return m_SourceCurrencyCode
            End Get
            Set(value As String)
                m_SourceCurrencyCode = value
            End Set
        End Property
        Private m_SourceCurrencyCode As String
        Public Property TargetCurrencyCode() As String
            Get
                Return m_TargetCurrencyCode
            End Get
            Set(value As String)
                m_TargetCurrencyCode = value
            End Set
        End Property
        Private m_TargetCurrencyCode As String
        Public Property CalculationRate() As Decimal
            Get
                Return m_CalculationRate
            End Get
            Set(value As Decimal)
                m_CalculationRate = value
            End Set


        End Property
        Private m_CalculationRate As Decimal

        

        Public Property [Date]() As String
            Get
                Return m_Date
            End Get
            Set(value As String)
                m_Date = value
            End Set
        End Property
        Private m_Date As String
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================



