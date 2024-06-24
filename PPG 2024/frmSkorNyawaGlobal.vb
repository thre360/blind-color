Public Class frmSkorNyawaGlobal
    Dim nomorJawaban As Integer = 1

    Private Sub frmSkorNyawaGlobal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Public Sub pertanyaan2()
        lblPertanyaan.Text = "Apa nama ibu kota Barito Timur?"
        rbA.Text = "Tamiyang Layang"
        rbB.Text = "Sampit"
        rbC.Text = "Palangka Raya"
        rbD.Text = "Pulang Pisau"
        gbPertanyaan.Text = "PERTANYAAN 2"
    End Sub

    Public Sub jawaban1()
        If rbA.Checked Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 10
            temp.nyawaGlobal = temp.nyawaGlobal - 0
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            pertanyaan2()
        Else
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            pertanyaan2()
        End If
    End Sub

    Public Sub jawaban2()
        If rbA.Checked Then
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 10
            temp.nyawaGlobal = temp.nyawaGlobal - 0
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            frmJawabanBintang5.Show()
        Else
            temp.skorGlobalStage1 = temp.skorGlobalStage1 + 0
            temp.nyawaGlobal = temp.nyawaGlobal - 1
            lblScore.Text = temp.skorGlobalStage1
            lblNyawa.Text = temp.nyawaGlobal
            nomorJawaban = nomorJawaban + 1
            'pertanyaan3()
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
End Class