Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim x As New List(Of Integer)
                Dim b$ = LineInput(i)
                Dim y As New List(Of Integer)
                Dim z% = 0
                Do Until b = "0"
                    Dim c$() = b.Split(",")
                    x.Add(Val(c(1)))
                    y.Add(z)
                    z = z + 1
                    b = LineInput(i)
                Loop
                Dim jj As New List(Of Integer)
                For k = 0 To y.Count - 1
                    jj.Add(0)
                Next
                For k = 0 To y.Count - 1
                    If x(k) <> 99 Then jj(x(k)) += 1
                    If x(k) <> 99 Then jj(y(k)) += 1
                Next
                Dim hhh As New List(Of Integer)
                Do Until jj.Contains(1) = False
                    hhh.Add(jj.IndexOf(1))
                    jj(jj.IndexOf(1)) += 1
                Loop
                Dim aans As New List(Of String)
                Dim t% = 0
                For k = 0 To hhh.Count - 1
                    If x(hhh(k)) <> 99 Then
                        QQ(x, hhh(k), "", aans)
                        If aans(t) = "" Then
                            aans(t) = hhh(k) & ":N"
                        Else
                            aans(t) = hhh(k) & ":" & aans(t)
                        End If
                        t += 1
                    End If
                Next
                For k = 0 To aans.Count - 1
                    PrintLine(3, aans(k))
                Next
                PrintLine(3)
            Next
        Next
    End Sub

    Function QQ(ByVal a As List(Of Integer), ByVal b%, ByVal ans$, ByVal h As List(Of String))
        If a(b) <> 99 Then
            If a(a(b)) <> 99 Then ans = ans & a(b) & ","
            QQ(a, a(b), ans, h)
        Else
            If ans <> "" Then
                ans = "{" & ans.Trim(",") & "}"
                h.Add(ans)
            Else
                h.Add(ans)
            End If
        End If
    End Function
End Class
