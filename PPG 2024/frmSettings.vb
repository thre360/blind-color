Imports System.Media
Imports PPG_2024.My

Public Class frmSettings
    Private settings As New MySettings
    Private player As SoundPlayer
    Public Property SoundEnabled As Boolean

    Public Sub New()
        InitializeComponent()
        player = New SoundPlayer("sound.wav")
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Text = "ON"
            My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.BackgroundLoop)
        Else
            CheckBox2.Text = "OFF"
            player.Stop()
        End If
        SaveSettings()
    End Sub


    Private Sub SaveSettings()
        settings.SoundEnabled = CheckBox2.Checked
        settings.Save()
    End Sub
    Private Sub LoadSettings()
        CheckBox2.Checked = settings.SoundEnabled
        CheckBox2_CheckedChanged(Me, New EventArgs())
    End Sub
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSettings()
        Me.Close()
        frmMulai.Show()
    End Sub
End Class