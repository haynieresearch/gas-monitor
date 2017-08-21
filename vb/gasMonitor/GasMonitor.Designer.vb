<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GasMonitor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.disconnectButton = New System.Windows.Forms.Button()
        Me.connectButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.commPortComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commandTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mq2Alm = New System.Windows.Forms.Label()
        Me.mq2Wrn = New System.Windows.Forms.Label()
        Me.mq2Avg = New System.Windows.Forms.Label()
        Me.mq2Inp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mq3Alm = New System.Windows.Forms.Label()
        Me.mq3Wrn = New System.Windows.Forms.Label()
        Me.mq3Avg = New System.Windows.Forms.Label()
        Me.mq3Inp = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mq4Alm = New System.Windows.Forms.Label()
        Me.mq4Wrn = New System.Windows.Forms.Label()
        Me.mq4Avg = New System.Windows.Forms.Label()
        Me.mq4Inp = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.mq5Alm = New System.Windows.Forms.Label()
        Me.mq5Wrn = New System.Windows.Forms.Label()
        Me.mq5Avg = New System.Windows.Forms.Label()
        Me.mq5Inp = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.mq8Alm = New System.Windows.Forms.Label()
        Me.mq8Wrn = New System.Windows.Forms.Label()
        Me.mq8Avg = New System.Windows.Forms.Label()
        Me.mq8Inp = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.mq9Alm = New System.Windows.Forms.Label()
        Me.mq9Wrn = New System.Windows.Forms.Label()
        Me.mq9Avg = New System.Windows.Forms.Label()
        Me.mq9Inp = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.sysTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sysSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gas Monitor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Haynie Research and Development"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.statusTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.disconnectButton)
        Me.GroupBox2.Controls.Add(Me.connectButton)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.commPortComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 146)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Interface Connection"
        '
        'statusTextBox
        '
        Me.statusTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusTextBox.Location = New System.Drawing.Point(9, 115)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(223, 20)
        Me.statusTextBox.TabIndex = 5
        Me.statusTextBox.Text = "Disconnected"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Status"
        '
        'disconnectButton
        '
        Me.disconnectButton.Location = New System.Drawing.Point(134, 59)
        Me.disconnectButton.Name = "disconnectButton"
        Me.disconnectButton.Size = New System.Drawing.Size(98, 27)
        Me.disconnectButton.TabIndex = 3
        Me.disconnectButton.Text = "Disconnect"
        Me.disconnectButton.UseVisualStyleBackColor = True
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(9, 59)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(98, 27)
        Me.connectButton.TabIndex = 2
        Me.connectButton.Text = "Connect"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Communication Port"
        '
        'commPortComboBox
        '
        Me.commPortComboBox.FormattingEnabled = True
        Me.commPortComboBox.Location = New System.Drawing.Point(9, 32)
        Me.commPortComboBox.Name = "commPortComboBox"
        Me.commPortComboBox.Size = New System.Drawing.Size(223, 21)
        Me.commPortComboBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.commandTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 146)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command Monitor"
        '
        'commandTextBox
        '
        Me.commandTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.commandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commandTextBox.Location = New System.Drawing.Point(6, 19)
        Me.commandTextBox.Name = "commandTextBox"
        Me.commandTextBox.ReadOnly = True
        Me.commandTextBox.Size = New System.Drawing.Size(415, 121)
        Me.commandTextBox.TabIndex = 3
        Me.commandTextBox.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mq2Alm)
        Me.GroupBox3.Controls.Add(Me.mq2Wrn)
        Me.GroupBox3.Controls.Add(Me.mq2Avg)
        Me.GroupBox3.Controls.Add(Me.mq2Inp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MQ2 Sensor Data"
        '
        'mq2Alm
        '
        Me.mq2Alm.AutoSize = True
        Me.mq2Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq2Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq2Alm.Name = "mq2Alm"
        Me.mq2Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq2Alm.TabIndex = 7
        Me.mq2Alm.Text = "0000"
        '
        'mq2Wrn
        '
        Me.mq2Wrn.AutoSize = True
        Me.mq2Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq2Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq2Wrn.Name = "mq2Wrn"
        Me.mq2Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq2Wrn.TabIndex = 6
        Me.mq2Wrn.Text = "0000"
        '
        'mq2Avg
        '
        Me.mq2Avg.AutoSize = True
        Me.mq2Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq2Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq2Avg.Name = "mq2Avg"
        Me.mq2Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq2Avg.TabIndex = 5
        Me.mq2Avg.Text = "0000"
        '
        'mq2Inp
        '
        Me.mq2Inp.AutoSize = True
        Me.mq2Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq2Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq2Inp.Name = "mq2Inp"
        Me.mq2Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq2Inp.TabIndex = 4
        Me.mq2Inp.Text = "0000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Alarm Value.......:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Warning Value....:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Average Reading.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Last Reading......:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mq3Alm)
        Me.GroupBox4.Controls.Add(Me.mq3Wrn)
        Me.GroupBox4.Controls.Add(Me.mq3Avg)
        Me.GroupBox4.Controls.Add(Me.mq3Inp)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(238, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MQ3 Sensor Data"
        '
        'mq3Alm
        '
        Me.mq3Alm.AutoSize = True
        Me.mq3Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq3Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq3Alm.Name = "mq3Alm"
        Me.mq3Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq3Alm.TabIndex = 7
        Me.mq3Alm.Text = "0000"
        '
        'mq3Wrn
        '
        Me.mq3Wrn.AutoSize = True
        Me.mq3Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq3Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq3Wrn.Name = "mq3Wrn"
        Me.mq3Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq3Wrn.TabIndex = 6
        Me.mq3Wrn.Text = "0000"
        '
        'mq3Avg
        '
        Me.mq3Avg.AutoSize = True
        Me.mq3Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq3Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq3Avg.Name = "mq3Avg"
        Me.mq3Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq3Avg.TabIndex = 5
        Me.mq3Avg.Text = "0000"
        '
        'mq3Inp
        '
        Me.mq3Inp.AutoSize = True
        Me.mq3Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq3Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq3Inp.Name = "mq3Inp"
        Me.mq3Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq3Inp.TabIndex = 4
        Me.mq3Inp.Text = "0000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 18)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Alarm Value.......:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 18)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Warning Value....:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(159, 18)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Average Reading.:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(158, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Last Reading......:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.mq4Alm)
        Me.GroupBox5.Controls.Add(Me.mq4Wrn)
        Me.GroupBox5.Controls.Add(Me.mq4Avg)
        Me.GroupBox5.Controls.Add(Me.mq4Inp)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(464, 70)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MQ4 Sensor Data"
        '
        'mq4Alm
        '
        Me.mq4Alm.AutoSize = True
        Me.mq4Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq4Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq4Alm.Name = "mq4Alm"
        Me.mq4Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq4Alm.TabIndex = 7
        Me.mq4Alm.Text = "0000"
        '
        'mq4Wrn
        '
        Me.mq4Wrn.AutoSize = True
        Me.mq4Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq4Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq4Wrn.Name = "mq4Wrn"
        Me.mq4Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq4Wrn.TabIndex = 6
        Me.mq4Wrn.Text = "0000"
        '
        'mq4Avg
        '
        Me.mq4Avg.AutoSize = True
        Me.mq4Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq4Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq4Avg.Name = "mq4Avg"
        Me.mq4Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq4Avg.TabIndex = 5
        Me.mq4Avg.Text = "0000"
        '
        'mq4Inp
        '
        Me.mq4Inp.AutoSize = True
        Me.mq4Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq4Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq4Inp.Name = "mq4Inp"
        Me.mq4Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq4Inp.TabIndex = 4
        Me.mq4Inp.Text = "0000"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 105)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(156, 18)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Alarm Value.......:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(159, 18)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Warning Value....:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 45)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(159, 18)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Average Reading.:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(158, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Last Reading......:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.mq5Alm)
        Me.GroupBox6.Controls.Add(Me.mq5Wrn)
        Me.GroupBox6.Controls.Add(Me.mq5Avg)
        Me.GroupBox6.Controls.Add(Me.mq5Inp)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "MQ5 Sensor Data"
        '
        'mq5Alm
        '
        Me.mq5Alm.AutoSize = True
        Me.mq5Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq5Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq5Alm.Name = "mq5Alm"
        Me.mq5Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq5Alm.TabIndex = 7
        Me.mq5Alm.Text = "0000"
        '
        'mq5Wrn
        '
        Me.mq5Wrn.AutoSize = True
        Me.mq5Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq5Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq5Wrn.Name = "mq5Wrn"
        Me.mq5Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq5Wrn.TabIndex = 6
        Me.mq5Wrn.Text = "0000"
        '
        'mq5Avg
        '
        Me.mq5Avg.AutoSize = True
        Me.mq5Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq5Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq5Avg.Name = "mq5Avg"
        Me.mq5Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq5Avg.TabIndex = 5
        Me.mq5Avg.Text = "0000"
        '
        'mq5Inp
        '
        Me.mq5Inp.AutoSize = True
        Me.mq5Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq5Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq5Inp.Name = "mq5Inp"
        Me.mq5Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq5Inp.TabIndex = 4
        Me.mq5Inp.Text = "0000"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(6, 105)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(156, 18)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Alarm Value.......:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(6, 75)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(159, 18)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Warning Value....:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 45)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(159, 18)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Average Reading.:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 15)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(158, 18)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Last Reading......:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.mq8Alm)
        Me.GroupBox7.Controls.Add(Me.mq8Wrn)
        Me.GroupBox7.Controls.Add(Me.mq8Avg)
        Me.GroupBox7.Controls.Add(Me.mq8Inp)
        Me.GroupBox7.Controls.Add(Me.Label41)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.Label44)
        Me.GroupBox7.Location = New System.Drawing.Point(238, 211)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "MQ8 Sensor Data"
        '
        'mq8Alm
        '
        Me.mq8Alm.AutoSize = True
        Me.mq8Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq8Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq8Alm.Name = "mq8Alm"
        Me.mq8Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq8Alm.TabIndex = 7
        Me.mq8Alm.Text = "0000"
        '
        'mq8Wrn
        '
        Me.mq8Wrn.AutoSize = True
        Me.mq8Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq8Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq8Wrn.Name = "mq8Wrn"
        Me.mq8Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq8Wrn.TabIndex = 6
        Me.mq8Wrn.Text = "0000"
        '
        'mq8Avg
        '
        Me.mq8Avg.AutoSize = True
        Me.mq8Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq8Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq8Avg.Name = "mq8Avg"
        Me.mq8Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq8Avg.TabIndex = 5
        Me.mq8Avg.Text = "0000"
        '
        'mq8Inp
        '
        Me.mq8Inp.AutoSize = True
        Me.mq8Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq8Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq8Inp.Name = "mq8Inp"
        Me.mq8Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq8Inp.TabIndex = 4
        Me.mq8Inp.Text = "0000"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(6, 105)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(156, 18)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Alarm Value.......:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 75)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(159, 18)
        Me.Label42.TabIndex = 2
        Me.Label42.Text = "Warning Value....:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(6, 45)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(159, 18)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "Average Reading.:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(6, 15)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(158, 18)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Last Reading......:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.mq9Alm)
        Me.GroupBox8.Controls.Add(Me.mq9Wrn)
        Me.GroupBox8.Controls.Add(Me.mq9Avg)
        Me.GroupBox8.Controls.Add(Me.mq9Inp)
        Me.GroupBox8.Controls.Add(Me.Label49)
        Me.GroupBox8.Controls.Add(Me.Label50)
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.Label52)
        Me.GroupBox8.Location = New System.Drawing.Point(464, 211)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(220, 132)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "MQ9 Sensor Data"
        '
        'mq9Alm
        '
        Me.mq9Alm.AutoSize = True
        Me.mq9Alm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq9Alm.Location = New System.Drawing.Point(168, 105)
        Me.mq9Alm.Name = "mq9Alm"
        Me.mq9Alm.Size = New System.Drawing.Size(48, 18)
        Me.mq9Alm.TabIndex = 7
        Me.mq9Alm.Text = "0000"
        '
        'mq9Wrn
        '
        Me.mq9Wrn.AutoSize = True
        Me.mq9Wrn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq9Wrn.Location = New System.Drawing.Point(168, 75)
        Me.mq9Wrn.Name = "mq9Wrn"
        Me.mq9Wrn.Size = New System.Drawing.Size(48, 18)
        Me.mq9Wrn.TabIndex = 6
        Me.mq9Wrn.Text = "0000"
        '
        'mq9Avg
        '
        Me.mq9Avg.AutoSize = True
        Me.mq9Avg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq9Avg.Location = New System.Drawing.Point(168, 45)
        Me.mq9Avg.Name = "mq9Avg"
        Me.mq9Avg.Size = New System.Drawing.Size(48, 18)
        Me.mq9Avg.TabIndex = 5
        Me.mq9Avg.Text = "0000"
        '
        'mq9Inp
        '
        Me.mq9Inp.AutoSize = True
        Me.mq9Inp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mq9Inp.Location = New System.Drawing.Point(168, 15)
        Me.mq9Inp.Name = "mq9Inp"
        Me.mq9Inp.Size = New System.Drawing.Size(48, 18)
        Me.mq9Inp.TabIndex = 4
        Me.mq9Inp.Text = "0000"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(6, 105)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(156, 18)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "Alarm Value.......:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(6, 75)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(159, 18)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Warning Value....:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(6, 45)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(159, 18)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "Average Reading.:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(6, 15)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(158, 18)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "Last Reading......:"
        '
        'sysTimer
        '
        Me.sysTimer.Interval = 1000
        '
        'GasMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 503)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GasMonitor"
        Me.Text = "Gas Monitor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents statusTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents disconnectButton As Button
    Friend WithEvents connectButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents commPortComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents commandTextBox As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mq2Alm As Label
    Friend WithEvents mq2Wrn As Label
    Friend WithEvents mq2Avg As Label
    Friend WithEvents mq2Inp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents mq3Alm As Label
    Friend WithEvents mq3Wrn As Label
    Friend WithEvents mq3Avg As Label
    Friend WithEvents mq3Inp As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents mq4Alm As Label
    Friend WithEvents mq4Wrn As Label
    Friend WithEvents mq4Avg As Label
    Friend WithEvents mq4Inp As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents mq5Alm As Label
    Friend WithEvents mq5Wrn As Label
    Friend WithEvents mq5Avg As Label
    Friend WithEvents mq5Inp As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents mq8Alm As Label
    Friend WithEvents mq8Wrn As Label
    Friend WithEvents mq8Avg As Label
    Friend WithEvents mq8Inp As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents mq9Alm As Label
    Friend WithEvents mq9Wrn As Label
    Friend WithEvents mq9Avg As Label
    Friend WithEvents mq9Inp As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents sysTimer As Timer
    Friend WithEvents sysSerialPort As IO.Ports.SerialPort
End Class
