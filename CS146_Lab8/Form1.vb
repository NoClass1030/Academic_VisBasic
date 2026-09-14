'Name: Nathan Emmrich
'Course: CS 146
'Section: 01
'Summary: This program takes the first and last name and lucky number values from the text boxes and list them in the list box below.
Public Class Form1
    Private Sub txtFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus
        'Highlight current txtbox and dim others
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.Gray
        txtLuckyNum.BackColor = Color.Gray
    End Sub
    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus
        'Highlight current txtbox and dim others
        txtFirstName.BackColor = Color.Gray
        txtLastName.BackColor = Color.White
        txtLuckyNum.BackColor = Color.Gray
    End Sub
    Private Sub txtLuckyNum_GotFocus(sender As Object, e As EventArgs) Handles txtLuckyNum.GotFocus
        'Highlight current txtbox and dim others
        txtFirstName.BackColor = Color.Gray
        txtLastName.BackColor = Color.Gray
        txtLuckyNum.BackColor = Color.White
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Add name and lucky number to the list
        lstResults.Items.Add(txtFirstName.Text &
                             Space(3) &
                             txtLastName.Text &
                             "'s Lucky Number is: " _
                             & txtLuckyNum.Text)

        'Clear Values
        txtFirstName.Text = " "
        txtLastName.Text = " "
        txtLuckyNum.Text = " "

        'Reset focus to first name
        txtFirstName.Focus()
    End Sub
End Class
