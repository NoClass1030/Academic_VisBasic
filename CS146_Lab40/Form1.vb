'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/16/2024
'SUMMARY: This program displays data in a DataGridView by the use of data structures and arrays

Imports System.IO
Imports System.Linq
Public Class frmLab40
    Structure Data
        Dim Year As Integer
        Dim Title As String
        Dim Uploader As String
        Dim Views As Decimal
        Dim UploadDate As String
    End Structure

    Private Sub frmLab40_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim readArray() As String = File.ReadAllLines("Youtube Top 5 By Year.csv")

        Dim dataArray() As Data

        dataArray = New Data(readArray.Length - 1) {}

        For i As Integer = 0 To readArray.Length - 1
            Dim parts As String() = readArray(i).Split(","c)

            dataArray(i).Year = parts(0)
            dataArray(i).Title = parts(1)
            dataArray(i).Uploader = parts(2)
            dataArray(i).Views = parts(3)
            dataArray(i).UploadDate = parts(4)

        Next

        Dim dataTable = From lines In dataArray
                        Order By lines.Year
                        Select lines.Year, lines.Title, lines.Uploader, lines.Views, lines.UploadDate

        dgvDisplay.DataSource = dataTable.ToList()
        dgvDisplay.AutoResizeColumns()

    End Sub


End Class
