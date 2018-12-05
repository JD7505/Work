Imports System.Data.OleDb
Public Class Accountcreation
    Private Sub Buttonaccountcreate_Click(sender As Object, e As EventArgs) Handles Buttonaccountcreate.Click
        Dim con As New OleDb.OleDbConnection
        Dim dataFile As String
        Dim connString As String
        Dim cmd As New OleDb.OleDbCommand
        Dim strSQL As String


        dataFile = "E:\Coding enviroments\COMPUTING COURCEWORK\PoEDatabase.accdb"
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'Defining the connection string
        con.ConnectionString = connString & dataFile
        'Opening connection to the database
        con.Open()
        MsgBox("connect opened")

        '*******************************************************
        Dim roleID As Integer
        If cmbBRole.Text = "Founder" Then
            roleID = 1
        ElseIf cmbBRole.Text = "Owner" Then
            roleID = 2
        ElseIf cmbBRole.Text = "SuperAdmin" Then
            roleID = 3
        ElseIf cmbBRole.Text = "Admin" Then
            roleID = 4
        ElseIf cmbBRole.Text = "Dev" Then
            roleID = 5
        ElseIf cmbBRole.Text = "HeadTech" Then
            roleID = 6
        ElseIf cmbBRole.Text = "Technician" Then
            roleID = 7
        ElseIf cmbBRole.Text = "HeadSales" Then
            roleID = 8
        ElseIf cmbBRole.Text = "SalesAssistant" Then
            roleID = 9
        ElseIf cmbBRole.Text = "Trainee" Then
            roleID = 10
        End If

        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("ddMMMyyyy")
        strSQL = "INSERT INTO logins(ID, Username, [Password], RoleID, RegDate, FirstName, Surname) " &
        "VALUES('" & Me.txtID.Text & "','" & Me.txtUsername.Text & "','" & Me.txtpassword.Text & "','" & roleID & "','" & strDate & "','" & Me.txtFirstname.Text & "','" & Me.Txtsurname.Text & "')"


        cmd = New OleDb.OleDbCommand(strSQL, con)
        cmd.ExecuteNonQuery()

        MsgBox("Record saved successfully!!")

        con.Close()
    End Sub
    Private Sub ButBackAccount_Click(sender As Object, e As EventArgs) Handles ButBackAccount.Click
        LoginScreen.Show()
        Me.Close()
        txtFirstname.Clear()
        Txtsurname.Clear()
        txtUsername.Clear()
        txtpassword.Clear()
        cmbBRole.ResetText()
        txtID.Clear()
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBRole.SelectedIndexChanged

    End Sub
End Class