Public Class HelloWorldClass
    Private hello_string As String

    Property HelloString As String
        Get
            Return hello_string
        End Get
        Set(value As String)
            hello_string = value
        End Set
    End Property

    ReadOnly Property Length() As Integer
        Get
            Return hello_string.Length
        End Get
    End Property

End Class
