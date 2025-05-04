Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtadmin_TextChanged(sender As Object, e As EventArgs) Handles txtadmin.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lines() As String = System.IO.File.ReadAllLines("user.txt")
        Dim username = txtadmin.Text
        Dim password = txtpassword.Text
        Dim expectedRole = "Student"

        Dim found As Boolean = False

        For Each line In lines
            Dim parts() As String = line.Split(","c)
            If parts.Length = 3 Then
                If parts(0) = username AndAlso parts(1) = password AndAlso parts(2) = expectedRole Then
                    found = True
                    Exit For
                End If
            End If
        Next

        If found Then
            MessageBox.Show("Login successful!")

            Dim reservationForm As New ReservationForm()
            reservationForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid login or role mismatch.")
        End If
    End Sub


    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterForm.Show()
        Me.Hide()
    End Sub
End Class