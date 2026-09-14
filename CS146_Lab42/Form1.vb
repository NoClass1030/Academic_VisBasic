'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/18/2024
'SUMMARY: This program is designed to display the distance between 2 cities from a set list when selected by a user.

Imports System.IO
Public Class frmLab42
    'Declare constants for starting and ending cities
    Const CHICAGO As Integer = 0
    Const LA As Integer = 1
    Const NY As Integer = 2
    Const PHILLY As Integer = 3

    'Declare array for information storage
    Dim roadMileage(,) As Integer = New Integer(3, 3) {}

    Private Sub frmLab41_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Add city names to ComboBoxes
        cboCity1.Items.AddRange({"CHICAGO", "LA", "NY", "PHILLY"})
        cboCity2.Items.AddRange({"CHICAGO", "LA", "NY", "PHILLY"})

        'read data from ext file
        Dim lines() As String = File.ReadAllLines("Distances.txt")

        'Assign data to the array
        For row As Integer = 0 To lines.Length - 1
            Dim distances() As String = lines(row).Split(","c)

            For col As Integer = 0 To distances.Length - 1
                roadMileage(row, col) = Integer.Parse(distances(col))
            Next
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Create index for referencing data
        Dim city1Idx As Integer = cboCity1.SelectedIndex
        Dim city2Idx As Integer = cboCity2.SelectedIndex

        'Display data in txt box
        txtDistance.Text = roadMileage(city1Idx, city2Idx) & " Miles"
    End Sub
End Class