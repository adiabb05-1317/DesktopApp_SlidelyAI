<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Description = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Phonenumber = New System.Windows.Forms.Label()
        Me.GithubLink = New System.Windows.Forms.Label()
        Me.StopwatchTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.Info
        Me.btnPrevious.Location = New System.Drawing.Point(228, 356)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(123, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous(CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNext.Location = New System.Drawing.Point(393, 356)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(128, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next(CTRL+N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(225, 23)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(235, 13)
        Me.Description.TabIndex = 2
        Me.Description.Text = "Kanneti Adithya Slidely Task 3- View Submission"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(301, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 20)
        Me.txtName.TabIndex = 3
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.Location = New System.Drawing.Point(301, 225)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.Size = New System.Drawing.Size(219, 20)
        Me.txtStopwatchTime.TabIndex = 4
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(301, 189)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(219, 20)
        Me.txtGithub.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(301, 152)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(219, 20)
        Me.txtPhone.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(301, 114)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(199, 83)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(35, 13)
        Me.Name.TabIndex = 8
        Me.Name.Text = "Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(199, 121)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(32, 13)
        Me.Email.TabIndex = 9
        Me.Email.Text = "Email"
        '
        'Phonenumber
        '
        Me.Phonenumber.AutoSize = True
        Me.Phonenumber.Location = New System.Drawing.Point(199, 159)
        Me.Phonenumber.Name = "Phonenumber"
        Me.Phonenumber.Size = New System.Drawing.Size(78, 13)
        Me.Phonenumber.TabIndex = 10
        Me.Phonenumber.Text = "Phone Number"
        '
        'GithubLink
        '
        Me.GithubLink.AutoSize = True
        Me.GithubLink.Location = New System.Drawing.Point(199, 196)
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.Size = New System.Drawing.Size(58, 13)
        Me.GithubLink.TabIndex = 11
        Me.GithubLink.Text = "GithubLink"
        '
        'StopwatchTime
        '
        Me.StopwatchTime.AutoSize = True
        Me.StopwatchTime.Location = New System.Drawing.Point(199, 232)
        Me.StopwatchTime.Name = "StopwatchTime"
        Me.StopwatchTime.Size = New System.Drawing.Size(87, 13)
        Me.StopwatchTime.TabIndex = 12
        Me.StopwatchTime.Text = "StopWatch Time"
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StopwatchTime)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.Phonenumber)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name.Text = "Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Description As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Name As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phonenumber As Label
    Friend WithEvents GithubLink As Label
    Friend WithEvents StopwatchTime As Label
End Class
