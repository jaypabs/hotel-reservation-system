'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Option Strict Off
Option Explicit On

Imports System.Data.OleDb

Public Class frmCheckOut
    Inherits System.Windows.Forms.Form

    Dim daTransactions As New OleDbDataAdapter()
    Dim dsTransactions As New DataSet()

    Public RoomNumber As Short
    Public AmountPaid As Decimal 'Amount paid from frmPayment
    Public OtherCharges As Decimal
    Public AutoCheckOut As Boolean

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
        ExecNonQuery("DELETE FolioNumber " & "From [Rate Per Period] " & "WHERE FolioNumber='" & txtGuestName.Tag & "'")

        ExecNonQuery("INSERT INTO [Rate Per Period] " & "SELECT [Rate Per Period Temp].* " & "FROM [Rate Per Period Temp] " & "Where ((([Rate Per Period Temp].FolioNumber) = '" & txtGuestName.Tag & "')) " & "ORDER BY [Rate Per Period Temp].Date;")

        Me.Close()
    End Sub

    Private Sub cmdCheckOut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCheckOut.Click
        If txtBalance.Text <> "0.00" Then
            MsgBox("There's still remaining balance for this guest.", MsgBoxStyle.Exclamation)

            Exit Sub
        End If

        If MsgBox("Are you sure you want to Check Out?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then Exit Sub

        ExecNonQuery("UPDATE Rooms SET RoomStatusID =3 WHERE RoomNumber = " & txtRoomNumber.Text)

        Call frmPayments.SaveRecord()
        Call frmOtherCharges.SaveRecord()

        Dim dt As DataTable = dsTransactions.Tables("Transactions")

        With dt
            'Delete record from Inventory
            ExecNonQuery("DELETE ID, Status " & "From [Inventory] " & "WHERE ID='" & .Rows(0)("FolioNumber") & "' AND Status='Check In'")

            .Rows(0)("DateOut") = dtpDateOut.Value
            .Rows(0)("OtherCharges") = txtOtherCharges.Text
            .Rows(0)("Discount") = txtDiscount.Text
            .Rows(0)("AmountPaid") = txtAmountPaid.Text
            .Rows(0)("Days") = txtDays.Text
            Debug.Print(.Rows(0)("Status"))
            .Rows(0)("Status") = "Check Out"
            Debug.Print(.Rows(0)("FolioNumber"))
            '.Rows(0)("CheckOutBy") = CurrUser.USER_PK
            daTransactions.Update(dsTransactions, "Transactions")
        End With

        Call PrintFolio()

        Me.Close()
    End Sub

    Private Sub PrintFolio()
        'With frmReports
        '    .strReport = "Folio"

        '    .strWhere = "{qry_RPT_Customers.FolioNumber} = '" & txtGuestName.Tag & "' AND {qry_RPT_Customers.Status} = 'Check Out'"

        '    frmReports.ShowDialog()
        'End With
    End Sub

    Private Sub dtpDateOut_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtpDateOut.Leave
        If CDate(dtpDateIn.Text) > dtpDateOut.Value Then
            MsgBox("Check In date must be below check out date. Please enter another check out date.", MsgBoxStyle.Information)

            dtpDateOut.Focus()
        End If
    End Sub

    Private Sub frmCheckOut_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmCheckOut_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim cnHotel As OleDbConnection

        cnHotel = New OleDbConnection

        Try
            With cnHotel
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        End Try

        FillCombobox(cboRateType, "SELECT * FROM Rate_Type", "Rate_Type", "RateType", "RateTypeID")

        txtRoomNumber.Text = CStr(RoomNumber)

        dsTransactions.Clear()

        Dim qryTransactions As String = "SELECT * FROM Transactions WHERE RoomNumber = " & RoomNumber & " AND Status = 'Check In'"

        daTransactions.SelectCommand = New OleDbCommand(qryTransactions, cnHotel)

        Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daTransactions)

        daTransactions.Fill(dsTransactions, "Transactions")

        Dim dt As DataTable = dsTransactions.Tables("Transactions")

        Try
            txtGuestName.Tag = dt.Rows(0)("FolioNumber")
            txtGuestName.Text = GetFieldValue("SELECT [Name] FROM qry_CheckIn WHERE FolioNumber = '" & dt.Rows(0)("FolioNumber") & " '", "Name")
            dtpDateIn.Text = dt.Rows(0)("DateIn")
            If AutoCheckOut = True Then
                If dt.Rows(0)("DateOut") >= Today Then
                    dtpDateOut.Value = dt.Rows(0)("DateOut")
                Else
                    dtpDateOut.Value = Today
                End If
            Else
                dtpDateOut.Value = dt.Rows(0)("DateOut")
            End If
            cboRateType.SelectedValue = dt.Rows(0)("RateType")
            txtDays.Text = dtpDateOut.Value.Subtract(dtpDateIn.Text).Days.ToString
            txtAdults.Text = dt.Rows(0)("Adults")
            txtChildrens.Text = dt.Rows(0)("Childrens")
            txtRate.Text = dt.Rows(0)("Rate")
            txtOtherCharges.Text = toMoney(dt.Rows(0)("OtherCharges"))
            txtDiscount.Text = toMoney(dt.Rows(0)("Discount"))
            txtAmountPaid.Text = toMoney(dt.Rows(0)("AmountPaid"))
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            cnHotel.Close()
        End Try

        cboRateType.Enabled = False

        Call ComputeAddRate()
        Call ComputeRate()

        ExecNonQuery("DELETE FolioNumber " & "From [Rate_Per_Period_Temp] " & "WHERE FolioNumber='" & txtGuestName.Tag & "'")

        ExecNonQuery("INSERT INTO [Rate_Per_Period_Temp] " & "SELECT [Rate_Per_Period].* " & "From [Rate_Per_Period] " & "WHERE FolioNumber='" & txtGuestName.Tag & "'")
    End Sub

    Private Sub ComputeRate()
        txtTotalCharges.Text = toMoney(CStr(ComputeRatePerPeriod()))
        txtSubTotal.Text = toMoney(CStr(toNumber(txtTotalCharges.Text) + toNumber(txtOtherCharges.Text)))
        txtTotal.Text = toMoney(CStr(toNumber(txtSubTotal.Text) - (toNumber(txtSubTotal.Text) * toNumber(txtDiscount.Text) / 100)))
        txtBalance.Text = toMoney(CStr(toNumber(txtTotal.Text) - toNumber(txtAmountPaid.Text)))
    End Sub

    'Compute additional rate (no. of days & childrens)
    Private Sub ComputeAddRate()
        Dim cnHotel As OleDbConnection

        cnHotel = New OleDbConnection

        Try
            With cnHotel
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        End Try

        Dim sqlQRY As String = "SELECT * FROM [Room_Rates] WHERE RoomNumber = " & RoomNumber & " AND RateTypeID = " & cboRateType.SelectedValue
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)
        Dim RecordCount As Integer

        RecordCount = CountRows("SELECT Count(*) FROM [Room_Rates]")

        Try
            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            While (rdr.Read)
                If RecordCount > 0 Then
                    txtRate.Text = toMoney(rdr("RoomRate"))
                    txtAdults.Tag = rdr("ExtraAdultRate")
                    txtChildrens.Tag = rdr("ExtraChildRate")
                End If
            End While
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            cnHotel.Close()
        End Try
    End Sub

    Private Sub frmCheckOut_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPayments.Close()

        'UPGRADE_NOTE: Object frmPayment may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        frmPayments = Nothing
        'UPGRADE_NOTE: Object frmCheckOut may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Me = Nothing
    End Sub

    Private Sub lblAmountPaid_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblAmountPaid.Click
        With frmPayments
            .FolioNumber = txtGuestName.Tag
            .GuestName = txtGuestName.Text
            .Balance = CDec(txtBalance.Text)
            .RefreshBalance()
            .RefForm = Me.Name

            .ShowDialog()

            txtAmountPaid.Text = toMoney(CStr(AmountPaid))
        End With
    End Sub

    Private Function ComputeRatePerPeriod() As Decimal
        Dim cnHotel As OleDbConnection
        cnHotel = New OleDbConnection

        Dim sqlQRY As String = "SELECT * FROM [Rate_Per_Period] WHERE FolioNumber = '" & txtGuestName.Tag & "'"

        Try
            With cnHotel
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)

            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            While (rdr.Read)
                ComputeRatePerPeriod = ComputeRatePerPeriod + CDbl(toMoney(rdr("Rate"))) + CDbl(toMoney(rdr("Adults"))) + CDbl(toMoney(rdr("Childrens")))
            End While
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            cnHotel.Close()
        End Try
    End Function

    Private Sub lblOtherCharges_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblOtherCharges.Click
        With frmOtherCharges
            .FolioNumber = txtGuestName.Tag
            .GuestName = txtGuestName.Text

            .RefForm = Me.Name

            .ShowDialog()

            txtOtherCharges.Text = toMoney(CStr(OtherCharges))
        End With
    End Sub


    Private Sub lblRatePerPeriod_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblRatePerPeriod.Click
        With frmRatePerPeriod
            .FolioNumber = txtGuestName.Tag

            .ShowDialog()

            Call ComputeRate()
        End With
    End Sub

    Private Sub txtAmountPaid_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAmountPaid.TextChanged
        txtBalance.Text = toMoney(toNumber(txtTotal.Text) - toNumber(txtAmountPaid.Text))
    End Sub

    Private Sub txtDays_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDays.TextChanged
        Dim tmpDate As Date
        Dim minNoofPerson As Short

        tmpDate = CDate(dtpDateIn.Text)

        If txtAdults.Tag.ToString = "" Then Exit Sub

        ExecNonQuery("DELETE [Date] " & "FROM [Rate Per Period] " & "WHERE [DateIn]>#" & dtpDateOut.Value.AddDays(-1) & "#")

        Dim intAdults As Short

        minNoofPerson = CShort(GetFieldValue("SELECT * FROM [Room_Rates] WHERE RoomNumber = " & RoomNumber & " AND RateTypeID = " & cboRateType.SelectedValue, "NoofPerson"))

        If CDbl(txtAdults.Text) = minNoofPerson Then
            intAdults = 0
        Else
            intAdults = CShort(txtAdults.Text) - minNoofPerson
        End If

        Dim qry As String = "SELECT * FROM Rate_Per_Period WHERE FolioNumber = '" & txtGuestName.Tag & "' ORDER BY DateIn"

        Dim cnHotel As OleDbConnection = New OleDbConnection(cnString)

        Try
            Dim da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(qry, cnHotel)

            Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(da)

            Dim ds As New DataSet()
            da.Fill(ds, "Rate_Per_Period")

            Dim dt As DataTable = ds.Tables("Rate_Per_Period")

            Dim newRow As DataRow

            Do Until tmpDate > dtpDateOut.Value.AddDays(-1)
                Dim rows As DataRow() = dt.Select("[DateIn] = #" & tmpDate & "#")
                If rows.Count = 0 Then
                    newRow = dt.NewRow()

                    newRow("FolioNumber") = txtGuestName.Tag
                    newRow("DateIn") = tmpDate
                    newRow("RoomNumber") = txtRoomNumber.Text
                    newRow("RateTypeID") = cboRateType.SelectedValue
                    newRow("Rate") = txtRate.Text
                    newRow("Adults") = CDbl(txtAdults.Tag) * intAdults
                    newRow("Childrens") = CDbl(toMoney(txtChildrens.Tag)) * toNumber(txtChildrens.Text)

                    dt.Rows.Add(newRow)
                End If
                tmpDate = System.DateTime.FromOADate(tmpDate.ToOADate + 1)
            Loop

            da.Update(ds, "Rate_Per_Period")
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            cnHotel.Close()
        End Try
    End Sub

    Private Sub dtpDateOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOut.ValueChanged
        txtDays.Text = CStr(System.DateTime.FromOADate(dtpDateOut.Value.ToOADate - CDate(dtpDateIn.Text).ToOADate))

        Call ComputeRate()
    End Sub
End Class