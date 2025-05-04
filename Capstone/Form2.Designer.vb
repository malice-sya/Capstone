<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        btnSign = New Button()
        txtUsername = New TextBox()
        txtpassword = New TextBox()
        LinkLabel1 = New LinkLabel()
        btnRegister = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Location = New Point(654, 157)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(440, 416)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Meiryo", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(816, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 48)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(696, 342)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(353, 1)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(696, 424)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(353, 1)
        Panel2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(696, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 14)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(696, 428)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 14)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' btnSign
        ' 
        btnSign.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSign.BackColor = Color.Crimson
        btnSign.FlatStyle = FlatStyle.Popup
        btnSign.Font = New Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSign.ForeColor = Color.White
        btnSign.Location = New Point(816, 455)
        btnSign.Name = "btnSign"
        btnSign.Size = New Size(120, 36)
        btnSign.TabIndex = 6
        btnSign.Text = "SIGN IN"
        btnSign.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(696, 322)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(353, 20)
        txtUsername.TabIndex = 7
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtpassword.BorderStyle = BorderStyle.None
        txtpassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(696, 404)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(353, 20)
        txtpassword.TabIndex = 8
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.WhiteSmoke
        LinkLabel1.LinkColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        LinkLabel1.Location = New Point(938, 557)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(156, 15)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Wrong selection? Click here!"
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.BackColor = Color.Crimson
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(779, 497)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(196, 36)
        btnRegister.TabIndex = 20
        btnRegister.Text = "Register as Admin"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1106, 607)
        Controls.Add(btnRegister)
        Controls.Add(LinkLabel1)
        Controls.Add(txtpassword)
        Controls.Add(txtUsername)
        Controls.Add(btnSign)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
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
    Friend WithEvents btnSign As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnRegister As Button

End Class
