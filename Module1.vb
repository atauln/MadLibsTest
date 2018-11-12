Module Module1
    Dim Lvl1Strings2 = {"creeper", "zombie", "husk", "skeleton", "wither"}
    Dim Lvl1Strings1 = {"princess", "bed", "bedroom", "XBox", "footon"}
    Sub Press()
        Console.WriteLine("Press any key..")
        Console.ReadKey(True)
    End Sub
    Sub Lvl1(name)
        Console.Clear()
        Console.WriteLine("Welcome to Level 1, " + name)
        Press()
        Console.WriteLine("Adjective: ")
        Dim Adj1 = Console.ReadLine()
        Console.WriteLine("Verb: ")
        Dim Vrb1 = Console.ReadLine()
        Console.WriteLine("Your story is done!")
        Press()
        Randomize()
        Dim Slcted1 = Math.Round(Rnd() * 5) - 1
        Dim Slcted2 = Math.Round(Rnd() * 5) - 1
        Console.WriteLine("The " + Adj1 + " " + Lvl1Strings1(Slcted1) + " was " + Vrb1 + "ing away the " + Lvl1Strings2(Slcted2) + ".")
        Press()
        End
    End Sub
    Sub Lvl2(name)
        Console.Clear()
        Console.WriteLine("Welcome to Level 2, " + name)
        Press()
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
        ElseIf numLvlResponse = 2 Then
            Lvl2(NameofUser)
        Else
            Console.WriteLine("That is not a valid response...")
            Console.WriteLine("Terminating program...")
            Press()
            End
        End If
    End Sub

End Module
