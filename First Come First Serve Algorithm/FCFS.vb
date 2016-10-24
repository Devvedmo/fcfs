Public Class FCFS


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        progressbarValues()
        clearFields()

        lblArrivalTime.Text = 0

        ProcessID_1.Text = txtProcessID_1.Text
        ProgressBar1.Maximum = Val(txtCPUBurst_1.Text)
        Timer1.Start()

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value <> ProgressBar1.Maximum Then

            ProgressBar1.Value = ProgressBar1.Value + 1

        Else

            lblCPUBurst_1.Text = Val(txtCPUBurst_1.Text)
            Timer1.Stop()

            ProcessID_2.Text = txtProcessID_2.Text
            ProgressBar2.Maximum = ProgressBar1.Maximum
            Timer2.Start()



        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If ProgressBar2.Value <> ProgressBar2.Maximum Then

            ProgressBar2.Value = ProgressBar2.Value + 1

        Else

            lblCPUBurst_2.Text = Val(txtCPUBurst_1.Text) + Val(txtCPUBurst_2.Text)
            Timer2.Stop()

            ProcessID_3.Text = txtProcessID_3.Text
            ProgressBar3.Maximum = ProgressBar2.Maximum
            Timer3.Start()

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        If ProgressBar3.Value <> ProgressBar3.Maximum Then

            ProgressBar3.Value = ProgressBar3.Value + 1

        Else

            lblCPUBurst_3.Text = Val(txtCPUBurst_1.Text) + Val(txtCPUBurst_2.Text) + Val(txtCPUBurst_3.Text)
            Timer3.Stop()

            ProcessID_4.Text = txtProcessID_4.Text
            ProgressBar4.Maximum = ProgressBar3.Maximum
            Timer4.Start()

        End If

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        If ProgressBar4.Value <> ProgressBar4.Maximum Then

            ProgressBar4.Value = ProgressBar4.Value + 1

        Else

            lblCPUBurst_4.Text = Val(txtCPUBurst_1.Text) + Val(txtCPUBurst_2.Text) + Val(txtCPUBurst_3.Text) + Val(txtCPUBurst_4.Text)
            Timer4.Stop()

            ProcessID_5.Text = txtProcessID_5.Text
            ProgressBar5.Maximum = ProgressBar4.Maximum
            Timer5.Start()

        End If

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        If ProgressBar5.Value <> ProgressBar5.Maximum Then

            ProgressBar5.Value = ProgressBar5.Value + 1

        Else

            lblCPUBurst_5.Text = Val(txtCPUBurst_1.Text) + Val(txtCPUBurst_2.Text) + Val(txtCPUBurst_3.Text) + Val(txtCPUBurst_4.Text) + Val(txtCPUBurst_5.Text)
            Timer5.Stop()



            WaitingProcess_1.Text = txtProcessID_1.Text
            WaitingProcess_2.Text = txtProcessID_2.Text
            WaitingProcess_3.Text = txtProcessID_3.Text
            WaitingProcess_4.Text = txtProcessID_4.Text
            WaitingProcess_5.Text = txtProcessID_5.Text

            txtWaitingTime_1.Text = Val(lblCPUBurst_1.Text) - Val(txtArrivalTime_1.Text)
            txtWaitingTime_2.Text = Val(lblCPUBurst_2.Text) - Val(txtArrivalTime_2.Text)
            txtWaitingTime_3.Text = Val(lblCPUBurst_3.Text) - Val(txtArrivalTime_3.Text)
            txtWaitingTime_4.Text = Val(lblCPUBurst_4.Text) - Val(txtArrivalTime_4.Text)
            txtWaitingTime_5.Text = Val(lblCPUBurst_5.Text) - Val(txtArrivalTime_5.Text)

            txtTotalTime.Text = Val(txtWaitingTime_1.Text) + Val(txtWaitingTime_2.Text) + Val(txtWaitingTime_3.Text) + Val(txtWaitingTime_4.Text) + Val(txtWaitingTime_5.Text)
            txtAverageTime.Text = Val(txtTotalTime.Text) / 5

        End If

    End Sub


    Public Sub progressbarValues()

        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
        ProgressBar5.Value = 0

    End Sub

    Public Sub clearFields()

        ProcessID_1.Clear()
        ProcessID_2.Clear()
        ProcessID_3.Clear()
        ProcessID_4.Clear()
        ProcessID_5.Clear()

        lblArrivalTime.Text = ""
        lblCPUBurst_1.Text = ""
        lblCPUBurst_2.Text = ""
        lblCPUBurst_3.Text = ""
        lblCPUBurst_4.Text = ""
        lblCPUBurst_5.Text = ""

        WaitingProcess_1.Clear()
        WaitingProcess_2.Clear()
        WaitingProcess_3.Clear()
        WaitingProcess_4.Clear()
        WaitingProcess_5.Clear()

        txtWaitingTime_1.Clear()
        txtWaitingTime_2.Clear()
        txtWaitingTime_3.Clear()
        txtWaitingTime_4.Clear()
        txtWaitingTime_5.Clear()

        txtAverageTime.Clear()
        txtTotalTime.Clear()

    End Sub




End Class