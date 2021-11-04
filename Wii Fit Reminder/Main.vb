Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.plusplus, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub CreditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditButton.Click
        MessageBox.Show("Created by SecretShopperServicing", "Credit ...")
    End Sub

    Private Sub ByeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByeButton.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FatRadio.CheckedChanged

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
End Class
