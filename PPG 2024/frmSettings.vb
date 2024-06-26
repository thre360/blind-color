Imports System.Media

Public Class frmSettings
    Private player As SoundPlayer

    Public Sub New()
        InitializeComponent()
        player = New SoundPlayer("sound.wav")
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
            My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.BackgroundLoop)
        Else
            CheckBox2.Text = "OFF"
            player.Stop()
        End If
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox2.Checked = True
        CheckBox2_CheckedChanged(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMulai.Show()
    End Sub
End Class