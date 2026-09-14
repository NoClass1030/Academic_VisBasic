'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/31/24
'Summary: This program enables the user to search a file for a partial match to a name of a president. To accomplish this, the file is read to the program and parsed into sections as part of a structure to organize the data. Upon a search, the program displays any partial or exact matches and displays a tally of all matches to the entered search term.

'Import utilities to enable file read
Imports System.Windows.Forms
Imports System.IO
Imports System.Globalization
Public Class frmLab32
    'Declare and assign Structure as data types
    Structure ListInfo
        Dim Number As Integer
        Dim StartDate As String
        Dim EndDate As String
        Dim Name As String
    End Structure

    'Declare array as Structure type
    Dim listArray() As ListInfo
    Private Sub frmLab32_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Declare variables
        Dim readArray() As String = File.ReadAllLines("USPresWithDates.txt")

        'ReDim array to match length of input file
        ReDim listArray(readArray.Length - 1)

        'For loop to parse array into desired fields
        For i As Integer = 0 To readArray.Length - 1
            Dim sections() As String = readArray(i).Split(";"c)
            listArray(i).Number = i + 1
            listArray(i).StartDate = sections(0).Trim()
            listArray(i).EndDate = sections(1).Trim()
            listArray(i).Name = sections(2)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declare variables
        Dim search As String = txtSearch.Text.ToLower
        Dim matchCount As Integer = 0
        Dim rowTemplate As String = "{0,-5}{1,-20}{2,-20}{3,-20}"

        'Clear listBox
        lstSearchResults.Items.Clear()

        'Display table header
        lstSearchResults.Items.Add(String.Format(rowTemplate, "#", "Start Date", "End Date", "Name"))

        'For loop to search for entered text as partial or exact matches
        For Each president As ListInfo In listArray
            If president.Name.ToLower().Contains(search) Then
                lstSearchResults.Items.Add(String.Format(rowTemplate, president.Number, president.StartDate.ToString(), president.EndDate.ToString(), president.Name.ToString()))
                matchCount += 1
            End If
        Next

        'Display number of matches
        lblMatchCount.Text = matchCount.ToString()
    End Sub
End Class
