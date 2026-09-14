'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/22/2024
'SUMMARY: This program allows the user to edit a list of authors from an external file and rewrite the file after edits are made

Imports System.IO
Imports System.Windows.Forms

Public Class frmLab46
    'Declare global array and file path
    Dim authorList As List(Of String)
    Dim filePath As String = " "
    Dim rowTemplate As String = "{0,-30} {1,-30} {2,-30} {3,-30} {4,-30}"
    Private Sub frmLab45_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Use if statement to determine if file exists
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If openDialog.ShowDialog = DialogResult.OK Then
            filePath = openDialog.FileName

            If File.Exists(filePath) Then
                authorList = New List(Of String)(File.ReadAllLines(filePath))

                For Each author In authorList
                    Dim authorFields() As String = author.Split(","c)
                    Dim formatString As String = String.Format(rowTemplate, authorFields)
                    lstDisplayAuthor.Items.Add(formatString)
                Next
            End If
        Else
            MessageBox.Show("File does not exist!")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectIdx As Integer = lstDisplayAuthor.SelectedIndex

        If selectIdx >= 0 Then
            Dim editAuthor As String = InputBox("Enter the edited author information:",
                                                "Edit Author", lstDisplayAuthor.SelectedItem.ToString())
            If Not String.IsNullOrEmpty(editAuthor) Then
                authorList(selectIdx) = editAuthor
                lstDisplayAuthor.Items.Clear()
                For Each author As String In authorList
                    lstDisplayAuthor.Items.Add(author)
                Next
            End If
        Else
            MessageBox.Show("Please select an author to edit")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If saveDialog.ShowDialog = DialogResult.OK Then
            Dim writer As StreamWriter = New StreamWriter(filePath)

            For Each author In authorList
                writer.WriteLine(author)
            Next

            MessageBox.Show("File Saved Successfully!")
        End If
    End Sub
End Class
