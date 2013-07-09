'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Data.OleDb

Friend Class frmCheckIn
    Inherits System.Windows.Forms.Form

    Dim daTransactions As New OleDbDataAdapter()
    Dim dsTransactions As New DataSet()
    Dim cnHotel As OleDbConnection

    Public RoomNumber As Integer
    Public State As modGlobal.FormState
    Public FolioNumber As String
    Public AmountPaid As Decimal
    Public OtherCharges As Decimal
    Public blnChangeRoom As Boolean

    Private IsInitializing As Boolean

    Private Sub frmCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        IsInitializing = True

        FillCombobox(cboCountry, "SELECT * FROM Countries", "Countries", "Country", "CountryID")
        FillCombobox(cboIDType, "SELECT * FROM [ID_Type]", "ID_Type", "IDType", "IDTypeID")
        FillCombobox(cboRateType, "SELECT RateTypeID, RateType FROM [Rate_Type]", "Rate_Type", "RateType", "RateTypeID")
        FillCombobox(cboBusinessSource, "SELECT * FROM [Business_Source]", "Business_Source", "BusinessSource", "BusinessSourceID")
        FillCombobox(cboVehicle, "SELECT * FROM [Vehicles]", "Vehicles", "Vehicle", "VehicleID")

        cboVehicle.Text = ""

        If State = modGlobal.FormState.adStateAddMode Then
            txtRoomNumber.Text = CStr(RoomNumber)
            dtpDateIn.Value = Today
            dtpDateOut.Value = DateTime.Now.AddDays(1)

            GeneratePK()

            Dim sqlQRY As String = "SELECT * FROM [Room_Rates] WHERE RoomNumber = " & RoomNumber & " AND RateTypeID = " & cboRateType.SelectedValue
            Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)
            Dim RecordCount As Integer

            RecordCount = CountRows("SELECT Count(*) FROM [Room_Rates]")

            Try
                Dim rdr As OleDbDataReader = cmd.ExecuteReader

                While (rdr.Read)
                    If RecordCount > 0 Then
                        txtRate.Text = rdr("RoomRate").ToString()
                        txtAdults.Text = rdr("NoofPerson").ToString()
                        hsAdults.Minimum = rdr("NoofPerson").ToString()
                        hsAdults.Value = rdr("NoofPerson").ToString()
                        txtAdults.Tag = rdr("ExtraAdultRate").ToString()
                        txtChildrens.Tag = rdr("ExtraChildRate").ToString()
                    End If
                End While

                Dim qryTransactions As String = "SELECT * FROM Transactions WHERE FolioNumber = '0'"

                daTransactions.SelectCommand = New OleDbCommand(qryTransactions, cnHotel)

                Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daTransactions)

                daTransactions.Fill(dsTransactions, "Transactions")
            Catch ex As OleDbException
                MsgBox(ex.ToString)
            Finally
                cnHotel.Close()
            End Try

            Call txtDays_TextChanged(sender, e)

            Call ComputeRate()
        ElseIf State = modGlobal.FormState.adStateEditMode Then
            Try
                Dim qryTransactions As String = "SELECT * FROM Transactions WHERE RoomNumber = " & RoomNumber & " AND Status = 'Check In'"

                daTransactions.SelectCommand = New OleDbCommand(qryTransactions, cnHotel)

                Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daTransactions)

                daTransactions.Fill(dsTransactions, "Transactions")

                Call FillData()

                btnCheckInOut.Text = "Check Out"
                btnChangeRoom.Enabled = True
                btnUpdateDelete.Enabled = True
                btnPrint.Visible = True

                Call txtDays_TextChanged(sender, e)

                Call ComputeRate()
            Catch ex As OleDbException
                MsgBox(ex.ToString)
            Finally
                cnHotel.Close()
            End Try
        Else 'adStatePopupMode
            Dim qryTransactions As String = "SELECT * FROM Transactions WHERE FolioNumber = '" & FolioNumber & "'"

            daTransactions.SelectCommand = New OleDbCommand(qryTransactions, cnHotel)

            Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daTransactions)

            daTransactions.Fill(dsTransactions, "Transactions")

            Call FillData()

            Call ComputeRate()

            btnPrint.Visible = True
            btnPrint.Left = 631
            'btnPrint.Top = 384
            btnChangeRoom.Visible = False
            btnCheckInOut.Visible = False
            btnUpdateDelete.Visible = False
        End If

        'Delete the temporary data of Rate Per Period
        ExecNonQuery("DELETE FolioNumber " & "From [Rate_Per_Period_Temp] " & "WHERE FolioNumber='" & txtFolioNumber.Text & "'")
        'Fill it again with new data from Rate Per Period
        ExecNonQuery("INSERT INTO [Rate_Per_Period_Temp] " & "SELECT [Rate_Per_Period].* " & "From [Rate_Per_Period] " & "WHERE FolioNumber='" & txtFolioNumber.Text & "'")

        IsInitializing = False
    End Sub

    'Procedure used to generate PK
    Private Sub GeneratePK()
        FolioNumber = GetIndex("Transactions")
        txtFolioNumber.Text = GenerateID(CStr(FolioNumber), Format(Today, "yy") & "-", "00000")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCheckInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckInOut.Click
        Dim strCaption As String
        Dim RoomNumber As Short

        strCaption = btnCheckInOut.Text
        RoomNumber = CShort(txtRoomNumber.Text)

        Call SaveRecord()

        If State = modGlobal.FormState.adStateAddMode Then
            MsgBox("New record has been successfully saved.", MsgBoxStyle.Information)

            Me.Close()
        Else
            MsgBox("Changes in  record has been successfully saved.", MsgBoxStyle.Information)

            Me.Close()
        End If

        If strCaption = "Check Out" Then
            With frmCheckOut
                .RoomNumber = RoomNumber
                .AutoCheckOut = False

                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub lblRatePerPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRatePerPeriod.Click
        With frmRatePerPeriod
            .FolioNumber = txtFolioNumber.Text

            .ShowDialog()
        End With
    End Sub

    Private Sub txtDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDays.TextChanged
        Dim tmpDate As Date

        tmpDate = dtpDateIn.Value

        If txtAdults.Tag = "" Then Exit Sub

        ExecNonQuery("DELETE [DateIn] " & "FROM [Rate_Per_Period] " & "WHERE [DateIn]>#" & dtpDateOut.Value.AddDays(-1) & "#")

        Dim intAdults As Short

        If txtAdults.Text = "" Then Exit Sub

        If CDbl(txtAdults.Text) = hsAdults.Minimum Then
            intAdults = 0
        Else
            intAdults = CShort(txtAdults.Text) - hsAdults.Minimum
        End If

        Dim qry As String = "SELECT * FROM Rate_Per_Period WHERE FolioNumber = '" & txtFolioNumber.Text & "' ORDER BY DateIn"

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

                    newRow("FolioNumber") = txtFolioNumber.Text
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

    Private Sub ComputeRate()
        txtTotalCharges.Text = toMoney(CStr(ComputeRatePerPeriod))
        txtSubTotal.Text = toMoney(CStr(toNumber(txtTotalCharges.Text) + toNumber(txtOtherCharges.Text)))
        txtTotal.Text = toMoney(CStr(toNumber(txtSubTotal.Text) - (toNumber(txtSubTotal.Text) * toNumber(txtDiscount.Text) / 100)))
        txtBalance.Text = toMoney(CStr(toNumber(txtTotal.Text) - toNumber(txtAmountPaid.Text)))
    End Sub

    Private Function ComputeRatePerPeriod() As Decimal
        Dim cnHotel As OleDbConnection
        cnHotel = New OleDbConnection

        Dim sqlQRY As String = "SELECT * FROM [Rate_Per_Period] WHERE FolioNumber = '" & txtFolioNumber.Text & "'"

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

    Public Sub dtpDateOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOut.ValueChanged
        If dtpDateOut.Value <= dtpDateIn.Value Then
            dtpDateOut.Value = dtpDateIn.Value.AddDays(1)
        End If

        txtDays.Text = dtpDateOut.Value.Subtract(dtpDateIn.Value).Days.ToString
        hsDays.Value = txtDays.Text

        Call ComputeRate()
    End Sub

    Private Sub lblOtherCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOtherCharges.Click
        With frmOtherCharges
            .FolioNumber = txtFolioNumber.Text
            .GuestName = txtFirstName.Text & " " & txtLastName.Text

            .RefForm = Me.Name

            .ShowDialog()

            txtOtherCharges.Text = toMoney(OtherCharges)
        End With

        Call ComputeRate()
    End Sub

    Private Sub lblAmountPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAmountPaid.Click
        With frmPayments
            .FolioNumber = txtFolioNumber.Text
            .GuestName = txtFirstName.Text & " " & txtLastName.Text
            .Balance = txtBalance.Text
            .RefreshBalance()

            .RefForm = Me.Name

            .ShowDialog()

            txtAmountPaid.Text = toMoney(AmountPaid)
        End With
    End Sub

    Private Sub btnUpdateDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDelete.Click
        If btnUpdateDelete.Text = "Update" Then
            Call SaveRecord()

            If State = modGlobal.FormState.adStateAddMode Then
                MsgBox("New record has been successfully saved.", vbInformation)

                'Me.Close()
            Else
                MsgBox("Changes in  record has been successfully saved.", vbInformation)

                'Me.Close 
            End If
        End If
    End Sub

    Private Sub SaveRecord()
        Dim CustomerID As Short
        Dim CompanyID As Short

        If Trim(txtLastName.Text) = "" Or Trim(txtFirstName.Text) = "" Then
            MsgBox("Please complete the name of a guest.", MsgBoxStyle.Information)

            Exit Sub
        End If

        CustomerID = GetFieldValue("SELECT CustomerID FROM Customers WHERE LastName = '" & txtLastName.Text & "' AND FirstName = '" & txtFirstName.Text & "'", "CustomerID")
        If CustomerID = 0 Then
            CustomerID = GetIndex("Customers")

            ExecNonQuery("INSERT INTO Customers (CustomerID, LastName, FirstName) Values (" & CustomerID & ", '" & txtLastName.Text & "', '" & txtFirstName.Text & "')")
        End If

        CompanyID = GetFieldValue("SELECT CompanyID FROM Company WHERE Company = '" & txtCompany.Text & "' ", "CompanyID")
        If CompanyID = 0 Then
            If CompanyID = 0 Then
                CompanyID = GetIndex("Company")

                ExecNonQuery("INSERT INTO Company (CompanyID, Company) Values (" & CompanyID & ", '" & txtCompany.Text & "')")
            End If
        End If

        Dim dt As DataTable = dsTransactions.Tables("Transactions")

        If State = modGlobal.FormState.adStateAddMode Then
            ' add a row
            Dim newRow As DataRow

            newRow = dt.NewRow()
            newRow("FolioNumber") = txtFolioNumber.Text
            newRow("Status") = "Check In"
            'newRow("CheckInBy") = CurrUser.USER_PK
            'newRow("AddedByFK") = CurrUser.USER_PK

            dt.Rows.Add(newRow)
        Else
            dt.Rows(0)("DateModified") = Now
            'dt.Rows(0)("LastUserFK") = CurrUser.USER_PK
        End If

        With dt
            .Rows(0)("RCardNo") = txtRCardNo.Text
            .Rows(0)("CustomerID") = CustomerID
            .Rows(0)("Address") = txtAddress.Text
            .Rows(0)("CountryID") = cboCountry.SelectedValue
            .Rows(0)("CompanyID") = CompanyID
            .Rows(0)("IDTypeID") = cboIDType.SelectedValue
            .Rows(0)("IDNumber") = txtIDNumber.Text
            .Rows(0)("RoomNumber") = txtRoomNumber.Text
            .Rows(0)("DateIn") = dtpDateIn.Value
            .Rows(0)("DateOut") = dtpDateOut.Value
            .Rows(0)("RateType") = cboRateType.SelectedValue
            .Rows(0)("Rate") = txtRate.Text
            .Rows(0)("OtherCharges") = txtOtherCharges.Text
            .Rows(0)("Discount") = txtDiscount.Text
            .Rows(0)("AmountPaid") = txtAmountPaid.Text
            .Rows(0)("Days") = txtDays.Text
            .Rows(0)("Adults") = txtAdults.Text
            .Rows(0)("Childrens") = txtChildrens.Text
            .Rows(0)("Total") = txtTotal.Text
            .Rows(0)("BusinessSourceID") = cboBusinessSource.SelectedValue
            .Rows(0)("VehicleID") = IIf(IsDBNull(cboVehicle.Text), System.DBNull.Value, cboVehicle.SelectedValue)
            .Rows(0)("VehicleModel") = txtVehicleModel.Text
            .Rows(0)("PlateNo") = txtPlateNo.Text
            .Rows(0)("Notes") = txtNotes.Text

            daTransactions.Update(dsTransactions, "Transactions")
        End With

        'Delete record from Inventory and add a new check in/out date
        ExecNonQuery("DELETE ID, Status " & "From [Inventory] " & "WHERE ID='" & txtFolioNumber.Text & "' AND Status='Check In'")

        Dim dtpStartDate As Date

        dtpStartDate = dtpDateIn.Value

        Do Until dtpStartDate = Format(dtpDateOut.Value, "Short Date")
            ExecNonQuery("INSERT INTO [Inventory] ( ID, RoomNumber, [Date], CustomerID, Status ) " & "VALUES ('" & txtFolioNumber.Text & "', " & txtRoomNumber.Text & ", #" & dtpStartDate & "#, " & txtLastName.Tag & ", 'Check In')")

            dtpStartDate = System.DateTime.FromOADate(dtpStartDate.ToOADate + 1)
        Loop

        ExecNonQuery("UPDATE Rooms SET RoomStatusID =2 WHERE RoomNumber = " & txtRoomNumber.Text)

        Call frmPayments.SaveRecord()
        Call frmOtherCharges.SaveRecord()

        If txtCompany.Text <> "" Then
            Dim RecordCount As Integer

            RecordCount = CountRows("SELECT Count(*) FROM [Room_Rates]")

            If RecordCount = 0 Then
                ExecNonQuery("INSERT INTO Accounts_Receivable (CompanyID, FolioNumber, Credit) Values (" & txtCompany.Tag & ", '" & txtFolioNumber.Text & "'," & txtBalance.Text & ")")
            Else
                ExecNonQuery("UPDATE Accounts_Receivable SET Debit = " & txtBalance.Text & " WHERE CompanyID = " & txtCompany.Tag & " AND FolioNumber = '" & txtFolioNumber.Text & "'")
            End If
        ElseIf State = modGlobal.FormState.adStateEditMode Then
            'delete record from accounts receivable table since the company field becomes blank.
            ExecNonQuery("DELETE FolioNumber " & "From Accounts_Receivable " & "WHERE FolioNumber= '" & txtFolioNumber.Text & "'")
        End If

    End Sub

    Private Sub hsDays_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsDays.ValueChanged
        dtpDateOut.Value = dtpDateIn.Value.AddDays(hsDays.Value.ToString)

        txtDays.Text = hsDays.Value.ToString

        Call ComputeRate()
    End Sub

    Private Sub hsAdults_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsAdults.ValueChanged
        txtAdults.Text = hsAdults.Value.ToString

        Call ComputeAdultsRate()
        Call ComputeRate()
    End Sub

    Private Sub hsChildrens_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsChildrens.ValueChanged
        txtChildrens.Text = hsChildrens.Value.ToString

        Call ComputeChildrensRate()
        Call ComputeRate()
    End Sub

    Private Sub ComputeAdultsRate()
        If txtAdults.Tag = "" Then Exit Sub

        Dim intAdults As Short

        If CDbl(txtAdults.Text) = hsAdults.Minimum Then
            intAdults = 0
        Else
            intAdults = CShort(txtAdults.Text) - hsAdults.Minimum
        End If

        Dim sSQL As String = "SELECT Count(*) FROM [Rate_Per_Period] WHERE FolioNumber = '" & txtFolioNumber.Text & "' AND [DateIn] = #" & dtpDateOut.Value.AddDays(-1) & "#"
        Dim RecordCount As Integer

        RecordCount = CountRows(sSQL)

        If RecordCount = 1 Then
            ExecNonQuery("UPDATE Rate_Per_Period SET Adults = " & CDbl(txtAdults.Tag) * intAdults & " WHERE FolioNumber = '" & txtFolioNumber.Text & "' AND [DateIn] = #" & dtpDateOut.Value.AddDays(-1) & "#")
        End If

    End Sub

    Private Sub ComputeChildrensRate()
        If txtChildrens.Tag = "" Then Exit Sub

        Dim sSQL As String = "SELECT Count(*) FROM [Rate_Per_Period] WHERE FolioNumber = '" & txtFolioNumber.Text & "' AND [DateIn] = #" & dtpDateOut.Value.AddDays(-1) & "#"
        Dim RecordCount As Integer

        RecordCount = CountRows(sSQL)

        If RecordCount = 1 Then
            ExecNonQuery("UPDATE Rate_Per_Period SET Childrens = " & CDbl(txtChildrens.Tag) * CDbl(txtChildrens.Text) & " WHERE FolioNumber = '" & txtFolioNumber.Text & "' AND [DateIn] = #" & dtpDateOut.Value.AddDays(-1) & "#")
        End If
    End Sub

    Private Sub btnLookupCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookupCust.Click
        With frmCustomerLookup
            .ShowDialog()

            txtLastName.Text = CurrCust.Lastname
            txtFirstName.Text = CurrCust.Firstname
        End With
    End Sub

    Private Sub btnLookupComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookupComp.Click
        With frmCompanyLookup
            .ShowDialog()

            txtCompany.Text = CurrCust.Company
        End With
    End Sub

    Private Sub btnChangeRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeRoom.Click
        Dim OldRoomNumber As Short

        With frmChangeRoom
            OldRoomNumber = CShort(txtRoomNumber.Text)
            .txtFrom.Text = CStr(OldRoomNumber)

            .ShowDialog()
        End With

        If blnChangeRoom = False Then Exit Sub

        ExecNonQuery("UPDATE Rooms SET RoomStatusID =2 WHERE RoomNumber = " & txtRoomNumber.Text)
        ExecNonQuery("UPDATE Rooms SET RoomStatusID =3 WHERE RoomNumber = " & OldRoomNumber)
        ExecNonQuery("UPDATE [Inventory] SET [Inventory].RoomNumber = " & txtRoomNumber.Text & " " & "WHERE RoomNumber=" & OldRoomNumber & " AND ID='" & txtFolioNumber.Text & "' AND Status='Check In'")
    End Sub

    Private Sub txtAmountPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountPaid.TextChanged
        txtBalance.Text = toMoney(CStr(toNumber(txtTotal.Text) - toNumber(txtAmountPaid.Text)))
    End Sub

    Private Sub dtpDateIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateIn.ValueChanged
        If Me.IsInitializing = True Then
            Exit Sub
        Else
            Call dtpDateOut_ValueChanged(sender, e)
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        Call ComputeRate()
    End Sub

    Private Sub FillData()
        Dim sqlQRY As String = "SELECT * FROM [Room_Rates] WHERE RoomNumber = " & RoomNumber & " AND RateTypeID = " & cboRateType.SelectedValue
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)
        Dim RecordCount As Integer

        RecordCount = CountRows("SELECT Count(*) FROM [Room_Rates]")

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While (rdr.Read)
            If RecordCount > 0 Then
                txtRate.Text = toMoney(rdr("RoomRate").ToString)
                hsAdults.Minimum = rdr("NoofPerson").ToString
                txtAdults.Tag = rdr("ExtraAdultRate").ToString
                txtChildrens.Tag = rdr("ExtraChildRate").ToString
            End If
        End While

        Dim dt As DataTable = dsTransactions.Tables("Transactions")

        txtFolioNumber.Text = dt.Rows(0)("FolioNumber")
        txtRCardNo.Text = dt.Rows(0)("RCardNo")
        txtLastName.Text = GetFieldValue("SELECT LastName FROM Customers WHERE CustomerID = " & dt.Rows(0)("CustomerID"), "LastName")
        txtFirstName.Text = GetFieldValue("SELECT FirstName FROM Customers WHERE CustomerID = " & dt.Rows(0)("CustomerID"), "FirstName")
        txtAddress.Text = dt.Rows(0)("Address")
        cboCountry.SelectedValue = dt.Rows(0)("CountryID")
        If Not IsDBNull(dt.Rows(0)("CompanyID")) Then txtCompany.Text = GetFieldValue("SELECT Company FROM Company WHERE CompanyID = " & dt.Rows(0)("CompanyID"), "Company")
        cboIDType.SelectedValue = dt.Rows(0)("IDTypeID")
        txtIDNumber.Text = dt.Rows(0)("IDNumber")
        txtRoomNumber.Text = dt.Rows(0)("RoomNumber")
        dtpDateIn.Value = dt.Rows(0)("DateIn")
        If State = modGlobal.FormState.adStateAddMode Or State = modGlobal.FormState.adStateEditMode Then
            If dt.Rows(0)("DateOut") >= Today Then
                dtpDateOut.Value = dt.Rows(0)("DateOut")
            ElseIf dt.Rows(0)("DateIn") = Today Then
                dtpDateOut.Value = dtpDateIn.Value.AddDays(1)
            Else
                dtpDateOut.Value = Today
            End If
        Else
            dtpDateOut.Value = dt.Rows(0)("DateOut")
        End If
        cboRateType.SelectedValue = dt.Rows(0)("RateType")
        txtRate.Text = toMoney(dt.Rows(0)("Rate"))
        txtOtherCharges.Text = toMoney(dt.Rows(0)("OtherCharges"))
        txtDiscount.Text = dt.Rows(0)("Discount")
        txtAmountPaid.Text = toMoney(dt.Rows(0)("AmountPaid"))
        txtAdults.Text = dt.Rows(0)("Adults")
        txtChildrens.Text = dt.Rows(0)("Childrens")
        txtDays.Text = dtpDateOut.Value.Subtract(dtpDateIn.Value).Days.ToString
        cboBusinessSource.SelectedValue = dt.Rows(0)("BusinessSourceID")
        cboVehicle.SelectedValue = dt.Rows(0)("VehicleID")
        txtVehicleModel.Text = dt.Rows(0)("VehicleModel")
        txtPlateNo.Text = dt.Rows(0)("PlateNo")
        txtNotes.Text = dt.Rows(0)("Notes")

        hsDays.Value = txtDays.Text
        hsAdults.Value = txtAdults.Text
        hsChildrens.Value = txtChildrens.Text

        StatusBar1.Items.Item(2).Text = "Check In By: " & GetFieldValue("SELECT UserID FROM Users WHERE PK = " & dt.Rows(0)("CheckInBy"), "UserID")
        StatusBar1.Items.Item(3).Text = "Business Source: " & cboBusinessSource.Text
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmReports As New frmReports

        With frmReports
            .strReport = "Folio"
            If State = modGlobal.FormState.adStatePopupMode Then
                .strWhere = "{qry_RPT_Customers.FolioNumber} = '" & txtFolioNumber.Text & "' AND {qry_RPT_Customers.Status} = 'Check Out'"
            Else
                If MsgBox("This will save the record before printing a folio. " & vbCrLf & vbCrLf & "Are you sure you want to continue?", vbYesNo + vbInformation) = vbYes Then
                    Call SaveRecord()

                    .strWhere = "{qry_RPT_Customers.FolioNumber} = '" & txtFolioNumber.Text & "' AND {qry_RPT_Customers.Status} = 'Check In'"
                Else
                    Exit Sub
                End If
            End If

            frmReports.ShowDialog()

        End With
    End Sub
End Class