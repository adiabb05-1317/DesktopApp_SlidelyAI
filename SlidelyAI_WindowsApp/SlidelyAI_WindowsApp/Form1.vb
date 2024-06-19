Public Class Form1

    ' This method is called when the "Create New Submission" button is clicked or Ctrl+N is pressed
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Create an instance of the CreateSubmissionForm
        Dim createForm As New CreateSubmissionForm()
        ' Show the form as a modal dialog
        createForm.ShowDialog()
    End Sub

    ' This method is called when the "View Submissions" button is clicked or Ctrl+V is pressed
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Create an instance of the ViewSubmissionsForm
        Dim viewForm As New ViewSubmissionsForm()
        ' Show the form as a modal dialog
        viewForm.ShowDialog()
    End Sub

    ' This overridden method handles keyboard shortcuts for the entire Form1
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmissions.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnCreateNewSubmission.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
