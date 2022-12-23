Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString
        con.Open()
        'My.Settings.adminpassword = "ADMIN"
        'My.Settings.Save()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Hey! Please No Blank Fields.")
            txtusername.Focus()
            Exit Sub
        End If
        If txtusername.Text = My.Settings.adminuser.ToString() And txtpassword.Text = My.Settings.adminpassword.ToString() Then
            Me.Hide()
            frmAdminPanel.Show()
            txtpassword.Text = ""
            Exit Sub
        End If

        With cmd
            .Connection = con
            .CommandText = "select * from tbluser where Username='" & txtusername.Text & "' And Password='" & txtpassword.Text & "'"
        End With
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                dr.Close()
                txtpassword.Clear()
                frmMyLuckyLotto.Show()
                frmMyLuckyLotto.lblUsername.Text = txtusername.Text
                Me.Hide()
            Else
                MsgBox("Sorry, Username or Password not Recognize", MsgBoxStyle.Critical, "TRY AGAIN")
                txtpassword.Clear()
                txtpassword.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub

   
    Private Sub lblcreatenew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblcreatenew.LinkClicked
        frmCreateAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class