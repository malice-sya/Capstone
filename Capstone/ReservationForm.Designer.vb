<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        AddReservationButton = New Button()
        StatusComboBox = New ComboBox()
        ReservationNameTextBox = New TextBox()
        TimeTextBox = New TextBox()
        RequesterNameTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RemoveReservationButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(67, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(747, 300)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Reservation/Event Name"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Time"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Reservation Status"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Name"
        Column4.Name = "Column4"
        ' 
        ' AddReservationButton
        ' 
        AddReservationButton.FlatAppearance.BorderColor = Color.White
        AddReservationButton.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddReservationButton.Location = New Point(688, 327)
        AddReservationButton.Name = "AddReservationButton"
        AddReservationButton.Size = New Size(126, 34)
        AddReservationButton.TabIndex = 1
        AddReservationButton.Text = "Add"
        AddReservationButton.UseVisualStyleBackColor = True
        ' 
        ' StatusComboBox
        ' 
        StatusComboBox.BackColor = Color.WhiteSmoke
        StatusComboBox.FormattingEnabled = True
        StatusComboBox.Items.AddRange(New Object() {"Approved", "Cancelled", "Postponed"})
        StatusComboBox.Location = New Point(472, 337)
        StatusComboBox.Name = "StatusComboBox"
        StatusComboBox.Size = New Size(163, 23)
        StatusComboBox.TabIndex = 2
        ' 
        ' ReservationNameTextBox
        ' 
        ReservationNameTextBox.BackColor = Color.WhiteSmoke
        ReservationNameTextBox.Location = New Point(137, 324)
        ReservationNameTextBox.Name = "ReservationNameTextBox"
        ReservationNameTextBox.Size = New Size(256, 23)
        ReservationNameTextBox.TabIndex = 3
        ' 
        ' TimeTextBox
        ' 
        TimeTextBox.BackColor = Color.WhiteSmoke
        TimeTextBox.Location = New Point(137, 358)
        TimeTextBox.Name = "TimeTextBox"
        TimeTextBox.Size = New Size(256, 23)
        TimeTextBox.TabIndex = 4
        ' 
        ' RequesterNameTextBox
        ' 
        RequesterNameTextBox.BackColor = Color.WhiteSmoke
        RequesterNameTextBox.Location = New Point(137, 395)
        RequesterNameTextBox.Name = "RequesterNameTextBox"
        RequesterNameTextBox.Size = New Size(256, 23)
        RequesterNameTextBox.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(61, 327)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 16)
        Label1.TabIndex = 6
        Label1.Text = "Event Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold)
        Label2.Location = New Point(77, 362)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 16)
        Label2.TabIndex = 7
        Label2.Text = "Time"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold)
        Label3.Location = New Point(67, 398)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 16)
        Label3.TabIndex = 8
        Label3.Text = "Reservor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(519, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 16)
        Label4.TabIndex = 9
        Label4.Text = "Event Name"
        ' 
        ' RemoveReservationButton
        ' 
        RemoveReservationButton.FlatAppearance.BorderColor = Color.White
        RemoveReservationButton.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RemoveReservationButton.Location = New Point(688, 380)
        RemoveReservationButton.Name = "RemoveReservationButton"
        RemoveReservationButton.Size = New Size(126, 34)
        RemoveReservationButton.TabIndex = 10
        RemoveReservationButton.Text = "Remove"
        RemoveReservationButton.UseVisualStyleBackColor = True
        ' 
        ' ReservationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.uesocialogp
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(877, 441)
        Controls.Add(RemoveReservationButton)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RequesterNameTextBox)
        Controls.Add(TimeTextBox)
        Controls.Add(ReservationNameTextBox)
        Controls.Add(StatusComboBox)
        Controls.Add(AddReservationButton)
        Controls.Add(DataGridView1)
        ForeColor = SystemColors.ControlText
        Name = "ReservationForm"
        Text = "ReservationForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AddReservationButton As Button
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents ReservationNameTextBox As TextBox
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents RequesterNameTextBox As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RemoveReservationButton As Button
End Class
