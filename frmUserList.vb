Public Class frmUserList
    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString
        con.Open()
        LoadData()
        btnDelete.Enabled = False
        'DataGridView1.Rows(0).Selected = True
        'DataGridView1.Columns(1).Selected = True
        DataGridView1_CellClick(DataGridView1, New DataGridViewCellEventArgs(0, 0))
    End Sub
    Private Sub LoadData()
        DataGridView1.AutoGenerateColumns = False
        With cmd
            .Connection = con
            .CommandText = "SELECT * from tbluser"
        End With

        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub frmUserList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmAdminPanel.Show()
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
                    .CommandText = "DELETE from tbluser where userid='" & id & "'"
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