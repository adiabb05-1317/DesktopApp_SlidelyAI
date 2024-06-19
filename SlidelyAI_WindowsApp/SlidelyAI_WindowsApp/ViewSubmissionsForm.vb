Imports System.Net.Http
Imports Newtonsoft.Json ' Assuming you are using Newtonsoft.Json for JSON deserialization

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private client As HttpClient
    Private baseURL As String = "http://localhost:3001" ' Adjust this as necessary for your backend

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        LoadSubmission(currentIndex)
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync($"{baseURL}/api/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim data As String = Await response.Content.ReadAsStringAsync()
                Dim submissionResponse As SubmissionResponse = JsonConvert.DeserializeObject(Of SubmissionResponse)(data)
                If submissionResponse.success Then
                    DisplaySubmission(submissionResponse.submission)
                Else
                    MessageBox.Show("Failed to fetch data: Submission not found.")
                End If
            Else
                MessageBox.Show("Failed to fetch data: Server error.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching submission: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.GithubLink
        txtStopwatchTime.Text = submission.StopwatchTime
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

Public Class SubmissionResponse
    Public Property success As Boolean
    Public Property submission As Submission
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
