Public Class frmQandAXML

    Const num_Col As Integer = 4
    Const Idx_Row_ID As Integer = 0
    Const Idx_Question As Integer = 1
    Const Idx_Answer As Integer = 2
    Const Idx_Score As Integer = 3

    Const Max_Time_Beginner As String = "30"
    Const Max_Time_Intermediate As String = "20"
    Const Max_Time_Advanced As String = "10"

    Structure QandA
        Dim questionNumber As Integer
        Dim question As String
        Dim answer As String
        Dim hint As String
        Dim answerCorrect As Boolean
    End Structure

    Dim popCulture() As QandA
    Dim maxTime As String = Max_Time_Beginner

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmQandAAboutBox.ShowDialog()
    End Sub

    Private Sub frmQandAXML_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not loadFile() Then
            Me.Close()
        Else
            ToolTip1.Initial Delay = 200
            ToolTip1.AutoPopDelay = 10000
            ToolTip1.ReshowDelay = 50

            dgvResults.ColumnCont = num_Col
        End If
    End Sub

    Public Function loadFile() As Boolean

    End Function

    Private Sub countDown()
Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

    Private Sub evalAnswer()

    End Sub

    Public Sub resetTimer()

    End Sub
End Class