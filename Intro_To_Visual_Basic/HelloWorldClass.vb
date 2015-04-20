Imports System.Collections.Generic

Public Class HelloWorldClass
    ''' <summary>
    ''' A private member string
    ''' </summary>
    ''' <remarks></remarks>
    Private hello_string As String

    ''' <summary>
    ''' A property to access and set the hello_string string
    ''' </summary>
    ''' <value> A string to set as the current string </value>
    ''' <returns> The current value of the string. </returns>
    ''' <remarks></remarks>
    Property HelloString As String
        Get
            Return hello_string
        End Get
        Set(value As String)
            hello_string = value
        End Set
    End Property

    ''' <summary>
    ''' Used to get access to the length of the hello_world string
    ''' </summary>
    ''' <returns> The length of hello_string</returns>
    ''' <remarks></remarks>
    ReadOnly Property Length() As Integer
        Get
            Return hello_string.Length
        End Get
    End Property

    ''' <summary>
    ''' Function to return a list of strings, used to learn for each loops
    ''' </summary>
    ''' <returns> A list of strings. </returns>
    ''' <remarks> Nothing special </remarks>
    Public Function hello_func() As List(Of String)
        Dim hello_list As New List(Of String) From {"hello", " ", "world", "!"}
        Return hello_list
    End Function

End Class
