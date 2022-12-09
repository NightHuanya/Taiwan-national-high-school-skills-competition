Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b%(20)
                For k = 0 To 20
                    b(k) = k
                Next
                Dim c$ = LineInput(i)
                Do Until InStr(c, "  ") = 0 : c = c.Replace("  ", " ") : Loop
                Dim d$() = c.Split
                Dim ans$ = ""
                Dim jj As New List(Of Integer)
                For k = 0 To UBound(d)
                    Dim x$() = d(k).Split(",")
                    If b(Val(x(0))) <> b(Val(x(1))) Then
                        Dim y% = Math.Max(b(Val(x(0))), b(Val(x(1))))
                        Dim z% = Math.Min(b(Val(x(0))), b(Val(x(1))))
                        Do Until b.Contains(y) = False : b(Array.IndexOf(b, y)) = z : Loop
                        jj.Add(Val(x(0))) : jj.Add(Val(x(1)))
                    Else
                        ans = ans & d(k) & " "
                    End If
                Next
                If ans = "" Then
                    For k = 1 To jj.Count - 1
                        If b(jj(k)) <> b(jj(0)) Then ans = "F" : Exit For
                    Next
                End If
                If ans = "" Then
                    ans = "T"
                End If
                PrintLine(3, Trim(ans))
            Next
            PrintLine(3)
        Next
    End Sub
End Class
