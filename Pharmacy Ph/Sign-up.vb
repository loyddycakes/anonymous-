Imports System.IO.File
Imports System.IO.FileStream

Public Class Sign_up
    Private Sub Sign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PMS_FileDataSet3.Registered' table. You can move, or remove it, as needed.
        Me.RegisteredTableAdapter.Fill(Me.PMS_FileDataSet3.Registered)

    End Sub

    Private Sub btnSignUP_Click(sender As Object, e As EventArgs) Handles btnSignUP.Click
        On Error GoTo SaveErr
        RegisteredBindingSource.EndEdit()
        RegisteredTableAdapter.Update(PMS_FileDataSet3.Registered)
        MessageBox.Show("registered successfuly!")
SaveErr:
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPassword.Clear()
        txtUsername.Clear()
        txtPicture.Clear()
    End Sub

    Private Sub txtPicture_TextChanged(sender As Object, e As EventArgs) Handles txtPicture.TextChanged
        If (System.IO.File.Exists(txtPicture.Text)) Then
            PictureBox1.Image = Image.FromFile(txtPicture.Text)
        End If
        If txtPicture.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        txtPicture.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisteredBindingSource.AddNew()
    End Sub

    Private Sub LinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Me.Hide()
        Form1.Show()
        Form1.Username.Text = ""
        Form1.Password.Text = ""
        Form1.ProgressBar1.Visible = False
        Form1.Username.Focus()




    End Sub
End Class