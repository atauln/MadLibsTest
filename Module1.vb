Module Module1
    'Declare variables

    'Declare Level1 Variables
    Dim Lvl1Strings2 = {"creeper", "zombie", "husk", "skeleton", "wither"}
    Dim Lvl1Strings1 = {"princess", "bed", "bedroom", "XBox", "footon"}

    'Declare Level2 Variables
    Dim Lvl2Strings1 = {"rose", "door", "iron golem", "creeper", "criminal"}
    Dim Lvl2Strings2 = {"Harry Potter", "Hermione Granger", "Ronald Weasley", "Severus Snape", "Albus Dumbledore", "Buckbeak"}

    'Declare Level3 Variables
    Dim Lvl3Strings1 = {"dog", "cat", "ocelot", "wolf", "monkey"}
    Dim Lvl3Strings2 = {"cake", "pie", "nametag", "tree", "lemon"}

    'Sub/function for when user button press required (for breaks)
    Sub Press()
        Console.WriteLine("Press any key..")
        Console.ReadKey(True)
    End Sub

    'Sub/function for level 1
    Sub Lvl1(name)
        Console.Clear()

        'Welcome
        Console.WriteLine("Welcome to Level 1, " + name)
        Press()

        'Ask for user input
Adjective:
        Console.WriteLine("Adjective: ")
        Dim Adj1 = Console.ReadLine()
        If Adj1 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Adjective
        End If

Verb:
        Console.WriteLine("Verb: ")
        Dim Vrb1 = Console.ReadLine()
        If Vrb1 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Verb
        End If

        Console.WriteLine("Your story is done!")
        Press()

        'Generate story
        Randomize()
        Dim Slcted1 = Math.Round(Rnd() * 5) - 1
        Dim Slcted2 = Math.Round(Rnd() * 5) - 1
        If Slcted1 < 0 Then
            Slcted1 = 4
        End If
        If Slcted2 < 0 Then
            Slcted2 = 4
        End If

        'Display story
        Console.WriteLine("The " + Adj1 + " " + Lvl1Strings1(Slcted1) + " was " + Vrb1 + " away the " + Lvl1Strings2(Slcted2) + ".")
        Press()

        'Ask to continue
        Console.WriteLine("Would you like to continue to level 2?")
        If Console.ReadLine() = "Yes" Then
            Lvl2(name)
        End If
    End Sub

    'Sub/function for level 2
    Sub Lvl2(name)
        Console.Clear()

        'Welcome
        Console.WriteLine("Welcome to Level 2, " + name)
        Press()

        'Ask for user input
Nickname:
        Console.WriteLine("Nickname: ")
        Dim Nick1 = Console.ReadLine()
        If Nick1 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Nickname
        End If

Verb:
        Console.WriteLine("Verb (in past tense): ")
        Dim Vrb1 = Console.ReadLine()
        If Vrb1 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Verb
        End If

        Console.WriteLine("Your story is done!")
        Press()

        'Generate story
        Randomize()
        Dim Slcted1 = Math.Round(Rnd() * 5) - 1
        Dim Slcted2 = Math.Round(Rnd() * 6) - 1
        If Slcted1 < 0 Then
            Slcted1 = 4
        End If
        If Slcted2 < 0 Then
            Slcted2 = 5
        End If

        'Display story
        Console.WriteLine("The " + Nick1 + " " + Lvl2Strings1(Slcted1) + " was " + Vrb1 + " by " + Lvl2Strings2(Slcted2) + ".")
        Press()

        'Ask to continue
        Console.WriteLine("Would you like to continue to level 3?")
        If Console.ReadLine() = "Yes" Then
            Lvl3(name)
        End If
    End Sub

    'Sub/function for level 3
    Sub Lvl3(name)
        Console.Clear()

        'Welcome
        Console.WriteLine("Welcome to level 3, " + name)
        Press()

        'Ask for user input
Adjective:
        Console.WriteLine("Adjective: ")
        Dim Adj1 = Console.ReadLine()
        If Adj1 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Adjective
        End If

Adjective2:
        Console.WriteLine("Adjective: ")
        Dim Adj2 = Console.ReadLine()
        If Adj2 = "" Then
            Console.WriteLine("Don't do that!")
            GoTo Adjective2
        End If

        Console.WriteLine("Your story is done! ")
        Press()

        'Generate story
        Randomize()
        Dim Slcted1 = Math.Round(Rnd() * 5) - 1
        Dim Slcted2 = Math.Round(Rnd() * 5) - 1
        If Slcted1 < 0 Then
            Slcted1 = 4
        End If
        If Slcted2 < 0 Then
            Slcted2 = 4
        End If

        'Display story
        Console.WriteLine("The " + Adj1 + " " + Lvl3Strings1(Slcted1) + " was making a " + Adj2 + " " + Lvl3Strings2(Slcted2) + ".")
        Press()
    End Sub

    'Main command zone
    Sub Main()

        'Ask for the user's name
        Console.WriteLine("Welcome to Mad Libs Lite!")
        Console.WriteLine("What is your name?")
        Dim NameofUser = Console.ReadLine()
        Console.WriteLine("Thanks, " + NameofUser)

        'Ask for the level to play/load
        Console.WriteLine("What level would you like to play?")
        Dim numLvlResponse = Console.ReadLine()

        'Transportation to the level
        Console.WriteLine("Transporting " + NameofUser + " to  level " + numLvlResponse + "...")
        If numLvlResponse = 1 Then
            Lvl1(NameofUser)
        ElseIf numLvlResponse = 2 Then
            Lvl2(NameofUser)
        ElseIf numLvlResponse = 3 Then
            Lvl3(NameofUser)
        Else

            'Terminate if level does not exist
            Console.WriteLine("That is not a valid response...")
            Console.WriteLine("Terminating program...")
            Press()
            End
        End If
    End Sub
End Module
