Public Class frmMain


    Private Sub btnA100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA100.Click
        currentFile = "aq1.rtf"
        currentFileAnswer = "aa1.rtf"
        diaProb.ShowDialog()
        diaProb.BringToFront()
        btnA100.Enabled = False
    End Sub

    Private Sub btnA200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA200.Click
        currentFile = "aq2.rtf"
        currentFileAnswer = "aa2.rtf"
        diaProb.ShowDialog()
        diaProb.BringToFront()
        btnA100.Enabled = False
    End Sub

    Private Sub btnA300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA300.Click
        currentFile = "aq3.rtf"
        currentFileAnswer = "aa3.rtf"
        diaProb.ShowDialog()
        diaProb.BringToFront()
        btnA100.Enabled = False
    End Sub

    Private Sub btnA400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA400.Click
        currentFile = "aq4.rtf"
        currentFileAnswer = "aa4.rtf"
        diaProb.ShowDialog()
        diaProb.BringToFront()
        btnA100.Enabled = False
    End Sub

    Private Sub btnA500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA500.Click
        currentFile = "aq5.rtf"
        currentFileAnswer = "aa5.rtf"
        diaProb.ShowDialog()
        diaProb.BringToFront()
        btnA100.Enabled = False
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        btnA100.Enabled = True
        btnB500.Enabled = True
        btnB400.Enabled = True
        btnB300.Enabled = True
        btnB200.Enabled = True
        btnB100.Enabled = True
        btnC500.Enabled = True
        btnC400.Enabled = True
        btnC300.Enabled = True
        btnA200.Enabled = True
        btnC200.Enabled = True
        btnC100.Enabled = True
        btnD500.Enabled = True
        btnD400.Enabled = True
        btnA300.Enabled = True
        btnA300.Enabled = True
        btnD200.Enabled = True
        btnD100.Enabled = True
        btnF500.Enabled = True
        btnA400.Enabled = True
        btnE400.Enabled = True
        btnE300.Enabled = True
        btnE200.Enabled = True
        btnE100.Enabled = True
        btnA500.Enabled = True

    End Sub

    Private Sub ModifyGroupsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyGroupsToolStripMenuItem.Click
        diaGrp.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ModifyAnswersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyAnswersToolStripMenuItem.Click
        diaEdit.ShowDialog()
        diaEdit.BringToFront()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        About.BringToFront()
    End Sub

    Private Sub FilePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilePathToolStripMenuItem.Click
        browse1.ShowDialog()

        path = browse1.SelectedPath
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        debug.ShowDialog()
        debug.BringToFront()
    End Sub

 
End Class
