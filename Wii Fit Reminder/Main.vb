Public Class Main
    Dim type As String
    Dim interval As Integer
    Dim wait As Boolean
    Dim radioSelect As String

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        My.Computer.Audio.Stop()
        Me.Hide()
    End Sub


    Private Sub CreditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditButton.Click
        MessageBox.Show("Created by SecretShopperServicing", "Credit ...")
    End Sub

    Private Sub ByeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByeButton.Click
        Remind.Close()
        Timer1.Enabled = False
        Me.Close()
        Application.Exit()
        End
    End Sub

    Private Sub SmallRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SmallRadio.MouseHover
        ToolTip1.SetToolTip(SmallRadio, "soften button")
    End Sub

    Private Sub FatRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FatRadio.CheckedChanged
        type = "1 hours"
        IntervalBox.Text = type
        radioSelect = "fat"
    End Sub

    Private Sub HumanRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HumanRadio.CheckedChanged
        type = "12 hours"
        IntervalBox.Text = type
        radioSelect = "human"
    End Sub

    Private Sub SmallRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallRadio.CheckedChanged
        type = "24 hours"
        IntervalBox.Text = type
        radioSelect = "small"
    End Sub

    Private Sub FatRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FatRadio.MouseHover
        ToolTip1.SetToolTip(FatRadio, "For the large peoples Among Us .....")
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        wait = True
        MessageBox.Show("You have chosen " + radioSelect, "Congratulation !!!!!!!!")
        If radioSelect = "fat" Then
            MessageBox.Show("FATTY", "FAT")
            interval = 3600000
            Me.Hide()
        ElseIf radioSelect = "human" Then
            MessageBox.Show("NICE", "HUMAN")
            interval = 43200000
            Me.Hide()
        ElseIf radioSelect = "small" Then
            MessageBox.Show("SOFTEN", "SMALL")
            interval = 86400000
            Me.Hide()
        Else
            MessageBox.Show("You Need To Select the Thing You Bitch..........", "You Dum")
            Me.Show()
        End If
        Timer1.Interval = interval
        Timer1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Remind.Show()
        Timer1.Enabled = True
    End Sub

    Private Sub NotifyMe_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyMe.MouseDoubleClick
        Me.Show()
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Application.Exit()
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Show()
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.Helo, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub IntervalBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IntervalBox.MouseClick
        My.Computer.Audio.Play(My.Resources.PissedPGM, AudioPlayMode.Background)
        MessageBox.Show("That Feature is for REGISTERED User Only ..", "NO TOUCHY")
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Remind.Show()
    End Sub
End Class
