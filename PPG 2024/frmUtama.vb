Public Class frmUtama

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmPilihGambar.Show()
    End Sub

    Private Sub frmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bgSound, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
