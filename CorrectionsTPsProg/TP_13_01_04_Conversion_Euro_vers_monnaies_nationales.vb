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

    End Sub


End Module
