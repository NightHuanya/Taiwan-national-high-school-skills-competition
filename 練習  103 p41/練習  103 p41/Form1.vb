Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim c$() = {"00", "01", "100", "101", "1100", "1101", "11100", "11101", "111100", "111101"}
                Dim z$(26)
                For k = 0 To 22
                    z(k) = Chr(68 + k)
                Next
                z(23) = "A"
                z(24) = "B"
                z(25) = "C"
                Dim b$ = LineInput(i)
                Dim x$ = ""
                If Mid(b, 1, 2) = "00" Then
                    x = x & 0 & Array.IndexOf(c, Mid(b, 3, Len(b) - 2))
                ElseIf Mid(b, 1, 2) = "01" Then
                    x = x & 1 & Array.IndexOf(c, Mid(b, 3, Len(b) - 2))
                Else
                    x = x & 2 & Array.IndexOf(c, Mid(b, 4, Len(b) - 3))
                End If
                Dim ans$ = z(Val(x) - 1)
                PrintLine(3, ans)
            Next
            PrintLine(3)
        Next
    End Sub
End Class
