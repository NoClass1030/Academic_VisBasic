'Name: Nathan Emmrich
'Course: CS 146
'Section: 01
'Date: 02/20/24
'Summary: This program displays a barchart of scores based on a max score and 3 places given values.
Public Class frmA10
    'global variables
    Const Num_Columns As Integer = 100
    Const Time_Label_Heading As String = "Time"
    Const Time_Label_1 As String = "5A - 11A"
    Const Time_Label_2 As String = "11A - 5P"
    Const Time_Label_3 As String = "5P - 11P"
    Const Time_Label_4 As String = "11P - 5A"
    Dim Time1Total As Integer = 0
    Dim Time2Total As Integer = 0
    Dim Time3Total As Integer = 0
    Dim Time4Total As Integer = 0

    Function buildBar(maxValue As Long, barValue As Long) As String
        'local variables
        Dim bar As String
        Dim starPercentofTotal As Double
        Dim starCount As Integer

        'determines percentage of total taken up by bar
        starPercentofTotal = Math.Round(maxValue / Num_Columns, 2)

        'determines number of stars to print
        starCount = CInt(barValue / starPercentofTotal)

        'creates asterisk string
        For i As Integer = 1 To starCount
            bar &= "*"
        Next

        'returns value of bar
        Return bar
    End Function

    Sub createBarChartWeekly(ByRef Time1Total As Integer, ByVal Time2Total As Integer, ByVal Time3Total As Integer, ByVal Time4Total As Integer, ByVal maxCal As Long)

        Dim headerFormat As String = "{0,-10}{1,30:N0}{2,30:N0}{3,30:N0}{4,30:N0}"
        Dim detailFormat As String = "{0,-10}{1,-100:S}"


        lstWeeklySumm.Items.Clear()

        lstWeeklySumm.Items.Add(String.Format(headerFormat, Time_Label_Heading,
                                            (maxCal * 0.25), (maxCal * 0.5),
                                            (maxCal * 0.75), (maxCal)))

        lstWeeklySumm.Items.Add(String.Format(detailFormat, Time_Label_1,
                                            buildBar(maxCal, Time1Total)))

        lstWeeklySumm.Items.Add(String.Format(detailFormat, Time_Label_2,
                                            buildBar(maxCal, Time2Total)))

        lstWeeklySumm.Items.Add(String.Format(detailFormat, Time_Label_3,
                                            buildBar(maxCal, Time3Total)))

        lstWeeklySumm.Items.Add(String.Format(detailFormat, Time_Label_4,
                                            buildBar(maxCal, Time4Total)))



    End Sub

    Sub createBarChartDaily(ByRef Time1 As Integer, ByVal Time2 As Integer, ByVal Time3 As Integer, ByVal Time4 As Integer)
        Dim rowTemplate As String = "{0,6} {1,10} {2,10} {3,10} {4,10}"

        Select Case True
            Case radSun.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Day", "5A - 11A", "11A - 5P", "5P - 11P", "11P - 5A"))
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Sun", Time1, Time2, Time3, Time4))
            Case radMon.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Mon", Time1, Time2, Time3, Time4))
            Case radTues.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Tues", Time1, Time2, Time3, Time4))
            Case radWed.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Wed", Time1, Time2, Time3, Time4))
            Case radThurs.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Thurs", Time1, Time2, Time3, Time4))
            Case radFri.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Fri", Time1, Time2, Time3, Time4))
            Case radSat.Checked
                lstDailySumm.Items.Add(String.Format(rowTemplate, "Sat", Time1, Time2, Time3, Time4))
        End Select

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'local variables
        Dim Time1 As Integer
        Dim Time2 As Integer
        Dim Time3 As Integer
        Dim Time4 As Integer

        Dim maxCal As Long = 0

        'assign values to variables
        Time1 = CInt(txtTime1.Text)
        Time2 = CInt(txtTime2.Text)
        Time3 = CInt(txtTime3.Text)
        Time4 = CInt(txtTime4.Text)
        Time1Total += Time1
        Time2Total += Time2
        Time3Total += Time3
        Time4Total += Time4
        maxCal = Time1Total + Time2Total + Time3Total + Time4Total

        'display results on bar chart
        createBarChartWeekly(Time1Total, Time2Total, Time3Total, Time4Total, maxCal)
        createBarChartDaily(Time1, Time2, Time3, Time4)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDailySumm.Items.Clear()
        lstWeeklySumm.Items.Clear()
    End Sub

End Class
