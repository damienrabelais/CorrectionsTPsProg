Module TP_07_02_Location

    Sub Main()
        Const LOCATIONESSENCE As Double = 30, KILOMETRAGEESSENCE As Double = 0.85
        Const LOCATIONDIESEL As Double = 35, KILOMETRAGEDIESEL As Double = 0.65
        Dim joursDeLocation, distanceAParcourir, coutEssence, coutDiesel As Integer
        Console.WriteLine("Nombre de jours de location ?")
        joursDeLocation = Console.ReadLine()
        Console.WriteLine("Kilomètrage ?")
        distanceAParcourir = Console.ReadLine()

        coutEssence = LOCATIONESSENCE * joursDeLocation + KILOMETRAGEESSENCE * distanceAParcourir
        coutDiesel = LOCATIONDIESEL * joursDeLocation + KILOMETRAGEDIESEL * distanceAParcourir

        If coutEssence > coutDiesel Then
            Console.WriteLine("Diesel")
        ElseIf coutEssence = coutDiesel Then
            Console.WriteLine("Egalité")
        Else
            Console.WriteLine("Essence")
        End If

    End Sub

End Module
