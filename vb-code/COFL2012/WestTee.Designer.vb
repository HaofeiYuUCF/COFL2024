<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WestTee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WestTee))
        btnNext = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label18 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
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
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label9 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
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
        btnPrevious.Location = New Point(1071, 744)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(130, 36)
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
        Label8.Size = New Size(234, 167)
        Label8.TabIndex = 109
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(603, 725)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(603, 678)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(389, 725)
        Label18.Name = "Label18"
        Label18.Size = New Size(208, 20)
        Label18.TabIndex = 101
        Label18.Text = "Approach Traffic (veh/hr)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(439, 678)
        Label17.Name = "Label17"
        Label17.Size = New Size(112, 20)
        Label17.TabIndex = 98
        Label17.Text = "Speed (mph)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(181, 463)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 24)
        Label4.TabIndex = 97
        Label4.Text = "EASTBOUND"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(301, 386)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(301, 337)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(85, 389)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 20)
        Label6.TabIndex = 93
        Label6.Text = "Approach Traffic (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(181, 337)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 20)
        Label7.TabIndex = 92
        Label7.Text = "Speed (mph)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(576, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 24)
        Label5.TabIndex = 91
        Label5.Text = "SOUTHBOUND"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(901, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(901, 143)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(687, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 20)
        Label3.TabIndex = 87
        Label3.Text = "Approach Traffic (veh/hr)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(687, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 86
        Label2.Text = "Speed (mph)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(475, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 31)
        Label1.TabIndex = 85
        Label1.Text = "Intersection Data - West Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.West_Tee
        PictureBox1.Location = New Point(407, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.InactiveCaption
        ToolStrip1.Items.AddRange(New ToolStripItem() {TitleToolStripButton, DistrictToolStripButton, IntersectionTypeToolStripButton, ToolStripButton7, RunToolStripButton, ToolStripLabel2, AboutToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1351, 25)
        ToolStrip1.TabIndex = 117
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(702, 778)
        Label9.Name = "Label9"
        Label9.Size = New Size(155, 24)
        Label9.TabIndex = 118
        Label9.Text = "NORTHBOUND"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.WhiteSmoke
        PictureBox4.Image = My.Resources.Resources.black_arrow_top
        PictureBox4.Location = New Point(750, 678)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(55, 77)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 122
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.WhiteSmoke
        PictureBox5.Image = My.Resources.Resources.black_arrow_right
        PictureBox5.Location = New Point(301, 450)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(104, 52)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 120
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.WhiteSmoke
        PictureBox6.Image = My.Resources.Resources.down_arrow_608258
        PictureBox6.Location = New Point(623, 125)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(53, 73)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 119
        PictureBox6.TabStop = False
        ' 
        ' WestTee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox6)
        Controls.Add(Label9)
        Controls.Add(ToolStrip1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "WestTee"
        Text = "CO Florida 2024 - West Tee"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
