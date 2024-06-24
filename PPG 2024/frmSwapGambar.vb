Public Class frmSwapGambar
    Dim tempSource As String
    Dim tempDestination As String
    Dim Gambar1, Gambar2, Gambar3, Gambar4, tempGambar1, tempGambar2, tempGambar3, tempGambar4 As Bitmap
    Dim GambarID1, GambarID2, GambarID3, GambarID4, tempGambarID1, tempGambarID2, tempGambarID3, tempGambarID4 As String


    Private Sub frmSwapGambar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Gambar1 = My.Resources.Apel1
        Gambar2 = My.Resources.Apel2
        Gambar3 = My.Resources.Apel3
        Gambar4 = My.Resources.Apel4

        PictureBox1.Image = Gambar1
        PictureBox2.Image = Gambar3
        PictureBox3.Image = Gambar2
        PictureBox4.Image = Gambar4


        GambarID1 = PictureBox1.Name
        GambarID2 = PictureBox3.Name
        GambarID3 = PictureBox2.Name
        GambarID4 = PictureBox4.Name

        tempGambarID1 = PictureBox1.Name
        tempGambarID2 = PictureBox2.Name
        tempGambarID3 = PictureBox3.Name
        tempGambarID4 = PictureBox4.Name
    End Sub

    Public Sub cekPosisi()
        If (tempSource = "L1" And tempDestination = "R2") Or (tempSource = "L2" And tempDestination = "R1") Then
            tempGambar1 = PictureBox1.Image
            tempGambar2 = PictureBox2.Image
            PictureBox1.Image = tempGambar2
            PictureBox2.Image = tempGambar1
            If (tempGambarID1.ToString = PictureBox1.Name) And (tempGambarID2.ToString = PictureBox2.Name) Then
                tempGambarID1 = PictureBox2.Name
                tempGambarID2 = PictureBox1.Name
            Else
                tempGambarID1 = PictureBox1.Name
                tempGambarID2 = PictureBox2.Name
            End If
            MsgBox(" ID1: " + tempGambarID1.ToString + " ID2: " + tempGambarID2 + " ID3: " + tempGambarID3 + " ID4: " + tempGambarID4)
            MsgBox(" ID1: " + GambarID1.ToString + " ID2: " + GambarID2 + " ID3: " + GambarID3 + " ID4: " + GambarID4)
        ElseIf (tempSource = "L1" And tempDestination = "R3") Or (tempSource = "L3" And tempDestination = "R1") Then
            tempGambar1 = PictureBox1.Image
            tempGambar3 = PictureBox3.Image
            PictureBox1.Image = tempGambar3
            PictureBox3.Image = tempGambar1
            If (tempGambarID1.ToString = PictureBox1.Name) And (tempGambarID3.ToString = PictureBox3.Name) Then
                tempGambarID1 = PictureBox3.Name
                tempGambarID3 = PictureBox1.Name
            Else
                tempGambarID1 = PictureBox1.Name
                tempGambarID3 = PictureBox3.Name
            End If
        ElseIf (tempSource = "L1" And tempDestination = "R4") Or (tempSource = "L4" And tempDestination = "R1") Then
            tempGambar1 = PictureBox1.Image
            tempGambar4 = PictureBox4.Image
            PictureBox1.Image = tempGambar4
            PictureBox4.Image = tempGambar1
            If (tempGambarID1.ToString = PictureBox1.Name) And (tempGambarID4.ToString = PictureBox4.Name) Then
                tempGambarID1 = PictureBox4.Name
                tempGambarID4 = PictureBox1.Name
            Else
                tempGambarID1 = PictureBox1.Name
                tempGambarID4 = PictureBox4.Name
            End If
        ElseIf (tempSource = "L2" And tempDestination = "R3") Or (tempSource = "L3" And tempDestination = "R2") Then
            tempGambar2 = PictureBox2.Image
            tempGambar3 = PictureBox3.Image
            PictureBox2.Image = tempGambar3
            PictureBox3.Image = tempGambar2
            If (tempGambarID2.ToString = PictureBox2.Name) And (tempGambarID3.ToString = PictureBox3.Name) Then
                tempGambarID2 = PictureBox3.Name
                tempGambarID3 = PictureBox2.Name
            Else
                tempGambarID2 = PictureBox2.Name
                tempGambarID3 = PictureBox3.Name
            End If
        ElseIf (tempSource = "L2" And tempDestination = "R4") Or (tempSource = "L4" And tempDestination = "R2") Then
            tempGambar2 = PictureBox2.Image
            tempGambar4 = PictureBox4.Image
            PictureBox2.Image = tempGambar4
            PictureBox4.Image = tempGambar2
            If (tempGambarID2.ToString = PictureBox2.Name) And (tempGambarID4.ToString = PictureBox4.Name) Then
                tempGambarID2 = PictureBox4.Name
                tempGambarID4 = PictureBox2.Name
            Else
                tempGambarID2 = PictureBox2.Name
                tempGambarID4 = PictureBox4.Name
            End If
        ElseIf (tempSource = "L3" And tempDestination = "R4") Or (tempSource = "L4" And tempDestination = "R3") Then
            tempGambar3 = PictureBox3.Image
            tempGambar4 = PictureBox4.Image
            PictureBox3.Image = tempGambar4
            PictureBox4.Image = tempGambar3
            If (tempGambarID3.ToString = PictureBox3.Name) And (tempGambarID4.ToString = PictureBox4.Name) Then
                tempGambarID3 = PictureBox4.Name
                tempGambarID4 = PictureBox3.Name
            Else
                tempGambarID3 = PictureBox3.Name
                tempGambarID4 = PictureBox4.Name
            End If
        End If
    End Sub

    Public Sub cekKebenaranGambar()
        If GambarID1.ToString = tempGambarID1.ToString And GambarID2.ToString = tempGambarID2.ToString And GambarID3.ToString = tempGambarID3.ToString And GambarID4.ToString = tempGambarID4.ToString Then
            MsgBox("Gambar Benar", vbOKOnly)
        Else
            MsgBox("Jawaban salah", vbOKOnly)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            'MsgBox("Left Button Clicked")
            'PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
            'PictureBox1.Padding = New System.Windows.Forms.Padding(10)
            tempSource = "L1"
        End If
        If e.Button = MouseButtons.Right Then
            tempDestination = "R1"
            cekPosisi()
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            tempSource = "L2"
        End If
        If e.Button = MouseButtons.Right Then
            tempDestination = "R2"
            cekPosisi()
        End If
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        If e.Button = MouseButtons.Left Then
            tempSource = "L3"
        End If
        If e.Button = MouseButtons.Right Then
            tempDestination = "R3"
            cekPosisi()
        End If
    End Sub

    Private Sub PictureBox4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown
        If e.Button = MouseButtons.Left Then
            tempSource = "L4"
        End If
        If e.Button = MouseButtons.Right Then
            tempDestination = "R4"
            cekPosisi()
        End If
    End Sub

    Private Sub btnKirimJawaban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimJawaban.Click
        cekKebenaranGambar()
    End Sub
End Class