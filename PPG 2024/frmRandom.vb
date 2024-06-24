Public Class frmRandom

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Dim randoms(1) As Integer
        For i As Integer = 0 To randoms.Length - 1
            randoms(i) = GetRandom(1, 3)
            Label1.Text = randoms(i)
            If randoms(i) = 1 Then
                PictureBox1.Image = My.Resources.Apel1
            ElseIf randoms(i) = 2 Then
                PictureBox1.Image = My.Resources.Apel2
            Else

            End If
        Next
    End Sub

    Private Sub frmRandom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class