Module module1
Sub main
Dim mesaj As String
mesaj= MsgBox("Çıkmak istediğinizden emin misiniz?", MsgBoxStyle.okCancel + MsgBoxStyle.information, "Çıkış")
If mesaj = vbOK Then
end
end If
end Sub
end Module
