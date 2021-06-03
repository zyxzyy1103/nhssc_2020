Imports USBHID
Imports System.IO.Ports
Public Class Form1
    Const usbVID As Integer = &H1234
    Const usbPID As Integer = &H6789
    Dim usb As New HID

    Dim dataBuffer(10) As Byte
    Dim connectDevice As String = "none"

    Dim rgb(8) As Microsoft.VisualBasic.PowerPacks.OvalShape
    Dim led(8) As Microsoft.VisualBasic.PowerPacks.OvalShape

    Dim mainIndex As Integer
    Dim ledBuffer As Integer
    Dim l7sBuffer As Integer
    Dim rgbBuffer(8, 3) As Integer
    Dim vr As Integer
    Dim button(4) As Boolean

    Dim rgbSelected(3) As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        led(0) = OvalShape_LED0
        led(1) = OvalShape_LED1
        led(2) = OvalShape_LED2
        led(3) = OvalShape_LED3
        led(4) = OvalShape_LED4
        led(5) = OvalShape_LED5
        led(6) = OvalShape_LED6
        led(7) = OvalShape_LED7

        RGB(0) = OvalShape_RGB0
        RGB(1) = OvalShape_RGB1
        RGB(2) = OvalShape_RGB2
        RGB(3) = OvalShape_RGB3
        RGB(4) = OvalShape_RGB4
        RGB(5) = OvalShape_RGB5
        RGB(6) = OvalShape_RGB6
        RGB(7) = OvalShape_RGB7

        For Each sp In SerialPort.GetPortNames
            ComboBox_COM.Items.Add(sp)
        Next

        Timer1.Enabled = True
    End Sub


    Sub SETUP(ByVal device As String)
        connectDevice = device
        If device = "usb" Then
            Label_Device.Text = "Device Online With USB"
        ElseIf device = "bt" Then
            Label_Device.Text = "Device Online With BT"
        End If
        Label_Device.BackColor = Color.FromArgb(0, 255, 0)
    End Sub
    Sub CLEAN()
        connectDevice = "none"
        Label_Device.Text = "Device Offline"
        Label_Device.BackColor = Color.FromArgb(255, 0, 0)
        For i = 0 To 7
            rgb(i).FillColor = Color.White
            led(i).FillColor = Color.White
        Next

        mainIndex = 0
        ledBuffer = 0
        l7sBuffer = 0
        For i = 0 To 7
            For j = 0 To 2
                rgbBuffer(i, j) = 0
            Next
        Next
    End Sub
    Function HEX_TO_INT(h) As Integer
        Dim s = "0123456789ABCDEF"
        Dim byteH, byteL

        byteH = s.IndexOf(Mid(h, 1, 1))
        byteL = s.IndexOf(Mid(h, 2, 1))

        Return byteH * 16 + byteL
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Current_Time.Text = "Current Time：" & TimeString

        Select Case connectDevice
            Case "none"
                If usb.OpenHIDDevice(usbVID, usbPID) Then SETUP("usb")
            Case "usb"
                USB_RECEIVE()
                TIME_SEND()
            Case "bt"
                BT_RECEIVE()
        End Select

    End Sub


    Function DATA_SEND(d0, d1, d2, d3, d4, d5, d6, d7, usbClose) As Boolean
        dataBuffer(0) = d0
        dataBuffer(1) = d1
        dataBuffer(2) = d2
        dataBuffer(3) = d3
        dataBuffer(4) = d4
        dataBuffer(5) = d5
        dataBuffer(6) = d6
        dataBuffer(7) = d7

        If connectDevice = "usb" Then
            If usb.OpenHIDDevice(usbVID, usbPID) Then
                usb.HIDSetReport(dataBuffer)
                If usbClose Then usb.CloseHIDDevice()
                DATA_SEND = True
            Else
                CLEAN()
                DATA_SEND = False
            End If
        ElseIf connectDevice = "bt" Then
            If Bluetooth.IsOpen Then
                Dim sendStr As String = ""
                For i = 0 To 7
                    sendStr = sendStr & dataBuffer(i) & ","
                Next
                Bluetooth.Write(sendStr)
                Label2.Text = sendStr
            Else
                CLEAN()
            End If
        End If
    End Function

    Sub TIME_SEND()
        DATA_SEND(0, 0, DatePart(Microsoft.VisualBasic.DateInterval.Second, Now),
                        DatePart(Microsoft.VisualBasic.DateInterval.Minute, Now),
                        DatePart(Microsoft.VisualBasic.DateInterval.Hour, Now),
                        DatePart(Microsoft.VisualBasic.DateInterval.Day, Now),
                        DatePart(Microsoft.VisualBasic.DateInterval.Month, Now), 0, True)
    End Sub


    Sub USB_RECEIVE()
        If Not DATA_SEND(66, 0, 0, 0, 0, 0, 0, 0, False) Then Exit Sub
        dataBuffer = usb.HidGetReport

        Dim buffer(10) As Integer
        For i = 1 To 10
            buffer(i) = dataBuffer(i)
        Next

        buffer(1) = buffer(1) - 240
        If buffer(1) <= 7 And buffer(1) >= 0 Then
            mainIndex = buffer(2)
            ledBuffer = buffer(3)
            l7sBuffer = buffer(4)

            rgbBuffer(buffer(1), 0) = buffer(5)
            rgbBuffer(buffer(1), 1) = buffer(6)
            rgbBuffer(buffer(1), 2) = buffer(7)

            REM LED_CHANGE(buffer(3))
            REM BUTTON_CHECK(buffer(8))
        End If

        REM If buffer(1) = 7 Then RGB_CHANGE()


        CHECK_LED()
        CHECK_RGB()
    End Sub


    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        If (Button_Connect.Text = "Connect") Then
            Bluetooth.Close()
            Bluetooth.PortName = ComboBox_COM.Text
            Bluetooth.BaudRate = 9600
            Bluetooth.DataBits = 8
            Bluetooth.Parity = Parity.None
            Bluetooth.StopBits = StopBits.One
            Bluetooth.Handshake = Handshake.None
            Bluetooth.Encoding = System.Text.Encoding.Default
            Bluetooth.ReadTimeout = 10000

            Bluetooth.Open()

            Button_Connect.Text = "Dis-Connect"
            ComboBox_COM.Enabled = False

            SETUP("bt")
        Else
            Bluetooth.Close()

            Button_Connect.Text = "Connect"
            ComboBox_COM.Enabled = True

            CLEAN()
        End If
    End Sub
    Sub BT_RECEIVE()
        Dim fromAvr As String
        Try
            fromAvr = Bluetooth.ReadExisting
            If fromAvr IsNot Nothing Then
                If fromAvr.Contains("<") And fromAvr.Contains(">") Then
                    CHECK_DATA(fromAvr)
                    Label1.Text = fromAvr
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub CHECK_DATA(receiveData)
        Dim msg, data, cmdH, cmdL
        Dim p1, p2
        REM <xxx><xxx>
        While True
            p1 = receiveData.Indexof("<", 0) + 1
            p2 = receiveData.Indexof(">", 0) + 1

            If p2 < p1 Then Exit Sub

            msg = Mid(receiveData, p1 + 1, p2 - p1 - 1)
            cmdH = Mid(msg, 1, 1)
            cmdL = Mid(msg, 2, 1)
            data = Mid(msg, 3)

            Select Case cmdH
                Case "z"
                REM BTTime = 0
                Case "a"
                    mainIndex = data
                Case "b"
                    ledBuffer = data
                    CHECK_LED()
                Case "c"
                    l7sBuffer = data
                Case "d"
                    Select Case cmdL
                        Case 0
                            BT_RGB_CHECK(0, Mid(data, 1, 6))
                            BT_RGB_CHECK(1, Mid(data, 7, 6))
                        Case 1
                            BT_RGB_CHECK(2, Mid(data, 1, 6))
                            BT_RGB_CHECK(3, Mid(data, 7, 6))
                        Case 2
                            BT_RGB_CHECK(4, Mid(data, 1, 6))
                            BT_RGB_CHECK(5, Mid(data, 7, 6))
                        Case 3
                            BT_RGB_CHECK(6, Mid(data, 1, 6))
                            BT_RGB_CHECK(7, Mid(data, 7, 6))
                    End Select
                Case "e"

            End Select

            receiveData = Mid(receiveData, p2 + 1)
        End While
    End Sub

    Sub temp(receiveData)
        Dim msg, data, cmdH, cmdL
        Dim p1, p2

        p1 = receiveData.Indexof("<", 0) + 1
        p2 = receiveData.Indexof(">", 0) + 1

        If p2 < p1 Then Exit Sub

        msg = Mid(receiveData, p1 + 1, p2 - p1 - 1)
        cmdH = Mid(msg, 1, 1)
        cmdL = Mid(msg, 2, 1)
        data = Mid(msg, 3)

        Select Case cmdH
            Case "z"
                REM BTTime = 0
            Case "a"
                mainIndex = data
            Case "b"
                ledBuffer = data
            Case "c"
                l7sBuffer = data
            Case "d"
                Select Case cmdL
                    Case 0
                        BT_RGB_CHECK(0, Mid(data, 1, 6))
                        BT_RGB_CHECK(1, Mid(data, 7, 6))
                    Case 1
                        BT_RGB_CHECK(2, Mid(data, 1, 6))
                        BT_RGB_CHECK(3, Mid(data, 7, 6))
                    Case 2
                        BT_RGB_CHECK(4, Mid(data, 1, 6))
                        BT_RGB_CHECK(5, Mid(data, 7, 6))
                    Case 3
                        BT_RGB_CHECK(6, Mid(data, 1, 6))
                        BT_RGB_CHECK(7, Mid(data, 7, 6))
                End Select
            Case "e"

        End Select
    End Sub
    Sub BT_RGB_CHECK(index, d)
        Dim dataR, dataG, dataB As String

        dataR = HEX_TO_INT(Mid(d, 1, 2))
        dataG = HEX_TO_INT(Mid(d, 3, 2))
        dataB = HEX_TO_INT(Mid(d, 5, 2))

        rgb(index).FillColor = Color.FromArgb(dataR, dataG, dataB)
    End Sub


    Sub CHECK_LED()
        Dim i As Short
        For i = 0 To 7
            If (ledBuffer And 2 ^ i) > 0 Then
                led(i).FillColor = Color.Yellow
            Else
                led(i).FillColor = Color.Olive
            End If
        Next i
    End Sub
    Sub CHECK_RGB()
        For i = 0 To 7
            rgb(i).FillColor = Color.FromArgb(rgbBuffer(i, 0), rgbBuffer(i, 1), rgbBuffer(i, 2))
        Next
    End Sub



    Private Sub OvalShape_LED0_Click(sender As Object, e As EventArgs) Handles OvalShape_LED0.Click
        DATA_SEND(2, 0, 1, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED1_Click(sender As Object, e As EventArgs) Handles OvalShape_LED1.Click
        DATA_SEND(2, 0, 2, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED2_Click(sender As Object, e As EventArgs) Handles OvalShape_LED2.Click
        DATA_SEND(2, 0, 4, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED3_Click(sender As Object, e As EventArgs) Handles OvalShape_LED3.Click
        DATA_SEND(2, 0, 8, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED4_Click(sender As Object, e As EventArgs) Handles OvalShape_LED4.Click
        DATA_SEND(2, 0, 16, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED5_Click(sender As Object, e As EventArgs) Handles OvalShape_LED5.Click
        DATA_SEND(2, 0, 32, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED6_Click(sender As Object, e As EventArgs) Handles OvalShape_LED6.Click
        DATA_SEND(2, 0, 64, 0, 0, 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_LED7_Click(sender As Object, e As EventArgs) Handles OvalShape_LED7.Click
        DATA_SEND(2, 0, 128, 0, 0, 0, 0, 0, True)
    End Sub


    Private Sub OvalShape_RGB0_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB0.Click
        DATA_SEND(3, 0, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB1_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB1.Click
        DATA_SEND(3, 1, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB2_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB2.Click
        DATA_SEND(3, 2, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB3_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB3.Click
        DATA_SEND(3, 3, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB4_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB4.Click
        DATA_SEND(3, 4, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB5_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB5.Click
        DATA_SEND(3, 5, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB6_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB6.Click
        DATA_SEND(3, 6, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub
    Private Sub OvalShape_RGB7_Click(sender As Object, e As EventArgs) Handles OvalShape_RGB7.Click
        DATA_SEND(3, 7, rgbSelected(0), rgbSelected(1), rgbSelected(2), 0, 0, 0, True)
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (ColorDialog1.ShowDialog() <> DialogResult.Cancel) Then
            PictureBox1.BackColor = ColorDialog1.Color
            rgbSelected(0) = ColorDialog1.Color.R
            rgbSelected(1) = ColorDialog1.Color.G
            rgbSelected(2) = ColorDialog1.Color.B
        End If
    End Sub

    Private Sub Button_Switch_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_Switch4.MouseDown, Button_Switch3.MouseDown, Button_Switch2.MouseDown, Button_Switch1.MouseDown
        If sender.ToString.Contains("S1") Then
            DATA_SEND(4, 0, 0, 0, 0, 0, 0, 0, True)
            Button_Switch1.BackColor = Color.Yellow
        ElseIf sender.ToString.Contains("S2") Then
            DATA_SEND(4, 1, 0, 0, 0, 0, 0, 0, True)
            Button_Switch2.BackColor = Color.Yellow
        ElseIf sender.ToString.Contains("S3") Then
            DATA_SEND(4, 2, 0, 0, 0, 0, 0, 0, True)
            Button_Switch3.BackColor = Color.Yellow
        ElseIf sender.ToString.Contains("S4") Then
            DATA_SEND(4, 3, 0, 0, 0, 0, 0, 0, True)
            Button_Switch4.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub Button_Switch1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_Switch4.MouseUp, Button_Switch3.MouseUp, Button_Switch2.MouseUp, Button_Switch1.MouseUp
        If sender.ToString.Contains("S1") Then
            Button_Switch1.BackColor = Color.WhiteSmoke
        ElseIf sender.ToString.Contains("S2") Then
            Button_Switch2.BackColor = Color.WhiteSmoke
        ElseIf sender.ToString.Contains("S3") Then
            Button_Switch3.BackColor = Color.WhiteSmoke
        ElseIf sender.ToString.Contains("S4") Then
            Button_Switch4.BackColor = Color.WhiteSmoke
        End If
    End Sub



    Private Sub TextBox_EEPROM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_EEPROM.KeyPress
        If e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub Button_EXIT_Click(sender As Object, e As EventArgs) Handles Button_EXIT.Click
        End
    End Sub
End Class
