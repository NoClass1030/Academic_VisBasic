'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/06/2024
'Summary: This program allows the user to search an array for a distinct artist imported from a txt file

'Import IO and LINQ utility
Imports System.IO
Imports System.Linq

Public Class frmLab34
    Dim spotifyArray As String()

    Private Sub frmLab34_Load(sender As Object, e As EventArgs) Handles Me.Load
        spotifyArray = File.ReadAllLines("Spotify Weekly Top 200 Streams.csv")

        Dim artistArray = From line In spotifyArray
                          Let data = line.Split(","c)
                          Select data(2) Distinct

        Dim artists = artistArray.OrderBy(Function(artist) artist).ToList()

        For Each artist In artists
            lstDisplay.Items.Add(artist)
        Next
    End Sub
End Class
