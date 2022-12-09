Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "test3.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$(8, 8)
        For i = 0 To 8
            Dim b$ = LineInput(1).Replace(" ", "")
            For j = 1 To Len(b)
                a(i, j - 1) = Mid(b, j, 1)
            Next
        Next
        Dim c$ = LineInput(1)
        Do Until c = "0 0"
            Dim d$() = c.Split
            Dim d1% = Val(d(1)) - 1, d2% = Val(d(0)) - 1
            If a(d1, d2) = "0" Then
                Dim x As New List(Of String)
                For k = 0 To 8
                    If a(d1, k) <> "0" And x.Contains(a(d1, k)) = False Then x.Add(a(d1, k))
                    If a(k, d2) <> "0" And x.Contains(a(k, d2)) = False Then x.Add(a(k, d2))
                Next
                For i = (d1 \ 3) * 3 To (d1 \ 3) * 3 + 2
                    For j = (d2 \ 3) * 3 To (d2 \ 3) * 3 + 2
                        If x.Contains(a(i, j)) = False And a(i, j) <> "0" Then x.Add(a(i, j))
                    Next
                Next
                Dim ans As New List(Of String)
                For i = 1 To 9
                    If x.Contains(i) = False Then ans.Add(i)
                Next
                PrintLine(2, Join(ans.ToArray, " "))
            Else
                PrintLine(2, "0")
            End If
            c = LineInput(1)
        Loop
    End Sub
End Class
