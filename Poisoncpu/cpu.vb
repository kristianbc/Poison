Public Class cpu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cup As Double = CDec(PerformanceCounter1.NextValue.ToString())
        cup = 100 - cup
        Label1.Text = cup.ToString() & "  %"
        Guna2CircleProgressBar1.Value = cup.ToString()
    End Sub

    Private Sub GunaCircleProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class