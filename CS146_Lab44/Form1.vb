'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/20/2024
'SUMMARY: This program reads data from 2 separate data files, finds the common entries and saves them to a third data file

'Import System utilities
Imports System.IO
Imports System.Linq
Public Class frmLab44
    'Utilize methods to achieve desired functions
    Dim bbChamps As New List(Of String())
    Dim fbChamps As New List(Of String())
    Dim comboChamps As New List(Of String)

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Declare subs to perform program actions
        LoadBBChamps()
        LoadFBChamps()
        FindComboChamps()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveComboChamps()
    End Sub

    Private Sub LoadBBChamps()
        Dim readArray() As String = File.ReadAllLines("College Basketball Mens Champions.csv")
        For Each line As String In readArray
            Dim fields() As String = line.Split(","c)
            bbChamps.Add(fields)
        Next
    End Sub

    Private Sub LoadFBChamps()
        Dim readArray() As String = File.ReadAllLines("College Football Mens Champions.csv")
        For Each line As String In readArray
            Dim fields() As String = line.Split(","c)
            fbChamps.Add(fields)
        Next
    End Sub

    Private Sub FindComboChamps()
        Dim bbTeams = bbChamps.Select(Function(lines) lines(1)).ToArray()
        Dim fbTeams = fbChamps.Select(Function(lines) lines(1)).ToArray()

        Dim query = bbTeams.Intersect(fbTeams).OrderBy(Function(x) x).ToArray()

        comboChamps = query.ToList()
    End Sub

    Private Sub SaveComboChamps()
        File.WriteAllLines("College BB and FB Mens Champions.csv", comboChamps)
    End Sub
End Class

