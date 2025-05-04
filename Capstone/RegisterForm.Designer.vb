<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        ComboBoxRole = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Location = New Point(487, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(454, 337)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Meiryo UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(648, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 41)
        Label1.TabIndex = 1
        Label1.Text = "Register"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(547, 252)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(353, 1)
        Panel1.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(547, 308)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(353, 1)
        Panel2.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(544, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 14)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(544, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 14)
        Label3.TabIndex = 14
        Label3.Text = "Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.BackColor = Color.Crimson
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(661, 410)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(120, 36)
        btnRegister.TabIndex = 15
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(547, 232)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(353, 20)
        txtUsername.TabIndex = 16
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(547, 288)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(353, 20)
        txtPassword.TabIndex = 17
        ' 
        ' ComboBoxRole
        ' 
        ComboBoxRole.FormattingEnabled = True
        ComboBoxRole.Items.AddRange(New Object() {"Student", "Admin"})
        ComboBoxRole.Location = New Point(660, 346)
        ComboBoxRole.Name = "ComboBoxRole"
        ComboBoxRole.Size = New Size(121, 23)
        ComboBoxRole.TabIndex = 18
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.ue_after
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(967, 516)
        Controls.Add(ComboBoxRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "RegisterForm"
        Text = "RegisterForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents ComboBoxRole As ComboBox
End Class
