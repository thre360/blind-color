Public Class frmWin
    Public Shared score As Integer = 0
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        frmUtama.Show()
    End Sub

    Private Sub frmWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = temp.skorGlobalStage1
    End Sub
End Class