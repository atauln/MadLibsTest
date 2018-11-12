Module Module1
    Sub Lvl1(name)
        Console.Clear()
        Console.WriteLine("Welcome to Level 1, " + name)
        Console.ReadKey(True)
    End Sub
    Sub Main()
        Console.WriteLine("Welcome to Mad Libs Lite!")
        Console.WriteLine("What is your name?")
        Dim NameofUser = Console.ReadLine()
        Console.WriteLine("Thanks, " + NameofUser)
        Console.WriteLine("What level would you like to play?")
        Dim numLvlResponse = Console.ReadLine()
        Console.WriteLine("Transporting " + NameofUser + " to  level " + numLvlResponse + "...")
        If numLvlResponse = 1 Then
            Lvl1(NameofUser)
        Else
            Console.WriteLine("That is not a valid response...")
            Console.WriteLine("Terminating program...")
            Console.ReadKey(True)
            End
        End If
    End Sub

End Module
