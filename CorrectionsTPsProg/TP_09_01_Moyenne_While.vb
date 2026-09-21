Module TP_09_01_Moyenne_While

    Sub Main()
        Dim noteSaisie, compteur, nombreDeNotes, somme As Integer
        Dim pourcentage, moyenne As Double
        nombreDeNotes = 0
        compteur = 0
        Console.WriteLine("Entrez une note (-1 pour fin) :")
        noteSaisie = Console.ReadLine()
        While noteSaisie <> -1  ' boucle de saisie des notes 
            somme = somme + noteSaisie
            nombreDeNotes = nombreDeNotes + 1
            If noteSaisie > 10 Then
                compteur = compteur + 1
            End If
            Console.WriteLine("Entrez une note (-1 pour fin) : ")
            noteSaisie = Console.ReadLine()
        End While
        pourcentage = (compteur / nombreDeNotes) * 100
        Console.WriteLine("Vous avez " + pourcentage.ToString() + " % de notes > à 10")
        moyenne = somme / nombreDeNotes
        Console.WriteLine("Votre moyenne est de  " + moyenne.ToString())
        Console.ReadLine()

    End Sub


End Module
