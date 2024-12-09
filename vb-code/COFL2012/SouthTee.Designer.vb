<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SouthTee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SouthTee))
        btnNext = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        Label16 = New Label()
        Label19 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        Label15 = New Label()
        TextBox6 = New TextBox()
        Label14 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ToolStrip1 = New ToolStrip()
        TitleToolStripButton = New ToolStripButton()
        DistrictToolStripButton = New ToolStripButton()
        IntersectionTypeToolStripButton = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        RunToolStripButton = New ToolStripButton()
        ToolStripLabel2 = New ToolStripLabel()
        AboutToolStripButton = New ToolStripButton()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.AppWorkspace
        btnNext.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.ForeColor = SystemColors.ControlText
        btnNext.Location = New Point(1207, 744)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(105, 36)
        btnNext.TabIndex = 6
        btnNext.Text = "Run"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.AppWorkspace
        btnPrevious.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = SystemColors.ControlText
        btnPrevious.Location = New Point(1076, 744)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(125, 36)
        btnPrevious.TabIndex = 7
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(12, 662)
        Label8.Name = "Label8"
        Label8.Size = New Size(235, 167)
        Label8.TabIndex = 81
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1050, 292)
        Label16.Name = "Label16"
        Label16.Size = New Size(141, 24)
        Label16.TabIndex = 80
        Label16.Text = "WESTBOUND"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(683, 706)
        Label19.Name = "Label19"
        Label19.Size = New Size(155, 24)
        Label19.TabIndex = 79
        Label19.Text = "NORTHBOUND"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(957, 354)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(957, 395)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(299, 309)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1076, 394)
        Label15.Name = "Label15"
        Label15.Size = New Size(142, 40)
        Label15.TabIndex = 71
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(299, 260)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 0
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1086, 354)
        Label14.Name = "Label14"
        Label14.Size = New Size(112, 20)
        Label14.TabIndex = 70
        Label14.Text = "Speed (mph)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(383, 654)
        Label18.Name = "Label18"
        Label18.Size = New Size(142, 40)
        Label18.TabIndex = 72
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(420, 605)
        Label17.Name = "Label17"
        Label17.Size = New Size(112, 20)
        Label17.TabIndex = 69
        Label17.Text = "Speed (mph)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(193, 379)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 24)
        Label4.TabIndex = 68
        Label4.Text = "EASTBOUND"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(545, 654)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(545, 605)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(122, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 40)
        Label6.TabIndex = 64
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(172, 259)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 20)
        Label7.TabIndex = 63
        Label7.Text = "Speed (mph)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(450, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(398, 31)
        Label1.TabIndex = 56
        Label1.Text = "Intersection Data - South Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.South_Tee
        PictureBox1.Location = New Point(420, 141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.InactiveCaption
        ToolStrip1.Items.AddRange(New ToolStripItem() {TitleToolStripButton, DistrictToolStripButton, IntersectionTypeToolStripButton, ToolStripButton7, RunToolStripButton, ToolStripLabel2, AboutToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1351, 25)
        ToolStrip1.TabIndex = 116
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' TitleToolStripButton
        ' 
        TitleToolStripButton.Image = CType(resources.GetObject("TitleToolStripButton.Image"), Image)
        TitleToolStripButton.ImageTransparentColor = Color.Magenta
        TitleToolStripButton.Name = "TitleToolStripButton"
        TitleToolStripButton.Size = New Size(127, 22)
        TitleToolStripButton.Text = "Project Description"
        ' 
        ' DistrictToolStripButton
        ' 
        DistrictToolStripButton.Image = CType(resources.GetObject("DistrictToolStripButton.Image"), Image)
        DistrictToolStripButton.ImageTransparentColor = Color.Magenta
        DistrictToolStripButton.Name = "DistrictToolStripButton"
        DistrictToolStripButton.Size = New Size(64, 22)
        DistrictToolStripButton.Text = "District"
        ' 
        ' IntersectionTypeToolStripButton
        ' 
        IntersectionTypeToolStripButton.Image = CType(resources.GetObject("IntersectionTypeToolStripButton.Image"), Image)
        IntersectionTypeToolStripButton.ImageTransparentColor = Color.Magenta
        IntersectionTypeToolStripButton.Name = "IntersectionTypeToolStripButton"
        IntersectionTypeToolStripButton.Size = New Size(122, 22)
        IntersectionTypeToolStripButton.Text = "Interesection Type"
        ' 
        ' ToolStripButton7
        ' 
        ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        ToolStripButton7.ImageTransparentColor = Color.Magenta
        ToolStripButton7.Name = "ToolStripButton7"
        ToolStripButton7.Size = New Size(122, 22)
        ToolStripButton7.Text = "Interesection Data"
        ' 
        ' RunToolStripButton
        ' 
        RunToolStripButton.Image = CType(resources.GetObject("RunToolStripButton.Image"), Image)
        RunToolStripButton.ImageTransparentColor = Color.Magenta
        RunToolStripButton.Name = "RunToolStripButton"
        RunToolStripButton.Size = New Size(48, 22)
        RunToolStripButton.Text = "Run"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(37, 22)
        ToolStripLabel2.Text = "          "
        ' 
        ' AboutToolStripButton
        ' 
        AboutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AboutToolStripButton.Image = CType(resources.GetObject("AboutToolStripButton.Image"), Image)
        AboutToolStripButton.ImageTransparentColor = Color.Magenta
        AboutToolStripButton.Name = "AboutToolStripButton"
        AboutToolStripButton.Size = New Size(23, 22)
        AboutToolStripButton.Text = "About"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.Control
        PictureBox7.Image = My.Resources.Resources.black_arrow_left
        PictureBox7.Location = New Point(957, 277)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 54)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 119
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Control
        PictureBox8.Image = My.Resources.Resources.black_arrow_top
        PictureBox8.Location = New Point(731, 605)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(55, 77)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 120
        PictureBox8.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Control
        PictureBox3.Image = My.Resources.Resources.black_arrow_right
        PictureBox3.Location = New Point(310, 367)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 52)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 118
        PictureBox3.TabStop = False
        ' 
        ' SouthTee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Label4)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox3)
        Controls.Add(ToolStrip1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(Label19)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox5)
        Controls.Add(Label15)
        Controls.Add(TextBox6)
        Controls.Add(Label14)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SouthTee"
        Text = "CO Florida 2024 - South Tee"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TitleToolStripButton As ToolStripButton
    Friend WithEvents DistrictToolStripButton As ToolStripButton
    Friend WithEvents IntersectionTypeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents RunToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents AboutToolStripButton As ToolStripButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
