Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/TaylorHerndon/Simple-Calculator
Module SimpleCalculator

    Sub Main()

        Dim value1 As Double = 0
        Dim value2 As Double = 0
        Dim repeat As Boolean = False
        Dim operation As String = ""
        Dim result As Double = 0

        Console.WriteLine("Hello there Mr.User.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Please lets compute some numbers!")
        System.Threading.Thread.Sleep(3000)

LineFirstInput:

        'Get first number
        Console.Clear()
        Console.WriteLine("What is the first number?")
        Try

            value1 = Convert.ToDouble(Console.ReadLine())

        Catch

            Console.WriteLine("Come on m8 thats not a number and you know it...")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("You should be ashamed of yourself...")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Now go back and try again!")
            System.Threading.Thread.Sleep(2000)

            repeat = True

            GoTo LineFirstInput

        End Try

        If repeat = True Then
            Console.WriteLine("Thanks for actually putting in a number this time...")
        End If

        Console.Clear()
        Console.WriteLine("Our first number is " & value1)
        System.Threading.Thread.Sleep(2000)

LineSecondInput:

        Console.WriteLine("Now, what is our second number going to be?")

        'Get second number
        Try


            value2 = Convert.ToDouble(Console.ReadLine())

        Catch

            Console.WriteLine("Come on now, that's not a number and you know isnt...")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("You should be ashamed of yourself...")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Now go back and try again!")
            System.Threading.Thread.Sleep(2500)

            GoTo LineSecondInput

        End Try

LineChooseFunction:

        'Ask for function
        Console.Clear()
        Console.WriteLine("Ok, so we have " & value1 & " and " & value2)
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("What do you want your function to be?")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("1. Sum [+]" & vbNewLine & "2. Sub [-]" & vbNewLine & "3. Product [x]" & vbNewLine & "4. Division [÷]")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.D1
                result = value1 + value2
                operation = "+"

            Case ConsoleKey.NumPad1
                result = value1 + value2
                operation = "+"

            Case ConsoleKey.D2
                result = value1 - value2
                operation = "-"

            Case ConsoleKey.NumPad2
                result = value1 - value2
                operation = "-"

            Case ConsoleKey.D3
                result = value1 * value2
                operation = "x"

            Case ConsoleKey.NumPad3
                result = value1 * value2
                operation = "x"

            Case ConsoleKey.D4
                result = value1 / value2
                operation = "÷"

            Case ConsoleKey.NumPad4
                result = value1 / value2
                operation = "÷"

            Case Else
                Console.Clear()
                Console.WriteLine("Come on bud... 1 - 4 you can do this...")
                System.Threading.Thread.Sleep(3000)
                GoTo LineChooseFunction

        End Select

        'Give the result
        Console.Clear()
        Console.Write("The result of " & value1 & " " & operation & " " & value2 & " is")

        System.Threading.Thread.Sleep(250)
        Console.Write(".")
        System.Threading.Thread.Sleep(250)
        Console.Write(".")
        System.Threading.Thread.Sleep(250)
        Console.WriteLine(".")
        System.Threading.Thread.Sleep(250)

        Console.WriteLine("[ " & result & " ]")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Would you like to do some more computing?")
        Console.WriteLine("Y - N")

LineTryAgain:

        Select Case Console.ReadKey.Key
            Case ConsoleKey.Y

                Console.Clear()
                Console.WriteLine("Yay! More computing!")
                System.Threading.Thread.Sleep(1000)
                GoTo LineFirstInput

            Case ConsoleKey.N

                Console.Clear()
                Console.WriteLine("Ok, bye bye!")
                System.Threading.Thread.Sleep(2000)
                End

            Case Else

                GoTo LineTryAgain

        End Select

    End Sub

End Module
