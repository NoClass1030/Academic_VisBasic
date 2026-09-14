'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/06/2024
'Summary: This program allows the user to search an array for a full or partial match, which is highlighted after the search button is clicked

Imports System.IO
Imports System.Windows.Forms
Public Class frmLab33
    'Declare array variable to hold imported txt file
    Dim heroArray As String()
    Private Sub frmLab33_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Assign txt file to array
        heroArray = File.ReadAllLines("Super Hero Names.txt")

        For Each heroName As String In heroArray
            lstDisplay.Items.Add(heroName)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declare variables
        Dim searchTerm As String = txtSearchBar.Text.Trim()

        'Utilize LINQ to search array for matches
        Dim query = From hero In heroArray
                    Where hero.ToLower().Contains(searchTerm.ToLower())
                    Order By hero Ascending
                    Select hero

        lstDisplay.Items.Clear()
        lstDisplay.Items.AddRange(query.ToArray())
    End Sub
End Class
