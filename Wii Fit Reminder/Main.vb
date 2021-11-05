Public Class Main
    Dim type As String
    Dim interval As Integer
    Dim wait As Boolean
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub CreditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditButton.Click
        MessageBox.Show("Created by SecretShopperServicing", "Credit ...")
    End Sub

    Private Sub ByeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByeButton.Click
        Me.Close()
    End Sub

    Private Sub SmallRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SmallRadio.MouseHover
        ToolTip1.SetToolTip(SmallRadio, "soften button")
    End Sub

    Private Sub Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu.Click
        Menu.Show()
    End Sub

    Private Sub Menu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu.DoubleClick
        Menu.Show()
    End Sub

    Private Sub FatRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FatRadio.CheckedChanged
        type = "1 hours"
        interval = 1
        IntervalBox.Text = type
    End Sub

    Private Sub HumanRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HumanRadio.CheckedChanged
        type = "12 hours"
        interval = 12
        IntervalBox.Text = type
    End Sub

    Private Sub SmallRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallRadio.CheckedChanged
        type = "24 hours"
        interval = 24
        IntervalBox.Text = type
        While wait = True

        End While
    End Sub

    Private Sub FatRadio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FatRadio.MouseHover
        ToolTip1.SetToolTip(FatRadio, "For the large peoples Among Us .....")
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        wait = True
        'make it go to tray
    End Sub

    Private Sub DebugButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugButton.Click
        Remind.Show()
        Me.Hide()
    End Sub
End Class
