Imports System.Data.OleDb
Public Class LoginScreen
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Sub ButLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButLogin.Click
        Dim name As String = txtUsername.Text
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Logins] WHERE [Username] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "'", myConnection)
        dataFile = "E:\Coding enviroments\COMPUTING COURCEWORK\PoEDatabase.accdb"
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        myConnection.ConnectionString = connString & dataFile
        myConnection.Open()

        Dim con As New OleDb.OleDbConnection
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim FirstName As String = ""
        Dim Surname As String = ""

        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            Surname = dr("Surname").ToString
        End While


        If userFound = True And Modules.Attempts < 3 Then
            MsgBox("Login success, Welcome " & FirstName & " " & Surname)
            Hide()
            HomeScreen.Show()
        Else
            MsgBox("Login Failed, Please try again")
            If 2 - Modules.Attempts = 1 Then
                MsgBox("Username or password incorrect, you have " & 1 & " attempt left.")
            Else
                MsgBox("Username or password incorrect, you have " & 2 - Modules.Attempts & " attempts left.")
            End If
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            Modules.Attempts = Modules.Attempts + 1
            txtAttempts.Text = Modules.Attempts
            myConnection.Close()
        End If

        ' If attempts is greater than 3 the program will close'
        If Modules.Attempts = 3 Then
            MsgBox("Too many invalid login attempts")
            End
        End If
    End Sub

    Private Sub ButDisconnect_Click(sender As Object, e As EventArgs) Handles ButDisconnect.Click
        Me.Close()
        HomeScreen.Close()
    End Sub

    Private Sub ButAcount_Click(sender As Object, e As EventArgs) Handles ButAcount.Click
        Me.Hide()
        Accountcreation.Show()
    End Sub
End Class