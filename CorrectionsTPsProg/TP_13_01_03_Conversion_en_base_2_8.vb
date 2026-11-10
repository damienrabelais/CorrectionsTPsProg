Module TP_13_01_03_Conversion_en_base_2_8
    Const MAX As Integer = 8
    Sub Convertir(ByVal pN As Integer, ByVal pBase As Integer)
        Dim resultat(MAX), n, i, temp, quotient As Integer
        temp = pN
        i = 0
        Do
            resultat(i) = temp Mod pBase 'Reste de la division entière
            quotient = temp \ pBase 'Division entière
            temp = quotient
            i = i + 1
        Loop Until temp = 0
        n = i
        ' Affichage
        Console.WriteLine("Affichage nombre = tableau résultat.")
        For i = n - 1 To 0 Step -1
            Console.Write(resultat(i))
        Next
        Console.WriteLine()
    End Sub

    Sub Main()
        Dim base, nombre As Integer
        Dim choix As Char

        Do
            Do
                Console.WriteLine("Entrez le nombre à convertir")
                nombre = Console.ReadLine
            Loop Until nombre >= 0 And nombre <= 255
            Do
                Console.WriteLine("Entrez la base vers laquelle faire la conversion (2 ou 8)")
                base = Console.ReadLine
            Loop Until base = 2 Or base = 8
            Convertir(nombre, base)
            Do
                Console.WriteLine("Voulez-vous refaire une conversion ? (O/N)")
                choix = Console.ReadLine()
            Loop Until choix = "N" Or choix = "O"
        Loop Until choix = "N"
    End Sub

End Module
