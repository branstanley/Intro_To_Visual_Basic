Module Hello
    Sub Main()
        ' Setting variables
        Dim index As Integer = 0
        Dim someVar As String = "Hello world!"
        ' Creating a class
        Dim hello_world_class As HelloWorldClass = New HelloWorldClass()

        ' Practicing using a property
        hello_world_class.HelloString = someVar
        MsgBox(hello_world_class.HelloString & " is " & hello_world_class.Length & " characters long")

        someVar = ""

        ' Practicing For Each loop and functions that return a list
        For Each tempString As String In hello_world_class.hello_func()
            someVar = someVar & tempString
        Next

        MsgBox(someVar)

        ' Practice for loop
        For i As Integer = 0 To 50
            Console.Write(i & " ")
        Next
        Console.WriteLine()

        ' Practive for loop that increments by 2
        For i As Integer = 0 To 50 Step 2
            Console.Write(i & " ")
        Next
        Console.WriteLine()

        While index <= 10
            If index Mod 3 Then
                Console.Write("Mod 3")
            ElseIf index Mod 4 Then
                Console.Write("Mod 4")
            Else
                Console.Write("No mod")
            End If
            index += 1
            Console.WriteLine()
        End While

    End Sub
End Module