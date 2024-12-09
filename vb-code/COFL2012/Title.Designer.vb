<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Title))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label7 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ToolStrip1 = New ToolStrip()
        TitleToolStripButton = New ToolStripButton()
        DistrictToolStripButton = New ToolStripButton()
        IntersectionTypeToolStripButton = New ToolStripButton()
        IntersectionDataToolStripButton = New ToolStripButton()
        RunToolStripButton = New ToolStripButton()
        ToolStripLabel2 = New ToolStripLabel()
        AboutToolStripButton = New ToolStripButton()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(105, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 1
        Label1.Text = "Project Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(105, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 25)
        Label2.TabIndex = 2
        Label2.Text = "User's name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label3.Location = New Point(105, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 2
        Label3.Text = "Facility Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(105, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 3
        Label4.Text = "Run Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(99, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(254, 25)
        Label5.TabIndex = 4
        Label5.Text = "Project Year (2010-2050)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(68, 424)
        Label6.Name = "Label6"
        Label6.Size = New Size(213, 25)
        Label6.TabIndex = 5
        Label6.Text = "Land Use (Click one)" & vbCrLf
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(105, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(348, 17)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Project Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(118, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(315, 29)
        Label7.TabIndex = 7
        Label7.Text = "PROJECT DESCRIPTION"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(105, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(348, 17)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Facility Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(105, 242)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(348, 17)
        TextBox3.TabIndex = 2
        TextBox3.Text = "User Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(105, 307)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(348, 17)
        TextBox4.TabIndex = 3
        TextBox4.Text = "Run Name"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(105, 373)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(348, 17)
        TextBox5.TabIndex = 4
        TextBox5.Text = "2024"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gainsboro
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(68, 452)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 34)
        Button1.TabIndex = 5
        Button1.Text = "Urban"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gainsboro
        Button2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(211, 452)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 34)
        Button2.TabIndex = 6
        Button2.Text = "Suburban"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gainsboro
        Button3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(359, 452)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 34)
        Button3.TabIndex = 7
        Button3.Text = "Rural"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGray
        Button4.FlatAppearance.BorderColor = Color.Black
        Button4.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(204, 528)
        Button4.Name = "Button4"
        Button4.Size = New Size(149, 53)
        Button4.TabIndex = 17
        Button4.Text = "Next"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.LightSteelBlue
        ToolStrip1.Items.AddRange(New ToolStripItem() {TitleToolStripButton, DistrictToolStripButton, IntersectionTypeToolStripButton, IntersectionDataToolStripButton, RunToolStripButton, ToolStripLabel2, AboutToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(559, 25)
        ToolStrip1.TabIndex = 18
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
        ' IntersectionDataToolStripButton
        ' 
        IntersectionDataToolStripButton.Image = CType(resources.GetObject("IntersectionDataToolStripButton.Image"), Image)
        IntersectionDataToolStripButton.ImageTransparentColor = Color.Magenta
        IntersectionDataToolStripButton.Name = "IntersectionDataToolStripButton"
        IntersectionDataToolStripButton.Size = New Size(122, 22)
        IntersectionDataToolStripButton.Text = "Interesection Data"
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
        AboutToolStripButton.Image = My.Resources.Resources.Info
        AboutToolStripButton.ImageTransparentColor = Color.Magenta
        AboutToolStripButton.Name = "AboutToolStripButton"
        AboutToolStripButton.Size = New Size(23, 22)
        AboutToolStripButton.Text = "About"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Title
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(559, 623)
        Controls.Add(ToolStrip1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label7)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Title"
        Text = "CO Florida 2024 - Title"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TitleToolStripButton As ToolStripButton
    Friend WithEvents DistrictToolStripButton As ToolStripButton
    Friend WithEvents IntersectionTypeToolStripButton As ToolStripButton
    Friend WithEvents IntersectionDataToolStripButton As ToolStripButton
    Friend WithEvents RunToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents AboutToolStripButton As ToolStripButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
