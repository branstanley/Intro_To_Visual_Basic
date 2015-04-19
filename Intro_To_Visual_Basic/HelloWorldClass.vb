Imports System.Collections.Generic

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

    Public Function hello_func() As List(Of String)
        Dim hello_list As New List(Of String) From {"hello", " ", "world", "!"}
        Return hello_list
    End Function

End Class
