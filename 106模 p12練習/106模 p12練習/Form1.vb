Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b$ = LineInput(i)
                Dim c$ = LineInput(i)
                Dim ans% = 0
                If Len(b) > Len(c) Then
                    For k = 1 To Len(c)
                        If Mid(b, 1, k) = Mid(c, Len(c) - k + 1, k) Then If ans < k Then ans = k
                    Next
                Else
                    For k = 1 To Len(b)
                        If Mid(b, 1, k) = Mid(c, Len(c) - k + 1, k) Then If ans < k Then ans = k
                    Next
                End If
                PrintLine(3, ans)
            Next
            PrintLine(3)
        Next
    End Sub
End Class
