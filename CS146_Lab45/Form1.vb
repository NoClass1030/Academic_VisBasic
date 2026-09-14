'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/22/2024
'SUMMARY: This program allows the user to edit a list of authors from an external file and rewrite the file after edits are made

Imports System.IO
Imports System.Linq
Public Class frmLab45
    'Declare global array and file path
    Dim authorList() As String
    Dim filePath As String = "Authors.csv"
    Dim rowTemplate As String = "{0,-30} {1,-30} {2,-30} {3,-30} {4,-30}"
    Private Sub frmLab45_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Use if statement to determine if file exists
        If File.Exists(filePath) Then
            Dim reader As StreamReader = New StreamReader(filePath)
            Dim fileLines As New List(Of String)

            Do While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim authorFields() As String = line.Split(","c)
                Dim formatAuthors As String = String.Format(rowTemplate, authorFields)
                fileLines.Add(formatAuthors)
            Loop
            reader.Close()

            ReDim authorList(fileLines.Count - 1)
            authorList = fileLines.ToArray()

            For Each author In authorList
                lstAuthorDisplay.Items.Add(author)
            Next

        Else
            MessageBox.Show("File does not exist!")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectIdx As Integer = lstAuthorDisplay.SelectedIndex

        If selectIdx >= 0 Then
            Dim editAuthor As String = InputBox("Enter the edited author information:",
                                                "Edit Author", lstAuthorDisplay.SelectedItem.ToString())
            If Not String.IsNullOrEmpty(editAuthor) Then
                authorList(selectIdx) = editAuthor
                lstAuthorDisplay.Items.Clear()
                For Each author As String In authorList
                    lstAuthorDisplay.Items.Add(author)
                Next
            End If
        Else
            MessageBox.Show("Please select an author to edit")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim writer As StreamWriter = New StreamWriter(filePath)

        For Each author In authorList
            writer.WriteLine(author)
        Next

        MessageBox.Show("File saved successfully.")
    End Sub
End Class
