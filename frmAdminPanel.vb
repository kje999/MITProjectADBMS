Public Class frmAdminPanel

    Dim luckypickid As Integer
    Dim Person As String
    Private Sub frmAdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString
        con.Open()

        DataGridView2.Rows.Add()
        btnDelete.Enabled = False
        cmbLottoType.Select()


        LoadData()

    End Sub
    Private Sub LoadData()
        DataGridView1.AutoGenerateColumns = False

        With cmd
            .Connection = con
            .CommandText = "SELECT * from tbllottoresult"
        End With

        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub CheckWinner()
        Dim Number1 As Integer = Me.DataGridView2.Rows(0).Cells("Number1").FormattedValue
        Dim Number2 As Integer = Me.DataGridView2.Rows(0).Cells("Number2").FormattedValue
        Dim Number3 As Integer = Me.DataGridView2.Rows(0).Cells("Number3").FormattedValue
        Dim Number4 As Integer = Me.DataGridView2.Rows(0).Cells("Number4").FormattedValue
        Dim Number5 As Integer = Me.DataGridView2.Rows(0).Cells("Number5").FormattedValue
        Dim Number6 As Integer = Me.DataGridView2.Rows(0).Cells("Number6").FormattedValue

        With cmd
            .Connection = con
            .CommandText = "SELECT luckypickid from tblluckypick where 1stNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And 2ndNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And 3rdNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And 4thNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And 5thNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And 6thNumber IN ('" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "') And AutoPredictLottoDrawDate='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' And LottoType='" & cmbLottoType.SelectedItem & "'"
        End With
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count >= 1 Then
            For i = 0 To dt.Rows.Count - 1
                luckypickid = dt.Rows(i)("luckypickid")
                'Person = dt.Rows(i)("LPUsername")
                'MsgBox(luckypickid & " " & Person)

                With cmd
                    .Connection = con
                    .CommandText = "INSERT into tblwinner (luckypickwinnerid, MessageStatus, lresultunique)" & _
                        "VALUES('" & luckypickid & "', 'Unread', '" & luckypickid & "-" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "-" & cmbLottoType.SelectedItem & "')"
                End With
                cmd.ExecuteNonQuery()

            Next
        End If

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MsgBox("Are you sure, you want to add this record?", MsgBoxStyle.YesNo, "Please take a review First!") = MsgBoxResult.Yes Then


            If DataGridView2.Rows(0).Cells.Item(0).Value = Nothing Or DataGridView2.Rows(0).Cells.Item(1).Value = Nothing Or DataGridView2.Rows(0).Cells.Item(2).Value = Nothing Or DataGridView2.Rows(0).Cells.Item(3).Value = Nothing Or DataGridView2.Rows(0).Cells.Item(4).Value = Nothing Or DataGridView2.Rows(0).Cells.Item(5).Value = Nothing Then
                MsgBox("Uh-oh.!!! No Blank Fields Please!")
                Exit Sub
            End If
            If cmbLottoType.SelectedIndex = -1 Then
                MsgBox("Uh-oh.!!! You forgot to Choose Lotto Type")
                Exit Sub
            End If
            If txtJackpot.Text = "" Then
                MsgBox("Uh-oh.!!! You forgot to input Jackpot Prize")
                Exit Sub
            End If
            Dim Number1 As Integer = Me.DataGridView2.Rows(0).Cells("Number1").FormattedValue
            Dim Number2 As Integer = Me.DataGridView2.Rows(0).Cells("Number2").FormattedValue
            Dim Number3 As Integer = Me.DataGridView2.Rows(0).Cells("Number3").FormattedValue
            Dim Number4 As Integer = Me.DataGridView2.Rows(0).Cells("Number4").FormattedValue
            Dim Number5 As Integer = Me.DataGridView2.Rows(0).Cells("Number5").FormattedValue
            Dim Number6 As Integer = Me.DataGridView2.Rows(0).Cells("Number6").FormattedValue



            With cmd
                .Connection = con
                .CommandText = "INSERT into tbllottoresult (LottoTypeResult, DateLottoDraw, DateAndTimeAdded, 1stNumberResult, 2ndNumberResult, 3rdNumberResult, 4thNumberResult, 5thNumberResult, 6thNumberResult, JackpotPrice)" & _
                    "VALUES('" & cmbLottoType.SelectedItem & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & Number1 & "','" & Number2 & "','" & Number3 & "','" & Number4 & "','" & Number5 & "','" & Number6 & "','" & txtJackpot.Text & "')"
            End With
            cmd.ExecuteNonQuery()

            CheckWinner()

            MsgBox("All Records Saved!", MsgBoxStyle.Information, "Success")


            LoadData()
            cmbLottoType.SelectedIndex = -1
            DateTimePicker1.Value = DateTime.Now
            txtJackpot.Text = ""
            DataGridView2.Rows.Clear()

        End If
    End Sub

    Private Sub ShowUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowUsersToolStripMenuItem.Click
        frmUserList.Show()
    End Sub

    Private Sub frmAdminPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub

    Private Sub ChangeMyPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeMyPasswordToolStripMenuItem.Click
        frmAdminChangePass.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure, you want to delete this record?", MsgBoxStyle.YesNo, "Wait!") = MsgBoxResult.Yes Then
            Dim row, id As Integer

            'Declared this variable to get value event click on dgv
            row = DataGridView1.CurrentRow.Index

            id = DataGridView1(0, row).Value

            Try
                With cmd
                    .Connection = con
                    .CommandText = "DELETE from tbllottoresult where lottoresultid='" & id & "'"
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted!", MsgBoxStyle.Information, "Success")
                btnDelete.Enabled = False
            Catch ex As Exception
                MsgBox("Cannot delete record", MsgBoxStyle.Critical, "Error")
                btnDelete.Enabled = False
            End Try
        End If
        LoadData()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count >= 1 Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub

End Class