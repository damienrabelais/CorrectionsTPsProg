Module TP_13_01_04_Conversion_Euro_vers_monnaies_nationales
    Sub Main()
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                                       "LUF", "NLG", "GRD", "SIT", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                                    40.33, 2.2, 340.75, 239.64, 200.48, 0.58, 0.42, 30.12}
        'Pour les deux tableaux, 16 cases, index de 0 à 15 donc 

        Const MAXDEVISES As Integer = 16 ' monnaies
        Dim montantEnEuros As Double
        Dim codeDevise As String
        Dim i As Integer = 0


        Do
            Do
                Console.WriteLine("Montant en euros ou 0 ?")
                montantEnEuros = Console.ReadLine()
                If montantEnEuros < 0 Then
                    Console.WriteLine("Montant >= 0 ?")
                End If
            Loop Until montantEnEuros >= 0
            If montantEnEuros <> 0 Then ' Sinon on sort
                Console.WriteLine("Code devise ?")
                codeDevise = Console.ReadLine()
                i = 0
                While codeDevise <> devises(i) And i < MAXDEVISES - 1
                    i = i + 1
                End While
                If codeDevise = devises(i) Then
                    Console.WriteLine("Montant dans l'ancienne monnaie nationale : " + (taux(i) * montantEnEuros).ToString())
                Else
                    Console.WriteLine("Devise non trouvée")
                End If
            End If
            Console.WriteLine(vbCrLf + "//////////////////////" + vbCrLf)
        Loop Until montantEnEuros = 0
        Console.WriteLine("Au revoir.")
        Console.ReadLine()


    End Sub


End Module
