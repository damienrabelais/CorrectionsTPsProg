Module Test
    Sub main()
        Dim n, i, Somme As Integer
        Do
            Console.WriteLine("Saisir le nombre :")
            n = Console.ReadLine()
        Loop Until n > 0
        Somme = 0
        For i = 10 To 100 Step 10
            Somme = Somme + i
        Next
        Console.WriteLine("La somme vaut : " + Somme.ToString())
        Console.WriteLine()

    End Sub
End Module
