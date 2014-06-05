Public Class frmMain
    'Public definitions
    Const EFF_RED As Integer = 25
    Const EFF_YELLOW As Integer = 50
    Const PWR_MAX = 7500


    'Public Declarations
    Dim bolViewSOC As Boolean = True                        'View SOC or kWH (default SOC)
    Dim bolError As Boolean = False                         'Error message visible or not visible
    Dim intEfficiencyHistory(6) As Integer                  'Efficiency history array
    Dim intCurrentEfficiency As Integer = 50                'Current efficiency
    Dim floBattPower As Double                              'Battery Power
    Dim floArrayPower As Double                             'Array Power
    Dim floBattVoltage As Double                            'Batt Voltage
    Dim floSOC As Double                                    'Battery SOC
    Dim flokWH As Double                                    'Battery kWH
    Dim floBattCurrent As Double                            'Battery Current
    Dim floMPPTCurrent As Double                            'MPPT current
    Dim floMaxkWH As Double                                 'Maximum kWH
    Dim BodyCurrent As String                               'Body Controller Current Usage
    Dim BodyCurrentValue As Array                           'Body Controller Power Array
    Dim BodyControllerOutput As Array                       'Body Controller Output States
    Dim message As MessageBox                               'Warning box

    'FUNCTION: InitCamera ()

    'GPS values
    Public Latitude As String                               'Latitude (from GPRMC)
    Public Longitude As String                              'Longitude (from GPRMC)
    Public SatCount As String                               'Number of satelites, AKA NumInUse (from GPGGA)
    Public Velocity As String                               'Velocity Correct to MPH (from GPRMC)
    Public Altitude As String                               'Altitude (from GPGGA) above or below MEAN sea level data (ellipsoid shaped earth) in METERS
    Public Bearing As String                                'Bearing... not yet populated........................................
    Public Quality As String                                'GPS quality indicator (0=invalid; 1=GPS fix; 2=Diff. GPS fix) (from GPGGA)
    Public NoS As String                                    'North or South
    Public EoW As String                                    'East or West
    Public UTC As String                                    'UTC at the position of the GPS




    'INPUTS: NONE
    'OUTPUTS: NONE
    'PURPOSE: Initializes web camera

    Private Sub InitCamera()
        'Declarations
        Dim camRear As New WebCamControl2.WebCamControl2
        Dim camRearLocation As Point
        Dim camRearSize As Size

        'Adds the control
        Me.Controls.Add(camRear)
        'frmMain.Controls.Add(camRear)

        'Sets the location
        camRearLocation.X = 150
        camRearLocation.Y = 177
        camRear.Location = camRearLocation

        'Sets the size
        camRearSize.Height = 420
        camRearSize.Width = 500
        camRear.Size = camRearSize
    End Sub

    'FUNCTION: InitEfficiencyHistory ()
    'INPUTS: NONE
    'OUTPUTS: NONE
    'PURPOSE: Initializes the efficiency history

    Private Sub InitEfficiencyHistory()
        'Adds blanks into the efficiency history array
        intEfficiencyHistory(0) = 120
        intEfficiencyHistory(1) = 60
        intEfficiencyHistory(2) = 20
        intEfficiencyHistory(3) = 40
        intEfficiencyHistory(4) = 10
        intEfficiencyHistory(5) = 70


    End Sub

    'FUNCTION: ToggleSOC ()
    'INPUTS: NONE
    'OUTPUTS: NONE
    'PURPOSE: Toggles SOC vs. kWH

    Private Sub ToggleSOC()
        'Toggles between SOC and kWH
        If bolViewSOC = False Then
            'Goes to SOC state
            bolViewSOC = True

            'Toggles the GUI
            lblSOC1.Text = "SOC:"
        Else
            'Goes to kWH state
            bolViewSOC = False

            'Toggles the GUI
            lblSOC1.Text = "kWH:"
        End If
    End Sub

    'FUNCTION: RefreshHistory()
    'INPUTS: NONE
    'OUTPUTS: NONE
    'PURPOSE: Refreshes the history of energy efficiency
    Private Sub RefreshHistory()
        'Constants
        Const MAX_SIZE As Integer = 93
        Const MAX_LOCATION As Integer = 42
        Const MAX_VALUE = 99

        'Declarations
        Dim EffRed As Color
        Dim EffYellow As Color
        Dim EffGreen As Color
        Dim sizTemp As Size
        Dim ptTemp As Point


        'Sets the values to the colors involved
        EffRed = Color.FromArgb(CType(255, Byte), CType(51, Byte), CType(0, Byte))
        EffYellow = Color.FromArgb(CType(255, Byte), CType(204, Byte), CType(102, Byte))
        EffGreen = Color.FromArgb(CType(153, Byte), CType(102, Byte), CType(255, Byte))

        'Sets the bars' width
        sizTemp.Width = 47

        'Checks for upper saturation
        For intIndex = 0 To 5
            If intEfficiencyHistory(intIndex) > 99 Then
                intEfficiencyHistory(intIndex) = 99
            End If
        Next


        'Changes size of each of the history bars
        sizTemp.Height = CInt((intEfficiencyHistory(0) / MAX_VALUE) * MAX_SIZE)
        lblHist1.Size = sizTemp

        sizTemp.Height = CInt((intEfficiencyHistory(1) / MAX_VALUE) * MAX_SIZE)
        lblHist2.Size = sizTemp

        sizTemp.Height = CInt((intEfficiencyHistory(2) / MAX_VALUE) * MAX_SIZE)
        lblHist3.Size = sizTemp

        sizTemp.Height = CInt((intEfficiencyHistory(3) / MAX_VALUE) * MAX_SIZE)
        lblHist4.Size = sizTemp

        sizTemp.Height = CInt((intEfficiencyHistory(4) / MAX_VALUE) * MAX_SIZE)
        lblHist5.Size = sizTemp

        sizTemp.Height = CInt((intEfficiencyHistory(5) / MAX_VALUE) * MAX_SIZE)
        lblHist6.Size = sizTemp

        'Changes the locations of each of the history bars to match
        ptTemp.X = lblHist1.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist1.Size.Height)
        lblHist1.Location = ptTemp

        ptTemp.X = lblHist2.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist2.Size.Height)
        lblHist2.Location = ptTemp

        ptTemp.X = lblHist3.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist3.Size.Height)
        lblHist3.Location = ptTemp

        ptTemp.X = lblHist4.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist4.Size.Height)
        lblHist4.Location = ptTemp

        ptTemp.X = lblHist5.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist5.Size.Height)
        lblHist5.Location = ptTemp

        ptTemp.X = lblHist6.Location.X
        ptTemp.Y = MAX_LOCATION + (MAX_SIZE - lblHist6.Size.Height)
        lblHist6.Location = ptTemp

        'Relabels the history bars
        If intEfficiencyHistory(0) < 25 Then
            'Removes label
            lblHist1.Text = ""
        Else
            'Labels history
            lblHist1.Text = intEfficiencyHistory(0)
        End If

        If intEfficiencyHistory(1) < 25 Then
            'Removes label
            lblHist2.Text = ""
        Else
            'Labels history
            lblHist2.Text = intEfficiencyHistory(1)
        End If

        If intEfficiencyHistory(2) < 25 Then
            'Removes label
            lblHist3.Text = ""
        Else
            'Labels history
            lblHist3.Text = intEfficiencyHistory(2)
        End If

        If intEfficiencyHistory(3) < 25 Then
            'Removes label
            lblHist4.Text = ""
        Else
            'Labels history
            lblHist4.Text = intEfficiencyHistory(3)
        End If

        If intEfficiencyHistory(4) < 25 Then
            'Removes label
            lblHist5.Text = ""
        Else
            'Labels history
            lblHist5.Text = intEfficiencyHistory(4)
        End If

        If intEfficiencyHistory(5) < 25 Then
            'Removes label
            lblHist6.Text = ""
        Else
            'Labels history
            lblHist6.Text = intEfficiencyHistory(5)
        End If

        'Changes the color of the labels
        If intEfficiencyHistory(0) < EFF_RED Then
            'Red
            lblHist1.BackColor = EffRed
        ElseIf intEfficiencyHistory(0) > EFF_RED And intEfficiencyHistory(0) < EFF_YELLOW Then
            'Red
            lblHist1.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist1.BackColor = EffGreen
        End If

        If intEfficiencyHistory(1) < EFF_RED Then
            'Red
            lblHist2.BackColor = EffRed
        ElseIf intEfficiencyHistory(1) > EFF_RED And intEfficiencyHistory(1) < EFF_YELLOW Then
            'Red
            lblHist2.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist2.BackColor = EffGreen
        End If

        If intEfficiencyHistory(2) < EFF_RED Then
            'Red
            lblHist3.BackColor = EffRed
        ElseIf intEfficiencyHistory(2) > EFF_RED And intEfficiencyHistory(2) < EFF_YELLOW Then
            'Red
            lblHist3.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist3.BackColor = EffGreen
        End If

        If intEfficiencyHistory(3) < EFF_RED Then
            'Red
            lblHist4.BackColor = EffRed
        ElseIf intEfficiencyHistory(3) > EFF_RED And intEfficiencyHistory(3) < EFF_YELLOW Then
            'Red
            lblHist4.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist4.BackColor = EffGreen
        End If

        If intEfficiencyHistory(4) < EFF_RED Then
            'Red
            lblHist5.BackColor = EffRed
        ElseIf intEfficiencyHistory(4) > EFF_RED And intEfficiencyHistory(4) < EFF_YELLOW Then
            'Red
            lblHist5.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist5.BackColor = EffGreen
        End If

        If intEfficiencyHistory(5) < EFF_RED Then
            'Red
            lblHist6.BackColor = EffRed
        ElseIf intEfficiencyHistory(5) > EFF_RED And intEfficiencyHistory(5) < EFF_YELLOW Then
            'Red
            lblHist6.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblHist6.BackColor = EffGreen
        End If

    End Sub
    'FUNCTION: RefreshEfficiency()
    'INPUTS: NONE
    'OUTPUTS: NONE
    'PURPOSE: Refreshes the energy efficiency
    Private Sub RefreshEfficiency()
        'Declarations
        Dim ptSize As Size
        Const BAR_MAX As Integer = 121
        Dim EffRed As Color
        Dim EffYellow As Color
        Dim EffGreen As Color

        'Sets the values to the colors involved
        EffRed = Color.FromArgb(CType(255, Byte), CType(51, Byte), CType(0, Byte))
        EffYellow = Color.FromArgb(CType(255, Byte), CType(204, Byte), CType(102, Byte))
        EffGreen = Color.FromArgb(CType(153, Byte), CType(102, Byte), CType(255, Byte))

        'Saturates the efficiecy 
        If intCurrentEfficiency > 99 Then
            'Saturates the current efficiency
            intCurrentEfficiency = 99
        End If

        'Resizes the efficiency 
        lblEfficiency.Text = intCurrentEfficiency
        ptSize.Height = lblEfficiencyBar.Height
        ptSize.Width = (intCurrentEfficiency / 99) * BAR_MAX
        lblEfficiencyBar.Size = ptSize

        'Recolors the efficiency
        If intCurrentEfficiency < EFF_RED Then
            'Red
            lblEfficiencyBar.BackColor = EffRed
        ElseIf intCurrentEfficiency > EFF_RED And intCurrentEfficiency < EFF_YELLOW Then
            'Yellow
            lblEfficiencyBar.BackColor = EffYellow
        Else
            'Green (blue actually)
            lblEfficiencyBar.BackColor = EffGreen
        End If
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PhoenixDataSet.SolarCarGPS' table. You can move, or remove it, as needed.
        Me.SolarCarGPSTableAdapter.Fill(Me.PhoenixDataSet.SolarCarGPS)
        'TODO: This line of code loads data into the 'PhoenixDataSet.SolarCarGPS' table. You can move, or remove it, as needed.
        Me.SolarCarGPSTableAdapter.Fill(Me.PhoenixDataSet.SolarCarGPS)
        'TODO: This line of code loads data into the 'PhoenixDataSet.SolarCarGPS' table. You can move, or remove it, as needed.
        Me.SolarCarGPSTableAdapter.Fill(Me.PhoenixDataSet.SolarCarGPS)
        'TODO: This line of code loads data into the 'PhoenixDataSet.SolarCarGPS' table. You can move, or remove it, as needed.
        Me.SolarCarGPSTableAdapter.Fill(Me.PhoenixDataSet.SolarCarGPS)
        'Declarations
        Dim objIniFile As New IniFile("c:\Odyssey.ini")

        'Initializes camera
        Call InitCamera()

        'Loads kWH
        flokWH = objIniFile.GetString("Vitals", "kWH", "0")
        floMaxkWH = objIniFile.GetString("Vitals", "MAX_KWH", "5.18")

        'Initializes the efficiency history
        Call InitEfficiencyHistory()
    End Sub

    Private Sub lblSOC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSOC1.Click
        'Toggles the SOC
        Call ToggleSOC()
    End Sub

    Private Sub lblSOC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSOC2.Click
        'Toggles the SOC
        Call ToggleSOC()
    End Sub

    Private Sub lblHist1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHist1.Click
        RefreshHistory()
        RefreshEfficiency()
    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        'Main Timer

        'Declarations
        Dim objIniFile As New IniFile("c:\Odyssey.ini")
        Dim PwrRed As Color
        Dim PwrYellow As Color
        Dim PwrGreen As Color
        Dim sizTemp As Size
        Dim ptTemp As Point


        'Sets the values to the colors involved
        PwrRed = Color.FromArgb(CType(255, Byte), CType(51, Byte), CType(0, Byte))
        PwrYellow = Color.FromArgb(CType(255, Byte), CType(204, Byte), CType(102, Byte))
        PwrGreen = Color.FromArgb(CType(32, Byte), CType(98, Byte), CType(238, Byte))


        'Updates time
        lblTime.Text = Now.ToShortTimeString.ToString

        'Calculates power data
        floArrayPower = floBattVoltage * floMPPTCurrent
        floBattPower = floBattVoltage * floBattCurrent

        'Displays power data
        lblMPPTPower2.Text = Math.Round(floArrayPower / 1000, 1).ToString
        lblBattPower2.Text = Math.Round(floBattPower / 1000, 1).ToString

        'Checks for power consumption levels
        If Math.Abs(floBattPower) < (PWR_MAX - 1500) Then
            'Changes color to green (blue)
            lblBattPower.BackColor = PwrGreen
            lblBattPower2.BackColor = PwrGreen
        ElseIf (Math.Abs(floBattPower) >= (PWR_MAX - 1500)) And (Math.Abs(floBattPower) < (PWR_MAX - 500)) Then
            'Changes color to yellow
            lblBattPower.BackColor = PwrYellow
            lblBattPower2.BackColor = PwrYellow
        Else
            'Changes color to red
            lblBattPower.BackColor = PwrRed
            lblBattPower2.BackColor = PwrRed
        End If

        'Performs charge integration
        flokWH = flokWH + (floBattPower / 1000) / 3600
        floSOC = flokWH / floMaxkWH

        'Stores charge data
        objIniFile.WriteString("Vitals", "kWH", flokWH)

        'Displays SOC/kWH
        If bolViewSOC = False Then
            'Displays kWH
            lblSOC2.Text = Math.Round(flokWH, 2)
        Else
            'Displays SOC
            lblSOC2.Text = Math.Round(floSOC * 100, 0) & "%"
        End If


        Try
            If serGPS.IsOpen = False Then
                serGPS.Open()
            End If
            lblSpeed.Text = Velocity
        Catch ex As Exception
            MessageBox.Show("try 1")
            If bolError = False Then
                bolError = True
                message.Show("Unplug and reconnect GPS. If the problem persists verify COM Port", "GPS Error")
            End If
        End Try

        'Store Values into SQL database (Which must have the correct tables)
        SolarCarGPSTableAdapter.Insert(UTC, Latitude, NoS, Longitude, EoW, Quality, SatCount, Velocity, Altitude)



    End Sub



    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        serGPS.Close()
        serBodyController.Close()
        Me.Close()
    End Sub


    Private Sub lblLeftBlinker_Click(sender As Object, e As System.EventArgs) Handles lblLeftBlinker.Click
        'Declarations
        Dim colBlinkerDefault = Color.FromArgb(CType(204, Byte), CType(102, Byte), CType(102, Byte))

        'Opens the COMM port if port is closed
        If serBodyController.IsOpen = False Then
            serBodyController.Open()
        End If


        'Disables the right blinker
        If tmrRightBlinker.Enabled = True Then
            tmrRightBlinker.Enabled = False

            'Resets the button's color
            lblRightBlinker.BackColor = colBlinkerDefault
        End If


        'Enables/disables the left turn timer
        If tmrLeftBlinker.Enabled = False Then
            'Flashes blinker
            tmrLeftBlinker.Enabled = True
        ElseIf tmrLeftBlinker.Enabled = True Then
            'Stops blinker flash
            tmrLeftBlinker.Enabled = False

            'Resets the button's color
            lblLeftBlinker.BackColor = colBlinkerDefault
        End If
    End Sub


    Private Sub tmrLeftBlinker_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeftBlinker.Tick
        'Declarations
        Dim colBlinkerDefault As Color
        Dim colFlash As Color


        'Sets the values to the colors for the blinker
        colBlinkerDefault = Color.FromArgb(CType(204, Byte), CType(102, Byte), CType(102, Byte))
        colFlash = Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))


        'Sends test blinker code out to serial port
        If tmrLeftBlinker.Tag = "" Then
            'Sends the serial string out
            serBodyController.WriteLine("$b,7,2,9,2")

            'Sets the timer tag so that we go half time
            tmrLeftBlinker.Tag = "You're it!"
        Else
            'Clears the tag
            tmrLeftBlinker.Tag = ""
        End If


        'Flashes the label
        If lblLeftBlinker.BackColor = colBlinkerDefault Then
            'Changes background to white
            lblLeftBlinker.BackColor = colFlash
        Else
            'Changes background to default
            lblLeftBlinker.BackColor = colBlinkerDefault
        End If


    End Sub

    Private Sub lblRightBlinker_Click(sender As System.Object, e As System.EventArgs) Handles lblRightBlinker.Click
        'Declarations
        Dim colBlinkerDefault = Color.FromArgb(CType(204, Byte), CType(102, Byte), CType(102, Byte))

        'Opens the COMM port if port is closed
        If serBodyController.IsOpen = False Then
            serBodyController.Open()
        End If


        'Disables the left blinker
        If tmrLeftBlinker.Enabled = True Then
            tmrLeftBlinker.Enabled = False

            'Resets the button's color
            lblLeftBlinker.BackColor = colBlinkerDefault
        End If


        'Enables/disables the right turn timer
        If tmrRightBlinker.Enabled = False Then
            'Flashes blinker
            tmrRightBlinker.Enabled = True
        ElseIf tmrRightBlinker.Enabled = True Then
            'Stops blinker flash
            tmrRightBlinker.Enabled = False

            'Resets the button's color
            lblRightBlinker.BackColor = colBlinkerDefault
        End If
    End Sub

    Private Sub tmrRightBlinker_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRightBlinker.Tick
        'Declarations
        Dim colBlinkerDefault As Color
        Dim colFlash As Color
        'Dim myString As Array


        'Sets the values to the colors for the blinker
        colBlinkerDefault = Color.FromArgb(CType(204, Byte), CType(102, Byte), CType(102, Byte))
        colFlash = Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))


        'Sends test blinker code out to serial port
        If tmrRightBlinker.Tag = "" Then
            'Sends the serial string out
            serBodyController.WriteLine("$b,8,2,10,2")

            'Sets the timer tag so that we go half time
            tmrRightBlinker.Tag = "You're it!"
        Else
            'Clears the tag
            tmrRightBlinker.Tag = ""
        End If


        'Flashes the label
        If lblRightBlinker.BackColor = colBlinkerDefault Then
            'Changes background to white
            lblRightBlinker.BackColor = colFlash
        Else
            'Changes background to default
            lblRightBlinker.BackColor = colBlinkerDefault
        End If


    End Sub





    Private Sub tmrPower_Tick(sender As System.Object, e As System.EventArgs) Handles tmrPower.Tick
        'Declarations


        'Set Battery Power on screen
        lblBattPower2.Text = "5 kW"


        'Set Array Power on screen
        lblMPPTPower2.Text = "5 kW"
        Try
            lblMPPTPower2.Text = Split(BodyControllerOutput(2), "=")(1)
        Catch ex As Exception

        End Try



        'Set SOC and kWH on screen
        If bolViewSOC = True Then
            lblSOC2.Text = "25%"

        ElseIf bolViewSOC = False Then
            lblSOC2.Text = "40kWH"
        End If

        'Set Body Controller Current on screen
        'Verify serial port is open, if not then open it
        Try

            If serBodyController.IsOpen = False Then
                serBodyController.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Try 2")
        End Try


        'BodyCurrent = serMain.ReadLine
        'Splits a huge message from body controller, first reduces

        If IsNothing(BodyCurrentValue) = False Then
            lblBodyCurrent2.Text = BodyCurrentValue(0)
        End If

    End Sub


    Private Sub serMain_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serBodyController.DataReceived
        'Reads the current line from the serial port
        BodyControllerOutput = Split(serBodyController.ReadLine, ",")

        'Parses data into array
        If BodyControllerOutput(0) = "$BodyController" Then
            'Splits the array and removes everything but the numeric value (0) and word amps (1) both as strings
            BodyCurrentValue = Split(Split(BodyControllerOutput(3), "=")(1), " ")
        End If

    End Sub


    Private Sub serGPS_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serGPS.DataReceived
        'Declarations
        Dim GPSArray As Array
        Dim VelocityRound As Integer

        'Try/Catch to keep it from crashing apon exit
        Try
            GPSArray = serGPS.ReadLine.Split(",")
        Catch ex As Exception
            'leave because the string wasn't populated correclty or whatever is causing it to crash
            MessageBox.Show("try 3")
        End Try

        '1    = UTC of position fix
        '2    = Data status (V=navigation receiver warning)
        '3    = Latitude of fix
        '4    = N or S
        '5    = Longitude of fix
        '6    = E or W
        '7    = Speed over ground in knots
        '8    = Track made good in degrees True
        '9    = UT date
        '10   = Magnetic variation degrees (Easterly var. subtracts from true course)
        '11   = E or W
        '12   = Checksum

        'Read and Split each line piece of data and store it into an array
        Try
            If GPSArray(0) = "$GPRMC" And GPSArray(2) = "A" Then

                'Display Speed Section
                Velocity = (Convert.ToDecimal(GPSArray(7)) * 1.15077945).ToString 'Convert into MPH
                VelocityRound = Val(Velocity) 'Get the integer value

                'round velocity to neart whole number
                If Velocity - VelocityRound >= 0.5 Then 'Round
                    Velocity = Velocity + 1 'Round Up
                Else : Velocity = VelocityRound 'Round Down
                End If

                'Store each value, Velocity is stored as a ROUNDED value from above
                UTC = GPSArray(1)
                Latitude = GPSArray(3)
                NoS = GPSArray(4)
                Longitude = GPSArray(5)
                EoW = GPSArray(6)
                Velocity = Velocity.ToString
            End If

        Catch ex As Exception

            'show the error, should only be index out of bounds at start or end of program
            MessageBox.Show("try 4")

        End Try



        Try
            If GPSArray(0) = "$GPGGA" Then

                '1    = UTC of Position
                '2    = Latitude
                '3    = N or S
                '4    = Longitude
                '5    = E or W
                '6    = GPS quality indicator (0=invalid; 1=GPS fix; 2=Diff. GPS fix)
                '7    = Number of satellites in use [not those in view]
                '8    = Horizontal dilution of position
                '9    = Antenna altitude above/below mean sea level (geoid)
                '10   = Meters  (Antenna height unit)
                '11   = Geoidal separation (Diff. between WGS-84 earth ellipsoid and
                '       mean sea level.  -=geoid is below WGS-84 ellipsoid)
                '12   = Meters  (Units of geoidal separation)
                '13   = Age in seconds since last update from diff. reference station
                '14   = Diff. reference station ID#
                '15   = Checksum

                'Store each value, Velocity is stored as a ROUNDED value from above
                Quality = GPSArray(6)
                SatCount = GPSArray(7)
                Altitude = GPSArray(9)
            End If

        Catch ex As Exception
            'Display the error
            MessageBox.Show("try 5")
        End Try



    End Sub


    Private Sub lblhorn_click(sender As System.Object, e As System.EventArgs) Handles lblHorn.MouseDown
        'Declarations
        Dim colDefault As Color = Color.Plum
        Dim colHold As Color = Color.MediumVioletRed

        'Enable the timer horn which outputs on the serial string for the horn
        If tmrHorn.Enabled = False Then
            tmrHorn.Enabled = True
        End If

        'Flashes the label
        If lblHorn.BackColor = colDefault Then
            'Changes background to 
            lblHorn.BackColor = colHold
        End If


    End Sub

    Private Sub lblhorn_unclick(sender As System.Object, e As System.EventArgs) Handles lblHorn.MouseUp
        'Declarations
        Dim colDefault As Color = Color.Plum
        Dim colHold As Color = Color.MediumVioletRed

        'Disables the timer horn which outputs on the serial string for the horn
        If tmrHorn.Enabled = True Then
            tmrHorn.Enabled = False
        End If

        If lblHorn.BackColor <> colDefault Then
            'Changes background to default
            lblHorn.BackColor = colDefault
        End If

    End Sub

    Private Sub tmrHorn_Tick(sender As System.Object, e As System.EventArgs) Handles tmrHorn.Tick

        'Opens the COMM port if port is closed
        If serBodyController.IsOpen = False Then
            serBodyController.Open()
        End If

        'Sends a pulse command for the horn(output 1) for 5 tenths of a second
        serBodyController.WriteLine("$p,1,4")
    End Sub

End Class
