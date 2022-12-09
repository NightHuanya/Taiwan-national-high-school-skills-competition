Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b$() = LineInput(i).Split("=")
                Dim c$ = ""
                Dim d$ = ""
                For k = 1 To Len(b(0))
                    If Mid(b(0), k, 1) = "+" Or Mid(b(0), k, 1) = "-" Then
                        c = c & " " & Mid(b(0), k, 1)
                    Else
                        c = c & Mid(b(0), k, 1)
                    End If
                Next
                For k = 1 To Len(b(1))
                    If Mid(b(1), k, 1) = "+" Or Mid(b(1), k, 1) = "-" Then
                        d = d & " " & Mid(b(1), k, 1)
                    Else
                        d = d & Mid(b(1), k, 1)
                    End If
                Next
                If Mid(c, 1, 1) <> "-" Then c = "+" & c
                If Mid(d, 1, 1) <> "-" Then d = "+" & d
                Dim x1% = 0, x2% = 0
                Dim m1% = 0, m2% = 0
                Dim z1$() = c.Split
                Dim z2$() = d.Split
                For k = 0 To UBound(z1)
                    If Mid(z1(k), 1, 1) = "-" Then
                        If Mid(z1(k), Len(z1(k)), 1) = "x" Then
                            If Len(z1(k)) = 2 Then
                                x1 = x1 - 1
                            Else
                                x1 = x1 - Val(Mid(z1(k), 2, Len(z1(k)) - 2))
                            End If
                        Else
                            m1 = m1 - Val(Mid(z1(k), 2, Len(z1(k)) - 1))
                        End If
                    Else
                        If Mid(z1(k), Len(z1(k)), 1) = "x" Then
                            If Len(z1(k)) = 2 Then
                                x1 = x1 + 1
                            Else
                                x1 = x1 + Val(Mid(z1(k), 2, Len(z1(k)) - 2))
                            End If
                        Else
                            m1 = m1 + Val(Mid(z1(k), 2, Len(z1(k)) - 1))
                        End If
                    End If
                Next
                For k = 0 To UBound(z2)
                    If Mid(z2(k), 1, 1) = "-" Then
                        If Mid(z2(k), Len(z2(k)), 1) = "x" Then
                            If Len(z2(k)) = 2 Then
                                x2 = x2 - 1
                            Else
                                x2 = x2 - Val(Mid(z2(k), 2, Len(z2(k)) - 2))
                            End If
                        Else
                            m2 = m2 - Val(Mid(z2(k), 2, Len(z2(k)) - 1))
                        End If
                    Else
                        If Mid(z2(k), Len(z2(k)), 1) = "x" Then
                            If Len(z2(k)) = 2 Then
                                x2 = x2 + 1
                            Else
                                x2 = x2 + Val(Mid(z2(k), 2, Len(z2(k)) - 2))
                            End If
                        Else
                            m2 = m2 + Val(Mid(z2(k), 2, Len(z2(k)) - 1))
                        End If
                    End If
                Next
                Dim x3% = x1 - x2
                Dim m3% = m2 - m1
                Dim ans$ = ""
                If x3 = 0 And m3 = 0 Then
                    ans = "IS"
                ElseIf x3 = 0 And m3 <> 0 Then
                    ans = "NS"
                End If
                If ans = "" Then
                    ans = m3 \ x3
                End If
                PrintLine(3, ans)
            Next
            PrintLine(3)
        Next
    End Sub
End Class
