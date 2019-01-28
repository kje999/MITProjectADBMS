Public Class frmCreateAccount

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString
        con.Open()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtusername.Text = "" Then
            MsgBox("You must fill in all Fields", MsgBoxStyle.Exclamation, "Complete Fields Required")
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("You must fill in all Fields", MsgBoxStyle.Exclamation, "Complete Fields Required")
            Exit Sub
        ElseIf txtconfirmpassword.Text = "" Then
            MsgBox("You must fill in all Fields", MsgBoxStyle.Exclamation, "Complete Fields Required")
            Exit Sub
        ElseIf txtpassword.Text <> txtconfirmpassword.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Exclamation, "Failed")
            txtpassword.Clear()
            txtconfirmpassword.Clear()
            Exit Sub
        End If
        With cmd
            .Connection = con
            .CommandText = "SELECT Username FROM tbluser where Username='" + txtusername.Text + "'"
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("The username already taken" & vbNewLine & "Please Try another one", MsgBoxStyle.Information, "Already Exist")
            dr.Close()
            txtusername.Text = ""
            txtusername.Focus()
            dr.Close()
            Exit Sub
        End If
        dr.Close()

        Try
            With cmd
                .Connection = con
                .CommandText = "INSERT into tbluser (Username, Password)" & _
                        "VALUES ('" & txtusername.Text & "', '" & txtconfirmpassword.Text & "')"
            End With
            cmd.ExecuteNonQuery()

            MsgBox("User Account Added!", MsgBoxStyle.Information, "Success")
            txtusername.ReadOnly = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmLogin.Show()
    End Sub



    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        txtpassword.UseSystemPasswordChar = False
        txtconfirmpassword.UseSystemPasswordChar = False
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        txtpassword.UseSystemPasswordChar = True
        txtconfirmpassword.UseSystemPasswordChar = True
    End Sub
End Class