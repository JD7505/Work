<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accountcreation
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
        Me.Labelusername = New System.Windows.Forms.Label()
        Me.Buttonaccountcreate = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Labelpassword = New System.Windows.Forms.Label()
        Me.Labelfirstname = New System.Windows.Forms.Label()
        Me.Txtsurname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Labelsurname = New System.Windows.Forms.Label()
        Me.Labelrole = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ButBackAccount = New System.Windows.Forms.Button()
        Me.cmbBRole = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Labelusername
        '
        Me.Labelusername.AutoSize = True
        Me.Labelusername.Location = New System.Drawing.Point(68, 15)
        Me.Labelusername.Name = "Labelusername"
        Me.Labelusername.Size = New System.Drawing.Size(55, 13)
        Me.Labelusername.TabIndex = 0
        Me.Labelusername.Text = "Username"
        '
        'Buttonaccountcreate
        '
        Me.Buttonaccountcreate.Location = New System.Drawing.Point(32, 201)
        Me.Buttonaccountcreate.Name = "Buttonaccountcreate"
        Me.Buttonaccountcreate.Size = New System.Drawing.Size(75, 35)
        Me.Buttonaccountcreate.TabIndex = 1
        Me.Buttonaccountcreate.Text = "Create Account"
        Me.Buttonaccountcreate.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(155, 38)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(155, 20)
        Me.txtpassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(155, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(155, 20)
        Me.txtUsername.TabIndex = 3
        '
        'Labelpassword
        '
        Me.Labelpassword.AutoSize = True
        Me.Labelpassword.Location = New System.Drawing.Point(68, 45)
        Me.Labelpassword.Name = "Labelpassword"
        Me.Labelpassword.Size = New System.Drawing.Size(53, 13)
        Me.Labelpassword.TabIndex = 4
        Me.Labelpassword.Text = "Password"
        '
        'Labelfirstname
        '
        Me.Labelfirstname.AutoSize = True
        Me.Labelfirstname.Location = New System.Drawing.Point(68, 71)
        Me.Labelfirstname.Name = "Labelfirstname"
        Me.Labelfirstname.Size = New System.Drawing.Size(57, 13)
        Me.Labelfirstname.TabIndex = 5
        Me.Labelfirstname.Text = "First Name"
        '
        'Txtsurname
        '
        Me.Txtsurname.Location = New System.Drawing.Point(155, 90)
        Me.Txtsurname.Name = "Txtsurname"
        Me.Txtsurname.Size = New System.Drawing.Size(155, 20)
        Me.Txtsurname.TabIndex = 6
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(155, 64)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(155, 20)
        Me.txtFirstname.TabIndex = 7
        '
        'Labelsurname
        '
        Me.Labelsurname.AutoSize = True
        Me.Labelsurname.Location = New System.Drawing.Point(68, 97)
        Me.Labelsurname.Name = "Labelsurname"
        Me.Labelsurname.Size = New System.Drawing.Size(49, 13)
        Me.Labelsurname.TabIndex = 9
        Me.Labelsurname.Text = "Surname"
        '
        'Labelrole
        '
        Me.Labelrole.AutoSize = True
        Me.Labelrole.Location = New System.Drawing.Point(68, 123)
        Me.Labelrole.Name = "Labelrole"
        Me.Labelrole.Size = New System.Drawing.Size(29, 13)
        Me.Labelrole.TabIndex = 10
        Me.Labelrole.Text = "Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(155, 156)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(155, 20)
        Me.txtID.TabIndex = 3
        '
        'ButBackAccount
        '
        Me.ButBackAccount.Location = New System.Drawing.Point(130, 201)
        Me.ButBackAccount.Name = "ButBackAccount"
        Me.ButBackAccount.Size = New System.Drawing.Size(89, 35)
        Me.ButBackAccount.TabIndex = 11
        Me.ButBackAccount.Text = "Back"
        Me.ButBackAccount.UseVisualStyleBackColor = True
        '
        'cmbBRole
        '
        Me.cmbBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBRole.FormattingEnabled = True
        Me.cmbBRole.Items.AddRange(New Object() {"Founder", "Owner", "SuperAdmin", "Admin", "Dev", "HeadTech", "Technician", "HeadSales", "SalesAssistant", "Trainee"})
        Me.cmbBRole.Location = New System.Drawing.Point(155, 120)
        Me.cmbBRole.MaxDropDownItems = 10
        Me.cmbBRole.Name = "cmbBRole"
        Me.cmbBRole.Size = New System.Drawing.Size(155, 21)
        Me.cmbBRole.TabIndex = 12
        '
        'Accountcreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 248)
        Me.Controls.Add(Me.cmbBRole)
        Me.Controls.Add(Me.ButBackAccount)
        Me.Controls.Add(Me.Labelrole)
        Me.Controls.Add(Me.Labelsurname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Txtsurname)
        Me.Controls.Add(Me.Labelfirstname)
        Me.Controls.Add(Me.Labelpassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonaccountcreate)
        Me.Controls.Add(Me.Labelusername)
        Me.Name = "Accountcreation"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelusername As Label
    Friend WithEvents Buttonaccountcreate As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Labelpassword As Label
    Friend WithEvents Labelfirstname As Label
    Friend WithEvents Txtsurname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Labelsurname As Label
    Friend WithEvents Labelrole As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents ButBackAccount As Button
    Friend WithEvents cmbBRole As ComboBox
End Class
