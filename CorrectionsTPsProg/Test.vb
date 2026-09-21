Module Test

    Function PlusGrand(ByVal pX As Integer, ByVal pY As Integer) As Integer
        If pX > pY Then
            Return pX
        Else
            Return pY
        End If
    End Function


    Sub Main() ' Programme principal
        Dim a, b As Integer
        Console.WriteLine("Entrer le premier nombre.")
        a = Console.ReadLine()
        Console.WriteLine("Entrer le deuxième nombre.")
        b = Console.ReadLine()
        Console.WriteLine("Le plus grand des deux est : " + PlusGrand(a, b).ToString())
        ' PlusGrand(a, b), Appel de la fonction
        Console.ReadLine()
    End Sub ' Fin du main
End Module
