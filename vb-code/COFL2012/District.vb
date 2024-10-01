Imports System.IO

Public Class District
    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub District_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.RoundButton(btnPrevious)
        'Gets the primary directory
        Welcome.PrimaryDirectory = Directory.GetCurrentDirectory()
        Welcome.InputsCorrect(2) = False
        'Calls Sub to Initialize District Form
        InitDistrict()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub




    '*************************************************************************************************************************************
    '************************************************Top Navigation Menus and Buttons*****************************************************
    '*************************************************************************************************************************************
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Welcome.ClearAll()
        InitDistrict()
        IntersectionType.InitIntType()
        My.Forms.Title.Show()
        Me.Visible = False
        Title.InitTitle()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        OpenFileDialog1.Filter = "Input files (*in)|*.in|All files (*.*)|*.*"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = OpenFileDialog1.FileName
            Welcome.OpenFile()
            My.Forms.Title.Show()
            Me.Visible = False
            Title.InitTitle()
            InitDistrict()
            IntersectionType.InitIntType()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Writes user program run inputs to text file
        SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = SaveFileDialog1.FileName
            Welcome.SaveFile()
        End If

    End Sub

    Private Sub TitleToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
        My.Forms.Title.Show()
        Welcome.FillEFArray()
        Me.Visible = False
    End Sub



    Private Sub IntersectionTypeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            My.Forms.IntersectionType.Show()
            Welcome.FillEFArray()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2024")
        End If
    End Sub


    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
        My.Forms.About.Show()
    End Sub


    Private Sub IntersectionDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionDataToolStripButton.Click
        If Welcome.InputsCorrect(2) = True Then
            If Welcome.InputsCorrect(3) = True Then
                Select Case Welcome.IntType
                    Case ""
                        My.Forms._4X4.Show()
                    Case "4 X 4"
                        My.Forms._4X4.Show()
                    Case "4 X 6"
                        My.Forms._4X6.Show()
                    Case "6 X 4"
                        My.Forms._6X4.Show()
                    Case "6 X 6"
                        My.Forms._6X6.Show()
                    Case "East Tee"
                        My.Forms.East_Tee.Show()
                    Case "North Tee"
                        My.Forms.North_Tee.Show()
                    Case "Toll Booth"
                        My.Forms.TollBoothEW.Show()
                    Case "West Tee"
                        My.Forms.WestTee.Show()
                    Case "South Tee"
                        My.Forms.SouthTee.Show()
                    Case "N-S Diamond"
                        My.Forms.NorthSouthFreeway.Show()
                    Case "E-W Diamond"
                        My.Forms.EastWestFreeway.Show()
                    Case "D Diamond"
                        My.Forms.dDiamond.Show()
                End Select
                Welcome.FillEFArray()
                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2024")
            End If
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2024")
        End If
    End Sub



    Private Sub RunToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
        If Welcome.InputsCorrect(2) = True Then
            If (Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4)) Then
                Select Case Welcome.IntType
                    Case ""
                        My.Forms._4X4.Show()
                    Case "4 X 4"
                        My.Forms._4X4.Show()
                    Case "4 X 6"
                        My.Forms._4X6.Show()
                    Case "6 X 4"
                        My.Forms._6X4.Show()
                    Case "6 X 6"
                        My.Forms._6X6.Show()
                    Case "East Tee"
                        My.Forms.East_Tee.Show()
                    Case "North Tee"
                        My.Forms.North_Tee.Show()
                    Case "Toll Booth"
                        My.Forms.TollBoothEW.Show()
                    Case "West Tee"
                        My.Forms.WestTee.Show()
                    Case "South Tee"
                        My.Forms.SouthTee.Show()
                    Case "N-S Diamond"
                        My.Forms.NorthSouthFreeway.Show()
                    Case "E-W Diamond"
                        My.Forms.EastWestFreeway.Show()
                    Case "D Diamond"
                        My.Forms.dDiamond.Show()
                End Select
                Welcome.FillEFArray()
                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2024")
            End If
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2024")
        End If
    End Sub



    '*************************************************************************************************************************************
    '*************************************************Sets all Buttons to Unselected******************************************************
    '*************************************************************************************************************************************
    Sub AllRegButtons()
    End Sub




    '*************************************************************************************************************************************
    '*************************************************Initializes District Form******************************************************
    '*************************************************************************************************************************************
    Sub InitDistrict()
        Welcome.InputsCorrect(2) = True
    End Sub




    '*************************************************************************************************************************************
    '*******************************************************Form Input Controls***********************************************************
    '*************************************************************************************************************************************
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 1
        Welcome.Temperature = "48.3"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 2
        Welcome.Temperature = "41.1"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 3
        Welcome.Temperature = "39.3"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 4
        Welcome.Temperature = "53.9"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 5
        Welcome.Temperature = "47.8"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 6
        Welcome.Temperature = "53.9"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Clears previously selected district
        AllRegButtons()

        Welcome.DistrictNum = 7
        Welcome.Temperature = "48.8"
        Welcome.InputsCorrect(2) = True
        autoClick()
    End Sub


    Private Sub autoClick()
        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            'Welcome.FillEFArray()
            My.Forms.IntersectionType.Show()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2024")
        End If
    End Sub



    '******************************************************************************************************************
    '****************************************Bottom Navigation Buttons*************************************************
    '******************************************************************************************************************
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            My.Forms.Title.Show()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2024")
        End If
    End Sub


End Class


