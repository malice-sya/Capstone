Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class RegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = ComboBoxRole.SelectedItem.ToString()

        Dim userInfo As String = username & "," & password & "," & role

        System.IO.File.AppendAllText("user.txt", userInfo & Environment.NewLine)

        MessageBox.Show("Registered successfully!")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Function GetHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRole.Items.Clear()
        ComboBoxRole.Items.Add("Admin")
        ComboBoxRole.Items.Add("Student")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged
        ComboBoxRole.Items.Add("Admin")
        ComboBoxRole.Items.Add("Student")
    End Sub
    Private Sub RegisterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
End Class