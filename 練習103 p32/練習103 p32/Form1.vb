Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b% = LineInput(i)
                Dim c%(16)
                c(0) = 1
                c(1) = 2
                For k = 2 To UBound(c)
                    c(k) = c(k - 1) + c(k - 2)
                Next
                Dim d% = b
                Dim ans$ = ""
                For k = UBound(c) To 0 Step -1
                    If d - c(k) >= 0 Then
                        d = d - c(k)
                        ans = ans & "1"
                    Else
                        ans = ans & "0"
                    End If
                Next
                For k = 1 To Len(ans)
                    If Mid(ans, k, 1) = "1" Then
                        ans = Mid(ans, k, Len(ans) - k + 1)
                        Exit For
                    End If
                Next
                PrintLine(3, b & "=" & ans)
            Next
            PrintLine(3)
        Next

    End Sub
End Class
