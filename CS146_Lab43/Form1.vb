'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/18/2024
'SUMMARY: This program allows the user to utilize an open file dialogue box to display a list of authors. It also allows the user to save the data and utilize a linq query to sort the data by author name.

Imports System.IO
Imports System.Linq
Public Class frmLab43
    'Declare global Array
    Dim authorArray() As String

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        'Declare and utilize OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv| All Files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            authorArray = File.ReadAllLines("Authors.csv")
            DisplayAuthors()
        End If
    End Sub

    Sub DisplayAuthors()
        'Declare display template
        Dim rowTemplate As String = "{0,-25} {1,-20} {2,-20} {3,-10} {4,-20}"

        'clear lstDisplay
        lstDisplay.Items.Clear()

        'Add header row
        lstDisplay.Items.Add(String.Format(rowTemplate, "Author", "Max Estimated Sales", "Original Language", "# of Books", "Nationality"))

        'Separate data into fields
        For i As Integer = 0 To authorArray.Length - 1
            Dim authorData As String = authorArray(i)
            Dim fields() As String = authorData.Split(","c)

            lstDisplay.Items.Add(String.Format(rowTemplate, fields(0), fields(1), fields(2), fields(3), fields(4)))
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'display error if no file selected
        If authorArray Is Nothing Then
            MessageBox.Show("Please select a file to load")
            Return
        End If

        'LINQ query to sort info
        Dim authorSort = authorArray.OrderBy(Function(line) line.Split(","c)(0).Split(" "c).Last()).ToArray()

        'WriteAllLines to overwrite file
        File.WriteAllLines("Authors.csv", authorSort)

        'Display successful save message
        MessageBox.Show("File has been saved successfully.")
    End Sub
End Class
