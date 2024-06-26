Imports System.Windows.Forms
Imports System.Media

Public Class FrmSetting

    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private player As SoundPlayer
    Public Sub New()
        player = New SoundPlayer("sound.wav")

        Me.Controls.Add(CheckBox1)
        Me.Controls.Add(CheckBox2)
        Me.Controls.Add(TextBox5)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Text = "ON"
        Else
            CheckBox1.Text = "OFF"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Text = "ON"
            player.PlayLooping()
        Else
            CheckBox2.Text = "OFF"
            player.Stop()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.Close()
    End Sub
End Class