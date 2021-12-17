Public Class frmMain
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlBlue.Height = btnDashboard.Height
        pnlBlue.Top = btnDashboard.Top
        pnlBlue.Left = btnDashboard.Left
        btnDashboard.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Dashboard"
        'Write Code


    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        pnlBlue.Height = btnConfig.Height
        pnlBlue.Top = btnConfig.Top
        pnlBlue.Left = btnConfig.Left
        btnConfig.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Config"
        'Write Code

    End Sub

    Private Sub btnReference_Click(sender As Object, e As EventArgs) Handles btnReference.Click
        pnlBlue.Height = btnReference.Height
        pnlBlue.Top = btnReference.Top
        pnlBlue.Left = btnReference.Left
        btnReference.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Reference"
        'Write Code


    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        pnlBlue.Height = btnManual.Height
        pnlBlue.Top = btnManual.Top
        pnlBlue.Left = btnManual.Left
        btnManual.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Manual"
        'Write Code


    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        pnlBlue.Height = btnLog.Height
        pnlBlue.Top = btnLog.Top
        pnlBlue.Left = btnLog.Left
        btnLog.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Log"
        'Write Code


    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlBlue.Height = btnAbout.Height
        pnlBlue.Top = btnAbout.Top
        pnlBlue.Left = btnAbout.Left
        btnAbout.BackColor = Color.FromArgb(46, 51, 73)
        lbMenu.Text = "Software About"
        'Write Code


    End Sub


#Region "LEAVE BUTTON"
    Private Sub btnDashboard_Leave(sender As Object, e As EventArgs) Handles btnDashboard.Leave
        btnDashboard.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub btnConfig_Leave(sender As Object, e As EventArgs) Handles btnConfig.Leave
        btnConfig.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub btnReference_Leave(sender As Object, e As EventArgs) Handles btnReference.Leave
        btnReference.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub btnManual_Leave(sender As Object, e As EventArgs) Handles btnManual.Leave
        btnManual.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub btnLog_Leave(sender As Object, e As EventArgs) Handles btnLog.Leave
        btnLog.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub btnAbout_Leave(sender As Object, e As EventArgs) Handles btnAbout.Leave
        btnAbout.BackColor = Color.FromArgb(24, 36, 52)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(48, 52, 68)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

#End Region



End Class
