Module TP_09_02_Moyenne_Do_Loop
    Sub main()
        Dim somme, note As Double
        Dim compteur As Integer
        Do
            Do
                Console.WriteLine("Note ? (entre 0 et 20, -1 pour sortir)")
                note = Console.ReadLine()
                If (note < 0 And note <> -1) Or note > 20 Then
                    Console.WriteLine("La note doit être entre 0 et 20")
                End If
            Loop Until note >= 0 And note <= 20 Or note = -1
            If note <> -1 Then
                somme = somme + note
                compteur = compteur + 1
            End If
        Loop Until note = -1
        Console.WriteLine("Somme : " + somme.ToString())
        Console.WriteLine("Compteur : " + compteur.ToString())
        Console.WriteLine("Moyenne = " + (somme / compteur).ToString())
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub

End Module
