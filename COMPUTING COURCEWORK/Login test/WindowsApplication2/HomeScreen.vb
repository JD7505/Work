Imports System.Data.OleDb
Public Class HomeScreen
    Public Sub ButLogout_Click(sender As Object, e As EventArgs) Handles ButLogout.Click
        Hide()
        LoginScreen.txtUsername.Clear()
        LoginScreen.txtPassword.Clear()
        Modules.Attempts = 0
        LoginScreen.txtAttempts.Clear()
        LoginScreen.Show()
        Application.Restart()
    End Sub

    Private Sub ButCustdataentry_Click(sender As Object, e As EventArgs) Handles ButCustdataentry.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub Butcustdataeditor_Click(sender As Object, e As EventArgs) Handles Butcustdataeditor.Click

    End Sub

    Private Sub ButJobslist_Click(sender As Object, e As EventArgs) Handles ButJobslist.Click

    End Sub

    Private Sub ButEmail_Click(sender As Object, e As EventArgs) Handles ButEmail.Click

    End Sub

    Private Sub Butpartlistorder_Click(sender As Object, e As EventArgs) Handles Butpartlistorder.Click

    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButAdminPan_Click(sender As Object, e As EventArgs) Handles ButAdminPan.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        If Modules.AccessroleID = "4" Or "3" Or "2" Or "1" Then
            Me.Hide()
            AdminPannel.Show()
            MessageBox.Show("ADMIN: Use carefully, changed made on the next screen cannot be changed!", "Access Granted", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        Else
            MessageBox.Show("If you believe this to be an issue, please contact an Administrator!", "Access Denied", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub ButVersionInfo_Click(sender As Object, e As EventArgs) Handles ButVersionInfo.Click
        Me.Hide()
        VersionInfo.Show()
    End Sub
End Class