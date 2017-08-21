Imports System
Imports System.IO.Ports

Public Class GasMonitor
    Dim comPort As String
    Dim receivedData As String = ""

    Private Sub GasMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sysTimer.Enabled = False
        comPort = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            commPortComboBox.Items.Add(sp)
        Next
    End Sub

    Private Sub commandTextBox_TextChanged(sender As Object, e As EventArgs) Handles commandTextBox.TextChanged
        commandTextBox.SelectionStart = commandTextBox.TextLength
        commandTextBox.ScrollToCaret()
    End Sub

    Private Sub commPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles commPortComboBox.SelectedIndexChanged
        If (commPortComboBox.SelectedItem <> "") Then
            comPort = commPortComboBox.SelectedItem
        End If
    End Sub

    Private Sub connectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        If (comPort <> "") Then
            sysSerialPort.Close()
            sysSerialPort.PortName = comPort
            sysSerialPort.BaudRate = 9600
            sysSerialPort.DataBits = 8
            sysSerialPort.Parity = Parity.None
            sysSerialPort.StopBits = StopBits.One
            sysSerialPort.Handshake = Handshake.None
            sysSerialPort.Encoding = System.Text.Encoding.Default 'very important!
            sysSerialPort.ReadTimeout = 10000

            sysSerialPort.Open()
            statusTextBox.Text = "Connected"
            sysTimer.Enabled = True
        Else
            MsgBox("Please select a communication port.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub disconnectButton_Click(sender As Object, e As EventArgs) Handles disconnectButton.Click
        If statusTextBox.Text = "Connected" Then
            sysSerialPort.Close()
            statusTextBox.Text = "Disconnected"
            sysTimer.Enabled = False
        Else
            MsgBox("You are not currently connected.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub sysTimer_Tick(sender As Object, e As EventArgs) Handles sysTimer.Tick
        sysTimer.Enabled = False

        receivedData = ReceiveSerialData()
        'commandTextBox.Text &= receivedData

        If ((receivedData.Contains("<") And receivedData.Contains(">"))) Then
            parseData()
        End If

        sysTimer.Enabled = True
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = sysSerialPort.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Function parseData()

        ' uses the global variable receivedData
        Dim pos1 As Integer
        Dim pos2 As Integer
        Dim length As Integer
        Dim newCommand As String
        Dim sensorName As String
        Dim sensorValue As String
        Dim done As Boolean = False

        While (Not done)

            pos1 = receivedData.IndexOf("<") + 1
            pos2 = receivedData.IndexOf(">") + 1

            If (pos2 < pos1) Then
                receivedData = Microsoft.VisualBasic.Mid(receivedData, pos2 + 1)
                pos1 = receivedData.IndexOf("<") + 1
                pos2 = receivedData.IndexOf(">") + 1
            End If
            If (pos1 = 0 Or pos2 = 0) Then
                done = True
            Else
                length = pos2 - pos1 + 1
                If (length > 0) Then
                    newCommand = Mid(receivedData, pos1 + 1, length - 2)
                    sensorName = newCommand.Substring(0, 6)
                    sensorValue = Mid(newCommand, 7)
                    receivedData = Mid(receivedData, pos2 + 1)

                    If (sensorName = "MQ2INP") Then
                        mq2Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ2AVG") Then
                        mq2Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ2WRN") Then
                        mq2Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ2ALM") Then
                        mq2Alm.Text = sensorValue
                    ElseIf (sensorName = "MQ3INP") Then
                        mq3Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ3AVG") Then
                        mq3Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ3WRN") Then
                        mq3Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ3ALM") Then
                        mq3Alm.Text = sensorValue
                    ElseIf (sensorName = "MQ4INP") Then
                        mq4Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ4AVG") Then
                        mq4Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ4WRN") Then
                        mq4Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ4ALM") Then
                        mq4Alm.Text = sensorValue
                    ElseIf (sensorName = "MQ5INP") Then
                        mq5Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ5AVG") Then
                        mq5Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ5WRN") Then
                        mq5Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ5ALM") Then
                        mq5Alm.Text = sensorValue
                    ElseIf (sensorName = "MQ8INP") Then
                        mq8Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ8AVG") Then
                        mq8Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ8WRN") Then
                        mq8Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ8ALM") Then
                        mq8Alm.Text = sensorValue
                    ElseIf (sensorName = "MQ9INP") Then
                        mq9Inp.Text = sensorValue
                    ElseIf (sensorName = "MQ9AVG") Then
                        mq9Avg.Text = sensorValue
                    ElseIf (sensorName = "MQ9WRN") Then
                        mq9Wrn.Text = sensorValue
                    ElseIf (sensorName = "MQ9ALM") Then
                        mq9Alm.Text = sensorValue
                    Else
                        commandTextBox.AppendText(newCommand & vbCrLf)
                    End If
                End If
            End If
        End While
    End Function
End Class
