Public Class frmSkorNyawaGlobalTimer
    Private TargetDT1, TargetDT2 As DateTime
    Private CountDownFrom1 As TimeSpan = TimeSpan.FromSeconds(10)
    Private CountDownFrom2 As TimeSpan = TimeSpan.FromSeconds(10)
    Dim nomorJawaban As Integer = 1


    Private Sub frmSkorNyawaGlobalTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        pertanyaan1()
        lblScore.Text = temp.skorGlobalStage1
        lblNyawa.Text = temp.nyawaGlobal
    End Sub

    Public Sub pertanyaan1()
        lblPertanyaan.Text = "Apa nama ibu kota Kalimantan Tengah?"
        rbA.Text = "Palangka Raya"
        rbB.Text = "Sampit"
        rbC.Text = "Pangkalanbun"
        rbD.Text = "Pulang Pisau"
        gbPertanyaan.Text = "PERTANYAAN 1"
        TPertanyaan1.Start()
    End Sub

    Public Sub pertanyaan2()
        lblPertanyaan.Text = "Apa nama ibu kota Barito Timur?"
        rbA.Text = "Tamiyang Layang"
        rbB.Text = "Sampit"
        rbC.Text = "Palangka Raya"
        rbD.Text = "Pulang Pisau"
        gbPertanyaan.Text = "PERTANYAAN 2"
        TPertanyaan2.Start()
    End Sub

    Public Sub jawaban1()
        If rbA.Checked Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 10
            temp.nyawaGlobal = temp.nyawaGlobal - 0
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            pertanyaan2()
            TPertanyaan1.Stop()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
        ElseIf rbA.Checked = False And rbB.Checked = False And rbC.Checked = False And rbD.Checked = False Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            pertanyaan2()
            TPertanyaan1.Stop()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
        Else
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            pertanyaan2()
            TPertanyaan1.Stop()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
        End If
    End Sub

    Public Sub jawaban2()
        If rbA.Checked Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 10
            temp.nyawaGlobal = temp.nyawaGlobal - 0
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            TPertanyaan2.Stop()
            'frmJawabanBintang5.Show()
        ElseIf rbA.Checked = False And rbB.Checked = False And rbC.Checked = False And rbD.Checked = False Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            TPertanyaan2.Stop()
        Else
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            TPertanyaan2.Stop()
        End If
    End Sub

    Private Sub btnKirimJawaban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimJawaban.Click
        If rbA.Checked Then
            If nomorJawaban = 1 Then
                jawaban1()
            ElseIf nomorJawaban = 2 Then
                jawaban2()
            End If
        ElseIf rbB.Checked Then
            If nomorJawaban = 1 Then
                jawaban1()
            ElseIf nomorJawaban = 2 Then
                jawaban2()
            End If
        ElseIf rbC.Checked Then
            If nomorJawaban = 1 Then
                jawaban1()
            ElseIf nomorJawaban = 2 Then
                jawaban2()
            End If
        ElseIf rbD.Checked Then
            If nomorJawaban = 1 Then
                jawaban1()
            ElseIf nomorJawaban = 2 Then
                jawaban2()
            End If
        End If
        clearCheckBox()
    End Sub

    Public Sub clearCheckBox()
        rbA.Checked = False
        rbB.Checked = False
        rbC.Checked = False
        rbD.Checked = False
    End Sub

    Private Sub TPertanyaan1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPertanyaan1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            lblWaktu.Text = ts.ToString("mm\:ss")
        Else
            lblWaktu.Text = "00:00"
            TPertanyaan1.Stop()
            'MessageBox.Show("Waktu Habis")
            jawaban1()
            pertanyaan2()
        End If
    End Sub

    Private Sub lblWaktu_Click(sender As Object, e As EventArgs) Handles lblWaktu.Click

    End Sub

    Private Sub lblPertanyaan_Click(sender As Object, e As EventArgs) Handles lblPertanyaan.Click

    End Sub

    Private Sub TPertanyaan2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPertanyaan2.Tick
        Dim ts As TimeSpan = TargetDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            lblWaktu.Text = ts.ToString("mm\:ss")
        Else
            lblWaktu.Text = "00:00"
            TPertanyaan2.Stop()
            jawaban2()
        End If
    End Sub
End Class