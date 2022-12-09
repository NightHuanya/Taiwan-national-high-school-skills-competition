Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Do Until a = 0
            Dim b$() = LineInput(1).Split(" ")
            Dim che% = 0
            For k = UBound(b) To 1 Step -1
                QQ(b, 0, k, che)
            Next
            PrintLine(2, UBound(b) - che)
            a = LineInput(1)
        Loop
    End Sub
    Function QQ(ByVal a$(), ByVal b%, ByVal x%, ByRef che%)
        For i = x To 0 Step -1
            If Val(a(x)) > Val(a(i)) Then QQ(a, b + 1, i, che)
        Next
        If b > che Then che = b
    End Function
End Class
