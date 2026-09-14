Public Class frmLab49
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Select Case cboTitle.SelectedItem
            Case "Mr."
                lstDisplay.Items.Add("Mr. " & txtName.Text)
            Case "Ms."
                lstDisplay.Items.Add("Ms. " & txtName.Text)
            Case "Mrs."
                lstDisplay.Items.Add("Mrs. " & txtName.Text)
            Case "Dr."
                lstDisplay.Items.Add("Dr. " & txtName.Text)
            Case "The Honorable"
                lstDisplay.Items.Add("The Honorable " & txtName.Text)
            Case "Her Highness"
                lstDisplay.Items.Add("Her Highness " & txtName.Text)
            Case "His Highness"
                lstDisplay.Items.Add("His Highness " & txtName.Text)
            Case "Add New"
                Dim userTitle As String = InputBox("Please enter your custom title:", "Title Entry")

                cboTitle.Items.Add(userTitle)
                lstDisplay.Items.Add(userTitle & " " & txtName.Text)
        End Select
    End Sub


End Class
