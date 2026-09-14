'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Professor: Beyers
'Date: 03/18/2024
'Summary: This program displays a password entry box and checks for correct password entry. The GUI does not display until the password is entered.
Public Class frmLab25
    Private Sub frmLab25_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim passKey As String = "LordOfTheRings"
        Dim passEntry As Boolean = False

        Do
            Dim passwordBox As String = InputBox("Please Enter the Password:", "Password Entry Form")

            If passwordBox <> "" Then
                If passwordBox = passKey Then
                    passEntry = True
                    MessageBox.Show("You've entered the password correctly!", "Great Job!")
                Else
                    MessageBox.Show("Whoops! Please try again!", "Incorrect Password")
                End If
            End If
        Loop Until passEntry

    End Sub
End Class
