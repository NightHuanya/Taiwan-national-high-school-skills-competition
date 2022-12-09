Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "in2.txt", 1)
        FileOpen(3, "out.txt", 2)
        For i = 1 To 2
            Dim a$ = LineInput(i)
            Dim M, N, P As New List(Of String)
            For K = 1 To Len(a)
                M.Add(Mid(a, K, 1))
                N.Add(K)
            Next
            Dim b% = M.Count - 1
            PrintLine(3, Join(N.ToArray, ""))
            For k = M.Count - 1 To 1 Step -1
                If M(M.IndexOf(N(b)) - 1) = N(b - 1) Then
                    P.Add(N(b - 1)) : N.Remove(N(b - 1))
                Else
                    Exit For
                End If
                b -= 1
            Next
            N.Remove(8) : P.Add(8)
            For k = 0 To N.Count - 1
                If M.IndexOf(N(0)) = 0 Then
                    P.Insert(0, N(0)) : N.Remove(N(0))
                ElseIf M.IndexOf(N(0)) = 7 Then
                    P.Add(N(0)) : N.Remove(N(0))
                Else
                    If P.Contains(M(M.IndexOf(N(0)) - 1)) Then
                        P.Insert(P.IndexOf(M(M.IndexOf(N(0)) - 1)) + 1, N(0)) : N.Remove(N(0))
                    ElseIf P.Contains(M(M.IndexOf(N(0)) + 1)) Then
                        P.Insert(P.IndexOf(M(M.IndexOf(N(0)) + 1)), N(0)) : N.Remove(N(0))
                    Else
                        If M.IndexOf(N(0)) > M.IndexOf(8) Then
                            P.Add(N(0)) : N.Remove(N(0))
                        Else
                            P.Insert(0, N(0)) : N.Remove(N(0))
                        End If
                    End If
                End If
                PrintLine(3, Join(N.ToArray, "") & Join(P.ToArray, ""))
                If a = Join(N.ToArray, "") & Join(P.ToArray, "") Then Exit For
            Next
            PrintLine(3)
        Next
    End Sub
End Class
