'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 04/25/2024
'Summary: This program focuses on the use of multiple forms being displayed to convey information

Imports System.IO
Imports System.Windows.Forms
Public Class frmMain
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'frmAboutBox.ShowDialog()
        frmAboutBox.Show()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
