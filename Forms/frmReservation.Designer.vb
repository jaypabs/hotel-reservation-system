<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservation))
        Me.bgHeader = New System.Windows.Forms.Panel
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.bgMain = New System.Windows.Forms.Panel
        Me.Label32 = New System.Windows.Forms.Label
        Me.cboRoomNumber = New System.Windows.Forms.ComboBox
        Me.dtpDateOut = New System.Windows.Forms.DateTimePicker
        Me.btnCheckIn = New System.Windows.Forms.Button
        Me.cboBusinessSource = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cboRateType = New System.Windows.Forms.ComboBox
        Me.hsAdults = New System.Windows.Forms.HScrollBar
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.hsChildrens = New System.Windows.Forms.HScrollBar
        Me.cboVehicle = New System.Windows.Forms.ComboBox
        Me.hsDays = New System.Windows.Forms.HScrollBar
        Me.cboIDType = New System.Windows.Forms.ComboBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.cboCountry = New System.Windows.Forms.ComboBox
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalCharges = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtChildrens = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtAdults = New System.Windows.Forms.TextBox
        Me.txtDays = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtIDNumber = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtReservationNo = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtOtherCharges = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtVehicleModel = New System.Windows.Forms.TextBox
        Me.txtPlateNo = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.btnLookupCust = New System.Windows.Forms.Button
        Me.btnLookupComp = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblRatePerPeriod = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOtherCharges = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAmountPaid = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusStrip
        Me._StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me._StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me._StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.bgHeader.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgMain.SuspendLayout()
        Me.StatusBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgHeader
        '
        Me.bgHeader.BackColor = System.Drawing.SystemColors.Window
        Me.bgHeader.Controls.Add(Me.Image1)
        Me.bgHeader.Controls.Add(Me.Label26)
        Me.bgHeader.Controls.Add(Me.Label27)
        Me.bgHeader.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgHeader.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgHeader.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bgHeader.Location = New System.Drawing.Point(0, 0)
        Me.bgHeader.Name = "bgHeader"
        Me.bgHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgHeader.Size = New System.Drawing.Size(687, 37)
        Me.bgHeader.TabIndex = 2
        Me.bgHeader.TabStop = True
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(2, 2)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(32, 32)
        Me.Image1.TabIndex = 0
        Me.Image1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(40, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(124, 23)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Reservation"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(40, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(265, 12)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Fill all fields or fields with '*' then click 'Save' button to update."
        '
        'bgMain
        '
        Me.bgMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bgMain.Controls.Add(Me.Label32)
        Me.bgMain.Controls.Add(Me.cboRoomNumber)
        Me.bgMain.Controls.Add(Me.dtpDateOut)
        Me.bgMain.Controls.Add(Me.btnCheckIn)
        Me.bgMain.Controls.Add(Me.cboBusinessSource)
        Me.bgMain.Controls.Add(Me.btnCancel)
        Me.bgMain.Controls.Add(Me.cboRateType)
        Me.bgMain.Controls.Add(Me.hsAdults)
        Me.bgMain.Controls.Add(Me.dtpDateIn)
        Me.bgMain.Controls.Add(Me.hsChildrens)
        Me.bgMain.Controls.Add(Me.cboVehicle)
        Me.bgMain.Controls.Add(Me.hsDays)
        Me.bgMain.Controls.Add(Me.cboIDType)
        Me.bgMain.Controls.Add(Me.txtBalance)
        Me.bgMain.Controls.Add(Me.cboCountry)
        Me.bgMain.Controls.Add(Me.txtAmountPaid)
        Me.bgMain.Controls.Add(Me.Label7)
        Me.bgMain.Controls.Add(Me.txtTotalCharges)
        Me.bgMain.Controls.Add(Me.Label25)
        Me.bgMain.Controls.Add(Me.btnClose)
        Me.bgMain.Controls.Add(Me.Label30)
        Me.bgMain.Controls.Add(Me.txtChildrens)
        Me.bgMain.Controls.Add(Me.Label31)
        Me.bgMain.Controls.Add(Me.txtAdults)
        Me.bgMain.Controls.Add(Me.txtDays)
        Me.bgMain.Controls.Add(Me.txtDiscount)
        Me.bgMain.Controls.Add(Me.txtRate)
        Me.bgMain.Controls.Add(Me.txtIDNumber)
        Me.bgMain.Controls.Add(Me.txtCompany)
        Me.bgMain.Controls.Add(Me.txtAddress)
        Me.bgMain.Controls.Add(Me.txtFirstName)
        Me.bgMain.Controls.Add(Me.txtLastName)
        Me.bgMain.Controls.Add(Me.txtReservationNo)
        Me.bgMain.Controls.Add(Me.btnSave)
        Me.bgMain.Controls.Add(Me.txtOtherCharges)
        Me.bgMain.Controls.Add(Me.txtSubTotal)
        Me.bgMain.Controls.Add(Me.txtTotal)
        Me.bgMain.Controls.Add(Me.txtVehicleModel)
        Me.bgMain.Controls.Add(Me.txtPlateNo)
        Me.bgMain.Controls.Add(Me.txtNotes)
        Me.bgMain.Controls.Add(Me.btnLookupCust)
        Me.bgMain.Controls.Add(Me.btnLookupComp)
        Me.bgMain.Controls.Add(Me.btnPrint)
        Me.bgMain.Controls.Add(Me.Label22)
        Me.bgMain.Controls.Add(Me.Label21)
        Me.bgMain.Controls.Add(Me.Label20)
        Me.bgMain.Controls.Add(Me.Label19)
        Me.bgMain.Controls.Add(Me.Label18)
        Me.bgMain.Controls.Add(Me.Label17)
        Me.bgMain.Controls.Add(Me.lblRatePerPeriod)
        Me.bgMain.Controls.Add(Me.Label15)
        Me.bgMain.Controls.Add(Me.Label14)
        Me.bgMain.Controls.Add(Me.Label13)
        Me.bgMain.Controls.Add(Me.Label12)
        Me.bgMain.Controls.Add(Me.Label11)
        Me.bgMain.Controls.Add(Me.Label10)
        Me.bgMain.Controls.Add(Me.Label6)
        Me.bgMain.Controls.Add(Me.Label5)
        Me.bgMain.Controls.Add(Me.Label4)
        Me.bgMain.Controls.Add(Me.Label3)
        Me.bgMain.Controls.Add(Me.Label2)
        Me.bgMain.Controls.Add(Me.Label1)
        Me.bgMain.Controls.Add(Me.lblOtherCharges)
        Me.bgMain.Controls.Add(Me.Label8)
        Me.bgMain.Controls.Add(Me.lblAmountPaid)
        Me.bgMain.Controls.Add(Me.Label24)
        Me.bgMain.Controls.Add(Me.Label9)
        Me.bgMain.Controls.Add(Me.Label23)
        Me.bgMain.Controls.Add(Me.Label28)
        Me.bgMain.Controls.Add(Me.Label29)
        Me.bgMain.Controls.Add(Me.Label16)
        Me.bgMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.bgMain.Location = New System.Drawing.Point(2, 39)
        Me.bgMain.Name = "bgMain"
        Me.bgMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgMain.Size = New System.Drawing.Size(746, 457)
        Me.bgMain.TabIndex = 5
        Me.bgMain.TabStop = True
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(705, 213)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(20, 21)
        Me.Label32.TabIndex = 208
        Me.Label32.Text = "%"
        '
        'cboRoomNumber
        '
        Me.cboRoomNumber.FormattingEnabled = True
        Me.cboRoomNumber.Location = New System.Drawing.Point(385, 44)
        Me.cboRoomNumber.Name = "cboRoomNumber"
        Me.cboRoomNumber.Size = New System.Drawing.Size(112, 22)
        Me.cboRoomNumber.TabIndex = 185
        '
        'dtpDateOut
        '
        Me.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOut.Location = New System.Drawing.Point(604, 71)
        Me.dtpDateOut.Name = "dtpDateOut"
        Me.dtpDateOut.Size = New System.Drawing.Size(121, 20)
        Me.dtpDateOut.TabIndex = 184
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.SystemColors.Control
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheckIn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheckIn.Location = New System.Drawing.Point(451, 401)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCheckIn.Size = New System.Drawing.Size(89, 21)
        Me.btnCheckIn.TabIndex = 138
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = False
        Me.btnCheckIn.Visible = False
        '
        'cboBusinessSource
        '
        Me.cboBusinessSource.FormattingEnabled = True
        Me.cboBusinessSource.Location = New System.Drawing.Point(385, 214)
        Me.cboBusinessSource.Name = "cboBusinessSource"
        Me.cboBusinessSource.Size = New System.Drawing.Size(121, 22)
        Me.cboBusinessSource.TabIndex = 183
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(451, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(179, 21)
        Me.btnCancel.TabIndex = 137
        Me.btnCancel.Text = "Cancel Reservation"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'cboRateType
        '
        Me.cboRateType.DisplayMember = "RateTypeID"
        Me.cboRateType.FormattingEnabled = True
        Me.cboRateType.Location = New System.Drawing.Point(385, 101)
        Me.cboRateType.Name = "cboRateType"
        Me.cboRateType.Size = New System.Drawing.Size(121, 22)
        Me.cboRateType.TabIndex = 182
        Me.cboRateType.ValueMember = "RateTypeID"
        '
        'hsAdults
        '
        Me.hsAdults.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsAdults.LargeChange = 1
        Me.hsAdults.Location = New System.Drawing.Point(420, 156)
        Me.hsAdults.Maximum = 32767
        Me.hsAdults.Minimum = 1
        Me.hsAdults.Name = "hsAdults"
        Me.hsAdults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsAdults.Size = New System.Drawing.Size(33, 21)
        Me.hsAdults.TabIndex = 108
        Me.hsAdults.TabStop = True
        Me.hsAdults.Value = 1
        '
        'dtpDateIn
        '
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateIn.Location = New System.Drawing.Point(385, 74)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.Size = New System.Drawing.Size(113, 20)
        Me.dtpDateIn.TabIndex = 181
        '
        'hsChildrens
        '
        Me.hsChildrens.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsChildrens.LargeChange = 1
        Me.hsChildrens.Location = New System.Drawing.Point(420, 184)
        Me.hsChildrens.Maximum = 32767
        Me.hsChildrens.Name = "hsChildrens"
        Me.hsChildrens.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsChildrens.Size = New System.Drawing.Size(33, 21)
        Me.hsChildrens.TabIndex = 107
        Me.hsChildrens.TabStop = True
        '
        'cboVehicle
        '
        Me.cboVehicle.DisplayMember = "VehicleID"
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Location = New System.Drawing.Point(108, 328)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(121, 22)
        Me.cboVehicle.TabIndex = 180
        Me.cboVehicle.ValueMember = "VehicleID"
        '
        'hsDays
        '
        Me.hsDays.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsDays.LargeChange = 1
        Me.hsDays.Location = New System.Drawing.Point(420, 128)
        Me.hsDays.Maximum = 32767
        Me.hsDays.Minimum = 1
        Me.hsDays.Name = "hsDays"
        Me.hsDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsDays.Size = New System.Drawing.Size(33, 21)
        Me.hsDays.TabIndex = 106
        Me.hsDays.TabStop = True
        Me.hsDays.Value = 1
        '
        'cboIDType
        '
        Me.cboIDType.DisplayMember = "IDTypeID"
        Me.cboIDType.FormattingEnabled = True
        Me.cboIDType.Location = New System.Drawing.Point(110, 252)
        Me.cboIDType.Name = "cboIDType"
        Me.cboIDType.Size = New System.Drawing.Size(121, 22)
        Me.cboIDType.TabIndex = 179
        Me.cboIDType.ValueMember = "IDTypeID"
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsReturn = True
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBalance.Location = New System.Drawing.Point(604, 296)
        Me.txtBalance.MaxLength = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBalance.Size = New System.Drawing.Size(121, 20)
        Me.txtBalance.TabIndex = 105
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCountry
        '
        Me.cboCountry.DisplayMember = "CountryID"
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(110, 160)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 22)
        Me.cboCountry.TabIndex = 178
        Me.cboCountry.ValueMember = "CountryID"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.AcceptsReturn = True
        Me.txtAmountPaid.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPaid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmountPaid.Location = New System.Drawing.Point(604, 270)
        Me.txtAmountPaid.MaxLength = 0
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.ReadOnly = True
        Me.txtAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAmountPaid.Size = New System.Drawing.Size(121, 20)
        Me.txtAmountPaid.TabIndex = 104
        Me.txtAmountPaid.Text = "0.00"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(280, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = "Rate Information"
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.AcceptsReturn = True
        Me.txtTotalCharges.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalCharges.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalCharges.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCharges.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalCharges.Location = New System.Drawing.Point(604, 128)
        Me.txtTotalCharges.MaxLength = 0
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.ReadOnly = True
        Me.txtTotalCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalCharges.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalCharges.TabIndex = 103
        Me.txtTotalCharges.Text = "0.00"
        Me.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Info
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(23, 300)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(146, 20)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Vehicle Information"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(631, 427)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(89, 21)
        Me.btnClose.TabIndex = 102
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Info
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(23, 220)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(185, 20)
        Me.Label30.TabIndex = 175
        Me.Label30.Text = "Identification Information"
        '
        'txtChildrens
        '
        Me.txtChildrens.AcceptsReturn = True
        Me.txtChildrens.BackColor = System.Drawing.SystemColors.Window
        Me.txtChildrens.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChildrens.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildrens.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChildrens.Location = New System.Drawing.Point(385, 183)
        Me.txtChildrens.MaxLength = 0
        Me.txtChildrens.Name = "txtChildrens"
        Me.txtChildrens.ReadOnly = True
        Me.txtChildrens.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChildrens.Size = New System.Drawing.Size(31, 20)
        Me.txtChildrens.TabIndex = 101
        Me.txtChildrens.Text = "0"
        Me.txtChildrens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Info
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(24, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(138, 20)
        Me.Label31.TabIndex = 174
        Me.Label31.Text = "Guest Information"
        '
        'txtAdults
        '
        Me.txtAdults.AcceptsReturn = True
        Me.txtAdults.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdults.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdults.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdults.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdults.Location = New System.Drawing.Point(385, 155)
        Me.txtAdults.MaxLength = 0
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.ReadOnly = True
        Me.txtAdults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdults.Size = New System.Drawing.Size(31, 20)
        Me.txtAdults.TabIndex = 100
        Me.txtAdults.Text = "1"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDays
        '
        Me.txtDays.AcceptsReturn = True
        Me.txtDays.BackColor = System.Drawing.SystemColors.Window
        Me.txtDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDays.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDays.Location = New System.Drawing.Point(385, 127)
        Me.txtDays.MaxLength = 0
        Me.txtDays.Name = "txtDays"
        Me.txtDays.ReadOnly = True
        Me.txtDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDays.Size = New System.Drawing.Size(31, 20)
        Me.txtDays.TabIndex = 99
        Me.txtDays.Text = "1"
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiscount
        '
        Me.txtDiscount.AcceptsReturn = True
        Me.txtDiscount.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiscount.Location = New System.Drawing.Point(604, 212)
        Me.txtDiscount.MaxLength = 0
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiscount.Size = New System.Drawing.Size(105, 20)
        Me.txtDiscount.TabIndex = 98
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRate
        '
        Me.txtRate.AcceptsReturn = True
        Me.txtRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRate.Location = New System.Drawing.Point(604, 100)
        Me.txtRate.MaxLength = 0
        Me.txtRate.Name = "txtRate"
        Me.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRate.Size = New System.Drawing.Size(121, 20)
        Me.txtRate.TabIndex = 97
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDNumber
        '
        Me.txtIDNumber.AcceptsReturn = True
        Me.txtIDNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDNumber.Location = New System.Drawing.Point(110, 280)
        Me.txtIDNumber.MaxLength = 0
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtIDNumber.TabIndex = 96
        '
        'txtCompany
        '
        Me.txtCompany.AcceptsReturn = True
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompany.Location = New System.Drawing.Point(110, 188)
        Me.txtCompany.MaxLength = 0
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompany.Size = New System.Drawing.Size(121, 20)
        Me.txtCompany.TabIndex = 95
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(110, 130)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.Size = New System.Drawing.Size(121, 20)
        Me.txtAddress.TabIndex = 94
        '
        'txtFirstName
        '
        Me.txtFirstName.AcceptsReturn = True
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(110, 100)
        Me.txtFirstName.MaxLength = 0
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 93
        '
        'txtLastName
        '
        Me.txtLastName.AcceptsReturn = True
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Location = New System.Drawing.Point(110, 70)
        Me.txtLastName.MaxLength = 0
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtLastName.TabIndex = 92
        '
        'txtReservationNo
        '
        Me.txtReservationNo.AcceptsReturn = True
        Me.txtReservationNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtReservationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReservationNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReservationNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReservationNo.Location = New System.Drawing.Point(110, 40)
        Me.txtReservationNo.MaxLength = 0
        Me.txtReservationNo.Name = "txtReservationNo"
        Me.txtReservationNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReservationNo.Size = New System.Drawing.Size(121, 20)
        Me.txtReservationNo.TabIndex = 91
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(631, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(89, 21)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.AcceptsReturn = True
        Me.txtOtherCharges.BackColor = System.Drawing.SystemColors.Window
        Me.txtOtherCharges.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOtherCharges.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherCharges.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOtherCharges.Location = New System.Drawing.Point(604, 156)
        Me.txtOtherCharges.MaxLength = 0
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.ReadOnly = True
        Me.txtOtherCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOtherCharges.Size = New System.Drawing.Size(121, 20)
        Me.txtOtherCharges.TabIndex = 89
        Me.txtOtherCharges.Text = "0.00"
        Me.txtOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AcceptsReturn = True
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubTotal.Location = New System.Drawing.Point(604, 184)
        Me.txtSubTotal.MaxLength = 0
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtSubTotal.TabIndex = 88
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.AcceptsReturn = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal.Location = New System.Drawing.Point(604, 240)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 87
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVehicleModel
        '
        Me.txtVehicleModel.AcceptsReturn = True
        Me.txtVehicleModel.BackColor = System.Drawing.SystemColors.Window
        Me.txtVehicleModel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVehicleModel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleModel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVehicleModel.Location = New System.Drawing.Point(108, 356)
        Me.txtVehicleModel.MaxLength = 0
        Me.txtVehicleModel.Name = "txtVehicleModel"
        Me.txtVehicleModel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVehicleModel.Size = New System.Drawing.Size(121, 20)
        Me.txtVehicleModel.TabIndex = 86
        '
        'txtPlateNo
        '
        Me.txtPlateNo.AcceptsReturn = True
        Me.txtPlateNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlateNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlateNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlateNo.Location = New System.Drawing.Point(108, 384)
        Me.txtPlateNo.MaxLength = 0
        Me.txtPlateNo.Name = "txtPlateNo"
        Me.txtPlateNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlateNo.Size = New System.Drawing.Size(121, 20)
        Me.txtPlateNo.TabIndex = 85
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNotes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNotes.Location = New System.Drawing.Point(300, 300)
        Me.txtNotes.MaxLength = 0
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNotes.Size = New System.Drawing.Size(203, 63)
        Me.txtNotes.TabIndex = 84
        '
        'btnLookupCust
        '
        Me.btnLookupCust.BackColor = System.Drawing.SystemColors.Control
        Me.btnLookupCust.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLookupCust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookupCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLookupCust.Location = New System.Drawing.Point(234, 70)
        Me.btnLookupCust.Name = "btnLookupCust"
        Me.btnLookupCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLookupCust.Size = New System.Drawing.Size(25, 21)
        Me.btnLookupCust.TabIndex = 83
        Me.btnLookupCust.Text = ">>"
        Me.btnLookupCust.UseVisualStyleBackColor = False
        '
        'btnLookupComp
        '
        Me.btnLookupComp.BackColor = System.Drawing.SystemColors.Control
        Me.btnLookupComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLookupComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookupComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLookupComp.Location = New System.Drawing.Point(234, 188)
        Me.btnLookupComp.Name = "btnLookupComp"
        Me.btnLookupComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLookupComp.Size = New System.Drawing.Size(25, 21)
        Me.btnLookupComp.TabIndex = 82
        Me.btnLookupComp.Text = ">>"
        Me.btnLookupComp.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(541, 401)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(89, 21)
        Me.btnPrint.TabIndex = 81
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(508, 130)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(93, 20)
        Me.Label22.TabIndex = 136
        Me.Label22.Text = "Total Charges"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(286, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(93, 20)
        Me.Label21.TabIndex = 135
        Me.Label21.Text = "Business Source"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(286, 186)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(93, 20)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "No. of Childrens"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(286, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(93, 20)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "No. of Adults"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(286, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(93, 20)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "No. of Days"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(508, 214)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(93, 20)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Discount"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRatePerPeriod
        '
        Me.lblRatePerPeriod.BackColor = System.Drawing.Color.Transparent
        Me.lblRatePerPeriod.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRatePerPeriod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatePerPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblRatePerPeriod.Location = New System.Drawing.Point(508, 100)
        Me.lblRatePerPeriod.Name = "lblRatePerPeriod"
        Me.lblRatePerPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRatePerPeriod.Size = New System.Drawing.Size(93, 20)
        Me.lblRatePerPeriod.TabIndex = 130
        Me.lblRatePerPeriod.Text = "Rate/Period"
        Me.lblRatePerPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(286, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(93, 20)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Rate Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(508, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(93, 20)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Date Out"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(286, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Date In"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(286, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Room Number"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(14, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "ID Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(14, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(93, 20)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "ID Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Country"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Company"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "First name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Last name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Reservation No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOtherCharges
        '
        Me.lblOtherCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblOtherCharges.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOtherCharges.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherCharges.ForeColor = System.Drawing.Color.Black
        Me.lblOtherCharges.Location = New System.Drawing.Point(508, 158)
        Me.lblOtherCharges.Name = "lblOtherCharges"
        Me.lblOtherCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOtherCharges.Size = New System.Drawing.Size(93, 20)
        Me.lblOtherCharges.TabIndex = 117
        Me.lblOtherCharges.Text = "Other Charges"
        Me.lblOtherCharges.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(508, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Sub Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPaid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAmountPaid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.lblAmountPaid.Location = New System.Drawing.Point(508, 272)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmountPaid.Size = New System.Drawing.Size(93, 20)
        Me.lblAmountPaid.TabIndex = 115
        Me.lblAmountPaid.Text = "Amount Paid"
        Me.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(508, 298)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(93, 20)
        Me.Label24.TabIndex = 114
        Me.Label24.Text = "Balance"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(508, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(12, 356)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(93, 20)
        Me.Label23.TabIndex = 112
        Me.Label23.Text = "Model"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(12, 328)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(93, 20)
        Me.Label28.TabIndex = 111
        Me.Label28.Text = "Vehicle Make"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(12, 384)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(93, 20)
        Me.Label29.TabIndex = 110
        Me.Label29.Text = "Plate No."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(300, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(39, 19)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "Notes"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StatusBar1_Panel1, Me._StatusBar1_Panel2, Me._StatusBar1_Panel3})
        Me.StatusBar1.Location = New System.Drawing.Point(0, 499)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(749, 25)
        Me.StatusBar1.TabIndex = 81
        '
        '_StatusBar1_Panel1
        '
        Me._StatusBar1_Panel1.AutoSize = False
        Me._StatusBar1_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar1_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar1_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar1_Panel1.Name = "_StatusBar1_Panel1"
        Me._StatusBar1_Panel1.Size = New System.Drawing.Size(367, 25)
        Me._StatusBar1_Panel1.Spring = True
        Me._StatusBar1_Panel1.Text = "Reserved By:"
        Me._StatusBar1_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar1_Panel2
        '
        Me._StatusBar1_Panel2.AutoSize = False
        Me._StatusBar1_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar1_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar1_Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar1_Panel2.Name = "_StatusBar1_Panel2"
        Me._StatusBar1_Panel2.Size = New System.Drawing.Size(367, 25)
        Me._StatusBar1_Panel2.Spring = True
        Me._StatusBar1_Panel2.Text = "Cancelled By:"
        Me._StatusBar1_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar1_Panel3
        '
        Me._StatusBar1_Panel3.AutoSize = False
        Me._StatusBar1_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar1_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar1_Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar1_Panel3.Name = "_StatusBar1_Panel3"
        Me._StatusBar1_Panel3.Size = New System.Drawing.Size(250, 25)
        Me._StatusBar1_Panel3.Spring = True
        Me._StatusBar1_Panel3.Text = "Business Source:"
        Me._StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 524)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.bgMain)
        Me.Controls.Add(Me.bgHeader)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.bgHeader.ResumeLayout(False)
        Me.bgHeader.PerformLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgMain.ResumeLayout(False)
        Me.bgMain.PerformLayout()
        Me.StatusBar1.ResumeLayout(False)
        Me.StatusBar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents bgHeader As System.Windows.Forms.Panel
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents bgMain As System.Windows.Forms.Panel
    Public WithEvents btnCheckIn As System.Windows.Forms.Button
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents hsAdults As System.Windows.Forms.HScrollBar
    Public WithEvents hsChildrens As System.Windows.Forms.HScrollBar
    Public WithEvents hsDays As System.Windows.Forms.HScrollBar
    Public WithEvents txtBalance As System.Windows.Forms.TextBox
    Public WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Public WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents txtChildrens As System.Windows.Forms.TextBox
    Public WithEvents txtAdults As System.Windows.Forms.TextBox
    Public WithEvents txtDays As System.Windows.Forms.TextBox
    Public WithEvents txtDiscount As System.Windows.Forms.TextBox
    Public WithEvents txtRate As System.Windows.Forms.TextBox
    Public WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Public WithEvents txtCompany As System.Windows.Forms.TextBox
    Public WithEvents txtAddress As System.Windows.Forms.TextBox
    Public WithEvents txtFirstName As System.Windows.Forms.TextBox
    Public WithEvents txtLastName As System.Windows.Forms.TextBox
    Public WithEvents txtReservationNo As System.Windows.Forms.TextBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents txtOtherCharges As System.Windows.Forms.TextBox
    Public WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Public WithEvents txtVehicleModel As System.Windows.Forms.TextBox
    Public WithEvents txtPlateNo As System.Windows.Forms.TextBox
    Public WithEvents txtNotes As System.Windows.Forms.TextBox
    Public WithEvents btnLookupCust As System.Windows.Forms.Button
    Public WithEvents btnLookupComp As System.Windows.Forms.Button
    Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents lblRatePerPeriod As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblOtherCharges As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lblAmountPaid As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboBusinessSource As System.Windows.Forms.ComboBox
    Friend WithEvents cboRateType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents cboIDType As System.Windows.Forms.ComboBox
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cboRoomNumber As System.Windows.Forms.ComboBox
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents StatusBar1 As System.Windows.Forms.StatusStrip
    Public WithEvents _StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
End Class
