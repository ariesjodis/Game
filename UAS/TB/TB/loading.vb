Public Class loading

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value < 100 Then
            If ProgressBar1.Value = 20 Then
                Label1.Text = "LOading....."
            ElseIf ProgressBar1.Value = 50 Then
                Label1.Text = "Waiting....."
            End If
        Else
            Timer1.Dispose()
            Me.Visible = False
            Home.Show()
            Me.Hide()
        End If
    End Sub

End Class

