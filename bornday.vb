Module module2
	sub main()

	dim dtarih,gun as Date
	

        Do

            dtarih = InputBox("Do�um Tarihinizi Giriniz :")



        Loop While Not IsDate(dtarih)

        Select Case Weekday(dtarih)

            Case 1 : gun = "Pazar"

            Case 2 : gun = "Pazartesi"

            Case 3 : gun = "Sal��"

            Case 4 : gun = "�ar�amba"

            Case 5 : gun = "Per�embe"

            Case 6 : gun = "Cuma"

            Case 7 : gun = "Cumartesi"

        End Select

        System.Console.write(gun)
		System.Console.write(" G��n�  Do�mu�sunuz")
    end sub
End Module
