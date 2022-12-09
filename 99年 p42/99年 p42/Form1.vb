Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim b% = LineInput(i)
            Dim Cost As New List(Of Integer), word As New List(Of String)
            Do Until EOF(i) = True
                Dim c$() = LineInput(i).Replace(",", "").Split
                word.Add(c(0)) : Cost.Add(Val(c(1)))
            Loop
            Dim Wans As New List(Of String), Cans As New List(Of Integer)
            QQ(Cost, word, Wans, Cans, b, "", 0)
            For j = 0 To Wans.Count - 1
                For k = j To Wans.Count - 1
                    If Cans(j) < Cans(k) Then
                        Dim x% = Cans(j), y$ = Wans(j)
                        Cans(j) = Cans(k) : Wans(j) = Wans(k)
                        Cans(k) = x : Wans(k) = y
                    End If
                Next
            Next
            For j = 0 To Cans.Count - 1
                PrintLine(3, Wans(j) & "  " & Cans(j))
            Next
            PrintLine(3)
        Next
    End Sub
    Function QQ(ByVal Cost As List(Of Integer), ByVal word As List(Of String), ByVal Wans As List(Of String), ByVal Cans As List(Of Integer), ByVal che%, ByVal NWD$, ByVal NCT%)
        For i = 0 To Cost.Count - 1
            Dim WC As New List(Of String), b As Boolean = False
            GG(WC, NWD & word(i), "")
            For k = 0 To WC.Count - 1
                If Wans.Contains(WC(k)) = True Then b = True : Exit For
            Next
            If b = False And InStr(NWD, word(i)) = 0 Then
                If NCT + Cost(i) <= che Then QQ(Cost, word, Wans, Cans, che, NWD & word(i), NCT + Cost(i))
            End If
            If NWD <> "" And Wans.Contains(NWD) = False Then Wans.Add(NWD) : Cans.Add(NCT)
        Next
    End Function
    Function GG(ByRef WC As List(Of String), ByVal x$, ByVal y$)
        Dim a As Boolean = False
        If Len(x) = Len(y) Then
            WC.Add(y)
        Else
            For i = 1 To Len(x)
                For j = 1 To Len(y)
                    If Mid(x, i, 1) = Mid(y, j, 1) Then a = True
                Next
                If a = False Then GG(WC, x, y & Mid(x, i, 1))
                a = False
            Next
        End If
    End Function
End Class
