Imports System.Data.OleDb
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()

        End If
        If Len(Trim(Username.Text)) = 0 Then
            MessageBox.Show("Please Enter Username", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Username.Focus()

        End If
        Try
            Dim myconnection As OleDbConnection
            myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Documents\PMS_File.accdb")
            Dim mycommand As OleDbCommand
            mycommand = New OleDbCommand("SELECT Username,Password FROM Registered WHERE Username=@Username AND Password=@Password", myconnection)
            Dim uName As New OleDbParameter("@Username", SqlDbType.VarChar)
            Dim UPassword As New OleDbParameter("@Password", SqlDbType.VarChar)
            uName.Value = Username.Text
            UPassword.Value = Password.Text

            mycommand.Parameters.Add(uName)
            mycommand.Parameters.Add(UPassword)
            mycommand.Connection.Open()

            Dim myreader As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If myreader.HasRows Then
                myreader.Read()
                Login = myreader(Login)


            End If
            If Login = Nothing Then
                MsgBox("Logib is Faied..try again!", MsgBoxStyle.Critical, "login Denied")
                Password.Clear()
                Username.Clear()
                Password.Focus()
            Else
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1
                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next
                Form2.ToolStripStatusLabel2.Text = Username.Text
                Me.Hide()
                Form2.Show()

            End If
            mycommand.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        Username.Clear()
        Password.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit ", "Closing Exms",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Sign_up.Show()
        Sign_up.txtUsername.Text = ""
        Sign_up.txtPassword.Text = ""
        Sign_up.txtPicture.Text = ""
        Sign_up.txtUsername.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
