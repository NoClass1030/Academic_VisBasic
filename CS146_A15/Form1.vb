'NAME:
'COURSE:
'INSTRUCTOR:
'DATE:
'SUMMARY:

Imports System.IO
Imports System.Windows.Forms

Structure JusticeData
    Dim FirstName As String
    Dim LastName As String
    Dim PresidentName As String
    Dim StateAppointedFrom As String
    Dim OathYear As Integer
    Dim LastYear As Integer
End Structure

Public Class frmA15
    Private Sub frmA15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Read data from selected file and populate DataGridView
            Dim justicesList As New List(Of JusticeData)()

            Using reader As New StreamReader(openFileDialog.FileName)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim parts As String() = line.Split(","c)

                    If parts.Length >= 6 Then
                        Dim justice As New JusticeData()

                        justice.FirstName = parts(0)
                        justice.LastName = parts(1)
                        justice.PresidentName = parts(2)
                        justice.StateAppointedFrom = parts(3)
                        Integer.TryParse(parts(4), justice.OathYear)
                        Integer.TryParse(parts(5), justice.LastYear)

                        justicesList.Add(justice)
                    End If
                End While
            End Using

            ' Display justices data in DataGridView
            dgvDisplay.DataSource = justicesList
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Text Files (*.txt)|*.txt"
        openDialog.Title = "Select Input File"

        If openDialog.ShowDialog() = DialogResult.OK Then
            Dim justices As New List(Of JusticeData)()

            Using fileReader As New StreamReader(openDialog.FileName)
                While Not fileReader.EndOfStream
                    Dim fields() As String = fileReader.ReadLine().Split(","c)
                    Dim justice As New JusticeData()
                    justice.FirstName = fields(0)
                    justice.LastName = fields(1)
                    justice.PresidentName = fields(2)
                    justice.StateAppointedFrom = fields(3)
                    justice.OathYear = Integer.Parse(fields(4))
                    justice.LastYear = Integer.Parse(fields(5))
                    justices.Add(justice)
                End While
            End Using

            ' Bind data to DataGridView
            dgvDisplay.DataSource = justices
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Calculate years without a Justice appointment
            Dim appointedYears = dgvDisplay.Rows.Cast(Of DataGridViewRow)().
                                 Select(Function(row) CInt(row.Cells("OathYear").Value)).
                                 ToList()

            Dim currentYear = DateTime.Now.Year
            Dim allYears = Enumerable.Range(1789, currentYear - 1789 + 1)
            Dim vacantYears = allYears.Except(appointedYears)

            ' Write vacant years to the output file
            Using writer As New StreamWriter(saveFileDialog.FileName)
                For Each entry In vacantYears
                    writer.WriteLine(entry)
                Next
            End Using

            MessageBox.Show("Output file saved successfully.", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
