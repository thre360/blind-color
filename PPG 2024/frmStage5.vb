Public Class frmStage5
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Jawaban anda benar")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Jawaban anda salah")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Jawaban anda salah")
    End Sub

    Private isPictureBox3Visible As Boolean = True
    Private isPictureBox1Visible As Boolean = True
    Private isPictureBox2Visible As Boolean = True
    Private isPictureBox8Visible As Boolean = True

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
            MessageBox.Show("ANDA KALAH")
            Me.Close()
            frmUtama.Show()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MessageBox.Show("Jawaban anda benar")
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
            MessageBox.Show("ANDA KALAH")
            Me.Close()
            frmUtama.Show()
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
            MessageBox.Show("ANDA KALAH")
            Me.Close()
            frmUtama.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MessageBox.Show("Jawaban anda benar")
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
            MessageBox.Show("ANDA KALAH")
            Me.Close()
            frmUtama.Show()
        End If
    End Sub

    Private Sub frmStage5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class