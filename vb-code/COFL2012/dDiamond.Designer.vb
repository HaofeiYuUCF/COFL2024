<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dDiamond
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dDiamond))
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ToolStrip1 = New ToolStrip()
        TitleToolStripButton = New ToolStripButton()
        DistrictToolStripButton = New ToolStripButton()
        IntersectionTypeToolStripButton = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        RunToolStripButton = New ToolStripButton()
        ToolStripLabel2 = New ToolStripLabel()
        AboutToolStripButton = New ToolStripButton()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label14 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label18 = New Label()
        TextBox11 = New TextBox()
        Label12 = New Label()
        TextBox2 = New TextBox()
        TextBox12 = New TextBox()
        Label13 = New Label()
        Label17 = New Label()
        TextBox7 = New TextBox()
        Label11 = New Label()
        TextBox4 = New TextBox()
        TextBox14 = New TextBox()
        Label9 = New Label()
        btnRun = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        Label16 = New Label()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        Label15 = New Label()
        Label4 = New Label()
        TextBox6 = New TextBox()
        TextBox13 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        ToolStrip1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.InactiveCaption
        ToolStrip1.Items.AddRange(New ToolStripItem() {TitleToolStripButton, DistrictToolStripButton, IntersectionTypeToolStripButton, ToolStripButton7, RunToolStripButton, ToolStripLabel2, AboutToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1350, 25)
        ToolStrip1.TabIndex = 166
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
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = My.Resources.Resources.black_arrow_left
        PictureBox7.Location = New Point(957, 373)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 54)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 206
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.WhiteSmoke
        PictureBox8.Image = My.Resources.Resources.black_arrow_top
        PictureBox8.Location = New Point(695, 677)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(55, 77)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 207
        PictureBox8.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = My.Resources.Resources.down_arrow_608258
        PictureBox2.Location = New Point(624, 144)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 204
        PictureBox2.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(652, 757)
        Label14.Name = "Label14"
        Label14.Size = New Size(155, 24)
        Label14.TabIndex = 203
        Label14.Text = "NORTHBOUND"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(1076, 435)
        Label10.Name = "Label10"
        Label10.Size = New Size(175, 20)
        Label10.TabIndex = 202
        Label10.Text = "Arterial Speed (mph)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(325, 812)
        Label7.Name = "Label7"
        Label7.Size = New Size(206, 20)
        Label7.TabIndex = 201
        Label7.Text = "On Ramp Traffic (veh/hr)" & vbCrLf
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(104, 378)
        Label18.Name = "Label18"
        Label18.Size = New Size(208, 20)
        Label18.TabIndex = 200
        Label18.Text = "Approach Traffic (veh/hr)"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(537, 724)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 175
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(325, 720)
        Label12.Name = "Label12"
        Label12.Size = New Size(208, 20)
        Label12.TabIndex = 199
        Label12.Text = "Approach Traffic (veh/hr)" & vbCrLf
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(537, 760)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 176
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(537, 677)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 174
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(325, 763)
        Label13.Name = "Label13"
        Label13.Size = New Size(214, 20)
        Label13.TabIndex = 198
        Label13.Text = "Off- Ramp Traffic (veh/hr)" & vbCrLf
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(347, 680)
        Label17.Name = "Label17"
        Label17.Size = New Size(184, 20)
        Label17.TabIndex = 197
        Label17.Text = "Freeway Speed (mph)" & vbCrLf
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(958, 126)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 172
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(728, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(208, 20)
        Label11.TabIndex = 196
        Label11.Text = "Approach Traffic (veh/hr)" & vbCrLf
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(537, 809)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 182
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(318, 338)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(100, 23)
        TextBox14.TabIndex = 177
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(137, 341)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 195
        Label9.Text = "Arterial Speed (mph)"
        ' 
        ' btnRun
        ' 
        btnRun.BackColor = SystemColors.AppWorkspace
        btnRun.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRun.ForeColor = SystemColors.ControlText
        btnRun.Location = New Point(1220, 733)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(105, 36)
        btnRun.TabIndex = 183
        btnRun.Text = "Run"
        btnRun.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.AppWorkspace
        btnPrevious.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = SystemColors.ControlText
        btnPrevious.Location = New Point(1078, 733)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(136, 36)
        btnPrevious.TabIndex = 184
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(25, 651)
        Label8.Name = "Label8"
        Label8.Size = New Size(234, 167)
        Label8.TabIndex = 194
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1050, 389)
        Label16.Name = "Label16"
        Label16.Size = New Size(141, 24)
        Label16.TabIndex = 193
        Label16.Text = "WESTBOUND"
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(957, 479)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(100, 23)
        TextBox15.TabIndex = 181
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(957, 437)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(100, 23)
        TextBox16.TabIndex = 180
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1076, 477)
        Label15.Name = "Label15"
        Label15.Size = New Size(208, 20)
        Label15.TabIndex = 192
        Label15.Text = "Approach Traffic (veh/hr)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(197, 452)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 24)
        Label4.TabIndex = 191
        Label4.Text = "EASTBOUND"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(957, 209)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 179
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(318, 375)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(100, 23)
        TextBox13.TabIndex = 178
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(728, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(201, 20)
        Label6.TabIndex = 190
        Label6.Text = "On RampTraffic (veh/hr)" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(568, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 24)
        Label5.TabIndex = 189
        Label5.Text = "SOUTHBOUND"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(957, 164)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 173
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(957, 86)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 171
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(727, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(214, 20)
        Label3.TabIndex = 188
        Label3.Text = "Off- Ramp Traffic (veh/hr)" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(727, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 20)
        Label2.TabIndex = 187
        Label2.Text = "Freeway Speed (mph)" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(473, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(426, 31)
        Label1.TabIndex = 186
        Label1.Text = "Divergent Diamond Interchange"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.WhiteSmoke
        PictureBox3.Image = My.Resources.Resources.black_arrow_right
        PictureBox3.Location = New Point(314, 437)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 52)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 205
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(420, 264)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(533, 375)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 208
        PictureBox1.TabStop = False
        ' 
        ' dDiamond
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1350, 877)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox2)
        Controls.Add(Label14)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(Label18)
        Controls.Add(TextBox11)
        Controls.Add(Label12)
        Controls.Add(TextBox2)
        Controls.Add(TextBox12)
        Controls.Add(Label13)
        Controls.Add(Label17)
        Controls.Add(TextBox7)
        Controls.Add(Label11)
        Controls.Add(TextBox4)
        Controls.Add(TextBox14)
        Controls.Add(Label9)
        Controls.Add(btnRun)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(TextBox15)
        Controls.Add(TextBox16)
        Controls.Add(Label15)
        Controls.Add(Label4)
        Controls.Add(TextBox6)
        Controls.Add(TextBox13)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "dDiamond"
        Text = "CO Florida 2024 -  Divergent Diamond Interchange"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TitleToolStripButton As ToolStripButton
    Friend WithEvents DistrictToolStripButton As ToolStripButton
    Friend WithEvents IntersectionTypeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents RunToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents AboutToolStripButton As ToolStripButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
