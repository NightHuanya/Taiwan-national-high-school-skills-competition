Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a% = LineInput(i)
            For j = 1 To a
                Dim b% = LineInput(i)
                Dim ouo% = 0
                Dim y As New List(Of String)
                Dim z As New List(Of Integer)
                For k = 1 To b
                    ouo = ouo + 1
                    Dim aaaaa$ = LineInput(i)
                    Do Until InStr(aaaaa, "  ") = 0 : aaaaa = aaaaa.Replace("  ", " ") : Loop
                    Dim c$() = LineInput(i).Split(" ")
                    Dim oao As New List(Of Integer)
                    Dim d%(UBound(c) + 2)
                    Dim x%(UBound(c) + 2)
                    For l = 0 To UBound(d)
                        d(l) = l
                    Next
                    For l = 0 To UBound(c)
                        Dim tree$() = c(l).Split("-")
                        Dim aa% = tree(0), bb% = tree(1)
                        Dim cc% = Math.Max(d(aa), d(bb))
                        If d(aa) <> d(bb) Then
                            Do Until Array.IndexOf(d, cc) = -1
                                d(Array.IndexOf(d, cc)) = Math.Min(d(aa), d(bb))
                            Loop
                            oao.Add(aa) : oao.Add(bb)
                            x(aa) = x(aa) + 1 : x(bb) = x(bb) + 1
                        Else
                            GoTo 1
                        End If
                    Next
                    For l = 0 To oao.Count - 1
                        If d(oao(l)) <> d(oao(0)) Then
                            GoTo 1
                        End If
                    Next
                    For l = 0 To UBound(x)
                        If x(l) > 1 Then
                            If z.Contains(l) = False Then
                                z.Add(l)
                            Else
                                GoTo 1
                            End If
                        End If
                    Next
                    For l = 0 To UBound(c)
                        For m = 0 To y.Count - 1
                            Dim gg$() = c(l).Split("-")
                            Dim hh$() = y(m).Split("-")
                            If Math.Max(Val(gg(0)), Val(gg(1))) = Math.Max(Val(hh(0)), Val(hh(1))) And Math.Min(Val(gg(0)), Val(gg(1))) = Math.Min(Val(hh(0)), Val(hh(1))) Then
                                GoTo 1
                            End If
                        Next
                        y.Add(c(l))
                    Next
                Next
                PrintLine(3, "T")
                If 1 = 2 Then
1:
                    PrintLine(3, "F")
                End If
                If j <> a Then LineInput(i)
                For k = 1 To b - ouo
                    LineInput(i)
                Next
            Next
            PrintLine(3)
        Next
    End Sub
End Class
