Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a$ = LineInput(i)
            Dim che% = 7
            Dim b, c, d As New List(Of String)
            For j = 1 To Len(a)
                b.Add(Mid(a, j, 1)) : c.Add(j)
            Next
            PrintLine(3, Join(c.ToArray, ""))
            c.Remove(8) : d.Add(8)
            For j = c.Count - 1 To 1 Step -1
                If Val(b(b.IndexOf(che + 1) - 1)) = che Then
                    d.Insert(0, che) : c.Remove(che)
                Else
                    Exit For
                End If
                che -= 1
            Next
            For j = 0 To c.Count - 1
                If b.IndexOf(c(0)) = 0 Then
                    d.Insert(0, c(0)) : c.Remove(c(0))
                ElseIf b.IndexOf(c(0)) = 7 Then
                    d.Add(c(0)) : c.Remove(c(0))
                Else
                    If d.Contains(b(b.IndexOf(c(0)) - 1)) Then
                        d.Insert(d.IndexOf(b(b.IndexOf(c(0)) - 1)) + 1, c(0)) : c.Remove(c(0))
                    ElseIf d.Contains(b(b.IndexOf(c(0)) + 1)) Then
                        d.Insert(d.IndexOf(b(b.IndexOf(c(0)) + 1)), c(0)) : c.Remove(c(0))
                    Else
                        If b.IndexOf(c(0)) < b.IndexOf(8) Then
                            d.Insert(0, c(0)) : c.Remove(c(0))
                        Else
                            d.Add(c(0)) : c.Remove(c(0))
                        End If
                    End If
                End If
                PrintLine(3, Join(c.ToArray, "") & Join(d.ToArray, ""))
                If a = Join(c.ToArray, "") & Join(d.ToArray, "") Then Exit For
            Next
            PrintLine(3)
        Next
    End Sub
End Class
