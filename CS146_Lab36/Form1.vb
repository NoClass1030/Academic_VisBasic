'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/12/2024
'SUMMARY: This program allows a user to search the name or year arrays and have them displayed in the listbox in ascending order

'import system utilities
Imports System.IO
Imports System.Linq

Public Class frmLab36
    'declare constants for LINQ query
    Const Year As Integer = 0
    Const Title As Integer = 1
    Const Uploader As Integer = 2
    Const Views As Decimal = 3
    Const UploadDate As Integer = 4

    'Declare storage array
    Dim readArray() As String

    Private Sub frmLab36_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Assign file contents to array
        readArray = File.ReadAllLines("Youtube Top 5 By Year.csv")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declare search variable and formatting array
        Dim searchTerm As String = txtSearch.Text
        Dim rowTemplate As String = "{0,-4} {1,-59} {2,-30} {3,-5} {4,-10}"

        'Clear listbox
        lstDisplay.Items.Clear()

        'Differentiate between radio buttons selected
        If radYear.Checked Then
            'LINQ query to find information
            Dim query = From line In readArray
                        Let fields = line.Split(","c)
                        Let year = fields(Year)
                        Let title = fields(Title)
                        Let uploader = fields(Uploader)
                        Let views = fields(Views)
                        Let uploadDate = fields(UploadDate)
                        Where MatchYear(year, searchTerm)
                        Order By year Descending, title Ascending
                        Select New With
                            {
                                .Year = year,
                                .Title = title,
                                .Uploader = uploader,
                                .Views = views,
                                .UploadDate = uploadDate
                            }
            'Display Header
            lstDisplay.Items.Add(String.Format(rowTemplate, "Year", "Title", "Uploader", "Views", "Upload Date"))

            'Display found information
            For Each item In query
                lstDisplay.Items.Add(String.Format(rowTemplate, item.Year, item.Title, item.Uploader, item.Views, item.UploadDate))
            Next

        ElseIf radName.Checked Then
            'LINQ query to search for information
            Dim query = From line In readArray
                        Let fields = line.Split(","c)
                        Let year = fields(Year)
                        Let title = fields(Title)
                        Let uploader = fields(Uploader)
                        Let views = fields(Views)
                        Let uploadDate = fields(UploadDate)
                        Where MatchTitle(title, searchTerm)
                        Order By year Descending, title Ascending
                        Select New With
                            {
                                .Year = year,
                                .Title = title,
                                .Uploader = uploader,
                                .Views = views,
                                .UploadDate = uploadDate
                            }

            'Display table header
            lstDisplay.Items.Add(String.Format(rowTemplate, "Year", "Title", "Uploader", "Views", "Upload Date"))

            'Display found information
            For Each item In query
                lstDisplay.Items.Add(String.Format(rowTemplate, item.Year, item.Title, item.Uploader, item.Views, item.UploadDate))
            Next
        End If
    End Sub
    Private Function MatchYear(year As Integer, searchTerm As String) As Boolean
        'Declare variable
        Dim searchYear As Integer

        'Determine if there are any items matching the year
        If Integer.TryParse(searchTerm, searchYear) Then
            Return year = searchYear.ToString()
        Else
            Return False
        End If
    End Function

    Private Function MatchTitle(title As String, searchTerm As String)
        'Declare variables
        Dim lowercaseTitle As String = title.ToLower()
        Dim lowercaseSearchTerm As String = searchTerm.ToLower()

        'Return matching titles containing search term
        Return lowercaseTitle.Contains(lowercaseSearchTerm)
    End Function
End Class
