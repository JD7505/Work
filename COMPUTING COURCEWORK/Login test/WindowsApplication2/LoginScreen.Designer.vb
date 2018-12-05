<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButLogin = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.Lblattempts = New System.Windows.Forms.Label()
        Me.TxtWelcome = New System.Windows.Forms.Label()
        Me.ButDisconnect = New System.Windows.Forms.Button()
        Me.ButAcount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButLogin
        '
        Me.ButLogin.Location = New System.Drawing.Point(269, 100)
        Me.ButLogin.Name = "ButLogin"
        Me.ButLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButLogin.TabIndex = 0
        Me.ButLogin.Text = "Login"
        Me.ButLogin.UseVisualStyleBackColor = True
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(208, 33)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(55, 13)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(208, 55)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(269, 52)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(112, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(269, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(112, 20)
        Me.txtUsername.TabIndex = 4
        '
        'txtAttempts
        '
        Me.txtAttempts.Location = New System.Drawing.Point(365, 123)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.ReadOnly = True
        Me.txtAttempts.Size = New System.Drawing.Size(26, 20)
        Me.txtAttempts.TabIndex = 5
        '
        'Lblattempts
        '
        Me.Lblattempts.AutoSize = True
        Me.Lblattempts.Location = New System.Drawing.Point(262, 126)
        Me.Lblattempts.Name = "Lblattempts"
        Me.Lblattempts.Size = New System.Drawing.Size(97, 13)
        Me.Lblattempts.TabIndex = 6
        Me.Lblattempts.Text = "Password Attempts"
        '
        'TxtWelcome
        '
        Me.TxtWelcome.AutoSize = True
        Me.TxtWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWelcome.Location = New System.Drawing.Point(8, 115)
        Me.TxtWelcome.Name = "TxtWelcome"
        Me.TxtWelcome.Size = New System.Drawing.Size(243, 24)
        Me.TxtWelcome.TabIndex = 7
        Me.TxtWelcome.Text = "POE Login System V0.01"
        '
        'ButDisconnect
        '
        Me.ButDisconnect.Location = New System.Drawing.Point(12, 9)
        Me.ButDisconnect.Name = "ButDisconnect"
        Me.ButDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.ButDisconnect.TabIndex = 8
        Me.ButDisconnect.Text = "Disconnect"
        Me.ButDisconnect.UseVisualStyleBackColor = True
        '
        'ButAcount
        '
        Me.ButAcount.Location = New System.Drawing.Point(12, 38)
        Me.ButAcount.Name = "ButAcount"
        Me.ButAcount.Size = New System.Drawing.Size(75, 46)
        Me.ButAcount.TabIndex = 9
        Me.ButAcount.Text = "Create Account"
        Me.ButAcount.UseVisualStyleBackColor = True
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 155)
        Me.Controls.Add(Me.ButAcount)
        Me.Controls.Add(Me.ButDisconnect)
        Me.Controls.Add(Me.TxtWelcome)
        Me.Controls.Add(Me.Lblattempts)
        Me.Controls.Add(Me.txtAttempts)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.ButLogin)
        Me.Name = "LoginScreen"
        Me.Text = "POE Staff Login v0.01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButLogin As System.Windows.Forms.Button
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtAttempts As System.Windows.Forms.TextBox
    Friend WithEvents Lblattempts As System.Windows.Forms.Label
    Friend WithEvents TxtWelcome As Label
    Friend WithEvents ButDisconnect As Button
    Friend WithEvents ButAcount As Button
End Class
