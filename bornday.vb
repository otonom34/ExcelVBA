Module module2
	sub main()

	dim dtarih,gun as Date
	

        Do

            dtarih = InputBox("Doğum Tarihinizi Giriniz :")



        Loop While Not IsDate(dtarih)

        Select Case Weekday(dtarih)

            Case 1 : gun = "Pazar"

            Case 2 : gun = "Pazartesi"

            Case 3 : gun = "Salı"

            Case 4 : gun = "Çarşamba"

            Case 5 : gun = "Perşembe"

            Case 6 : gun = "Cuma"

            Case 7 : gun = "Cumartesi"

        End Select

        System.Console.write(gun)
		System.Console.write(" Günü  Doğmuşsunuz")
    end sub
End Module
