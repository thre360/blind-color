Public Class frmBerhasilSkorNyawaGlobal

    Private Sub frmBerhasilSkorNyawaGlobal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNyawaGlobal.Text = temp.nyawaGlobal
        lblSkorGlobal.Text = temp.skorGlobalStage1

        If temp.skorGlobalStage1 = "20" Then
            MessageBox.Show("Bintang 5")
        Else
            Button2.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Button 2 di klik")
    End Sub
End Class