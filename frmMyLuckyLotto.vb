Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Speech

Public Class frmMyLuckyLotto
    'Dim cn As New MySqlConnection
    ' Dim sql As String
    ' Dim cmd As New MySqlCommand
    'Dim dr As MySqlDataReader
    'Dim dt As DataTable
    'Dim adapter As New MySqlDataAdapter
    Private rand As New Random
    Dim LottoTypeMaximumNumber As Integer
    'Dim Startingsound As New Media.SoundPlayer(My.Resources.SlotMachineWinning)
    Dim LuckyNumber As New Media.SoundPlayer(My.Resources.GetNumber)
    Dim WinnerWinnerChickenDinner As New Media.SoundPlayer(My.Resources.SlotMachineWinning)
    Dim YeheyKids As New Media.SoundPlayer(My.Resources.YeheyKids)
    ''..........//////////////////////////////////////////////////////
    Private Snds As New MultiSounds

    ''...........////////////////////////////////////////////////////
    Dim spk As New Speech.Synthesis.SpeechSynthesizer
    Dim spk1 As New Speech.Synthesis.SpeechSynthesizer
    Dim spk2 As New Speech.Synthesis.SpeechSynthesizer
    Dim spk3 As New Speech.Synthesis.SpeechSynthesizer
    Dim spk4 As New Speech.Synthesis.SpeechSynthesizer
    Dim spk5 As New Speech.Synthesis.SpeechSynthesizer
    Dim spk6 As New Speech.Synthesis.SpeechSynthesizer
    Dim spkDrawDate As New Speech.Synthesis.SpeechSynthesizer

    Private Sub frmMyLuckyLotto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = ConnectionString

        Try
            con.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)

        End Try
        RefreshRecentLuckyLottoNumber()
        lblLottoType.Parent = PictureBox7
        Label1.Parent = PictureBox7
        Label2.Parent = Panel7
        'lblLottoType.BackColor = Color.Transparent
        lblLottoType.BringToFront()
        Label1.BringToFront()
        Label2.BringToFront()
        'lblLottoType.ForeColor = Color.White
        lblLottoType.Location = New Point(530, 12)
        Label1.Location = New Point(15, 20)
        Label2.Location = New Point(598, -2)

        CheckforAvailableMessage()



        'Snds.AddSound("GetNumber", "C:\Users\Kenth\Documents\Visual Studio 2013\Projects\LuckyLotto\GetNumber.wav")
    End Sub

    Private Sub CheckMessage()

        Dim id As Integer
        Dim Username As String
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer
        Dim number4 As Integer
        Dim number5 As Integer
        Dim number6 As Integer
        Dim DrawDate As String
        Dim lResultUnique As String
        Dim ArrayHolder() As String
        Dim JackpotPrize As String

        Dim MessageStatus As String

        With cmd
            .Connection = con
            .CommandText = "SELECT * from tblluckypick inner join tblwinner on tblluckypick.luckypickid=tblwinner.luckypickwinnerid where MessageStatus='Unread' And LPUsername='" & frmLogin.txtusername.Text & "'LIMIT 1"
        End With

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            dr.Close()
            Exit Sub
        End If
        MessageStatus = dr.Item("MessageStatus")
        lResultUnique = dr.Item("lresultunique")

        ArrayHolder = lResultUnique.Split("-")



        id = dr.Item("luckypickwinnerid")
        'Username = dr.Item("LPUsername")
        number1 = dr.Item("1stNumber")
        number2 = dr.Item("2ndNumber")
        number3 = dr.Item("3rdNumber")
        number4 = dr.Item("4thNumber")
        number5 = dr.Item("5thNumber")
        number6 = dr.Item("6thNumber")
        'DrawDate = dr.Item("AutoPredictLottoDrawDate")
        'ArrayHolder(1).Replace("/", "-")
        dr.Close()

        With cmd
            .Connection = con
            .CommandText = "SELECT JackpotPrice from tbllottoresult where DateLottoDraw='" & ArrayHolder(1).Replace("/", "-") & "' And LottoTypeResult='" & ArrayHolder(2) & "'"
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        JackpotPrize = dr.Item("JackpotPrice")
        dr.Close()

        With cmd
            .Connection = con
            .CommandText = "UPDATE tblwinner SET MessageStatus='Read' where luckypickwinnerid='" & id & "' "
        End With
        cmd.ExecuteNonQuery()

        MsgBox("Congratulations!!! You Won the Jackpot Price worth: " & JackpotPrize & "." & vbNewLine & "With your lucky number combination of: " & number1 & ", " & number2 & ", " & number3 & ", " & number4 & ", " & number5 & ", " & number6 & vbNewLine & "Inquire on How to claim your prize in the nearest PCSO Lotto Outlet.")

        btnGotMessage.Visible = False
        CheckforAvailableMessage()

    End Sub

    Private Sub CheckforAvailableMessage()
        Dim Unread As String

        With cmd
            .Connection = con
            .CommandText = "SELECT MessageStatus from tblluckypick inner join tblwinner on tblluckypick.luckypickid=tblwinner.luckypickwinnerid where LPUsername='" & frmLogin.txtusername.Text & "' And MessageStatus='Unread'"
        End With

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Unread = dr.GetString("MessageStatus")
            If Unread = "Unread" Then
                btnGotMessage.Visible = True
                dr.Close()
            Else
                btnGotMessage.Visible = False
                dr.Close()
            End If
        End If
        dr.Close()
    End Sub

    Private Sub cmbLottoType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLottoType.SelectedIndexChanged
        If lblNumber1.Text = "Roll1" Then

        Else
            lblNumber1.Text = "Roll1"
            lblNumber2.Text = "Roll2"
            lblNumber3.Text = "Roll3"
            lblNumber4.Text = "Roll4"
            lblNumber5.Text = "Roll5"
            lblNumber6.Text = "Roll6"
        End If

        spk.Volume = 100%
        lblLottoType.Text = cmbLottoType.SelectedItem
        If cmbLottoType.SelectedItem = "6/58" Then
            spk.SpeakAsync("Six fifty-eight")
        ElseIf cmbLottoType.SelectedItem = "6/55" Then
            spk.SpeakAsync("Six fifty-five")
        ElseIf cmbLottoType.SelectedItem = "6/49" Then
            spk.SpeakAsync("Six forty-nine")
        ElseIf cmbLottoType.SelectedItem = "6/45" Then
            spk.SpeakAsync("Six forty-five")
        End If


    End Sub



    Private Sub btnRollIt_Click(sender As Object, e As EventArgs) Handles btnRollIt.Click
        If cmbLottoType.SelectedItem = "" Or cmbLottoType.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Your Lotto Type First")
            Exit Sub
        End If

        btnViewDraw.Enabled = False
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox8.Visible = False
        lblNumber1.Text = ""
        lblNumber2.Text = ""
        lblNumber3.Text = ""
        lblNumber4.Text = ""
        lblNumber5.Text = ""
        lblNumber6.Text = ""
        LottoTypeMaximumNumber = 0
        btnRollIt.Enabled = False
        cmbLottoType.Enabled = False
        lblDrawDate.Text = "Click Gridview"
        'Startingsound.PlayLooping()
        'My.Computer.Audio.Play(My.Resources.SlotMachineWinning, AudioPlayMode.BackgroundLoop)
        'Snds.Play("GetNumber")
        If cmbLottoType.SelectedItem = "6/58" Then
            LottoTypeMaximumNumber = 58
        ElseIf cmbLottoType.SelectedItem = "6/55" Then
            LottoTypeMaximumNumber = 55
        ElseIf cmbLottoType.SelectedItem = "6/49" Then
            LottoTypeMaximumNumber = 49
        Else
            LottoTypeMaximumNumber = 45
        End If
        ' Store the numbers 1 to LottoTypeMaximumNumber in a list '
        Dim allNumbers As New List(Of Integer)(Enumerable.Range(1, LottoTypeMaximumNumber))
        ' Store the randomly selected numbers in this list: '
        Dim selectedNumbers As New List(Of Integer)

        For i As Integer = 0 To 5
            ' A random index in numbers '
            Dim index As Integer = rand.Next(0, allNumbers.Count)
            ' Copy the item at index from allNumbers. '
            Dim selectedNumber As Integer = allNumbers(index)
            ' And store it in our list of picked numbers. '
            selectedNumbers.Add(selectedNumber)
            ' Remove the item from the list so that it cannot be picked again. '
            allNumbers.RemoveAt(index)
        Next

        Timer1.Start()
        ' Show them on the labels '
        For Each i As Integer In selectedNumbers
            If lblNumber1.Text = "" Then

                lblNumber1.Text = i
                GoTo NextLine
            End If
            If lblNumber2.Text = "" Then

                lblNumber2.Text = i
                GoTo NextLine
            End If
            If lblNumber3.Text = "" Then

                lblNumber3.Text = i
                GoTo NextLine
            End If
            If lblNumber4.Text = "" Then

                lblNumber4.Text = i
                GoTo NextLine
            End If
            If lblNumber5.Text = "" Then

                lblNumber5.Text = i
                GoTo NextLine
            End If
            If lblNumber6.Text = "" Then

                lblNumber6.Text = i
                GoTo NextLine
            End If

NextLine:
        Next

        btnViewDraw.Enabled = True
    End Sub

    Sub RefreshRecentLuckyLottoNumber()
        DataGridView1.AutoGenerateColumns = False
        With cmd
            .Connection = con
            .CommandText = "SELECT * from tblluckypick where LPUsername='" & frmLogin.txtusername.Text & "'"
        End With

        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Function AutoPredicDateDraw(ByVal DayWeek As String) As String
        'Dim DayArray() As String
        Dim PredictedDay As DateTime


        If cmbLottoType.SelectedItem = "6/58" And DayWeek = "Monday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Tuesday")
            MsgBox("The Lotto Draw will be 9:00 PM Tuesday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Tuesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Wednesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Friday")
            MsgBox("The Lotto Draw will be 9:00 PM Friday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(2)

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Thursday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Friday")
            MsgBox("The Lotto Draw will be 9:00 PM Friday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Friday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Saturday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Sunday")
            MsgBox("The Lotto Draw will be 9:00 PM Sunday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/58" And DayWeek = "Sunday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        End If
        '--------------------------------------------------------------------------------------------------'

        If cmbLottoType.SelectedItem = "6/55" And DayWeek = "Monday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Tuesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Wednesday")
            MsgBox("The Lotto Draw will be 9:00 PM Wednesday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Wednesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Thursday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Saturday")
            MsgBox("The Lotto Draw will be 9:00 PM Saturday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(2)

        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Friday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Saturday")
            MsgBox("The Lotto Draw will be 9:00 PM Saturday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Saturday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")


        ElseIf cmbLottoType.SelectedItem = "6/55" And DayWeek = "Sunday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Monday")
            MsgBox("The Lotto Draw will be 9:00 PM Monday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        End If
        '--------------------------------------------------------------------------------------------------'

        If cmbLottoType.SelectedItem = "6/49" And DayWeek = "Monday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Tuesday")
            MsgBox("The Lotto Draw will be 9:00 PM Tuesday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Tuesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Wednesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Sunday")
            MsgBox("The Lotto Draw will be 9:00 PM Sunday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(4)

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Thursday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Sunday")
            MsgBox("The Lotto Draw will be 9:00 PM Sunday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(3)

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Friday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Sunday")
            MsgBox("The Lotto Draw will be 9:00 PM Sunday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(2)

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Saturday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Sunday")
            MsgBox("The Lotto Draw will be 9:00 PM Sunday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/49" And DayWeek = "Sunday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        End If
        '--------------------------------------------------------------------------------------------------'

        If cmbLottoType.SelectedItem = "6/45" And DayWeek = "Monday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Tuesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Wednesday")
            MsgBox("The Lotto Draw will be 9:00 PM Wednesday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Wednesday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Thursday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Friday")
            MsgBox("The Lotto Draw will be 9:00 PM Friday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Friday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be this day 9:00 PM")
            MsgBox("The Lotto Draw will be this day 9:00 PM")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Saturday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Monday")
            MsgBox("The Lotto Draw will be 9:00 PM Monday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(2)

        ElseIf cmbLottoType.SelectedItem = "6/45" And DayWeek = "Sunday" Then
            spkDrawDate.SpeakAsync("The Lotto Draw will be 9:00 PM Monday")
            MsgBox("The Lotto Draw will be 9:00 PM Monday")
            PredictedDay = DateTime.Now.ToString("yyyy-MM-dd")
            PredictedDay = PredictedDay.AddDays(1)

        End If

        AutoPredicDateDraw = PredictedDay.ToString("yyyy-MM-dd")
    End Function
    Dim counter As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        lbltimer.Text = counter
        If counter = 2 Then
            spk1.SpeakAsync(lblNumber1.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox1.Visible = False
        ElseIf counter = 4 Then
            spk2.SpeakAsync(lblNumber2.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox2.Visible = False
        ElseIf counter = 6 Then
            spk3.SpeakAsync(lblNumber3.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox3.Visible = False
        ElseIf counter = 8 Then
            spk4.SpeakAsync(lblNumber4.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox4.Visible = False
        ElseIf counter = 10 Then
            spk5.SpeakAsync(lblNumber5.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox5.Visible = False
        ElseIf counter = 12 Then
            spk6.SpeakAsync(lblNumber6.Text)
            LuckyNumber.Play()
            'Snds.Play("GetNumber")
            PictureBox6.Visible = False
            Timer1.Stop()
            counter = 0



            If MessageBox.Show("Do you want to save your generated Number and Use this in Lotto?", "System Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    With cmd
                        .Connection = con
                        .CommandText = "Insert into tblluckypick (1stNumber,2ndNumber,3rdNumber,4thNumber,5thNumber,6thNumber,LottoType,DateAndTime,LPUsername,AutoPredictLottoDrawDate) VALUES ('" & lblNumber1.Text & "','" & lblNumber2.Text & "','" & lblNumber3.Text & "','" & lblNumber4.Text & "','" & lblNumber5.Text & "','" & lblNumber6.Text & "','" & lblLottoType.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & lblUsername.Text & "','" & AutoPredicDateDraw(DateTime.Now.ToString("dddd")) & "') "
                        .ExecuteNonQuery()
                    End With
                    WinnerWinnerChickenDinner.Play()
                    PictureBox8.Visible = True


                    MsgBox("Succesfully Save")
                    RefreshRecentLuckyLottoNumber()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                spk.Volume = 100%
                spk.SpeakAsync("Good-luck")
            End If

            btnRollIt.Enabled = True
            cmbLottoType.Enabled = True
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row, id As Integer

        'Declared this variable to get value event click on dgv
        row = DataGridView1.CurrentRow.Index

        id = DataGridView1(0, row).Value
        With cmd
            .Connection = con
            .CommandText = "SELECT AutoPredictLottoDrawDate from tblluckypick where luckypickid='" & id & "'"
        End With

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            lblDrawDate.Text = dr.Item("AutoPredictLottoDrawDate")
            dr.Close()
        Else
            dr.Close()
        End If
    End Sub

    Private Sub frmMyLuckyLotto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub

    Private Sub btnViewDraw_Click(sender As Object, e As EventArgs) Handles btnViewDraw.Click
        frmViewLottoResult.ShowDialog()
    End Sub

    Private Sub btnGotMessage_Click(sender As Object, e As EventArgs) Handles btnGotMessage.Click
        YeheyKids.Play()
        CheckMessage()
    End Sub

End Class
