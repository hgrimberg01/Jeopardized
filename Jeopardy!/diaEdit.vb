

Imports System.Windows.Forms

Public Class diaEdit

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        aq1.Dispose()
        aq2.Dispose()
        Me.Dispose()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        aq1.Dispose()
        aq2.Dispose()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub diaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TabPage1.Text = frmMain.GroupBox1.Text
        TabPage2.Text = frmMain.GroupBox2.Text
        TabPage3.Text = frmMain.GroupBox3.Text
        TabPage4.Text = frmMain.GroupBox4.Text
        TabPage5.Text = frmMain.GroupBox5.Text


    End Sub

    Private Sub aq1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aq1.LostFocus
        Try
            aq1.SaveFile(path + "\aq1.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aq2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aq2.LostFocus
        Try
            aq2.SaveFile(path + "\aq2.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aq3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aq3.LostFocus
        Try
            aq3.SaveFile(path + "\aq3.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aq4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aq4.LostFocus
        Try
            aq4.SaveFile(path + "\aq4.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub aq5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aq5.LostFocus
        Try
            aq5.SaveFile(path + "\aq5.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aa1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aa1.LostFocus
        Try
            aa1.SaveFile(path + "\aa1.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aa2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aa2.LostFocus
        Try
            aa2.SaveFile(path + "\aa2.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aa3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aa3.LostFocus
        Try
            aa3.SaveFile(path + "\aa3.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aa4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aa4.LostFocus
        Try
            aa4.SaveFile(path + "\aa4.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aa5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aa5.LostFocus
        Try
            aa5.SaveFile(path + "\aa5.rtf")

        Catch
            MessageBox.Show("Please Check Your File Settings", "File Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class


