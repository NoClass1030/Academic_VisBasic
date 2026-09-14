'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/31/24
'Summary: This program displays an address book read from an exterior input file. It contains the ability to search the address book for a specific string or to add a new contact to the CSV file

Imports System.IO
Imports System.Windows.Forms

Public Class frmA12
    ' Define constants for array indexes
    Private Const LastNameIndex As Integer = 0
    Private Const FirstNameIndex As Integer = 1
    Private Const EmailIndex As Integer = 2
    Private Const PhoneIndex As Integer = 3

    ' Define array to store address book data
    Private addressBookData As String(,)

    Private Sub AddressBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read all lines from the CSV file into the array
        ReadAddressData()
        ' Display all information in the Listbox
        RefreshListBox()
    End Sub

    Private Sub ReadAddressData()
        ' Read all lines from the CSV file
        Dim lines() As String = File.ReadAllLines("A12AddressBook.csv")
        ' Initialize the array with the appropriate size
        addressBookData = New String(lines.Length - 1, 3) {}

        ' Populate the array with data from the file
        For contactIndex As Integer = 0 To lines.Length - 1
            Dim fields() As String = lines(contactIndex).Split(","c)
            For fieldIndex As Integer = 0 To 3
                If fieldIndex < fields.Length Then
                    addressBookData(contactIndex, fieldIndex) = fields(fieldIndex)
                Else
                    addressBookData(contactIndex, fieldIndex) = ""
                End If
            Next
        Next
    End Sub

    Private Sub RefreshListBox()
        ' Clear the Listbox
        lstAddressBook.Items.Clear()

        ' Add header row
        lstAddressBook.Items.Add(String.Format("{0,-20} {1,-20} {2,-40} {3,-30}", "Last Name", "First Name", "Email", "Phone"))

        ' Add data rows
        For contactIndex As Integer = 0 To addressBookData.GetLength(0) - 1
            lstAddressBook.Items.Add(String.Format("{0,-20} {1,-20} {2,-40} {3,-30}", addressBookData(contactIndex, LastNameIndex), addressBookData(contactIndex, FirstNameIndex), addressBookData(contactIndex, EmailIndex), addressBookData(contactIndex, PhoneIndex)))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Prompt the user to enter new contact information
        Dim newLastName As String = txtLastName.Text
        Dim newFirstName As String = txtFirstName.Text
        Dim newEmail As String = txtEmail.Text
        Dim newPhone As String = txtPhone.Text

        ' Check if any of the required fields are empty
        If String.IsNullOrEmpty(newLastName) OrElse (String.IsNullOrEmpty(newEmail) AndAlso String.IsNullOrEmpty(newPhone)) Then
            MessageBox.Show("Last Name and either Email or Phone Number are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim numRows As Integer = If(addressBookData Is Nothing, 0, addressBookData.GetLength(0))
        Dim newData(numRows, 3) As String

        ' Copy existing data to temporary array
        If addressBookData IsNot Nothing Then
            Array.Copy(addressBookData, newData, addressBookData.Length)
        End If

        ' Resize the main array
        ReDim addressBookData(numRows, 3)

        ' Copy the data back
        If addressBookData IsNot Nothing Then
            Array.Copy(newData, addressBookData, newData.Length)
        End If

        ' Add the new contact to the array
        addressBookData(numRows, LastNameIndex) = newLastName
        addressBookData(numRows, FirstNameIndex) = newFirstName
        addressBookData(numRows, EmailIndex) = newEmail
        addressBookData(numRows, PhoneIndex) = newPhone

        ' Update the ListBox to display the new contact
        RefreshListBox()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declare search variable
        Dim searchTerm As String = txtSearch.Text

        ' Loop through the address book data array to find a partial match
        For i As Integer = 0 To addressBookData.GetLength(0) - 1
            If addressBookData(i, LastNameIndex).Contains(searchTerm) OrElse
           addressBookData(i, FirstNameIndex).Contains(searchTerm) OrElse
           addressBookData(i, EmailIndex).Contains(searchTerm) OrElse
           addressBookData(i, PhoneIndex).Contains(searchTerm) Then
                ' Select the first match in the ListBox
                lstAddressBook.SelectedIndex = i + 1
                Return
            End If
        Next

        'For no matches, display:
        MessageBox.Show("No matching contact found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
