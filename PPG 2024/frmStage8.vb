Public Class frmStage8

    Private totalStages As Integer = 10
    Private currentStage As Integer = 1
    Dim nomorJawaban As Integer = 1
    Public Shared score As Integer = 0

    Private isPictureBox3Visible As Boolean = True
    Private isPictureBox1Visible As Boolean = True
    Private isPictureBox2Visible As Boolean = True
    Private isPictureBox8Visible As Boolean = True

    Public Sub jawaban1()
        If PictureBox7.Visible Then
            score += 10
            lblScore.Text = score.ToString()
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 10
            lblScore.Text = temp.skorGlobalStage1
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If isPictureBox3Visible Then
            Me.Controls.Remove(PictureBox3)
            isPictureBox3Visible = False
        ElseIf isPictureBox1Visible Then
            Me.Controls.Remove(PictureBox1)
            isPictureBox1Visible = False
        Else
            Me.Controls.Remove(PictureBox2)
            isPictureBox2Visible = False
            Me.Close()
            frmLose.Show()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If nomorJawaban = 1 Then
            jawaban1()
        End If
        Me.Close()
        frmWin.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If isPictureBox3Visible Then
            Me.Controls.Remove(PictureBox3)
            isPictureBox3Visible = False
        ElseIf isPictureBox1Visible Then
            Me.Controls.Remove(PictureBox1)
            isPictureBox1Visible = False
        Else
            Me.Controls.Remove(PictureBox2)
            isPictureBox2Visible = False
            Me.Close()
            frmLose.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If isPictureBox3Visible Then
            Me.Controls.Remove(PictureBox3)
            isPictureBox3Visible = False
        ElseIf isPictureBox1Visible Then
            Me.Controls.Remove(PictureBox1)
            isPictureBox1Visible = False
        Else
            Me.Controls.Remove(PictureBox2)
            isPictureBox2Visible = False
            Me.Close()
            frmLose.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If nomorJawaban = 1 Then
            jawaban1()
        End If
        Me.Close()
        frmWin.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If isPictureBox3Visible Then
            Me.Controls.Remove(PictureBox3)
            isPictureBox3Visible = False
        ElseIf isPictureBox1Visible Then
            Me.Controls.Remove(PictureBox1)
            isPictureBox1Visible = False
        Else
            Me.Controls.Remove(PictureBox2)
            isPictureBox2Visible = False
            Me.Close()
            frmLose.Show()
        End If
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Close()
        frmUtama.Show()
    End Sub

    Private WithEvents stage1Timer As New Timer

    Private targetDT As DateTime = DateTime.Now

    Private remainingTime As TimeSpan

    Private Sub frmStage8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = frmStage7.score.ToString()
        lblScore.Text = temp.skorGlobalStage1
        Timer1.Start()
        ResetTimer()
    End Sub

    Public Sub ResetTimer()
        targetDT = DateTime.Now
        remainingTime = TimeSpan.Zero
        Label6.Text = remainingTime.ToString("mm\:ss")
        stage1Timer.Start()
    End Sub

    Private Sub stage8Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        remainingTime = targetDT.AddSeconds(60).Subtract(DateTime.Now)
        If remainingTime.TotalMilliseconds > 0 Then
            Label6.Text = remainingTime.ToString("mm\:ss")
        Else
            stage1Timer.Stop()
            Label6.Text = "00:00"
            Me.Close()
            frmTimeout.Show()
        End If
    End Sub
End Class