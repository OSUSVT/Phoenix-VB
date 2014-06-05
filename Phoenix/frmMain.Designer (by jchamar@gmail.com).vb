<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblBorder1 = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblBorder2 = New System.Windows.Forms.Label()
        Me.picLeftBorder = New System.Windows.Forms.PictureBox()
        Me.lblSOC1 = New System.Windows.Forms.Label()
        Me.lblSOC2 = New System.Windows.Forms.Label()
        Me.lblLeftBlinker = New System.Windows.Forms.Label()
        Me.lblRightBlinker = New System.Windows.Forms.Label()
        Me.lblEfficiency = New System.Windows.Forms.Label()
        Me.lblBorder3 = New System.Windows.Forms.Label()
        Me.lblHist1 = New System.Windows.Forms.Label()
        Me.lblHist2 = New System.Windows.Forms.Label()
        Me.lblHist3 = New System.Windows.Forms.Label()
        Me.lblHist4 = New System.Windows.Forms.Label()
        Me.lblHist5 = New System.Windows.Forms.Label()
        Me.lblHist6 = New System.Windows.Forms.Label()
        Me.lblEfficiencyBar = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblBattPower2 = New System.Windows.Forms.Label()
        Me.lblBattPower = New System.Windows.Forms.Label()
        Me.lblMPPTPower2 = New System.Windows.Forms.Label()
        Me.lblMPPTPower = New System.Windows.Forms.Label()
        Me.serBodyController = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrLeftBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRightBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPower = New System.Windows.Forms.Timer(Me.components)
        Me.lblBodyCurrent = New System.Windows.Forms.Label()
        Me.lblBodyCurrent2 = New System.Windows.Forms.Label()
        Me.serGPS = New System.IO.Ports.SerialPort(Me.components)
        Me.srcGPS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoenixDataSet = New Phoenix.PhoenixDataSet()
        Me.SolarCarGPSTableAdapter = New Phoenix.PhoenixDataSetTableAdapters.SolarCarGPSTableAdapter()
        Me.lblHorn = New System.Windows.Forms.Label()
        Me.tmrHorn = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLeftBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srcGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoenixDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 80.0!)
        Me.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpeed.Location = New System.Drawing.Point(134, 34)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(125, 126)
        Me.lblSpeed.TabIndex = 1
        Me.lblSpeed.Text = "55"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBorder1
        '
        Me.lblBorder1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblBorder1.Location = New System.Drawing.Point(163, 2)
        Me.lblBorder1.Name = "lblBorder1"
        Me.lblBorder1.Size = New System.Drawing.Size(348, 30)
        Me.lblBorder1.TabIndex = 2
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 18.0!)
        Me.lblExit.Location = New System.Drawing.Point(611, 2)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(187, 30)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "EXIT"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 20.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(514, 2)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(94, 30)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "12:00 pm"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBorder2
        '
        Me.lblBorder2.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblBorder2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!)
        Me.lblBorder2.ForeColor = System.Drawing.Color.Black
        Me.lblBorder2.Location = New System.Drawing.Point(148, 142)
        Me.lblBorder2.Name = "lblBorder2"
        Me.lblBorder2.Size = New System.Drawing.Size(505, 30)
        Me.lblBorder2.TabIndex = 2
        Me.lblBorder2.Text = "REARVIEW CAMERA SYSTEM"
        '
        'picLeftBorder
        '
        Me.picLeftBorder.Image = Global.Phoenix.My.Resources.Resources.Left_Border
        Me.picLeftBorder.ImageLocation = ""
        Me.picLeftBorder.Location = New System.Drawing.Point(2, 2)
        Me.picLeftBorder.Name = "picLeftBorder"
        Me.picLeftBorder.Size = New System.Drawing.Size(154, 50)
        Me.picLeftBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftBorder.TabIndex = 5
        Me.picLeftBorder.TabStop = False
        '
        'lblSOC1
        '
        Me.lblSOC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblSOC1.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 35.0!)
        Me.lblSOC1.Location = New System.Drawing.Point(2, 54)
        Me.lblSOC1.Name = "lblSOC1"
        Me.lblSOC1.Size = New System.Drawing.Size(129, 117)
        Me.lblSOC1.TabIndex = 6
        Me.lblSOC1.Text = "SOC:"
        '
        'lblSOC2
        '
        Me.lblSOC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblSOC2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 48.0!)
        Me.lblSOC2.Location = New System.Drawing.Point(2, 101)
        Me.lblSOC2.Name = "lblSOC2"
        Me.lblSOC2.Size = New System.Drawing.Size(129, 71)
        Me.lblSOC2.TabIndex = 7
        Me.lblSOC2.Text = "100%"
        Me.lblSOC2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblLeftBlinker
        '
        Me.lblLeftBlinker.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblLeftBlinker.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftBlinker.Location = New System.Drawing.Point(2, 183)
        Me.lblLeftBlinker.Name = "lblLeftBlinker"
        Me.lblLeftBlinker.Size = New System.Drawing.Size(129, 117)
        Me.lblLeftBlinker.TabIndex = 8
        Me.lblLeftBlinker.Text = "LEFT BLINKER"
        '
        'lblRightBlinker
        '
        Me.lblRightBlinker.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblRightBlinker.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 35.0!)
        Me.lblRightBlinker.Location = New System.Drawing.Point(669, 183)
        Me.lblRightBlinker.Name = "lblRightBlinker"
        Me.lblRightBlinker.Size = New System.Drawing.Size(129, 117)
        Me.lblRightBlinker.TabIndex = 9
        Me.lblRightBlinker.Text = "RIGHT BLINKER"
        '
        'lblEfficiency
        '
        Me.lblEfficiency.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEfficiency.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lblEfficiency.Location = New System.Drawing.Point(669, 101)
        Me.lblEfficiency.Name = "lblEfficiency"
        Me.lblEfficiency.Size = New System.Drawing.Size(129, 71)
        Me.lblEfficiency.TabIndex = 11
        Me.lblEfficiency.Text = "40"
        Me.lblEfficiency.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblBorder3
        '
        Me.lblBorder3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblBorder3.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 35.0!)
        Me.lblBorder3.Location = New System.Drawing.Point(669, 54)
        Me.lblBorder3.Name = "lblBorder3"
        Me.lblBorder3.Size = New System.Drawing.Size(129, 117)
        Me.lblBorder3.TabIndex = 10
        Me.lblBorder3.Text = "MI/kWH"
        '
        'lblHist1
        '
        Me.lblHist1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHist1.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist1.ForeColor = System.Drawing.Color.Black
        Me.lblHist1.Location = New System.Drawing.Point(576, 46)
        Me.lblHist1.Name = "lblHist1"
        Me.lblHist1.Size = New System.Drawing.Size(50, 91)
        Me.lblHist1.TabIndex = 12
        Me.lblHist1.Text = "75"
        '
        'lblHist2
        '
        Me.lblHist2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblHist2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist2.ForeColor = System.Drawing.Color.Black
        Me.lblHist2.Location = New System.Drawing.Point(520, 68)
        Me.lblHist2.Name = "lblHist2"
        Me.lblHist2.Size = New System.Drawing.Size(50, 66)
        Me.lblHist2.TabIndex = 13
        Me.lblHist2.Text = "50"
        '
        'lblHist3
        '
        Me.lblHist3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHist3.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist3.ForeColor = System.Drawing.Color.Black
        Me.lblHist3.Location = New System.Drawing.Point(464, 101)
        Me.lblHist3.Name = "lblHist3"
        Me.lblHist3.Size = New System.Drawing.Size(50, 33)
        Me.lblHist3.TabIndex = 14
        Me.lblHist3.Text = "25"
        '
        'lblHist4
        '
        Me.lblHist4.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHist4.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist4.ForeColor = System.Drawing.Color.Black
        Me.lblHist4.Location = New System.Drawing.Point(408, 56)
        Me.lblHist4.Name = "lblHist4"
        Me.lblHist4.Size = New System.Drawing.Size(50, 78)
        Me.lblHist4.TabIndex = 15
        Me.lblHist4.Text = "69"
        '
        'lblHist5
        '
        Me.lblHist5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblHist5.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist5.ForeColor = System.Drawing.Color.Black
        Me.lblHist5.Location = New System.Drawing.Point(352, 78)
        Me.lblHist5.Name = "lblHist5"
        Me.lblHist5.Size = New System.Drawing.Size(50, 56)
        Me.lblHist5.TabIndex = 16
        Me.lblHist5.Text = "42"
        '
        'lblHist6
        '
        Me.lblHist6.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHist6.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHist6.ForeColor = System.Drawing.Color.Black
        Me.lblHist6.Location = New System.Drawing.Point(296, 68)
        Me.lblHist6.Name = "lblHist6"
        Me.lblHist6.Size = New System.Drawing.Size(50, 66)
        Me.lblHist6.TabIndex = 17
        Me.lblHist6.Text = "56"
        '
        'lblEfficiencyBar
        '
        Me.lblEfficiencyBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblEfficiencyBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfficiencyBar.Location = New System.Drawing.Point(669, 34)
        Me.lblEfficiencyBar.Name = "lblEfficiencyBar"
        Me.lblEfficiencyBar.Size = New System.Drawing.Size(54, 17)
        Me.lblEfficiencyBar.TabIndex = 18
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'lblBattPower2
        '
        Me.lblBattPower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblBattPower2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 40.0!)
        Me.lblBattPower2.Location = New System.Drawing.Point(2, 357)
        Me.lblBattPower2.Name = "lblBattPower2"
        Me.lblBattPower2.Size = New System.Drawing.Size(129, 71)
        Me.lblBattPower2.TabIndex = 20
        Me.lblBattPower2.Text = "-2.5kW"
        Me.lblBattPower2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblBattPower
        '
        Me.lblBattPower.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblBattPower.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 32.0!)
        Me.lblBattPower.Location = New System.Drawing.Point(2, 310)
        Me.lblBattPower.Name = "lblBattPower"
        Me.lblBattPower.Size = New System.Drawing.Size(129, 117)
        Me.lblBattPower.TabIndex = 19
        Me.lblBattPower.Text = "BATT PW"
        '
        'lblMPPTPower2
        '
        Me.lblMPPTPower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMPPTPower2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 40.0!)
        Me.lblMPPTPower2.Location = New System.Drawing.Point(669, 357)
        Me.lblMPPTPower2.Name = "lblMPPTPower2"
        Me.lblMPPTPower2.Size = New System.Drawing.Size(129, 71)
        Me.lblMPPTPower2.TabIndex = 22
        Me.lblMPPTPower2.Text = "1.0kW"
        Me.lblMPPTPower2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblMPPTPower
        '
        Me.lblMPPTPower.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMPPTPower.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 32.0!)
        Me.lblMPPTPower.Location = New System.Drawing.Point(669, 310)
        Me.lblMPPTPower.Name = "lblMPPTPower"
        Me.lblMPPTPower.Size = New System.Drawing.Size(129, 117)
        Me.lblMPPTPower.TabIndex = 21
        Me.lblMPPTPower.Text = "ARRAY:"
        '
        'serBodyController
        '
        Me.serBodyController.PortName = "COM7"
        '
        'tmrLeftBlinker
        '
        Me.tmrLeftBlinker.Interval = 500
        '
        'tmrRightBlinker
        '
        Me.tmrRightBlinker.Interval = 500
        '
        'tmrPower
        '
        Me.tmrPower.Enabled = True
        Me.tmrPower.Interval = 500
        '
        'lblBodyCurrent
        '
        Me.lblBodyCurrent.BackColor = System.Drawing.Color.PaleGreen
        Me.lblBodyCurrent.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 32.0!)
        Me.lblBodyCurrent.Location = New System.Drawing.Point(2, 438)
        Me.lblBodyCurrent.Name = "lblBodyCurrent"
        Me.lblBodyCurrent.Size = New System.Drawing.Size(129, 117)
        Me.lblBodyCurrent.TabIndex = 23
        Me.lblBodyCurrent.Text = "BDY CURR"
        '
        'lblBodyCurrent2
        '
        Me.lblBodyCurrent2.BackColor = System.Drawing.Color.PaleGreen
        Me.lblBodyCurrent2.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 40.0!)
        Me.lblBodyCurrent2.Location = New System.Drawing.Point(2, 484)
        Me.lblBodyCurrent2.Name = "lblBodyCurrent2"
        Me.lblBodyCurrent2.Size = New System.Drawing.Size(129, 71)
        Me.lblBodyCurrent2.TabIndex = 24
        Me.lblBodyCurrent2.Text = "1 A"
        Me.lblBodyCurrent2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'serGPS
        '
        Me.serGPS.BaudRate = 4800
        Me.serGPS.PortName = "COM3"
        '
        'srcGPS
        '
        Me.srcGPS.DataMember = "SolarCarGPS"
        Me.srcGPS.DataSource = Me.PhoenixDataSet
        '
        'PhoenixDataSet
        '
        Me.PhoenixDataSet.DataSetName = "PhoenixDataSet"
        Me.PhoenixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolarCarGPSTableAdapter
        '
        Me.SolarCarGPSTableAdapter.ClearBeforeFill = True
        '
        'lblHorn
        '
        Me.lblHorn.BackColor = System.Drawing.Color.Plum
        Me.lblHorn.Font = New System.Drawing.Font("Helvetica LT UltraCompressed", 50.0!)
        Me.lblHorn.Location = New System.Drawing.Point(668, 438)
        Me.lblHorn.Name = "lblHorn"
        Me.lblHorn.Size = New System.Drawing.Size(129, 117)
        Me.lblHorn.TabIndex = 25
        Me.lblHorn.Text = "Horn"
        Me.lblHorn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrHorn
        '
        Me.tmrHorn.Interval = 50
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblHorn)
        Me.Controls.Add(Me.lblBodyCurrent2)
        Me.Controls.Add(Me.lblBodyCurrent)
        Me.Controls.Add(Me.lblMPPTPower2)
        Me.Controls.Add(Me.lblMPPTPower)
        Me.Controls.Add(Me.lblBattPower2)
        Me.Controls.Add(Me.lblBattPower)
        Me.Controls.Add(Me.lblEfficiencyBar)
        Me.Controls.Add(Me.lblHist6)
        Me.Controls.Add(Me.lblHist5)
        Me.Controls.Add(Me.lblHist4)
        Me.Controls.Add(Me.lblHist3)
        Me.Controls.Add(Me.lblHist2)
        Me.Controls.Add(Me.lblHist1)
        Me.Controls.Add(Me.lblEfficiency)
        Me.Controls.Add(Me.lblBorder3)
        Me.Controls.Add(Me.lblRightBlinker)
        Me.Controls.Add(Me.lblLeftBlinker)
        Me.Controls.Add(Me.lblSOC2)
        Me.Controls.Add(Me.lblSOC1)
        Me.Controls.Add(Me.picLeftBorder)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblBorder2)
        Me.Controls.Add(Me.lblBorder1)
        Me.Controls.Add(Me.lblSpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLeftBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srcGPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoenixDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblBorder1 As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblBorder2 As System.Windows.Forms.Label
    Friend WithEvents picLeftBorder As System.Windows.Forms.PictureBox
    Friend WithEvents lblSOC1 As System.Windows.Forms.Label
    Friend WithEvents lblSOC2 As System.Windows.Forms.Label
    Friend WithEvents lblLeftBlinker As System.Windows.Forms.Label
    Friend WithEvents lblRightBlinker As System.Windows.Forms.Label
    Friend WithEvents lblEfficiency As System.Windows.Forms.Label
    Friend WithEvents lblBorder3 As System.Windows.Forms.Label
    Friend WithEvents lblHist1 As System.Windows.Forms.Label
    Friend WithEvents lblHist2 As System.Windows.Forms.Label
    Friend WithEvents lblHist3 As System.Windows.Forms.Label
    Friend WithEvents lblHist4 As System.Windows.Forms.Label
    Friend WithEvents lblHist5 As System.Windows.Forms.Label
    Friend WithEvents lblHist6 As System.Windows.Forms.Label
    Friend WithEvents lblEfficiencyBar As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents lblBattPower2 As System.Windows.Forms.Label
    Friend WithEvents lblBattPower As System.Windows.Forms.Label
    Friend WithEvents lblMPPTPower2 As System.Windows.Forms.Label
    Friend WithEvents lblMPPTPower As System.Windows.Forms.Label
    Friend WithEvents serBodyController As System.IO.Ports.SerialPort
    Friend WithEvents tmrLeftBlinker As System.Windows.Forms.Timer
    Friend WithEvents tmrRightBlinker As System.Windows.Forms.Timer
    Friend WithEvents tmrPower As System.Windows.Forms.Timer
    Friend WithEvents lblBodyCurrent As System.Windows.Forms.Label
    Friend WithEvents lblBodyCurrent2 As System.Windows.Forms.Label
    Friend WithEvents serGPS As System.IO.Ports.SerialPort
    Friend WithEvents srcGPS As System.Windows.Forms.BindingSource
    Friend WithEvents PhoenixDataSet As Phoenix.PhoenixDataSet
    Friend WithEvents SolarCarGPSTableAdapter As Phoenix.PhoenixDataSetTableAdapters.SolarCarGPSTableAdapter
    Friend WithEvents lblHorn As System.Windows.Forms.Label
    Friend WithEvents tmrHorn As System.Windows.Forms.Timer

End Class
