Public Class frmLab51
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim choices() As String =
        {“Rock”, “Paper”, “Scissors”}
        Dim randomNumber As New Random
        Dim n As Integer
        'Randomly select 0, 1, or 2
        n = randomNumber.Next(0, 3)
        txtSelection.Text = choices(n)
    End Sub
End Class
