Imports System.Data.OleDb
Imports System.IO

Public Class Form2
    Dim sSql As String
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PMS_FileDataSet.PMS_Record' table. You can move, or remove it, as needed.
        Me.PMS_RecordTableAdapter.Fill(Me.PMS_FileDataSet.PMS_Record)
        ToolStripStatusLabel4.Text = Now
        ToolStripStatusLabel2.Text = Form1.Username.Text
        Me.Refresh()
        Button1.PerformClick()
        Timer2.Start()
        Timer2.Interval = 1000

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ToolStripStatusLabel4.Text = Now
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button1.PerformClick()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.Username.Text = ""
        Form1.Password.Text = ""
        Form1.Username.Focus()
        Form1.ProgressBar1.Visible = False
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        MessageBox.Show("'Please click SIGN-UP'")
        Form1.Username.Text = ""
        Form1.Password.Text = ""
        Form1.Username.Focus()
        Form1.ProgressBar1.Visible = False
    End Sub
End Class