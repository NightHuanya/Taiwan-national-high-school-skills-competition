Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b$() = LineInput(i).Split(",")
                Dim c$(Val(b(0)))
                For k = 1 To Val(b(0))
                    Dim d$() = LineInput(i).Split(",")
                    c(Val(d(0))) = Val(d(1))
                Next
                Dim ans% = 0
                QQ(c, 0, Val(b(1)), 99, ans)
                PrintLine(3, ans)
                If a <> j Then LineInput(i)
            Next
            PrintLine(3)
        Next
    End Sub
    Function QQ(ByVal a() As String, ByVal b As Integer, ByVal c As Integer, ByVal d As String, ByRef ans As Integer)
        For i = 0 To UBound(a)
            If a(i) = d Then
                If b = c Then
                    ans = ans + 1
                Else
                    QQ(a, b + 1, c, i, ans)
                End If
            End If
        Next
    End Function
End Class
