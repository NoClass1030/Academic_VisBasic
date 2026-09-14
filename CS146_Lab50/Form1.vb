'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/28/2024
'Summary: This program enables a user to start and stop a timer with button clicks.
Public Class frmLab50
    Dim timerCount As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrTime.Interval = 100
        timerCount = 0
        txtTimer.Text = "0.0"
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrTime.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrTime.Stop()
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        timerCount += 1
        txtTimer.Text = (timerCount / 10.0).ToString("0.0")
    End Sub
End Class
