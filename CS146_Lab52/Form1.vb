'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/25/2024
'SUMMARY: 
Public Class frmLab52
    Private Sub frmLab52_Load(sender As Object, e As EventArgs) Handles Me.Load
        ttpTaxRate.SetToolTip(txtTax, "Value must be entered as a decimal, not a percentage")
        ttpPrice.SetToolTip(txtPrice, "Cannot exceed 99,999")
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Decimal
        Dim taxRate As Decimal = txtTax.Text
        Dim itemPrice As Decimal = txtPrice.Text

        total = itemPrice + ((taxRate / 100) * itemPrice)

        txtTotalCost.Text = total
    End Sub
End Class
