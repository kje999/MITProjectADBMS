Public Class frmViewLottoResult

    Private Sub frmViewLottoResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString
        con.Open()

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class