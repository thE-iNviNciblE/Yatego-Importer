Public Class frmYategoSettings
    Private Sub txtYategoDomainnamen_TextChanged(sender As Object, e As EventArgs) Handles txtYategoDomainnamen.TextChanged
        My.Settings.yatego_domain = txtYategoDomainnamen.Text
        My.Settings.Save()
    End Sub

    Private Sub txtYategoPasswd_TextChanged(sender As Object, e As EventArgs) Handles txtYategoPasswd.TextChanged
        My.Settings.yatego_pwd = txtYategoPasswd.Text
        My.Settings.Save()
    End Sub

    Private Sub frmYategoSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtYategoDomainnamen.Text = My.Settings.yatego_domain
        txtYategoPasswd.Text = My.Settings.yatego_pwd
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub
End Class