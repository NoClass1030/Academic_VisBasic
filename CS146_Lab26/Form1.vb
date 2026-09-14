Public Class frmLab26
    Private Sub btnCreateChart_Click(sender As Object, e As EventArgs) Handles btnCreateChart.Click
        Dim headerArray(11) As Integer
        For i As Integer = 0 To 11
            headerArray(i) = i + 1
        Next

        Dim multArray(12, 12) As Integer ' Adjusted array size to include index 0

        For i As Integer = 1 To 12 ' Start from index 1
            For j As Integer = 1 To 12 ' Start from index 1
                multArray(i, j) = i * j ' Use i and j directly, no need to add 1
            Next
        Next

        DisplayTable(headerArray, multArray)
    End Sub

    Private Sub DisplayTable(headerArray As Integer(), multArray As Integer(,))
        Dim columnWidth As Integer = 5 ' Fixed column width

        lstDisplayChart.Items.Clear()

        ' Display header row
        Dim header As String = "x"
        For Each headerValue In headerArray
            header &= String.Format("{0,10}", headerValue)
        Next
        lstDisplayChart.Items.Add(header)

        ' Display multiplication table
        For i As Integer = 1 To 12 ' Start from index 1
            Dim rowString As String = i.ToString().PadLeft(2) ' Start the row with the row number
            For j As Integer = 1 To 12 ' Start from index 1
                Dim valueString As String = multArray(i, j).ToString().PadLeft(columnWidth)
                rowString &= String.Format("{0,10}", valueString)
            Next
            lstDisplayChart.Items.Add(rowString)
        Next
    End Sub
End Class
