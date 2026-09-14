'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Prof. Beyers
'Date: 03/20/2024
'Summary: This program reads the values from an external source file and displays them in a listbox using arrays
Imports System.IO
Imports System.Windows.Forms
Public Class frmLab27

    Private Sub frmLab27_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim readArray As Array = File.ReadAllLines("Digits.txt")
        Dim intArray(readArray.Length - 1) As Integer

        For i As Integer = 0 To readArray.Length - 1
            intArray(i) = Integer.Parse(readArray(i))
        Next

        lstResults.Items.Add($"{intArray.Length}")
        lstResults.Items.Add($"{intArray(0)}")
        lstResults.Items.Add($"{intArray(intArray.Length - 1)}")

        Dim sum As Integer = 0
        For Each int As Integer In intArray
            sum += int
        Next
        lstResults.Items.Add($"{sum}")

        Dim max As Integer = Integer.MinValue
        For Each int As Integer In intArray
            If int > max Then
                max = int
            End If
        Next
        lstResults.Items.Add($"{max}")

        Dim min As Integer = Integer.MaxValue
        For Each int As Integer In intArray
            If int < min Then
                min = int
            End If
        Next
        lstResults.Items.Add($"{min}")

        Dim average As Double = sum / intArray.Length
        lstResults.Items.Add($"{Math.Round(average)}")
    End Sub
End Class
