'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/26/24
'Summary: This program allows the user to edit an xml array with the use of buttons and text boxes

Imports System.Xml.Linq
Imports System.IO
Imports System.Windows.Forms

Structure Entry
    Dim Rank As Integer
    Dim Description As String
    Dim Status As String
End Structure
Public Class frmA16
    Dim entryArray As New List(Of Entry)()
    Dim filePath As String = ""
    Dim currIdx As Integer = -1

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newEntry As New Entry()
        newEntry.Rank = entryArray.Count + 1
        newEntry.Description = txtDescript.Text
        newEntry.Status = txtStatus.Text

        entryArray.Add(newEntry)
        currIdx = entryArray.Count - 1
        MessageBox.Show("New entry has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim fileLoad As OpenFileDialog = New OpenFileDialog()

        If fileLoad.ShowDialog = DialogResult.OK Then
            filePath = fileLoad.FileName
            LoadInfo(filePath)
            currIdx = 0
            DisplayCurrIdx()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currIdx < entryArray.Count - 1 Then
            currIdx += 1
            DisplayCurrIdx()
        Else
            MessageBox.Show("No further entries available!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currIdx > 0 Then
            currIdx -= 1
            DisplayCurrIdx()
        Else
            MessageBox.Show("No previous entries available!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If currIdx >= 0 AndAlso currIdx < entryArray.Count Then
            entryArray(currIdx).Rank = Integer.Parse(txtRank.Text)
            entryArray(currIdx).Description = txtDescript.Text
            entryArray(currIdx).Status = txtStatus.Text
            MessageBox.Show("Entry Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Entry Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currIdx >= 0 AndAlso currIdx < entryArray.Count Then
            entryArray(currIdx).Description = txtDescript.Text
            entryArray(currIdx).Status = txtStatus.Text
            MessageBox.Show("Entry Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Entry Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub DisplayCurrIdx()
        If currIdx >= 0 AndAlso currIdx < entryArray.Count Then
            Dim currEntry As Entry = entryArray(currIdx)
            txtRank.Text = currEntry.Rank.ToString()
            txtDescript.Text = currEntry.Description
            txtStatus.Text = currEntry.Status
        End If
    End Sub

    Sub LoadInfo(filePath As String)
        Try
            Dim doc As XDocument = XDocument.Load(filePath)
            entryArray.Clear()

            For Each element In doc.Root.Elements("entry")
                Dim newEntry As New Entry()
                newEntry.Rank = Integer.Parse(element.Element("rank").Value)
                newEntry.Description = element.Element("description").Value
                newEntry.Status = element.Element("status").Value

                entryArray.Add(newEntry)
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading XML file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
