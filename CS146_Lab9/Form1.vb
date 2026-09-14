'Name: Nathan Emmrich
'Course:CS 146
'Section: 01
'Summary: This program calculates the composition of coins from a given amount of change less than or equal to 99 cents.

Public Class frmCoinCompCalc
    Private Sub btnCoinComp_Click(sender As Object, e As EventArgs) Handles btnCoinComp.Click

        txtQuarters.Text = txtChangeAmount.Text \ 25

        txtChangeAmount.Text = txtChangeAmount.Text Mod 25

        txtDimes.Text = txtChangeAmount.Text \ 10

        txtChangeAmount.Text = txtChangeAmount.Text Mod 10

        txtNickels.Text = txtChangeAmount.Text \ 5

        txtChangeAmount.Text = txtChangeAmount.Text Mod 5

        txtPennies.Text = txtChangeAmount.Text

    End Sub

End Class
