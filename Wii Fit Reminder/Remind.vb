Public Class Remind

    Private Sub WaitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitButton.Click
        If MsgBox("Are you sure you would like to postpone the timer until the next tick?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Postpone Timer") = MsgBoxResult.No Then
            Me.Close()
        Else
            MessageBox.Show("Timer has not been postponed. Have fun with Wii Fit!", "Postpone Timer")
            Me.Close()
        End If
    End Sub

    Private Sub DoneButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DoneButton.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Remind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim interval As Double
            interval = Main.Timer1.Interval / 3600000
            Label2.Text = "The " & interval & " Hour timer has ended;" & vbNewLine & "It is time for you to play Wii Fit!"
        Catch ex As Exception

        End Try
    End Sub
End Class