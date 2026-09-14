'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/18/2024
'SUMMARY: This program is designed to display the distance between 2 cities from a set list when selected by a user.
Public Class frmLab41
    Const CHICAGO As Integer = 0
    Const LA As Integer = 1
    Const NY As Integer = 2
    Const PHILLY As Integer = 3

    Dim roadMileage(,) As Integer = {
        {0, 2054, 802, 738},
        {2054, 0, 2786, 2706},
        {802, 2786, 0, 100},
        {738, 2706, 100, 0}
    }

    Private Sub frmLab41_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboCity1.Items.AddRange({"CHICAGO", "LA", "NY", "PHILLY"})
        cboCity2.Items.AddRange({"CHICAGO", "LA", "NY", "PHILLY"})
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim city1Idx As Integer = cboCity1.SelectedIndex
        Dim city2Idx As Integer = cboCity2.SelectedIndex

        txtDistance.Text = roadMileage(city1Idx, city2Idx) & " Miles"
    End Sub
End Class
