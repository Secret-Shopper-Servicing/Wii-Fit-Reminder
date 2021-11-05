Public Class Remind

    Private Sub RefuseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefuseButton.Click
        If MsgBox("You HAVE to do it...", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "But Bro...") = MsgBoxResult.No Then
            ' annoy more
            If MsgBox("You HAVE to do it, i MEAN it", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "But Bro...") = MsgBoxResult.No Then
                My.Computer.Audio.Play(My.Resources.AgitatedProgram, AudioPlayMode.Background)
                Process.Start("shutdown.exe", "/s /t 10 /c Shocking.")
            Else
                My.Computer.Audio.Stop()
                Me.Close()
            End If
        Else
            My.Computer.Audio.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub NowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NowButton.Click
        My.Computer.Audio.Play(My.Resources.Yay, AudioPlayMode.Background)
        MessageBox.Show("Good Job!", "Wii Fit")
        Me.Close()
    End Sub

    Private Sub Remind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.MusicMaking, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class