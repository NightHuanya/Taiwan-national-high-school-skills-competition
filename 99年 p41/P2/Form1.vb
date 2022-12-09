Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        Dim Va As New List(Of String)
        Va.Add("肉") : Va.Add("菜") : Va.Add("蛋") : Va.Add("果") : Va.Add("魚") : Va.Add("蝦") : Va.Add("豆") : Va.Add("菇")
        Dim Noo As New List(Of String)
        Noo.Add("肉果") : Noo.Add("肉豆") : Noo.Add("肉菇") : Noo.Add("菜蛋") : Noo.Add("菜魚") : Noo.Add("菜菇") : Noo.Add("蛋果") : Noo.Add("蛋蝦")
        Noo.Add("蛋菇") : Noo.Add("果魚") : Noo.Add("果豆") : Noo.Add("果菇") : Noo.Add("魚蝦") : Noo.Add("魚豆") : Noo.Add("魚菇")
        Noo.Add("蝦豆") : Noo.Add("豆菇")
        For i = 1 To 2
            Dim a% = LineInput(i)
            Dim ans As New List(Of String)
            QQ(Va, Noo, ans, "", a)
            For j = 0 To ans.Count - 1
                PrintLine(3, ans(j))
            Next
            PrintLine(3, Trim(ans.Count))
            PrintLine(3)
        Next
    End Sub
    Function QQ(ByVal Va As List(Of String), ByVal Noo As List(Of String), ByVal ans As List(Of String), ByVal x$, ByVal a%)
        If Len(x) = a Then
            ans.Add(x)
        Else
            For i = 0 To a - 1
                If x <> "" Then
                    If InStr(x, Va(i)) = 0 Then
                        If Noo.Contains(Mid(x, Len(x), 1) & Va(i)) = False And Noo.Contains(Va(i) & Mid(x, Len(x), 1)) = False Then
                            QQ(Va, Noo, ans, x & Va(i), a)
                        End If
                    End If
                Else
                    QQ(Va, Noo, ans, x & Va(i), a)
                End If
            Next
        End If
    End Function
End Class
