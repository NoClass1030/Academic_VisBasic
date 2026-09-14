'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/21/2024
'Summary: This program adds items from a text box into a list box, is capable of sorting it alphabetically and can search the items for a match from a search box.
Public Class frmLab28
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemArray() As String = txtAdd.Text.Split(","c)

        For Each item As String In itemArray
            Dim trimItem As String = item.Trim()
            lstOrigList.Items.Add(trimItem)
        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text
        Dim itemFound As Integer = lstOrigList.FindStringExact(searchText)

        If itemFound <> ListBox.NoMatches Then
            lstOrigList.SetSelected(itemFound, True)
            lstOrigList.TopIndex = itemFound
        Else
            MessageBox.Show("Item(s) Not Found!")

        End If
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim sortList(lstOrigList.Items.Count - 1) As String
        lstOrigList.Items.CopyTo(sortList, 0)

        Array.Sort(sortList)
        lstSortList.Items.Clear()

        For Each sortItem As String In sortList
            lstSortList.Items.Add(sortItem)
        Next

    End Sub
End Class
