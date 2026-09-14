'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/22/2024
'Summary: This program sorts through a supplied text file to evaluate the amounts of different denominations of notes.

Imports System.IO
Imports System.Windows.Forms
Public Class frmA11
    'global constants and variables
    Const washingtons As Integer = 0
    Const jeffersons As Integer = 1
    Const lincolns As Integer = 2
    Const hamiltons As Integer = 3
    Const jacksons As Integer = 4
    Const grants As Integer = 5
    Const franklins As Integer = 6

    Dim denomCount(6) As Integer
    Private Sub frmA11_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Array to hold data
        Dim readArray() As String = File.ReadAllLines("MoneyBag.txt")

        'For Each loop to count each denomination
        For Each line As String In readArray
            Dim denomType As Integer = Integer.Parse(line)

            'Select case to sort denominations
            Select Case denomType
                Case 1
                    denomCount(washingtons) += 1
                Case 2
                    denomCount(jeffersons) += 1
                Case 5
                    denomCount(lincolns) += 1
                Case 10
                    denomCount(hamiltons) += 1
                Case 20
                    denomCount(jacksons) += 1
                Case 50
                    denomCount(grants) += 1
                Case 100
                    denomCount(franklins) += 1
            End Select
        Next

        lstOutput.Items.Add("Denomination     Count")
        lstOutput.Items.Add(String.Format("{0,-32} {1}", "$1:", denomCount(washingtons)))
        lstOutput.Items.Add(String.Format("{0,-34} {1}", "$2:", denomCount(jeffersons)))
        lstOutput.Items.Add(String.Format("{0,-32} {1}", "$5:", denomCount(lincolns)))
        lstOutput.Items.Add(String.Format("{0,-33} {1}", "$10:", denomCount(hamiltons)))
        lstOutput.Items.Add(String.Format("{0,-31} {1}", "$20:", denomCount(jacksons)))
        lstOutput.Items.Add(String.Format("{0,-31} {1}", "$50:", denomCount(grants)))
        lstOutput.Items.Add(String.Format("{0,-30} {1}", "$100:", denomCount(franklins)))

        'For loop to name denominations for output

    End Sub
End Class
