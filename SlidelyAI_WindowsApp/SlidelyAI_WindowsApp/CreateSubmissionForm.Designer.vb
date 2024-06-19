<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Description = New System.Windows.Forms.Label()
        Me.GithubLink = New System.Windows.Forms.Label()
        Me.Phonenumber = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnStopwatch = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnResetStopwatch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(211, 18)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(266, 13)
        Me.Description.TabIndex = 0
        Me.Description.Text = "Kanneti Adithya Slidely Task 3 Create Submission Form"
        '
        'GithubLink
        '
        Me.GithubLink.AutoSize = True
        Me.GithubLink.Location = New System.Drawing.Point(165, 216)
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.Size = New System.Drawing.Size(58, 13)
        Me.GithubLink.TabIndex = 19
        Me.GithubLink.Text = "GithubLink"
        '
        'Phonenumber
        '
        Me.Phonenumber.AutoSize = True
        Me.Phonenumber.Location = New System.Drawing.Point(165, 179)
        Me.Phonenumber.Name = "Phonenumber"
        Me.Phonenumber.Size = New System.Drawing.Size(78, 13)
        Me.Phonenumber.TabIndex = 18
        Me.Phonenumber.Text = "Phone Number"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(165, 141)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(32, 13)
        Me.Email.TabIndex = 17
        Me.Email.Text = "Email"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(165, 103)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(35, 13)
        Me.Name.TabIndex = 16
        Me.Name.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(303, 134)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(303, 172)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(219, 20)
        Me.txtPhone.TabIndex = 14
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(303, 209)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(219, 20)
        Me.txtGithub.TabIndex = 13
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(303, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 20)
        Me.txtName.TabIndex = 12
        '
        'btnStopwatch
        '
        Me.btnStopwatch.AutoSize = True
        Me.btnStopwatch.Location = New System.Drawing.Point(207, 264)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(58, 13)
        Me.btnStopwatch.TabIndex = 20
        Me.btnStopwatch.Text = "Stopwatch"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(303, 264)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
        Me.lblStopwatch.TabIndex = 21
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Moccasin
        Me.btnSubmit.Location = New System.Drawing.Point(204, 335)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(318, 23)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit(CTRL+S)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.SystemColors.Info
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(391, 256)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(75, 21)
        Me.btnToggleStopwatch.TabIndex = 23
        Me.btnToggleStopwatch.Text = "Toggle"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnResetStopwatch
        '
        Me.btnResetStopwatch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnResetStopwatch.Location = New System.Drawing.Point(490, 256)
        Me.btnResetStopwatch.Name = "btnResetStopwatch"
        Me.btnResetStopwatch.Size = New System.Drawing.Size(75, 21)
        Me.btnResetStopwatch.TabIndex = 24
        Me.btnResetStopwatch.Text = "Reset"
        Me.btnResetStopwatch.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnResetStopwatch)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.Phonenumber)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Description)
        Me.Name.Text = "Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents GithubLink As Label
    Friend WithEvents Phonenumber As Label
    Friend WithEvents Email As Label
    Friend WithEvents Name As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnStopwatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnResetStopwatch As Button
End Class
