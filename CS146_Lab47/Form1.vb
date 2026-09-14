
Imports System.Xml.Linq

Public Class Form1
    Structure Transcript
        Dim year As Integer
        Dim term As String
        Dim Course As String
        Dim Section As Integer
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        xmlData()
    End Sub

    Sub xmlData()
        Dim xmlArray As XElement =
            XElement.Load("SemesterInfo.xml")
        Dim transcripts As New List(Of Transcript)()

        Dim semesterNodes = From semester In xmlArray.<Semester>
                            Select New With {
                                .Year = semester.<Year>.Value,
                                .Term = semester.<Term>.Value,
                                .Course = semester.<Course>.Value,
                                .Section = semester.<Section>.Value
                            }

        For Each semesterNode In semesterNodes
            Dim transcript As New Transcript() With {
                .year = semesterNode.Year,
                .term = semesterNode.Term,
                .Course = semesterNode.Course,
                .Section = semesterNode.Section
            }
            transcripts.Add(transcript)
        Next

        For Each transcript In transcripts
            ListBox1.Items.Add(transcript)
        Next
    End Sub

End Class
