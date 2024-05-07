<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(296, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(517, 73)
        Label1.TabIndex = 0
        Label1.Text = "CO Florida 2024"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(13, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(217, 29)
        Label5.TabIndex = 5
        Label5.Text = "Developed by UCF"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(835, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(236, 29)
        Label6.TabIndex = 6
        Label6.Text = "Sponsored by FDOT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.ucf_logo
        PictureBox2.Location = New Point(52, 53)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(135, 115)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.fdot_logo
        PictureBox3.Location = New Point(868, 56)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(187, 102)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(433, 43)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 62)
        Button1.TabIndex = 0
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(-2, 466)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1111, 171)
        Panel1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(405, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(299, 29)
        Label2.TabIndex = 11
        Label2.Text = "For Florida Interesctions" & vbCrLf
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1108, 636)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Welcome"
        RightToLeftLayout = True
        Text = "CO Florida 2012 - Welcome"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
