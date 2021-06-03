<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox_LED_Control = New System.Windows.Forms.GroupBox()
        Me.Button_Clean_LED = New System.Windows.Forms.Button()
        Me.Button_Even_LED = New System.Windows.Forms.Button()
        Me.Button_Odd_LED = New System.Windows.Forms.Button()
        Me.Label_LED0 = New System.Windows.Forms.Label()
        Me.Label_LED1 = New System.Windows.Forms.Label()
        Me.Label_LED2 = New System.Windows.Forms.Label()
        Me.Label_LED3 = New System.Windows.Forms.Label()
        Me.Label_LED4 = New System.Windows.Forms.Label()
        Me.Label_LED5 = New System.Windows.Forms.Label()
        Me.Label_LED6 = New System.Windows.Forms.Label()
        Me.Label_LED7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape_LED0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_LED7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_RGB0 = New System.Windows.Forms.Label()
        Me.Label_RGB1 = New System.Windows.Forms.Label()
        Me.Label_RGB2 = New System.Windows.Forms.Label()
        Me.Label_RGB3 = New System.Windows.Forms.Label()
        Me.Label_RGB4 = New System.Windows.Forms.Label()
        Me.Label_RGB5 = New System.Windows.Forms.Label()
        Me.Label_RGB6 = New System.Windows.Forms.Label()
        Me.Label_RGB7 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape_RGB0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_RGB7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Button_EXIT = New System.Windows.Forms.Button()
        Me.Label_Current_Time = New System.Windows.Forms.Label()
        Me.Label_Status = New System.Windows.Forms.Label()
        Me.Label_Device = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button_Write = New System.Windows.Forms.Button()
        Me.Button_Read = New System.Windows.Forms.Button()
        Me.TextBox_EEPROM = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label_COM_Port = New System.Windows.Forms.Label()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.ComboBox_COM = New System.Windows.Forms.ComboBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Bluetooth = New System.IO.Ports.SerialPort(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Switch4 = New System.Windows.Forms.Button()
        Me.Button_Switch3 = New System.Windows.Forms.Button()
        Me.Button_Switch2 = New System.Windows.Forms.Button()
        Me.Button_Switch1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox_LED_Control.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_LED_Control
        '
        Me.GroupBox_LED_Control.Controls.Add(Me.Button_Clean_LED)
        Me.GroupBox_LED_Control.Controls.Add(Me.Button_Even_LED)
        Me.GroupBox_LED_Control.Controls.Add(Me.Button_Odd_LED)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED0)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED1)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED2)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED3)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED4)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED5)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED6)
        Me.GroupBox_LED_Control.Controls.Add(Me.Label_LED7)
        Me.GroupBox_LED_Control.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox_LED_Control.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_LED_Control.Name = "GroupBox_LED_Control"
        Me.GroupBox_LED_Control.Size = New System.Drawing.Size(438, 192)
        Me.GroupBox_LED_Control.TabIndex = 1
        Me.GroupBox_LED_Control.TabStop = False
        Me.GroupBox_LED_Control.Text = "LED Control"
        '
        'Button_Clean_LED
        '
        Me.Button_Clean_LED.Location = New System.Drawing.Point(303, 128)
        Me.Button_Clean_LED.Name = "Button_Clean_LED"
        Me.Button_Clean_LED.Size = New System.Drawing.Size(100, 40)
        Me.Button_Clean_LED.TabIndex = 11
        Me.Button_Clean_LED.Text = "Clean LED"
        Me.Button_Clean_LED.UseVisualStyleBackColor = True
        '
        'Button_Even_LED
        '
        Me.Button_Even_LED.Location = New System.Drawing.Point(163, 128)
        Me.Button_Even_LED.Name = "Button_Even_LED"
        Me.Button_Even_LED.Size = New System.Drawing.Size(100, 40)
        Me.Button_Even_LED.TabIndex = 10
        Me.Button_Even_LED.Text = "Even LED"
        Me.Button_Even_LED.UseVisualStyleBackColor = True
        '
        'Button_Odd_LED
        '
        Me.Button_Odd_LED.Location = New System.Drawing.Point(20, 128)
        Me.Button_Odd_LED.Name = "Button_Odd_LED"
        Me.Button_Odd_LED.Size = New System.Drawing.Size(100, 40)
        Me.Button_Odd_LED.TabIndex = 9
        Me.Button_Odd_LED.Text = "Odd LED"
        Me.Button_Odd_LED.UseVisualStyleBackColor = True
        '
        'Label_LED0
        '
        Me.Label_LED0.AutoSize = True
        Me.Label_LED0.Location = New System.Drawing.Point(374, 75)
        Me.Label_LED0.Name = "Label_LED0"
        Me.Label_LED0.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED0.TabIndex = 8
        Me.Label_LED0.Text = "LED0"
        '
        'Label_LED1
        '
        Me.Label_LED1.AutoSize = True
        Me.Label_LED1.Location = New System.Drawing.Point(323, 75)
        Me.Label_LED1.Name = "Label_LED1"
        Me.Label_LED1.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED1.TabIndex = 7
        Me.Label_LED1.Text = "LED1"
        '
        'Label_LED2
        '
        Me.Label_LED2.AutoSize = True
        Me.Label_LED2.Location = New System.Drawing.Point(272, 75)
        Me.Label_LED2.Name = "Label_LED2"
        Me.Label_LED2.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED2.TabIndex = 6
        Me.Label_LED2.Text = "LED2"
        '
        'Label_LED3
        '
        Me.Label_LED3.AutoSize = True
        Me.Label_LED3.Location = New System.Drawing.Point(221, 75)
        Me.Label_LED3.Name = "Label_LED3"
        Me.Label_LED3.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED3.TabIndex = 5
        Me.Label_LED3.Text = "LED3"
        '
        'Label_LED4
        '
        Me.Label_LED4.AutoSize = True
        Me.Label_LED4.Location = New System.Drawing.Point(170, 75)
        Me.Label_LED4.Name = "Label_LED4"
        Me.Label_LED4.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED4.TabIndex = 4
        Me.Label_LED4.Text = "LED4"
        '
        'Label_LED5
        '
        Me.Label_LED5.AutoSize = True
        Me.Label_LED5.Location = New System.Drawing.Point(119, 75)
        Me.Label_LED5.Name = "Label_LED5"
        Me.Label_LED5.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED5.TabIndex = 3
        Me.Label_LED5.Text = "LED5"
        '
        'Label_LED6
        '
        Me.Label_LED6.AutoSize = True
        Me.Label_LED6.Location = New System.Drawing.Point(68, 75)
        Me.Label_LED6.Name = "Label_LED6"
        Me.Label_LED6.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED6.TabIndex = 2
        Me.Label_LED6.Text = "LED6"
        '
        'Label_LED7
        '
        Me.Label_LED7.AutoSize = True
        Me.Label_LED7.Location = New System.Drawing.Point(17, 75)
        Me.Label_LED7.Name = "Label_LED7"
        Me.Label_LED7.Size = New System.Drawing.Size(45, 16)
        Me.Label_LED7.TabIndex = 1
        Me.Label_LED7.Text = "LED7"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape_LED0, Me.OvalShape_LED1, Me.OvalShape_LED2, Me.OvalShape_LED3, Me.OvalShape_LED4, Me.OvalShape_LED5, Me.OvalShape_LED6, Me.OvalShape_LED7})
        Me.ShapeContainer1.Size = New System.Drawing.Size(432, 166)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape_LED0
        '
        Me.OvalShape_LED0.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED0.Location = New System.Drawing.Point(374, 15)
        Me.OvalShape_LED0.Name = "OvalShape_LED0"
        Me.OvalShape_LED0.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED1
        '
        Me.OvalShape_LED1.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED1.Location = New System.Drawing.Point(323, 15)
        Me.OvalShape_LED1.Name = "OvalShape_LED1"
        Me.OvalShape_LED1.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED2
        '
        Me.OvalShape_LED2.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED2.Location = New System.Drawing.Point(272, 15)
        Me.OvalShape_LED2.Name = "OvalShape_LED2"
        Me.OvalShape_LED2.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED3
        '
        Me.OvalShape_LED3.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED3.Location = New System.Drawing.Point(221, 15)
        Me.OvalShape_LED3.Name = "OvalShape_LED3"
        Me.OvalShape_LED3.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED4
        '
        Me.OvalShape_LED4.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED4.Location = New System.Drawing.Point(170, 15)
        Me.OvalShape_LED4.Name = "OvalShape_LED4"
        Me.OvalShape_LED4.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED5
        '
        Me.OvalShape_LED5.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED5.Location = New System.Drawing.Point(119, 15)
        Me.OvalShape_LED5.Name = "OvalShape_LED5"
        Me.OvalShape_LED5.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED6
        '
        Me.OvalShape_LED6.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED6.Location = New System.Drawing.Point(68, 15)
        Me.OvalShape_LED6.Name = "OvalShape_LED6"
        Me.OvalShape_LED6.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_LED7
        '
        Me.OvalShape_LED7.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_LED7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_LED7.Location = New System.Drawing.Point(17, 15)
        Me.OvalShape_LED7.Name = "OvalShape_LED7"
        Me.OvalShape_LED7.Size = New System.Drawing.Size(25, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label_RGB0)
        Me.GroupBox1.Controls.Add(Me.Label_RGB1)
        Me.GroupBox1.Controls.Add(Me.Label_RGB2)
        Me.GroupBox1.Controls.Add(Me.Label_RGB3)
        Me.GroupBox1.Controls.Add(Me.Label_RGB4)
        Me.GroupBox1.Controls.Add(Me.Label_RGB5)
        Me.GroupBox1.Controls.Add(Me.Label_RGB6)
        Me.GroupBox1.Controls.Add(Me.Label_RGB7)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 192)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB Control"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(34, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label_RGB0
        '
        Me.Label_RGB0.AutoSize = True
        Me.Label_RGB0.Location = New System.Drawing.Point(374, 75)
        Me.Label_RGB0.Name = "Label_RGB0"
        Me.Label_RGB0.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB0.TabIndex = 8
        Me.Label_RGB0.Text = "RGB0"
        '
        'Label_RGB1
        '
        Me.Label_RGB1.AutoSize = True
        Me.Label_RGB1.Location = New System.Drawing.Point(323, 75)
        Me.Label_RGB1.Name = "Label_RGB1"
        Me.Label_RGB1.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB1.TabIndex = 7
        Me.Label_RGB1.Text = "RGB1"
        '
        'Label_RGB2
        '
        Me.Label_RGB2.AutoSize = True
        Me.Label_RGB2.Location = New System.Drawing.Point(272, 75)
        Me.Label_RGB2.Name = "Label_RGB2"
        Me.Label_RGB2.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB2.TabIndex = 6
        Me.Label_RGB2.Text = "RGB2"
        '
        'Label_RGB3
        '
        Me.Label_RGB3.AutoSize = True
        Me.Label_RGB3.Location = New System.Drawing.Point(221, 75)
        Me.Label_RGB3.Name = "Label_RGB3"
        Me.Label_RGB3.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB3.TabIndex = 5
        Me.Label_RGB3.Text = "RGB3"
        '
        'Label_RGB4
        '
        Me.Label_RGB4.AutoSize = True
        Me.Label_RGB4.Location = New System.Drawing.Point(170, 75)
        Me.Label_RGB4.Name = "Label_RGB4"
        Me.Label_RGB4.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB4.TabIndex = 4
        Me.Label_RGB4.Text = "RGB4"
        '
        'Label_RGB5
        '
        Me.Label_RGB5.AutoSize = True
        Me.Label_RGB5.Location = New System.Drawing.Point(119, 75)
        Me.Label_RGB5.Name = "Label_RGB5"
        Me.Label_RGB5.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB5.TabIndex = 3
        Me.Label_RGB5.Text = "RGB5"
        '
        'Label_RGB6
        '
        Me.Label_RGB6.AutoSize = True
        Me.Label_RGB6.Location = New System.Drawing.Point(68, 75)
        Me.Label_RGB6.Name = "Label_RGB6"
        Me.Label_RGB6.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB6.TabIndex = 2
        Me.Label_RGB6.Text = "RGB6"
        '
        'Label_RGB7
        '
        Me.Label_RGB7.AutoSize = True
        Me.Label_RGB7.Location = New System.Drawing.Point(17, 75)
        Me.Label_RGB7.Name = "Label_RGB7"
        Me.Label_RGB7.Size = New System.Drawing.Size(47, 16)
        Me.Label_RGB7.TabIndex = 1
        Me.Label_RGB7.Text = "RGB7"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape_RGB0, Me.OvalShape_RGB1, Me.OvalShape_RGB2, Me.OvalShape_RGB3, Me.OvalShape_RGB4, Me.OvalShape_RGB5, Me.OvalShape_RGB6, Me.OvalShape_RGB7})
        Me.ShapeContainer2.Size = New System.Drawing.Size(432, 166)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'OvalShape_RGB0
        '
        Me.OvalShape_RGB0.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB0.Location = New System.Drawing.Point(374, 15)
        Me.OvalShape_RGB0.Name = "OvalShape_RGB0"
        Me.OvalShape_RGB0.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB1
        '
        Me.OvalShape_RGB1.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB1.Location = New System.Drawing.Point(323, 15)
        Me.OvalShape_RGB1.Name = "OvalShape_RGB1"
        Me.OvalShape_RGB1.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB2
        '
        Me.OvalShape_RGB2.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB2.Location = New System.Drawing.Point(272, 15)
        Me.OvalShape_RGB2.Name = "OvalShape_RGB2"
        Me.OvalShape_RGB2.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB3
        '
        Me.OvalShape_RGB3.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB3.Location = New System.Drawing.Point(221, 15)
        Me.OvalShape_RGB3.Name = "OvalShape_RGB3"
        Me.OvalShape_RGB3.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB4
        '
        Me.OvalShape_RGB4.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB4.Location = New System.Drawing.Point(170, 15)
        Me.OvalShape_RGB4.Name = "OvalShape_RGB4"
        Me.OvalShape_RGB4.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB5
        '
        Me.OvalShape_RGB5.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB5.Location = New System.Drawing.Point(119, 15)
        Me.OvalShape_RGB5.Name = "OvalShape_RGB5"
        Me.OvalShape_RGB5.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB6
        '
        Me.OvalShape_RGB6.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB6.Location = New System.Drawing.Point(68, 15)
        Me.OvalShape_RGB6.Name = "OvalShape_RGB6"
        Me.OvalShape_RGB6.Size = New System.Drawing.Size(25, 25)
        '
        'OvalShape_RGB7
        '
        Me.OvalShape_RGB7.FillColor = System.Drawing.SystemColors.Control
        Me.OvalShape_RGB7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape_RGB7.Location = New System.Drawing.Point(17, 15)
        Me.OvalShape_RGB7.Name = "OvalShape_RGB7"
        Me.OvalShape_RGB7.Size = New System.Drawing.Size(25, 25)
        '
        'Button_EXIT
        '
        Me.Button_EXIT.Location = New System.Drawing.Point(716, 542)
        Me.Button_EXIT.Name = "Button_EXIT"
        Me.Button_EXIT.Size = New System.Drawing.Size(100, 40)
        Me.Button_EXIT.TabIndex = 23
        Me.Button_EXIT.Text = "EXIT"
        Me.Button_EXIT.UseVisualStyleBackColor = True
        '
        'Label_Current_Time
        '
        Me.Label_Current_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_Current_Time.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label_Current_Time.Location = New System.Drawing.Point(648, 431)
        Me.Label_Current_Time.Name = "Label_Current_Time"
        Me.Label_Current_Time.Size = New System.Drawing.Size(250, 40)
        Me.Label_Current_Time.TabIndex = 26
        Me.Label_Current_Time.Text = "Current Time：HH:MM:SS"
        Me.Label_Current_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Status
        '
        Me.Label_Status.AutoSize = True
        Me.Label_Status.Location = New System.Drawing.Point(649, 500)
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(93, 16)
        Me.Label_Status.TabIndex = 25
        Me.Label_Status.Text = "Device Status"
        '
        'Label_Device
        '
        Me.Label_Device.BackColor = System.Drawing.Color.Red
        Me.Label_Device.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_Device.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label_Device.Location = New System.Drawing.Point(748, 486)
        Me.Label_Device.Name = "Label_Device"
        Me.Label_Device.Size = New System.Drawing.Size(150, 40)
        Me.Label_Device.TabIndex = 24
        Me.Label_Device.Text = "Device Offline"
        Me.Label_Device.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button_Write)
        Me.GroupBox5.Controls.Add(Me.Button_Read)
        Me.GroupBox5.Controls.Add(Me.TextBox_EEPROM)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 323)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 113)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "EEPROM"
        '
        'Button_Write
        '
        Me.Button_Write.Location = New System.Drawing.Point(303, 41)
        Me.Button_Write.Name = "Button_Write"
        Me.Button_Write.Size = New System.Drawing.Size(100, 40)
        Me.Button_Write.TabIndex = 2
        Me.Button_Write.Text = "Write"
        Me.Button_Write.UseVisualStyleBackColor = True
        '
        'Button_Read
        '
        Me.Button_Read.Location = New System.Drawing.Point(161, 41)
        Me.Button_Read.Name = "Button_Read"
        Me.Button_Read.Size = New System.Drawing.Size(100, 40)
        Me.Button_Read.TabIndex = 1
        Me.Button_Read.Text = "Read"
        Me.Button_Read.UseVisualStyleBackColor = True
        '
        'TextBox_EEPROM
        '
        Me.TextBox_EEPROM.Location = New System.Drawing.Point(20, 50)
        Me.TextBox_EEPROM.MaxLength = 2
        Me.TextBox_EEPROM.Name = "TextBox_EEPROM"
        Me.TextBox_EEPROM.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_EEPROM.TabIndex = 0
        Me.TextBox_EEPROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label_COM_Port)
        Me.GroupBox4.Controls.Add(Me.Button_Connect)
        Me.GroupBox4.Controls.Add(Me.ComboBox_COM)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(438, 107)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bluetooth"
        '
        'Label_COM_Port
        '
        Me.Label_COM_Port.AutoSize = True
        Me.Label_COM_Port.Location = New System.Drawing.Point(68, 51)
        Me.Label_COM_Port.Name = "Label_COM_Port"
        Me.Label_COM_Port.Size = New System.Drawing.Size(87, 16)
        Me.Label_COM_Port.TabIndex = 12
        Me.Label_COM_Port.Text = "COM Port："
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(303, 39)
        Me.Button_Connect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(100, 40)
        Me.Button_Connect.TabIndex = 18
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'ComboBox_COM
        '
        Me.ComboBox_COM.FormattingEnabled = True
        Me.ComboBox_COM.Location = New System.Drawing.Point(161, 48)
        Me.ComboBox_COM.Name = "ComboBox_COM"
        Me.ComboBox_COM.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox_COM.Sorted = True
        Me.ComboBox_COM.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Switch4)
        Me.GroupBox2.Controls.Add(Me.Button_Switch3)
        Me.GroupBox2.Controls.Add(Me.Button_Switch2)
        Me.GroupBox2.Controls.Add(Me.Button_Switch1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 442)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 113)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Switch"
        '
        'Button_Switch4
        '
        Me.Button_Switch4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_Switch4.Location = New System.Drawing.Point(27, 46)
        Me.Button_Switch4.Name = "Button_Switch4"
        Me.Button_Switch4.Size = New System.Drawing.Size(80, 40)
        Me.Button_Switch4.TabIndex = 5
        Me.Button_Switch4.Text = "S4"
        Me.Button_Switch4.UseVisualStyleBackColor = False
        '
        'Button_Switch3
        '
        Me.Button_Switch3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_Switch3.Location = New System.Drawing.Point(132, 46)
        Me.Button_Switch3.Name = "Button_Switch3"
        Me.Button_Switch3.Size = New System.Drawing.Size(80, 40)
        Me.Button_Switch3.TabIndex = 4
        Me.Button_Switch3.Text = "S3"
        Me.Button_Switch3.UseVisualStyleBackColor = False
        '
        'Button_Switch2
        '
        Me.Button_Switch2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_Switch2.Location = New System.Drawing.Point(234, 46)
        Me.Button_Switch2.Name = "Button_Switch2"
        Me.Button_Switch2.Size = New System.Drawing.Size(80, 40)
        Me.Button_Switch2.TabIndex = 3
        Me.Button_Switch2.Text = "S2"
        Me.Button_Switch2.UseVisualStyleBackColor = False
        '
        'Button_Switch1
        '
        Me.Button_Switch1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_Switch1.Location = New System.Drawing.Point(336, 44)
        Me.Button_Switch1.Name = "Button_Switch1"
        Me.Button_Switch1.Size = New System.Drawing.Size(80, 40)
        Me.Button_Switch1.TabIndex = 2
        Me.Button_Switch1.Text = "S1"
        Me.Button_Switch1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(648, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(645, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 688)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button_EXIT)
        Me.Controls.Add(Me.Label_Current_Time)
        Me.Controls.Add(Me.Label_Status)
        Me.Controls.Add(Me.Label_Device)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_LED_Control)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "109學年度　工業類科學生技藝競賽　電腦修護職種　第二站　崗位號碼：20"
        Me.GroupBox_LED_Control.ResumeLayout(False)
        Me.GroupBox_LED_Control.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_LED_Control As GroupBox
    Friend WithEvents Button_Clean_LED As Button
    Friend WithEvents Button_Even_LED As Button
    Friend WithEvents Button_Odd_LED As Button
    Friend WithEvents Label_LED0 As Label
    Friend WithEvents Label_LED1 As Label
    Friend WithEvents Label_LED2 As Label
    Friend WithEvents Label_LED3 As Label
    Friend WithEvents Label_LED4 As Label
    Friend WithEvents Label_LED5 As Label
    Friend WithEvents Label_LED6 As Label
    Friend WithEvents Label_LED7 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape_LED0 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED4 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED5 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED6 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_LED7 As PowerPacks.OvalShape
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_RGB0 As Label
    Friend WithEvents Label_RGB1 As Label
    Friend WithEvents Label_RGB2 As Label
    Friend WithEvents Label_RGB3 As Label
    Friend WithEvents Label_RGB4 As Label
    Friend WithEvents Label_RGB5 As Label
    Friend WithEvents Label_RGB6 As Label
    Friend WithEvents Label_RGB7 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape_RGB0 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB4 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB5 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB6 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_RGB7 As PowerPacks.OvalShape
    Friend WithEvents Button_EXIT As Button
    Friend WithEvents Label_Current_Time As Label
    Friend WithEvents Label_Status As Label
    Friend WithEvents Label_Device As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button_Write As Button
    Friend WithEvents Button_Read As Button
    Friend WithEvents TextBox_EEPROM As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label_COM_Port As Label
    Friend WithEvents Button_Connect As Button
    Friend WithEvents ComboBox_COM As ComboBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Bluetooth As IO.Ports.SerialPort
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button_Switch4 As Button
    Friend WithEvents Button_Switch3 As Button
    Friend WithEvents Button_Switch2 As Button
    Friend WithEvents Button_Switch1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
