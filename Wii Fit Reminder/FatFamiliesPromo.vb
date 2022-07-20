Public Class FatFamiliesPromo
    Dim closable As Boolean = False
    Private Sub FatFamiliesPromo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If closable = False Then
            PictureBox1.Image = My.Resources.PISSEDSteveLard
            Me.BackColor = Color.Maroon
            Label1.Text = "NO MANNERS!"
            Label2.Text = "You didn't even have a single second to just let the Advertisment talk! That kind of hurriedness is not healthy."
            Label3.Text = "Pro Life Advice: When you're given a solid offer, you listen to it, or you move on with your day. You don't just try and suppress it rudely!!!"
            Application.DoEvents()
            My.Computer.Audio.Play(My.Resources.PissedMiller, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.PissedMiller, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.PissedMiller, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.PissedMiller, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.Bull, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.Bull, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.Bull, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.Bull, AudioPlayMode.WaitToComplete)
            Timer1.Stop()
            closable = True
            Me.Close()
        End If
        Timer1.Stop()
    End Sub

    Private Sub FatFamiliesPromo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Miller, AudioPlayMode.Background)
        Me.BackColor = Color.MidnightBlue
        Label1.Text = "HEY, FATTY!"
        Label2.Text = "I'm here to stamp out the obesity epidemic that is sweeping the UK, one massive family at a time!"
        Label3.Text = "If you or ANYONE you know is getting a bit hefty, please give me a call at 08456 50 50 50!"
        PictureBox1.Image = My.Resources.SteveLardPointsAtU
        Timer1.Start()
        closable = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        closable = True
    End Sub
End Class