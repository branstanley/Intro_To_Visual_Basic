Module Hello
    Sub Main()
        Dim someVar As String = "Hello world!"
        Dim hello_world_class As HelloWorldClass = New HelloWorldClass()

        hello_world_class.HelloString = someVar

        MsgBox(hello_world_class.HelloString & " is " & hello_world_class.Length() & " characters long")

        someVar = ""
        For Each tempString As String In hello_world_class.hello_func()
            someVar = someVar & tempString
        Next

        MsgBox(someVar)

    End Sub
End Module