Module TP_13_01_02_Plus_petit_plus_grand
    Sub MinMax(ByVal pTab() As Double)
        Dim i As Integer
        Dim max, min As Double

        min = pTab(0)
        max = pTab(0)
        For i = 1 To 9
            If pTab(i) > max Then
                max = pTab(i)
            End If
            If pTab(i) < min Then
                min = pTab(i)
            End If
        Next
        Console.WriteLine("Min = " + min.ToString)
        Console.WriteLine("Max = " + max.ToString)
    End Sub

    Sub Main()
        Dim nombres(9) As Double
        Dim i As Integer
        For i = 0 To 9
            Console.WriteLine("Nombre n°" + i.ToString() + " ?")
            nombres(i) = Console.ReadLine()
        Next
        MinMax(nombres)
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub
End Module
