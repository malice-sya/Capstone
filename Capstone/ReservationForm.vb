Public Class ReservationForm
    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Reservation Name"
        DataGridView1.Columns(1).Name = "Time"
        DataGridView1.Columns(2).Name = "Reservation Status"
        DataGridView1.Columns(3).Name = "Requester Name"
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub AddReservationButton_Click(sender As Object, e As EventArgs) Handles AddReservationButton.Click
        Dim reservationName As String = ReservationNameTextBox.Text
        Dim time As String = TimeTextBox.Text
        Dim status As String = StatusComboBox.SelectedItem.ToString()
        Dim requesterName As String = RequesterNameTextBox.Text
        Dim newRow As String() = {reservationName, time, status, requesterName}
        DataGridView1.Rows.Add(newRow)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub ReservationForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub RemoveReservationButton_Click(sender As Object, e As EventArgs) Handles RemoveReservationButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If Not row.IsNewRow Then
                    DataGridView1.Rows.Remove(row)
                End If
            Next
        Else
            MessageBox.Show("Please select a reservation to remove.")
        End If
    End Sub
End Class