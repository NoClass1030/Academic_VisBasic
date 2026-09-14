'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/08/2024
'Summary: This program displays all information from an external input file ordered by descending year and ascending title

'Import system utilities
Imports System.IO
Imports System.Linq

Public Class frmLab35
    Private Sub frmLab35_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Declare constants
        Const yearPosition As Integer = 0
        Const titlePosition As Integer = 1
        Const uploaderPosition As Integer = 2
        Const viewsPosition As Integer = 3
        Const uploadDatePosition As Integer = 4

        'Declare template to format output data
        Dim rowTemplate As String = "{0,-4} {1,-59} {2,-30} {3,-5} {4,-10}"

        'Declare array to hold information from external file
        Dim fileLines() As String = File.ReadAllLines("YouTube Top 5 By Year.csv")

        'Utilize LINQ to search data for needed details and to sort to specified requirements
        Dim query = From line In fileLines
                    Let fields = line.Split(","c)
                    Let year = If(IsNumeric(fields(yearPosition)), CInt(fields(yearPosition)), 0)
                    Let title = fields(titlePosition)
                    Let uploader = fields(uploaderPosition)
                    Let views = If(IsNumeric(fields(viewsPosition)), CInt(fields(viewsPosition)), 0)
                    Let uploadDate = fields(uploadDatePosition)
                    Order By year Descending, title Ascending
                    Select New With
                        {
                            .Year = year,
                            .Title = title,
                            .Uploader = uploader,
                            .Views = views,
                            .UploadDate = uploadDate
                        }

        'Print header row for data
        lstSearchResults.Items.Add(String.Format(rowTemplate, "Year", "Title", "Uploader", "Views", "Upload Date"))

        'Print data in specified format for each item in the LINQ query
        For Each item In query
            lstSearchResults.Items.Add(String.Format(rowTemplate, item.Year, item.Title, item.Uploader, item.Views, item.UploadDate))
        Next
    End Sub
End Class
