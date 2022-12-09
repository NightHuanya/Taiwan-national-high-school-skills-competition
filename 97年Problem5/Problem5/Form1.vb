Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim b$ = LineInput(1)
            Dim C$ = ""
            For i = 1 To Len(b)
                If Mid(b, i, 1) = "+" Or Mid(b, i, 1) = "-" Or Mid(b, i, 1) = "*" Then C &= " " & Mid(b, i, 1) & " " Else C &= Mid(b, i, 1)
            Next
            Dim d As New List(Of String)
            d = C.Split.ToList
            Dim ans$ = 0
            Dim z% = 0
            QQ(d, ans, z)
            MsgBox(z)
            PrintLine(2, ans)
        Loop
    End Sub
    Function QQ(ByVal a As List(Of String), ByRef ans$, ByRef Z%)
        If a.Count = 1 Then
            If Val(a(0)) > Val(ans) Then ans = a(0)
        Else

            For i = 0 To a.Count - 1 Step 2
                If i <> a.Count - 1 Then
                    Z += 1
                    Dim b As New List(Of String)
                    For k = 0 To a.Count - 1
                        b.Add(a(k))
                    Next
                    Dim x1% = Val(b(i)), x2% = Val(b(i + 2))
                    Dim x3$ = b(i + 1)
                    If x3 = "+" Then
                        x1 = x1 + x2
                    ElseIf x3 = "-" Then
                        x1 = x1 - x2
                    Else
                        x1 = x1 * x2
                    End If
                    b.RemoveAt(i) : b.RemoveAt(i) : b.RemoveAt(i)
                    b.Insert(i, x1)
                    QQ(b, ans, Z)
                    If b.Count = 1 Then Exit For
                End If
            Next
        End If
    End Function
End Class
