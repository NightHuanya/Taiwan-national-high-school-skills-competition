Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a$ = LineInput(i)
            Dim b As New List(Of String)
            Dim c As New List(Of String)
            For k = 1 To 5
                b.Add(Mid(a, k, 1)) : c.Add(k)
            Next
            PrintLine(3, Join(c.ToArray, ""))
            For k = 4 To 0 Step -1
                If c.IndexOf(b(k)) <> k Then
                    Dim x$ = c(c.IndexOf(b(k)))
                    If c.IndexOf(b(k)) <> 0 Then
                        c(c.IndexOf(b(k))) = c(0)
                        c(0) = x
                        PrintLine(3, Join(c.ToArray, ""))
                    End If
                    c(0) = c(k)
                    c(k) = x
                    PrintLine(3, Join(c.ToArray, ""))
                End If
            Next
            PrintLine(3)
        Next
    End Sub
End Class
