Imports System.Windows.Forms

Public Class diaProb
    Dim clock, bar As Integer


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaProb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        clock = 30
        timetell.Text = clock.ToString
        ' Label1.Text = problems(posx, posy)
        '  Try
        rtfProblem.LoadFile(path + "\" + currentFile.ToString)
        'Catch
        '  End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If clock > 0 Then
            bar = ((clock / 100) * 100)
            clock = (clock - 1)
            timetell.Text = clock.ToString
            timebar.Value = bar
        ElseIf clock = 0 Then
            rtfProblem.LoadFile(path + "\" + currentFileAnswer.ToString)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clock = (clock + 1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clock = (clock - 1)
    End Sub

End Class
