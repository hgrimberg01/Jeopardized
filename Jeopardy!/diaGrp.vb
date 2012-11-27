Imports System.Windows.Forms

Public Class diaGrp

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click



        frmMain.GroupBox1.Text = txt1.Text
        frmMain.GroupBox2.Text = txt2.Text
        frmMain.GroupBox3.Text = txt3.Text
        frmMain.GroupBox4.Text = txt4.Text
        frmMain.GroupBox5.Text = txt5.Text



        frmMain.BringToFront()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        frmMain.BringToFront()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaGrp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt1.Text = frmMain.GroupBox1.Text
        txt2.Text = frmMain.GroupBox2.Text
        txt3.Text = frmMain.GroupBox3.Text
        txt4.Text = frmMain.GroupBox4.Text
        txt5.Text = frmMain.GroupBox5.Text
    End Sub
End Class
