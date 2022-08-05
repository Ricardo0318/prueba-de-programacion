Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRed_Click(sender As Object, e As EventArgs) Handles BtnRed.Click
        TextColor.BackColor = Color.Red
    End Sub

    Private Sub BtnGreen_Click(sender As Object, e As EventArgs) Handles BtnGreen.Click
        TextColor.BackColor = Color.Green
    End Sub

    Private Sub BtnPurple_Click(sender As Object, e As EventArgs) Handles BtnPurple.Click
        TextColor.BackColor = Color.Purple
    End Sub

    Private Sub BtnBlue_Click(sender As Object, e As EventArgs) Handles BtnBlue.Click
        TextColor.BackColor = Color.Blue
    End Sub

    Private Sub BtnPink_Click(sender As Object, e As EventArgs) Handles BtnPink.Click
        TextColor.BackColor = Color.Pink
    End Sub
End Class
