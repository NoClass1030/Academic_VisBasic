'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/14/2024
'SUMMARY: This program is designed to use LINQ queries to search for artist in the provided csv file and display each distinct artist name.

'Import system utilities
Imports System.Array
Imports System.IO

Public Class frmLab37
    'Declare constants for LINQ Query
    Const DateInt As Integer = 0
    Const RankInt As Integer = 1
    Const SongInt As Integer = 2
    Const ArtistInt As Integer = 3

    Private Sub frmLab37_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Declare and assign array to read input file
        Dim readArray() As String = File.ReadAllLines("Billboard Hot100 2001 to 2015.csv")

        'LINQ query to search for desired data
        Dim query = From lines In readArray
                    Let fields = lines.Split(","c)
                    Let dateField = fields(DateInt)
                    Let rankField = fields(RankInt)
                    Let songField = fields(SongInt)
                    Let artistField = fields(ArtistInt)
                    Order By artistField Ascending
                    Select New With
                        {
                            .dateField = dateField,
                            .rankField = rankField,
                            .songField = songField,
                            .artistField = artistField
                        }

        'Declare and assign a function to sort out each distinct name and remove duplicates
        Dim distinctArtist = query.Select(Function(item) item.artistField).Distinct()

        'Loop to add and display artist names to ListBox
        For Each artist In distinctArtist
            lstDisplay.Items.Add(artist)
        Next
    End Sub
End Class
