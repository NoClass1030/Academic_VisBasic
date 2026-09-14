'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Prof. Beyers
'Date: 2/27/24
'Summary: This program displays a multiplication table after the activation button is clicked.

'This program shows examples of Anonymous blocks!!
Public Class Form1
    Private Sub btnCreateChart_Click(sender As Object, e As EventArgs) Handles btnCreateChart.Click
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        Dim x4 As Integer
        Dim x5 As Integer
        Dim x6 As Integer
        Dim x7 As Integer
        Dim x8 As Integer
        Dim x9 As Integer
        Dim x10 As Integer
        Dim rowTemplate As String = "{0,2} {1,2} {2,2} {3,2} {4,2} {5,2} {6,2} {7,2} {8,2} {9,2} {10,3}"

        lstMultChart.Items.Add(String.Format(rowTemplate, "x", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"))

        'outer row loop
        For rowIdx As Integer = 1 To 10
            'inner loop columns
            For colIdx As Integer = 1 To 10
                'Multiplication loop to calc products
                'use colIdx to determine var assigned
                Select Case colIdx
                    Case 1
                        x1 = rowIdx * colIdx
                    Case 2
                        x2 = rowIdx * colIdx
                    Case 3
                        x3 = rowIdx * colIdx
                    Case 4
                        x4 = rowIdx * colIdx
                    Case 5
                        x5 = rowIdx * colIdx
                    Case 6
                        x6 = rowIdx * colIdx
                    Case 7
                        x7 = rowIdx * colIdx
                    Case 8
                        x8 = rowIdx * colIdx
                    Case 9
                        x9 = rowIdx * colIdx
                    Case 10
                        x10 = rowIdx * colIdx
                End Select
            Next colIdx
            lstMultChart.Items.Add(String.Format(rowTemplate, rowIdx, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10))

        Next rowIdx

    End Sub
End Class