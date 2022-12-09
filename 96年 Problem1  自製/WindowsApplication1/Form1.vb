Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "test1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Do Until a = 0
            Dim b$() = LineInput(1).Split
            Dim ans% = 0
            For i = 0 To UBound(b)
                NO(b, i + 1, i, 0, ans)
            Next
            a = LineInput(1)
            PrintLine(2, UBound(b) - ans)
        Loop
    End Sub
    Function NO(ByVal a$(), ByVal x%, ByVal y%, ByVal key%, ByRef ans%)
        If key > ans Then ans = key
        If x > UBound(a) Or y > UBound(a) Then Exit Function
        For i = x To UBound(a)
            If Val(a(i)) > Val(a(y)) Then NO(a, i + 1, i, key + 1, ans)
        Next
    End Function
End Class
