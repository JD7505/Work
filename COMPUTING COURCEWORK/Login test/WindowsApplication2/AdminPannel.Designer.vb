<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPannel
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
        Me.ButAdminback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButAdminback
        '
        Me.ButAdminback.Location = New System.Drawing.Point(181, 12)
        Me.ButAdminback.Name = "ButAdminback"
        Me.ButAdminback.Size = New System.Drawing.Size(91, 38)
        Me.ButAdminback.TabIndex = 0
        Me.ButAdminback.Text = "Back"
        Me.ButAdminback.UseVisualStyleBackColor = True
        '
        'AdminPannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButAdminback)
        Me.Name = "AdminPannel"
        Me.Text = "AdminPannel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButAdminback As Button
End Class
