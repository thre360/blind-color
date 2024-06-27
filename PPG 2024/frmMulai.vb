Imports System.Threading

Public Class frmMulai
    Private settingsThread As Thread
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        frmUtama.Show()
    End Sub

    Private Sub frmMulai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmSettings.CheckBox2.Checked Then
            My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        frmSettings.Show()
    End Sub

    Sub New()
        InitializeComponent()

        settingsThread = New Thread(AddressOf OpenSettings)
        settingsThread.IsBackground = True
        settingsThread.Start()
    End Sub

    Private Sub OpenSettings()
        Dim settingsForm As New frmSettings()
        settingsForm.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        frmTentang.Show()
    End Sub
End Class