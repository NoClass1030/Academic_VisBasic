'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/29/2024
'Summary: This program keeps a running tally of a list of shopping item costs using the ReDim Preserve function, and displays the count, minimum value, maximum value, average cost, and total cost of all items in the array holding all information
Public Class frmLab30
    'Declare global array variable
    Dim infoArray As Double()
    Dim itemCount As Integer = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Declare new item variable
        Dim newItem As Double = CDbl(txtItemCost.Text)

        'Resize array with every button click event
        ReDim Preserve infoArray(itemCount)
        infoArray(itemCount) = newItem
        itemCount += 1

        'call method to show info in listbox
        showList(infoArray)
    End Sub

    Sub showList(infoArray)
        'Declare sub variables
        Dim itemCount As Integer = infoArray.Length
        Dim minCost As Double
        Dim maxCost As Double
        Dim avgCost As Double
        Dim totalCost As Double
        Dim rowTemplate As String = "{0,-6} {1,6} {2,8}"

        If itemCount > 0 Then
            minCost = infoArray(0)
        End If

        'For loop to find minimum, maximum and total value
        For i = 0 To itemCount - 1
            If infoArray(i) < minCost Then
                minCost = infoArray(i)
            End If
            If infoArray(i) > maxCost Then
                maxCost = infoArray(i)
            End If
            totalCost = totalCost + infoArray(i)
        Next i

        'Calculation for average item cost in array
        If itemCount > 0 Then
            avgCost = totalCost / itemCount
        End If

        'List Box manipulation
        lstSummary.Items.Clear()
        lstSummary.Items.Add(String.Format(rowTemplate, "Count:", "#", itemCount))
        lstSummary.Items.Add(String.Format(rowTemplate, "Min:", "$", Format(minCost, "0.00")))
        lstSummary.Items.Add(String.Format(rowTemplate, "Max:", "$", Format(maxCost, "0.00")))
        lstSummary.Items.Add(String.Format(rowTemplate, "Avg:", "$", Format(avgCost, "0.00")))
        lstSummary.Items.Add(String.Format(rowTemplate, "Total:", "$", Format(totalCost, "0.00")))
    End Sub
End Class
