Public Class frmAdminChangePass

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtpassword.Text = "" Then
            MsgBox("Requires Non-Blank Field!")
        Else
            My.Settings.adminpassword = txtpassword.Text
            My.Settings.Save()
            MsgBox("Your Password Changed Successfully!")
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAdminChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.Select()
    End Sub
End Class