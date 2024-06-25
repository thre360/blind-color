Public Class frmMulai
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        frmUtama.Show()
    End Sub

    Private Sub frmMulai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class