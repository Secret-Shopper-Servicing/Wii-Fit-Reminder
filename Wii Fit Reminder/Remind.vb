Public Class Remind
    Dim count As Integer
    Private Sub DebugButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugButton.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RefuseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefuseButton.Click
        MessageBox.Show("You have to do it!", "Uh Oh ..")
        count = count + 1
        If count = 5 Then
            MessageBox.Show("It Is Too Late Now... Good Job!", "Dead .") ' shut down windows after 5 seconds
            Me.Close()
            Main.Close()
        End If
    End Sub

    Private Sub NowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NowButton.Click
        MessageBox.Show("Good Job!", "Wii Fit")
        Me.Close()
    End Sub
End Class