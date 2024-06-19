Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json ' Ensure Newtonsoft.Json is installed via NuGet

Public Class CreateSubmissionForm
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private client As HttpClient

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        client = New HttpClient()
        ResetStopwatch()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        Timer1.Enabled = Not Timer1.Enabled
        If Timer1.Enabled Then
            btnToggleStopwatch.Text = "Pause Stopwatch"
        Else
            btnToggleStopwatch.Text = "Start Stopwatch"
        End If
    End Sub

    Private Sub btnResetStopwatch_Click(sender As Object, e As EventArgs) Handles btnResetStopwatch.Click
        ResetStopwatch()
    End Sub

    Private Sub ResetStopwatch()
        Timer1.Enabled = False
        elapsedTime = TimeSpan.Zero
        lblStopwatch.Text = "00:00:00"
        btnToggleStopwatch.Text = "Start Stopwatch"
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithub.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        Await SendDataToServer(name, email, phone, githubLink, stopwatchTime)
    End Sub

    Private Async Function SendDataToServer(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task
        Dim submissionData As New Dictionary(Of String, String) From {
            {"Name", name},
            {"Email", email},
            {"Phone", phone},
            {"GithubLink", githubLink},
            {"StopwatchTime", stopwatchTime}
        }

        Try
            Dim json As String = JsonConvert.SerializeObject(submissionData)
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3001/api/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data submitted successfully!")
            Else
                MessageBox.Show("Failed to submit data.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}")
        End Try
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Name.Click
        ' Empty event handler for Name click event, remove if not necessary.
    End Sub
End Class
