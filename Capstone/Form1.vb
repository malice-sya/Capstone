Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem IsNot Nothing Then
            If ComboBox1.SelectedItem.ToString() = "Admin" Then
                Dim adminForm As New Form2()
                adminForm.Show()
                Me.Hide()
            ElseIf ComboBox1.SelectedItem.ToString() = "Student" Then
                Dim Form3 As New Form3()
                Form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a valid role (Admin or Student).", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Student")
        ComboBox1.Items.Add("Admin")
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class