'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/07/2024
'Summary: This program takes a sentence entered by a user and converts any text that matches an external input file to textese and outputs the resulting converted sentence

'Import System Utilities
Imports System.IO
Imports System.Linq
Public Class frmA14
    'Create structure for Conversion
    Structure Conversion
        Dim English As String
        Dim Textese As String
    End Structure

    'Create array as structure type
    Dim convertArray() As Conversion

    'Create constants to separate words
    Const fullWord As Integer = 0
    Const abbrevWord As Integer = 1

    Private Sub frmA14_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Declare array to read file input
        Dim lines() As String = File.ReadAllLines("Textese.txt")

        'Reassign array to length of file read array
        convertArray = New Conversion(lines.Length - 1) {}

        'Loop to split the array and sort into english vs textese
        For i As Integer = 0 To lines.Length - 1
            Dim words() As String = lines(i).Split(","c)

            convertArray(i).English = words(fullWord)
            convertArray(i).Textese = words(abbrevWord)
        Next

        'Create LINQ query to search array for information
        Dim convertTable = From word In convertArray
                           Order By word.English Ascending
                           Select word.English, word.Textese

        'DataGridView manipulation
        dgvConvList.DataSource = convertTable.ToList()
        dgvConvList.AutoResizeColumns()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare variables for user input and output
        Dim engSentence As String = txtOrigSentence.Text
        Dim engWords() As String = engSentence.Split(" "c)
        Dim txteseSentence As String = " "

        For Each word In engWords
            'Use Linq to compare the words in the original sentence to the conversion table
            Dim matchWord = (From w In convertArray
                             Where String.Compare(w.English, word, True) = 0
                             Select w).FirstOrDefault()

            'Add the converted text to the output string
            If matchWord.English IsNot Nothing Then
                txteseSentence &= matchWord.Textese & " "
            Else
                txteseSentence &= word & " "
            End If
        Next

        'Assign the converted sentence to the corresponding textBox
        txtTextese.Text = txteseSentence.Trim()

    End Sub
End Class
