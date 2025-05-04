<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        txtpassword = New TextBox()
        txtadmin = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        btnRegister = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtpassword.BorderStyle = BorderStyle.None
        txtpassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(657, 386)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(353, 20)
        txtpassword.TabIndex = 17
        ' 
        ' txtadmin
        ' 
        txtadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtadmin.BorderStyle = BorderStyle.None
        txtadmin.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtadmin.Location = New Point(657, 304)
        txtadmin.Name = "txtadmin"
        txtadmin.Size = New Size(353, 20)
        txtadmin.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.BackColor = Color.Crimson
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(702, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 36)
        Button1.TabIndex = 15
        Button1.Text = "SIGN IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(657, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 14)
        Label3.TabIndex = 14
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(657, 328)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 14)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(657, 406)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(353, 1)
        Panel2.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(657, 324)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(353, 1)
        Panel1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Meiryo", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(747, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 48)
        Label1.TabIndex = 10
        Label1.Text = "STUDENT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Location = New Point(615, 146)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(440, 409)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.WhiteSmoke
        LinkLabel1.LinkColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        LinkLabel1.Location = New Point(898, 538)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(156, 15)
        LinkLabel1.TabIndex = 18
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
        btnRegister.Location = New Point(862, 444)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(120, 36)
        btnRegister.TabIndex = 21
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1067, 567)
        Controls.Add(btnRegister)
        Controls.Add(LinkLabel1)
        Controls.Add(txtpassword)
        Controls.Add(txtadmin)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtadmin As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnRegister As Button
End Class
