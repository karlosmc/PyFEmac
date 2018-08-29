
<Serializable> _
Public Class UBLExtensions
    Public Property Extension1() As UBLExtension
        Get
            Return m_Extension1
        End Get
        Set(value As UBLExtension)
            m_Extension1 = value
        End Set
    End Property
    Private m_Extension1 As UBLExtension
    Public Property Extension2() As UBLExtension
        Get
            Return m_Extension2
        End Get
        Set(value As UBLExtension)
            m_Extension2 = value
        End Set
    End Property



    Private m_Extension2 As UBLExtension

    Public Property Extension3() As UBLExtension
        Get
            Return m_Extension3
        End Get
        Set(value As UBLExtension)
            m_Extension3 = value
        End Set
    End Property



    Private m_Extension3 As UBLExtension

    

    Public Sub New()
        Extension1 = New UBLExtension()
        Extension2 = New UBLExtension()
        Extension3 = New UBLExtension()
    End Sub
End Class
