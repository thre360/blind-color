Public Class frmTxtBox

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPertanyaan1.Text = "A" And TextBox1.Text = "N" And TextBox2.Text = "G" Then
            MessageBox.Show("JAWABAN ANDA BENAR")
        Else
            MessageBox.Show("JAWABAN SALAH")
            txtPertanyaan1.Clear()
            txtPertanyaan1.Focus()
        End If
    End Sub
End Class