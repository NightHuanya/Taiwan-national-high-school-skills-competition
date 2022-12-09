Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b$() = LineInput(i).Split("=")
                Dim x%(1), y%(1)
                For k = 0 To 1
                    Dim z$ = ""
                    For l = 1 To Len(b(k))
                        If Mid(b(k), l, 1) <> "+" And Mid(b(k), l, 1) <> "-" Then z = z & Mid(b(k), l, 1) Else z = z & " " & Mid(b(k), l, 1)
                    Next
                    If Mid(z, 1, 1) <> "-" Then z = "+" & z
                    Dim MH$() = z.Split
                    For l = 0 To UBound(MH)
                        If Mid(MH(l), 1, 1) = "+" Then
                            If Mid(MH(l), Len(MH(l)), 1) = "x" Then
                                If Len(MH(l)) = 2 Then x(k) += 1 Else x(k) += Val(Mid(MH(l), 2, Len(MH(l)) - 2))
                            Else
                                y(k) += Val(Mid(MH(l), 2, Len(MH(l)) - 1))
                            End If
                        Else
                            If Mid(MH(l), Len(MH(l)), 1) = "x" Then
                                If Len(MH(l)) = 2 Then x(k) -= 1 Else x(k) -= Val(Mid(MH(l), 2, Len(MH(l)) - 2))
                            Else
                                y(k) -= Val(Mid(MH(l), 2, Len(MH(l)) - 1))
                            End If
                        End If
                    Next
                Next
                x(0) -= x(1)
                y(1) -= y(0)
                Dim ans$ = ""
                If x(0) = 0 And y(1) = 0 Then
                    ans = "IS"
                ElseIf x(0) = 0 And y(1) <> 0 Then
                    ans = "NS"
                Else
                    ans = y(1) / x(0)
                End If
                PrintLine(3, ans)
            Next
            PrintLine(3)
        Next
    End Sub
End Class
