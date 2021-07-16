Module module5
	Sub Main()
		Dim ad as String
		Console.BackGroundColor = ConsoleColor.White
		Console.ForegroundColor = ConsoleColor.Black
		Console.Clear()
		Console.Write("Adınızı Girin :")
		ad =Console.ReadLine()
		
		MsgBox(ad, MsgBoxStyle.okCancel + MsgBoxStyle.information, "Üyemiz")
		Console.ReadKey()	
	End	Sub
End module