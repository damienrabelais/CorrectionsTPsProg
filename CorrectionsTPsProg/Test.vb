Module Test

    Function Factorielle(ByVal pN As Integer) As Integer
        Dim fact, i As Integer
        fact = 1
        For i = 1 To pN
            fact = fact * i
        Next

        Return fact
    End Function


    Sub Main() ' Programme principal
        Dim n As Integer

        Do
            Console.WriteLine("Saisir un nombre >= 0")
            n = Console.ReadLine()
            If n < 0 Then
                Console.WriteLine("n > 0")
            End If
        Loop Until n >= 0
        Console.WriteLine("La factorielle de ce nombre est " + Factorielle(n).ToString())


    End Sub ' Fin du main
End Module
