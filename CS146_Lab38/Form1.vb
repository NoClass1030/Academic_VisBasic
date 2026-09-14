'NAME: Nathan Emmrich
'COURSE: CS 146 01 WI24
'INSTRUCTOR: Beyers
'DATE: 04/15/2024
'SUMMARY: This program collects data from txt boxes to populate a listbox displaying the data defined by a structure in a table of family history information
Public Class frmLab39
    'Define Family Structure
    Structure Family
        Dim fullName As String
        Dim birthDate As Date
        Dim heightInches As Integer
        Dim firstCar As String
    End Structure

    Dim familyArray() As Family

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variable as structure data type
        ReDim Preserve familyArray(UBound(familyArray) + 1)

        'Define family history data inputs
        familyArray(UBound(familyArray)).fullName = txtFullName.Text
        familyArray(UBound(familyArray)).birthDate = txtDOB.Text
        familyArray(UBound(familyArray)).heightInches = CInt(txtHeight.Text)
        familyArray(UBound(familyArray)).firstCar = txtFirstCar.Text

        'Subroutine to add information to ListBox
        AddHistory()
    End Sub

    Sub AddHistory()
        'Clear listbox
        lstHistory.Items.Clear()

        'Define row template for data input
        Dim rowTemplate As String = "{0,-30} {1,-15} {2,-15} {3,-40}"

        'Add data to ListBox
        Dim headerTemplate As String = "{0,-30} {1,-15} {2,-15} {3,-40}"
        lstHistory.Items.Add(String.Format(headerTemplate, "Full Name", "Date of Birth",
                                           "Height (Inches)", "First Car"))

        For Each member As Family In familyArray
            lstHistory.Items.Add(String.Format(rowTemplate, member.fullName,
                                           member.birthDate.ToShortDateString(),
                                           member.heightInches, member.firstCar))
        Next

    End Sub

    Private Sub frmLab39_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReDim familyArray(0)
    End Sub
End Class
