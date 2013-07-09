'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Data.OleDb

Friend Class frmReservation
    Inherits System.Windows.Forms.Form

    Dim daReservation As New OleDbDataAdapter()
    Dim dsReservation As New DataSet()

    Public State As modGlobal.FormState
    Public ReservationNo As String

    Private IsInitializing As Boolean
    Private blnSaved As Boolean

    Private Sub frmReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        IsInitializing = True

        FillCombobox(cboCountry, "SELECT * FROM Countries", "Countries", "Country", "CountryID")
        FillCombobox(cboIDType, "SELECT * FROM [ID_Type]", "ID_Type", "IDType", "IDTypeID")
        FillCombobox(cboRoomNumber, "SELECT * FROM qry_Available_Rooms", "qry_Available_Rooms", "AvailableRoom", "RoomNumber")
        FillCombobox(cboRateType, "SELECT RateTypeID, RateType FROM [Rate_Type]", "Rate_Type", "RateType", "RateTypeID")
        FillCombobox(cboBusinessSource, "SELECT * FROM [Business_Source]", "Business_Source", "BusinessSource", "BusinessSourceID")
        FillCombobox(cboVehicle, "SELECT * FROM [Vehicles]", "Vehicles", "Vehicle", "VehicleID")

        cboVehicle.Text = ""

        If State = modGlobal.FormState.adStateAddMode Then
            dtpDateIn.Value = Today
            dtpDateOut.Value = DateTime.Now.AddDays(1)

            GeneratePK()

            Dim sqlQRY As String = "SELECT * FROM [Room_Rates] WHERE RoomNumber = " & cboRoomNumber.SelectedValue & " AND RateTypeID = " & cboRateType.SelectedValue
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

                cboBusinessSource.SelectedValue = 2

                Dim qryReservation As String = "SELECT * FROM Reservation WHERE ReservationNo = '" & ReservationNo & "'"

                daReservation.SelectCommand = New OleDbCommand(qryReservation, cnHotel)

                Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daReservation)

                daReservation.Fill(dsReservation, "Reservation")
            Catch ex As OleDbException
                MsgBox(ex.ToString)
            Finally
                cnHotel.Close()
            End Try

            Call ComputeRate()
        ElseIf State = modGlobal.FormState.adStateEditMode Then
            Dim sqlQRY As String = "SELECT * FROM [Room_Rates] WHERE RoomNumber = " & cboRoomNumber.SelectedValue & " AND RateTypeID = " & cboRateType.SelectedValue
            Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, cnHotel)
            Dim RecordCount As Integer

            RecordCount = CountRows("SELECT Count(*) FROM [Room_Rates]")

            Try
                Dim rdr As OleDbDataReader = cmd.ExecuteReader

                While (rdr.Read)
                    If RecordCount > 0 Then
                        txtRate.Text = toMoney(rdr("RoomRate").ToString)
                        hsAdults.Minimum = rdr("NoofPerson").ToString
                        txtAdults.Tag = rdr("ExtraAdultRate").ToString
                        txtChildrens.Tag = rdr("ExtraChildRate").ToString
                    End If
                End While

                Dim qryReservation As String = "SELECT * FROM Reservation WHERE ReservationNo = '" & ReservationNo & "'"

                daReservation.SelectCommand = New OleDbCommand(qryReservation, cnHotel)

                Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(daReservation)

                daReservation.Fill(dsReservation, "Reservation")

                Dim dt As DataTable = dsReservation.Tables("Reservation")

                txtReservationNo.Text = dt.Rows(0)("ReservationNo")
                txtLastName.Text = GetFieldValue("SELECT LastName FROM Customers WHERE CustomerID = " & dt.Rows(0)("CustomerID"), "LastName")
                txtFirstName.Text = GetFieldValue("SELECT FirstName FROM Customers WHERE CustomerID = " & dt.Rows(0)("CustomerID"), "FirstName")
                txtAddress.Text = dt.Rows(0)("Address")
                cboCountry.SelectedValue = dt.Rows(0)("CountryID")
                If Not IsDBNull(dt.Rows(0)("CompanyID")) Then txtCompany.Text = GetFieldValue("SELECT Company FROM Company WHERE CompanyID = " & dt.Rows(0)("CompanyID"), "Company")
                cboIDType.SelectedValue = dt.Rows(0)("IDTypeID")
                txtIDNumber.Text = dt.Rows(0)("IDNumber")
                cboRoomNumber.SelectedValue = dt.Rows(0)("RoomNumber")
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
                txtDays.Text = dtpDateOut.Value.Subtract(dtpDateIn.Value).Days.ToString  ' dtpDateOut.Value - dtpDateIn.Value 'dt.Rows(0)("Days")
                cboBusinessSource.SelectedValue = dt.Rows(0)("BusinessSourceID")
                cboVehicle.SelectedValue = dt.Rows(0)("VehicleID")
                txtVehicleModel.Text = dt.Rows(0)("VehicleModel")
                txtPlateNo.Text = dt.Rows(0)("PlateNo")
                txtNotes.Text = dt.Rows(0)("Notes")

                hsDays.Value = txtDays.Text
                hsAdults.Value = txtAdults.Text
                hsChildrens.Value = txtChildrens.Text

                StatusBar1.Items.Item(1).Text = "Reserved By: " & GetFieldValue("SELECT UserID FROM Users WHERE PK = " & dt.Rows(0)("ReservedBy"), "UserID")
                StatusBar1.Items.Item(2).Text = "Cancelled By: " & GetFieldValue("SELECT UserID FROM Users WHERE PK = " & dt.Rows(0)("CancelledBy"), "UserID")

                btnCheckIn.Visible = True
                btnPrint.Visible = True
                btnCancel.Visible = True

                'Call txtDays_TextChanged(sender, e)

                Call ComputeRate()
            Catch ex As OleDbException
                MsgBox(ex.ToString)
            Finally
                cnHotel.Close()
            End Try
        End If

        IsInitializing = False
    End Sub

    'Procedure used to generate PK
    Private Sub GeneratePK()
        ReservationNo = GetIndex("Reservation")
        txtReservationNo.Text = GenerateID(CStr(ReservationNo), Format(Today, "yy") & "-", "00000")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIn.Click
        If cboRoomNumber.Text = "" Then
            MsgBox("Please select Room number.", MsgBoxStyle.Critical)

            Exit Sub
        End If

        Call SaveRecord(sender, e)

        If blnSaved = False Then Exit Sub

        Dim FolioNumber As String
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

            FolioNumber = CStr(GetIndex("Reservation"))
            FolioNumber = GenerateID(FolioNumber, Format(Today, "yy") & "-", "00000")

            ExecNonQuery("INSERT INTO Reservation ( FolioNumber, CustomerID, Address, CountryID, CompanyID, IDTypeID, IDNumber, RoomNumber, DateIn, DateOut, RateType, Rate, Days, Adults, Childrens, BusinessSourceID, VehicleID, VehicleModel, PlateNo, Status, Notes, ReservedBy, CheckInBy, AddedByFK ) " & "SELECT '" & FolioNumber & "' AS Folio, CustomerID, Address, CountryID, CompanyID, IDTypeID, IDNumber, " & cboRoomNumber.SelectedValue & ", DateIn, DateOut, RateType, Rate, Days, Adults, Childrens, BusinessSourceID, VehicleID, VehicleModel, PlateNo, 'Check In' AS CheckIn, Notes, ReservedBy, " & CurrUser.USER_PK & ", " & CurrUser.USER_PK & " " & "FROM Reservation " & "WHERE ReservationNo='" & txtReservationNo.Text & "'")

            Call AddRatePerPeriod(FolioNumber)

            ExecNonQuery("UPDATE Rooms SET RoomStatusID =2 WHERE RoomNumber = " & cboRoomNumber.SelectedValue)
            ExecNonQuery("UPDATE Reservation SET Status = 'Check In' WHERE ReservationNo = '" & txtReservationNo.Text & "'")
            ExecNonQuery("UPDATE [Inventory] SET Status = 'Check In', ID = '" & FolioNumber & "' " & "WHERE ID= '" & txtReservationNo.Text & "' AND RoomNumber= " & cboRoomNumber.SelectedValue & " AND Status='Reservation'")
        End If
    End Sub

    Private Sub ComputeRate()
        If txtAdults.Tag = "" Then Exit Sub

        Dim intAdults As Short

        If CDbl(txtAdults.Text) = hsAdults.Minimum Then
            intAdults = 0
        Else
            intAdults = CShort(txtAdults.Text) - hsAdults.Minimum
        End If

        txtTotalCharges.Text = CStr((CDbl(toMoney(txtRate.Text)) * toNumber(txtDays.Text)) + (CDbl(toMoney(txtAdults.Tag)) * intAdults) + (CDbl(toMoney(txtChildrens.Tag)) * toNumber(txtChildrens.Text)))
        txtTotalCharges.Text = toMoney(txtTotalCharges.Text)
        txtSubTotal.Text = toMoney(CStr(toNumber(txtTotalCharges.Text) + toNumber(txtOtherCharges.Text)))
        txtTotal.Text = toMoney(CStr(toNumber(txtSubTotal.Text) - (toNumber(txtSubTotal.Text) * toNumber(txtDiscount.Text) / 100)))
        txtBalance.Text = toMoney(CStr(toNumber(txtTotal.Text) - toNumber(txtAmountPaid.Text)))
    End Sub

    Public Sub dtpDateOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOut.ValueChanged
        If dtpDateOut.Value <= dtpDateIn.Value Then
            dtpDateOut.Value = dtpDateIn.Value.AddDays(1)
        End If

        txtDays.Text = dtpDateOut.Value.Subtract(dtpDateIn.Value).Days.ToString
        hsDays.Value = txtDays.Text

        Call ComputeRate()
    End Sub

    Private Sub SaveRecord(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        Dim dt As DataTable = dsReservation.Tables("Reservation")

        If State = modGlobal.FormState.adStateAddMode Then
            ' add a row
            Dim newRow As DataRow

            newRow = dt.NewRow()
            newRow("ReservationNo") = txtReservationNo.Text
            newRow("Status") = "Reserved"
            newRow("DateAdded") = Now()
            'newRow("ReservedBy") = CurrUser.USER_PK
            'newRow("AddedByFK") = CurrUser.USER_PK

            dt.Rows.Add(newRow)
        Else
            dt.Rows(0)("DateModified") = Now
            'dt.Rows(0)("LastUserFK") = CurrUser.USER_PK
        End If

        With dt
            .Rows(0)("CustomerID") = CustomerID
            .Rows(0)("Address") = txtAddress.Text
            .Rows(0)("CountryID") = cboCountry.SelectedValue
            .Rows(0)("CompanyID") = CompanyID
            .Rows(0)("IDTypeID") = cboIDType.SelectedValue
            .Rows(0)("IDNumber") = txtIDNumber.Text
            .Rows(0)("RoomNumber") = IIf(cboRoomNumber.Text = "", System.DBNull.Value, cboRoomNumber.SelectedValue)
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
            .Rows(0)("VehicleID") = IIf(cboVehicle.Text = "", System.DBNull.Value, cboVehicle.SelectedValue)
            .Rows(0)("VehicleModel") = txtVehicleModel.Text
            .Rows(0)("PlateNo") = txtPlateNo.Text
            .Rows(0)("Notes") = txtNotes.Text

            daReservation.Update(dsReservation, "Reservation")
        End With

        'Delete record from Inventory and add a new check in/out date
        ExecNonQuery("DELETE ID, Status " & "From [Inventory] " & "WHERE ID='" & txtReservationNo.Text & "' AND Status='Reservation'")

        Dim dtpStartDate As Date

        dtpStartDate = dtpDateIn.Value

        Do Until dtpStartDate = Format(dtpDateOut.Value, "Short Date")
            ExecNonQuery("INSERT INTO [Inventory] ( ID, RoomNumber, [Date], CustomerID, Status ) " & "VALUES ('" & txtReservationNo.Text & "', " & cboRoomNumber.SelectedValue & ", #" & dtpStartDate & "#, " & txtLastName.Tag & ", 'Reservation')")

            dtpStartDate = System.DateTime.FromOADate(dtpStartDate.ToOADate + 1)
        Loop

        blnSaved = True
    End Sub

    Private Sub hsDays_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsDays.ValueChanged
        dtpDateOut.Value = dtpDateIn.Value.AddDays(hsDays.Value.ToString)

        txtDays.Text = hsDays.Value.ToString

        Call ComputeRate()
    End Sub

    Private Sub hsAdults_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsAdults.ValueChanged
        txtAdults.Text = hsAdults.Value.ToString

        Call ComputeRate()
    End Sub

    Private Sub hsChildrens_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hsChildrens.ValueChanged
        txtChildrens.Text = hsChildrens.Value.ToString

        Call ComputeRate()
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

    Private Sub AddRatePerPeriod(ByRef FolioNumber As String)
        Dim tmpDate As Date

        tmpDate = dtpDateIn.Value

        If txtAdults.Tag = "" Then Exit Sub

        Dim intAdults As Short

        If CDbl(txtAdults.Text) = hsAdults.Minimum Then
            intAdults = 0
        Else
            intAdults = CShort(txtAdults.Text) - hsAdults.Minimum
        End If

        Dim qry As String = "SELECT * FROM Rate_Per_Period WHERE FolioNumber = '" & FolioNumber & "' ORDER BY DateIn"

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
                newRow = dt.NewRow()

                newRow("FolioNumber") = FolioNumber
                newRow("DateIn") = tmpDate
                newRow("RoomNumber") = cboRoomNumber.SelectedValue
                newRow("RateTypeID") = cboRateType.SelectedValue
                newRow("Rate") = txtRate.Text
                newRow("Adults") = CDbl(txtAdults.Tag) * intAdults
                newRow("Childrens") = CDbl(toMoney(txtChildrens.Tag)) * toNumber(txtChildrens.Text)

                dt.Rows.Add(newRow)

                tmpDate = System.DateTime.FromOADate(tmpDate.ToOADate + 1)
            Loop

            da.Update(ds, "Rate_Per_Period")
        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            cnHotel.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveRecord(sender, e)

        If State = modGlobal.FormState.adStateAddMode And blnSaved = True Then
            MsgBox("New record has been successfully saved.", MsgBoxStyle.Information)

            'Me.Close()
        ElseIf State = modGlobal.FormState.adStateEditMode And blnSaved = True Then
            MsgBox("Changes in  record has been successfully saved.", MsgBoxStyle.Information)

            'Me.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        With frmReports
            .strReport = "Reservation"

            .strWhere = "{qry_rpt_Reservation.ReservationNo} = '" & txtReservationNo.Text & "'"

            frmReports.ShowDialog()
        End With
    End Sub
End Class