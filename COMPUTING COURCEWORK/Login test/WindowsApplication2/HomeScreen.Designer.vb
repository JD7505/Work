<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Me.ButCustdataentry = New System.Windows.Forms.Button()
        Me.ButJobslist = New System.Windows.Forms.Button()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.ButEmail = New System.Windows.Forms.Button()
        Me.Butcustdataeditor = New System.Windows.Forms.Button()
        Me.Butpartlistorder = New System.Windows.Forms.Button()
        Me.ButLogout = New System.Windows.Forms.Button()
        Me.ButAdminPan = New System.Windows.Forms.Button()
        Me.ButVersionInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButCustdataentry
        '
        Me.ButCustdataentry.Location = New System.Drawing.Point(34, 63)
        Me.ButCustdataentry.Name = "ButCustdataentry"
        Me.ButCustdataentry.Size = New System.Drawing.Size(202, 77)
        Me.ButCustdataentry.TabIndex = 0
        Me.ButCustdataentry.Text = "Customer data entry form"
        Me.ButCustdataentry.UseVisualStyleBackColor = True
        '
        'ButJobslist
        '
        Me.ButJobslist.Location = New System.Drawing.Point(273, 63)
        Me.ButJobslist.Name = "ButJobslist"
        Me.ButJobslist.Size = New System.Drawing.Size(202, 77)
        Me.ButJobslist.TabIndex = 1
        Me.ButJobslist.Text = "Jobs list"
        Me.ButJobslist.UseVisualStyleBackColor = True
        '
        'Butsearch
        '
        Me.Butsearch.Location = New System.Drawing.Point(34, 146)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(202, 77)
        Me.Butsearch.TabIndex = 2
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = True
        '
        'ButEmail
        '
        Me.ButEmail.Location = New System.Drawing.Point(273, 146)
        Me.ButEmail.Name = "ButEmail"
        Me.ButEmail.Size = New System.Drawing.Size(202, 77)
        Me.ButEmail.TabIndex = 3
        Me.ButEmail.Text = "Email"
        Me.ButEmail.UseVisualStyleBackColor = True
        '
        'Butcustdataeditor
        '
        Me.Butcustdataeditor.Location = New System.Drawing.Point(34, 229)
        Me.Butcustdataeditor.Name = "Butcustdataeditor"
        Me.Butcustdataeditor.Size = New System.Drawing.Size(202, 77)
        Me.Butcustdataeditor.TabIndex = 4
        Me.Butcustdataeditor.Text = "Customer data editor"
        Me.Butcustdataeditor.UseVisualStyleBackColor = True
        '
        'Butpartlistorder
        '
        Me.Butpartlistorder.Location = New System.Drawing.Point(273, 229)
        Me.Butpartlistorder.Name = "Butpartlistorder"
        Me.Butpartlistorder.Size = New System.Drawing.Size(202, 77)
        Me.Butpartlistorder.TabIndex = 5
        Me.Butpartlistorder.Text = "Parts list and Order form"
        Me.Butpartlistorder.UseVisualStyleBackColor = True
        '
        'ButLogout
        '
        Me.ButLogout.Location = New System.Drawing.Point(374, 14)
        Me.ButLogout.Name = "ButLogout"
        Me.ButLogout.Size = New System.Drawing.Size(135, 43)
        Me.ButLogout.TabIndex = 6
        Me.ButLogout.Text = "Logout"
        Me.ButLogout.UseVisualStyleBackColor = True
        '
        'ButAdminPan
        '
        Me.ButAdminPan.Location = New System.Drawing.Point(188, 12)
        Me.ButAdminPan.Name = "ButAdminPan"
        Me.ButAdminPan.Size = New System.Drawing.Size(128, 45)
        Me.ButAdminPan.TabIndex = 7
        Me.ButAdminPan.Text = "Admin Pannel"
        Me.ButAdminPan.UseVisualStyleBackColor = True
        '
        'ButVersionInfo
        '
        Me.ButVersionInfo.Location = New System.Drawing.Point(12, 12)
        Me.ButVersionInfo.Name = "ButVersionInfo"
        Me.ButVersionInfo.Size = New System.Drawing.Size(120, 45)
        Me.ButVersionInfo.TabIndex = 8
        Me.ButVersionInfo.Text = "Version Info"
        Me.ButVersionInfo.UseVisualStyleBackColor = True
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(521, 333)
        Me.Controls.Add(Me.ButVersionInfo)
        Me.Controls.Add(Me.ButAdminPan)
        Me.Controls.Add(Me.ButLogout)
        Me.Controls.Add(Me.Butpartlistorder)
        Me.Controls.Add(Me.Butcustdataeditor)
        Me.Controls.Add(Me.ButEmail)
        Me.Controls.Add(Me.Butsearch)
        Me.Controls.Add(Me.ButJobslist)
        Me.Controls.Add(Me.ButCustdataentry)
        Me.Name = "HomeScreen"
        Me.Text = "Staff Access Terminal V1.00 "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButCustdataentry As System.Windows.Forms.Button
    Friend WithEvents ButJobslist As Button
    Friend WithEvents Butsearch As Button
    Friend WithEvents ButEmail As Button
    Friend WithEvents Butcustdataeditor As Button
    Friend WithEvents Butpartlistorder As Button
    Friend WithEvents ButLogout As Button
    Friend WithEvents ButAdminPan As Button
    Friend WithEvents ButVersionInfo As Button
End Class
