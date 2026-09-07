Module TP_07_01_Remise

    Sub Main()
        Dim montantSaisi, remise, montantNet As Double

        Console.WriteLine("Veuillez taper votre montant")
        montantSaisi = Console.ReadLine()

        If montantSaisi < 2000 Then
            remise = 0
        ElseIf montantSaisi < 5000 Then
            remise = 1
        Else
            remise = 2
        End If
        Console.WriteLine("Remise de  : " + remise.ToString() + "\%")
        montantNet = montantSaisi - (montantSaisi * remise / 100)
        Console.WriteLine("Le montant net est : " + montantNet.ToString())
    End Sub

End Module
