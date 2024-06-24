Public Class frmUtama

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmStage1.Show()
        Me.Hide()
    End Sub

    Private Sub frmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bgSound, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
