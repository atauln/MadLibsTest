Module Module1
    Dim Lvl1Strings2 = {"creeper", "zombie", "husk", "skeleton", "wither"}
    Dim Lvl1Strings1 = {"princess", "bed", "bedroom", "XBox", "footon"}
    Dim Lvl2Strings1 = {"rose", "door", "iron golem", "creeper", "criminal"}
    Dim Lvl2Strings2 = {"Harry Potter", "Hermione Granger", "Ronald Weasley", "Severus Snape", "Albus Dumbledore", "Buckbeak"}
    Dim Lvl3Strings1(5) As Array
    Dim Lvl3Strings2(5) As Array
    
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
        Console.WriteLine("Would you like to continue to level 2?")
        If Console.ReadLine() = "Yes" Then
            Lvl2(name)
        End If
    End Sub
    Sub Lvl2(name)
        Console.Clear()
        Console.WriteLine("Welcome to Level 2, " + name)
        Press()
        Console.WriteLine("Nickname: ")
        Dim Nick1 = Console.ReadLine()
        Console.WriteLine("Verb (in past tense): ")
        Dim Vrb1 = Console.ReadLine()
        Console.WriteLine("Your story is done!")
        Press()
        Randomize()
        Dim Slcted1 = Math.Round(Rnd() * 5) - 1
        Dim Slcted2 = Math.Round(Rnd() * 6) - 1
        Console.WriteLine("The " + Nick1 + " " + Lvl2Strings1(Slcted1) + " was " + Vrb1 + " by " + Lvl2Strings2(Slcted2) + ".")
        Press()
    End Sub
    Sub Lvl3(name)
        Console.Clear
        Console.WriteLine("Welcome to level 3, " + NameofUser)
        Press()
        Console.WriteLine( "Adjective: ")
        Dim Adj1 = Console.ReadLine()
        Console.WriteLine(" Adjective: ")
        Din Adj2 = Console.Readline()
        Console.WriteLine(" Your story is done! ")
        Press()
        Randomize()
        Dim Slcted1 = Math.Round(Rnd()*5)-1
        Dim Slcted2 = Math.Round(Rnd()*5)-1
        Console.WriteLine(" The " + Adj1 + " " + Lvl3Strings1(Slcted1) + " was making a "
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
        ElseIf numLvlResponse = 3 Then
            
        Else
            Console.WriteLine("That is not a valid response...")
            Console.WriteLine("Terminating program...")
            Press()
            End
        End If
    End Sub

End Module
