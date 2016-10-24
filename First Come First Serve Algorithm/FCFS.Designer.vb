<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCFS
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAverageTime = New System.Windows.Forms.TextBox()
        Me.txtTotalTime = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtWaitingTime_5 = New System.Windows.Forms.TextBox()
        Me.txtWaitingTime_4 = New System.Windows.Forms.TextBox()
        Me.txtWaitingTime_3 = New System.Windows.Forms.TextBox()
        Me.txtWaitingTime_2 = New System.Windows.Forms.TextBox()
        Me.txtWaitingTime_1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WaitingProcess_5 = New System.Windows.Forms.TextBox()
        Me.WaitingProcess_4 = New System.Windows.Forms.TextBox()
        Me.WaitingProcess_3 = New System.Windows.Forms.TextBox()
        Me.WaitingProcess_2 = New System.Windows.Forms.TextBox()
        Me.WaitingProcess_1 = New System.Windows.Forms.TextBox()
        Me.lblCPUBurst_5 = New System.Windows.Forms.Label()
        Me.lblCPUBurst_4 = New System.Windows.Forms.Label()
        Me.lblCPUBurst_3 = New System.Windows.Forms.Label()
        Me.lblCPUBurst_2 = New System.Windows.Forms.Label()
        Me.lblCPUBurst_1 = New System.Windows.Forms.Label()
        Me.lblArrivalTime = New System.Windows.Forms.Label()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProcessID_5 = New System.Windows.Forms.TextBox()
        Me.ProcessID_4 = New System.Windows.Forms.TextBox()
        Me.ProcessID_3 = New System.Windows.Forms.TextBox()
        Me.ProcessID_2 = New System.Windows.Forms.TextBox()
        Me.ProcessID_1 = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtCPUBurst_5 = New System.Windows.Forms.TextBox()
        Me.txtCPUBurst_4 = New System.Windows.Forms.TextBox()
        Me.txtCPUBurst_3 = New System.Windows.Forms.TextBox()
        Me.txtCPUBurst_2 = New System.Windows.Forms.TextBox()
        Me.txtCPUBurst_1 = New System.Windows.Forms.TextBox()
        Me.txtArrivalTime_5 = New System.Windows.Forms.TextBox()
        Me.txtArrivalTime_4 = New System.Windows.Forms.TextBox()
        Me.txtArrivalTime_3 = New System.Windows.Forms.TextBox()
        Me.txtArrivalTime_2 = New System.Windows.Forms.TextBox()
        Me.txtArrivalTime_1 = New System.Windows.Forms.TextBox()
        Me.txtProcessID_5 = New System.Windows.Forms.TextBox()
        Me.txtProcessID_4 = New System.Windows.Forms.TextBox()
        Me.txtProcessID_3 = New System.Windows.Forms.TextBox()
        Me.txtProcessID_2 = New System.Windows.Forms.TextBox()
        Me.txtProcessID_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(433, 453)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 13)
        Me.Label25.TabIndex = 124
        Me.Label25.Text = "ms"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(433, 423)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 13)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = "ms"
        '
        'txtAverageTime
        '
        Me.txtAverageTime.Location = New System.Drawing.Point(327, 450)
        Me.txtAverageTime.Name = "txtAverageTime"
        Me.txtAverageTime.ReadOnly = True
        Me.txtAverageTime.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageTime.TabIndex = 122
        Me.txtAverageTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalTime
        '
        Me.txtTotalTime.Location = New System.Drawing.Point(327, 420)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.ReadOnly = True
        Me.txtTotalTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTime.TabIndex = 121
        Me.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(304, 453)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 120
        Me.Label23.Text = "="
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(304, 423)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 119
        Me.Label22.Text = "="
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(186, 453)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 13)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Average Waiting Time"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(202, 423)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "Total Waiting Time"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(433, 393)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "ms"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(433, 367)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 13)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "ms"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(433, 341)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "ms"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(433, 315)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "ms"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(433, 290)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 13)
        Me.Label19.TabIndex = 112
        Me.Label19.Text = "ms"
        '
        'txtWaitingTime_5
        '
        Me.txtWaitingTime_5.Location = New System.Drawing.Point(327, 390)
        Me.txtWaitingTime_5.Name = "txtWaitingTime_5"
        Me.txtWaitingTime_5.ReadOnly = True
        Me.txtWaitingTime_5.Size = New System.Drawing.Size(100, 20)
        Me.txtWaitingTime_5.TabIndex = 111
        Me.txtWaitingTime_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWaitingTime_4
        '
        Me.txtWaitingTime_4.Location = New System.Drawing.Point(327, 364)
        Me.txtWaitingTime_4.Name = "txtWaitingTime_4"
        Me.txtWaitingTime_4.ReadOnly = True
        Me.txtWaitingTime_4.Size = New System.Drawing.Size(100, 20)
        Me.txtWaitingTime_4.TabIndex = 110
        Me.txtWaitingTime_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWaitingTime_3
        '
        Me.txtWaitingTime_3.Location = New System.Drawing.Point(327, 338)
        Me.txtWaitingTime_3.Name = "txtWaitingTime_3"
        Me.txtWaitingTime_3.ReadOnly = True
        Me.txtWaitingTime_3.Size = New System.Drawing.Size(100, 20)
        Me.txtWaitingTime_3.TabIndex = 109
        Me.txtWaitingTime_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWaitingTime_2
        '
        Me.txtWaitingTime_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWaitingTime_2.Location = New System.Drawing.Point(327, 312)
        Me.txtWaitingTime_2.Name = "txtWaitingTime_2"
        Me.txtWaitingTime_2.ReadOnly = True
        Me.txtWaitingTime_2.Size = New System.Drawing.Size(100, 20)
        Me.txtWaitingTime_2.TabIndex = 108
        Me.txtWaitingTime_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWaitingTime_1
        '
        Me.txtWaitingTime_1.Location = New System.Drawing.Point(327, 286)
        Me.txtWaitingTime_1.Name = "txtWaitingTime_1"
        Me.txtWaitingTime_1.ReadOnly = True
        Me.txtWaitingTime_1.Size = New System.Drawing.Size(100, 20)
        Me.txtWaitingTime_1.TabIndex = 107
        Me.txtWaitingTime_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(304, 393)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(304, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(304, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(304, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "="
        '
        'WaitingProcess_5
        '
        Me.WaitingProcess_5.Location = New System.Drawing.Point(198, 390)
        Me.WaitingProcess_5.Name = "WaitingProcess_5"
        Me.WaitingProcess_5.ReadOnly = True
        Me.WaitingProcess_5.Size = New System.Drawing.Size(100, 20)
        Me.WaitingProcess_5.TabIndex = 101
        Me.WaitingProcess_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WaitingProcess_4
        '
        Me.WaitingProcess_4.Location = New System.Drawing.Point(198, 364)
        Me.WaitingProcess_4.Name = "WaitingProcess_4"
        Me.WaitingProcess_4.ReadOnly = True
        Me.WaitingProcess_4.Size = New System.Drawing.Size(100, 20)
        Me.WaitingProcess_4.TabIndex = 100
        Me.WaitingProcess_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WaitingProcess_3
        '
        Me.WaitingProcess_3.Location = New System.Drawing.Point(198, 338)
        Me.WaitingProcess_3.Name = "WaitingProcess_3"
        Me.WaitingProcess_3.ReadOnly = True
        Me.WaitingProcess_3.Size = New System.Drawing.Size(100, 20)
        Me.WaitingProcess_3.TabIndex = 99
        Me.WaitingProcess_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WaitingProcess_2
        '
        Me.WaitingProcess_2.Location = New System.Drawing.Point(198, 312)
        Me.WaitingProcess_2.Name = "WaitingProcess_2"
        Me.WaitingProcess_2.ReadOnly = True
        Me.WaitingProcess_2.Size = New System.Drawing.Size(100, 20)
        Me.WaitingProcess_2.TabIndex = 98
        Me.WaitingProcess_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WaitingProcess_1
        '
        Me.WaitingProcess_1.Location = New System.Drawing.Point(198, 286)
        Me.WaitingProcess_1.Name = "WaitingProcess_1"
        Me.WaitingProcess_1.ReadOnly = True
        Me.WaitingProcess_1.Size = New System.Drawing.Size(100, 20)
        Me.WaitingProcess_1.TabIndex = 97
        Me.WaitingProcess_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCPUBurst_5
        '
        Me.lblCPUBurst_5.AutoSize = True
        Me.lblCPUBurst_5.Location = New System.Drawing.Point(559, 256)
        Me.lblCPUBurst_5.Name = "lblCPUBurst_5"
        Me.lblCPUBurst_5.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUBurst_5.TabIndex = 96
        '
        'lblCPUBurst_4
        '
        Me.lblCPUBurst_4.AutoSize = True
        Me.lblCPUBurst_4.Location = New System.Drawing.Point(462, 256)
        Me.lblCPUBurst_4.Name = "lblCPUBurst_4"
        Me.lblCPUBurst_4.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUBurst_4.TabIndex = 95
        '
        'lblCPUBurst_3
        '
        Me.lblCPUBurst_3.AutoSize = True
        Me.lblCPUBurst_3.Location = New System.Drawing.Point(365, 256)
        Me.lblCPUBurst_3.Name = "lblCPUBurst_3"
        Me.lblCPUBurst_3.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUBurst_3.TabIndex = 94
        '
        'lblCPUBurst_2
        '
        Me.lblCPUBurst_2.AutoSize = True
        Me.lblCPUBurst_2.Location = New System.Drawing.Point(267, 256)
        Me.lblCPUBurst_2.Name = "lblCPUBurst_2"
        Me.lblCPUBurst_2.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUBurst_2.TabIndex = 93
        '
        'lblCPUBurst_1
        '
        Me.lblCPUBurst_1.AutoSize = True
        Me.lblCPUBurst_1.Location = New System.Drawing.Point(166, 256)
        Me.lblCPUBurst_1.Name = "lblCPUBurst_1"
        Me.lblCPUBurst_1.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUBurst_1.TabIndex = 92
        '
        'lblArrivalTime
        '
        Me.lblArrivalTime.AutoSize = True
        Me.lblArrivalTime.Location = New System.Drawing.Point(68, 256)
        Me.lblArrivalTime.Name = "lblArrivalTime"
        Me.lblArrivalTime.Size = New System.Drawing.Size(0, 13)
        Me.lblArrivalTime.TabIndex = 91
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(468, 230)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar5.TabIndex = 90
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(369, 230)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar4.TabIndex = 89
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(270, 230)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar3.TabIndex = 88
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(170, 230)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 87
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(70, 230)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(101, 23)
        Me.ProgressBar1.TabIndex = 86
        '
        'ProcessID_5
        '
        Me.ProcessID_5.Location = New System.Drawing.Point(469, 204)
        Me.ProcessID_5.Name = "ProcessID_5"
        Me.ProcessID_5.ReadOnly = True
        Me.ProcessID_5.Size = New System.Drawing.Size(100, 20)
        Me.ProcessID_5.TabIndex = 85
        Me.ProcessID_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProcessID_4
        '
        Me.ProcessID_4.Location = New System.Drawing.Point(370, 204)
        Me.ProcessID_4.Name = "ProcessID_4"
        Me.ProcessID_4.ReadOnly = True
        Me.ProcessID_4.Size = New System.Drawing.Size(100, 20)
        Me.ProcessID_4.TabIndex = 84
        Me.ProcessID_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProcessID_3
        '
        Me.ProcessID_3.Location = New System.Drawing.Point(270, 204)
        Me.ProcessID_3.Name = "ProcessID_3"
        Me.ProcessID_3.ReadOnly = True
        Me.ProcessID_3.Size = New System.Drawing.Size(100, 20)
        Me.ProcessID_3.TabIndex = 83
        Me.ProcessID_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProcessID_2
        '
        Me.ProcessID_2.Location = New System.Drawing.Point(171, 204)
        Me.ProcessID_2.Name = "ProcessID_2"
        Me.ProcessID_2.ReadOnly = True
        Me.ProcessID_2.Size = New System.Drawing.Size(100, 20)
        Me.ProcessID_2.TabIndex = 82
        Me.ProcessID_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProcessID_1
        '
        Me.ProcessID_1.Location = New System.Drawing.Point(71, 204)
        Me.ProcessID_1.Name = "ProcessID_1"
        Me.ProcessID_1.ReadOnly = True
        Me.ProcessID_1.Size = New System.Drawing.Size(100, 20)
        Me.ProcessID_1.TabIndex = 81
        Me.ProcessID_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(290, 160)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 80
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtCPUBurst_5
        '
        Me.txtCPUBurst_5.Location = New System.Drawing.Point(384, 134)
        Me.txtCPUBurst_5.Name = "txtCPUBurst_5"
        Me.txtCPUBurst_5.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUBurst_5.TabIndex = 79
        Me.txtCPUBurst_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPUBurst_4
        '
        Me.txtCPUBurst_4.Location = New System.Drawing.Point(384, 108)
        Me.txtCPUBurst_4.Name = "txtCPUBurst_4"
        Me.txtCPUBurst_4.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUBurst_4.TabIndex = 78
        Me.txtCPUBurst_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPUBurst_3
        '
        Me.txtCPUBurst_3.Location = New System.Drawing.Point(384, 82)
        Me.txtCPUBurst_3.Name = "txtCPUBurst_3"
        Me.txtCPUBurst_3.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUBurst_3.TabIndex = 77
        Me.txtCPUBurst_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPUBurst_2
        '
        Me.txtCPUBurst_2.Location = New System.Drawing.Point(384, 56)
        Me.txtCPUBurst_2.Name = "txtCPUBurst_2"
        Me.txtCPUBurst_2.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUBurst_2.TabIndex = 76
        Me.txtCPUBurst_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPUBurst_1
        '
        Me.txtCPUBurst_1.Location = New System.Drawing.Point(384, 30)
        Me.txtCPUBurst_1.Name = "txtCPUBurst_1"
        Me.txtCPUBurst_1.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUBurst_1.TabIndex = 75
        Me.txtCPUBurst_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArrivalTime_5
        '
        Me.txtArrivalTime_5.Location = New System.Drawing.Point(278, 134)
        Me.txtArrivalTime_5.Name = "txtArrivalTime_5"
        Me.txtArrivalTime_5.Size = New System.Drawing.Size(100, 20)
        Me.txtArrivalTime_5.TabIndex = 74
        Me.txtArrivalTime_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArrivalTime_4
        '
        Me.txtArrivalTime_4.Location = New System.Drawing.Point(278, 108)
        Me.txtArrivalTime_4.Name = "txtArrivalTime_4"
        Me.txtArrivalTime_4.Size = New System.Drawing.Size(100, 20)
        Me.txtArrivalTime_4.TabIndex = 72
        Me.txtArrivalTime_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArrivalTime_3
        '
        Me.txtArrivalTime_3.Location = New System.Drawing.Point(278, 82)
        Me.txtArrivalTime_3.Name = "txtArrivalTime_3"
        Me.txtArrivalTime_3.Size = New System.Drawing.Size(100, 20)
        Me.txtArrivalTime_3.TabIndex = 73
        Me.txtArrivalTime_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArrivalTime_2
        '
        Me.txtArrivalTime_2.Location = New System.Drawing.Point(278, 56)
        Me.txtArrivalTime_2.Name = "txtArrivalTime_2"
        Me.txtArrivalTime_2.Size = New System.Drawing.Size(100, 20)
        Me.txtArrivalTime_2.TabIndex = 71
        Me.txtArrivalTime_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArrivalTime_1
        '
        Me.txtArrivalTime_1.Location = New System.Drawing.Point(278, 30)
        Me.txtArrivalTime_1.Name = "txtArrivalTime_1"
        Me.txtArrivalTime_1.Size = New System.Drawing.Size(100, 20)
        Me.txtArrivalTime_1.TabIndex = 70
        Me.txtArrivalTime_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessID_5
        '
        Me.txtProcessID_5.Location = New System.Drawing.Point(172, 134)
        Me.txtProcessID_5.Name = "txtProcessID_5"
        Me.txtProcessID_5.ReadOnly = True
        Me.txtProcessID_5.Size = New System.Drawing.Size(100, 20)
        Me.txtProcessID_5.TabIndex = 69
        Me.txtProcessID_5.TabStop = False
        Me.txtProcessID_5.Text = "E"
        Me.txtProcessID_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessID_4
        '
        Me.txtProcessID_4.Location = New System.Drawing.Point(172, 108)
        Me.txtProcessID_4.Name = "txtProcessID_4"
        Me.txtProcessID_4.ReadOnly = True
        Me.txtProcessID_4.Size = New System.Drawing.Size(100, 20)
        Me.txtProcessID_4.TabIndex = 68
        Me.txtProcessID_4.TabStop = False
        Me.txtProcessID_4.Text = "D"
        Me.txtProcessID_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessID_3
        '
        Me.txtProcessID_3.Location = New System.Drawing.Point(172, 82)
        Me.txtProcessID_3.Name = "txtProcessID_3"
        Me.txtProcessID_3.ReadOnly = True
        Me.txtProcessID_3.Size = New System.Drawing.Size(100, 20)
        Me.txtProcessID_3.TabIndex = 67
        Me.txtProcessID_3.TabStop = False
        Me.txtProcessID_3.Text = "C"
        Me.txtProcessID_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessID_2
        '
        Me.txtProcessID_2.Location = New System.Drawing.Point(172, 56)
        Me.txtProcessID_2.Name = "txtProcessID_2"
        Me.txtProcessID_2.ReadOnly = True
        Me.txtProcessID_2.Size = New System.Drawing.Size(100, 20)
        Me.txtProcessID_2.TabIndex = 66
        Me.txtProcessID_2.TabStop = False
        Me.txtProcessID_2.Text = "B"
        Me.txtProcessID_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessID_1
        '
        Me.txtProcessID_1.Location = New System.Drawing.Point(172, 30)
        Me.txtProcessID_1.Name = "txtProcessID_1"
        Me.txtProcessID_1.ReadOnly = True
        Me.txtProcessID_1.Size = New System.Drawing.Size(100, 20)
        Me.txtProcessID_1.TabIndex = 65
        Me.txtProcessID_1.TabStop = False
        Me.txtProcessID_1.Text = "A"
        Me.txtProcessID_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "CPU Burst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Arrival Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Process ID"
        '
        'FCFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 485)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAverageTime)
        Me.Controls.Add(Me.txtTotalTime)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtWaitingTime_5)
        Me.Controls.Add(Me.txtWaitingTime_4)
        Me.Controls.Add(Me.txtWaitingTime_3)
        Me.Controls.Add(Me.txtWaitingTime_2)
        Me.Controls.Add(Me.txtWaitingTime_1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.WaitingProcess_5)
        Me.Controls.Add(Me.WaitingProcess_4)
        Me.Controls.Add(Me.WaitingProcess_3)
        Me.Controls.Add(Me.WaitingProcess_2)
        Me.Controls.Add(Me.WaitingProcess_1)
        Me.Controls.Add(Me.lblCPUBurst_5)
        Me.Controls.Add(Me.lblCPUBurst_4)
        Me.Controls.Add(Me.lblCPUBurst_3)
        Me.Controls.Add(Me.lblCPUBurst_2)
        Me.Controls.Add(Me.lblCPUBurst_1)
        Me.Controls.Add(Me.lblArrivalTime)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ProcessID_5)
        Me.Controls.Add(Me.ProcessID_4)
        Me.Controls.Add(Me.ProcessID_3)
        Me.Controls.Add(Me.ProcessID_2)
        Me.Controls.Add(Me.ProcessID_1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtCPUBurst_5)
        Me.Controls.Add(Me.txtCPUBurst_4)
        Me.Controls.Add(Me.txtCPUBurst_3)
        Me.Controls.Add(Me.txtCPUBurst_2)
        Me.Controls.Add(Me.txtCPUBurst_1)
        Me.Controls.Add(Me.txtArrivalTime_5)
        Me.Controls.Add(Me.txtArrivalTime_4)
        Me.Controls.Add(Me.txtArrivalTime_3)
        Me.Controls.Add(Me.txtArrivalTime_2)
        Me.Controls.Add(Me.txtArrivalTime_1)
        Me.Controls.Add(Me.txtProcessID_5)
        Me.Controls.Add(Me.txtProcessID_4)
        Me.Controls.Add(Me.txtProcessID_3)
        Me.Controls.Add(Me.txtProcessID_2)
        Me.Controls.Add(Me.txtProcessID_1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FCFS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Come First Serve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAverageTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtWaitingTime_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtWaitingTime_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtWaitingTime_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtWaitingTime_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWaitingTime_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents WaitingProcess_5 As System.Windows.Forms.TextBox
    Friend WithEvents WaitingProcess_4 As System.Windows.Forms.TextBox
    Friend WithEvents WaitingProcess_3 As System.Windows.Forms.TextBox
    Friend WithEvents WaitingProcess_2 As System.Windows.Forms.TextBox
    Friend WithEvents WaitingProcess_1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCPUBurst_5 As System.Windows.Forms.Label
    Friend WithEvents lblCPUBurst_4 As System.Windows.Forms.Label
    Friend WithEvents lblCPUBurst_3 As System.Windows.Forms.Label
    Friend WithEvents lblCPUBurst_2 As System.Windows.Forms.Label
    Friend WithEvents lblCPUBurst_1 As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTime As System.Windows.Forms.Label
    Friend WithEvents ProgressBar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProcessID_5 As System.Windows.Forms.TextBox
    Friend WithEvents ProcessID_4 As System.Windows.Forms.TextBox
    Friend WithEvents ProcessID_3 As System.Windows.Forms.TextBox
    Friend WithEvents ProcessID_2 As System.Windows.Forms.TextBox
    Friend WithEvents ProcessID_1 As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtCPUBurst_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPUBurst_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPUBurst_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPUBurst_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPUBurst_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtArrivalTime_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtArrivalTime_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtArrivalTime_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtArrivalTime_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtArrivalTime_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessID_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessID_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessID_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessID_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessID_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
