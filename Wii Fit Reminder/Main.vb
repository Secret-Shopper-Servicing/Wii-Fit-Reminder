Public Class Main
    Dim type As String
    Dim interval As Integer
    Dim wait As Boolean
    Dim radioSelect As String
    Dim r As New Random
    Dim voiceline As Integer

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub


    Private Sub CreditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditButton.Click
        MessageBox.Show("Created by oscie - https://oscie.net/en/", "Credits")
    End Sub

    Private Sub ByeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByeButton.Click
        Remind.Close()
        Timer1.Enabled = False
        Me.Close()
        Application.Exit()
        End
    End Sub

    Private Sub EasyRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles EasyRadio.MouseHover
        ToolTip1.SetToolTip(EasyRadio, "Easy Intensity - Play every 24 Hours")
    End Sub

    Private Sub ExpertRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExpertRadio.MouseHover
        ToolTip1.SetToolTip(ExpertRadio, "Expert Intensity - Play every 6 Hours")
    End Sub

    Private Sub MedRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MedRadio.MouseHover
        ToolTip1.SetToolTip(MedRadio, "Intermediate Intensity - Play every 12 Hours")
    End Sub


    Private Sub ExpertRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertRadio.CheckedChanged
        type = "1 hours"
        IntervalBox.Text = type
        radioSelect = "Expert"
    End Sub

    Private Sub MedRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedRadio.CheckedChanged
        type = "12 hours"
        IntervalBox.Text = type
        radioSelect = "Intermediate"
    End Sub

    Private Sub EasyRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyRadio.CheckedChanged
        type = "24 hours"
        IntervalBox.Text = type
        radioSelect = "Easy"
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        wait = True
        If radioSelect = "Expert" Then
            interval = 21600000
            Timer1.Interval = interval
            Timer1.Enabled = True
            MessageBox.Show("Saved. You have chosen " & radioSelect & "." & vbNewLine & "The " & interval / 3600000 & " Hour Interval has been saved.")
            Me.Close()
        ElseIf radioSelect = "Intermediate" Then
            interval = 43200000
            Timer1.Interval = interval
            Timer1.Enabled = True
            MessageBox.Show("Saved. You have chosen " & radioSelect & "." & vbNewLine & "The " & interval / 3600000 & " Hour Interval has been saved.")
            Me.Close()
        ElseIf radioSelect = "Easy" Then
            interval = 86400000
            Timer1.Interval = interval
            Timer1.Enabled = True
            MessageBox.Show("Saved. You have chosen " & radioSelect & "." & vbNewLine & "The " & interval / 3600000 & " Hour Interval has been saved.")
            Me.Close()
        Else
            MessageBox.Show("You need to select an option.", "Error")
            Me.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Remind.Show()
        Timer1.Enabled = True
    End Sub

    Private Sub NotifyMe_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyMe.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Application.Exit()
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ' play random voice line from wiibo
        voiceline = r.Next(1, 27)
        If voiceline = 1 Then
            My.Computer.Audio.Play(My.Resources.alldone, AudioPlayMode.Background)
        ElseIf voiceline = 2 Then
            My.Computer.Audio.Play(My.Resources.batteries, AudioPlayMode.Background)
        ElseIf voiceline = 3 Then
            My.Computer.Audio.Play(My.Resources.closeeyes, AudioPlayMode.Background)
        ElseIf voiceline = 4 Then
            My.Computer.Audio.Play(My.Resources.done, AudioPlayMode.Background)
        ElseIf voiceline = 5 Then
            My.Computer.Audio.Play(My.Resources.evening, AudioPlayMode.Background)
        ElseIf voiceline = 6 Then
            My.Computer.Audio.Play(My.Resources.great, AudioPlayMode.Background)
        ElseIf voiceline = 7 Then
            My.Computer.Audio.Play(My.Resources.great2, AudioPlayMode.Background)
        ElseIf voiceline = 8 Then
            My.Computer.Audio.Play(My.Resources.hello, AudioPlayMode.Background)
        ElseIf voiceline = 9 Then
            My.Computer.Audio.Play(My.Resources.keepstill, AudioPlayMode.Background)
        ElseIf voiceline = 10 Then
            My.Computer.Audio.Play(My.Resources.measuring, AudioPlayMode.Background)
        ElseIf voiceline = 11 Then
            My.Computer.Audio.Play(My.Resources.morning, AudioPlayMode.Background)
        ElseIf voiceline = 12 Then
            My.Computer.Audio.Play(My.Resources.morning2, AudioPlayMode.Background)
        ElseIf voiceline = 13 Then
            My.Computer.Audio.Play(My.Resources.normal, AudioPlayMode.Background)
        ElseIf voiceline = 14 Then
            My.Computer.Audio.Play(My.Resources.obese, AudioPlayMode.Background)
        ElseIf voiceline = 15 Then
            My.Computer.Audio.Play(My.Resources.oh, AudioPlayMode.Background)
        ElseIf voiceline = 16 Then
            My.Computer.Audio.Play(My.Resources.oh2, AudioPlayMode.Background)
        ElseIf voiceline = 17 Then
            My.Computer.Audio.Play(My.Resources.oops, AudioPlayMode.Background)
        ElseIf voiceline = 18 Then
            My.Computer.Audio.Play(My.Resources.openeyes, AudioPlayMode.Background)
        ElseIf voiceline = 19 Then
            My.Computer.Audio.Play(My.Resources.overweight, AudioPlayMode.Background)
        ElseIf voiceline = 20 Then
            My.Computer.Audio.Play(My.Resources.ready, AudioPlayMode.Background)
        ElseIf voiceline = 21 Then
            My.Computer.Audio.Play(My.Resources.starting, AudioPlayMode.Background)
        ElseIf voiceline = 22 Then
            My.Computer.Audio.Play(My.Resources.stepon, AudioPlayMode.Background)
        ElseIf voiceline = 23 Then
            My.Computer.Audio.Play(My.Resources.thanks, AudioPlayMode.Background)
        ElseIf voiceline = 24 Then
            My.Computer.Audio.Play(My.Resources.thatsit, AudioPlayMode.Background)
        ElseIf voiceline = 25 Then
            My.Computer.Audio.Play(My.Resources.thatsit2, AudioPlayMode.Background)
        ElseIf voiceline = 26 Then
            My.Computer.Audio.Play(My.Resources.underweight, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Remind.Show()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.SetToolTip(MedRadio, "Click me for sound :)")
    End Sub
End Class
