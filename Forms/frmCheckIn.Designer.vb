<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckIn
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
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim DateOutLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim BusinessSourceIDLabel As System.Windows.Forms.Label
        Dim RateTypeLabel As System.Windows.Forms.Label
        Dim DateInLabel As System.Windows.Forms.Label
        Dim RoomNumberLabel As System.Windows.Forms.Label
        Dim PlateNoLabel As System.Windows.Forms.Label
        Dim VehicleModelLabel As System.Windows.Forms.Label
        Dim VehicleIDLabel As System.Windows.Forms.Label
        Dim IDNumberLabel As System.Windows.Forms.Label
        Dim IDTypeIDLabel As System.Windows.Forms.Label
        Dim CountryIDLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim RCardNoLabel As System.Windows.Forms.Label
        Dim FolioNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckIn))
        Me.Label26 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.bgHeader = New System.Windows.Forms.Panel
        Me.StatusBar1 = New System.Windows.Forms.StatusStrip
        Me._StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me._StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me._StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me._StatusBar1_Panel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.bgMain = New System.Windows.Forms.Panel
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtOtherCharges = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.dtpDateOut = New System.Windows.Forms.DateTimePicker
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.cboBusinessSource = New System.Windows.Forms.ComboBox
        Me.txtChildrens = New System.Windows.Forms.TextBox
        Me.txtAdults = New System.Windows.Forms.TextBox
        Me.txtDays = New System.Windows.Forms.TextBox
        Me.cboRateType = New System.Windows.Forms.ComboBox
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.txtPlateNo = New System.Windows.Forms.TextBox
        Me.txtVehicleModel = New System.Windows.Forms.TextBox
        Me.cboVehicle = New System.Windows.Forms.ComboBox
        Me.txtIDNumber = New System.Windows.Forms.TextBox
        Me.cboIDType = New System.Windows.Forms.ComboBox
        Me.cboCountry = New System.Windows.Forms.ComboBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtRCardNo = New System.Windows.Forms.TextBox
        Me.txtFolioNumber = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnLookupComp = New System.Windows.Forms.Button
        Me.btnLookupCust = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.btnUpdateDelete = New System.Windows.Forms.Button
        Me.btnChangeRoom = New System.Windows.Forms.Button
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.btnCheckInOut = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtTotalCharges = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.hsDays = New System.Windows.Forms.HScrollBar
        Me.hsChildrens = New System.Windows.Forms.HScrollBar
        Me.hsAdults = New System.Windows.Forms.HScrollBar
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblAmountPaid = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblOtherCharges = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblRatePerPeriod = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        DiscountLabel = New System.Windows.Forms.Label
        DateOutLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        BusinessSourceIDLabel = New System.Windows.Forms.Label
        RateTypeLabel = New System.Windows.Forms.Label
        DateInLabel = New System.Windows.Forms.Label
        RoomNumberLabel = New System.Windows.Forms.Label
        PlateNoLabel = New System.Windows.Forms.Label
        VehicleModelLabel = New System.Windows.Forms.Label
        VehicleIDLabel = New System.Windows.Forms.Label
        IDNumberLabel = New System.Windows.Forms.Label
        IDTypeIDLabel = New System.Windows.Forms.Label
        CountryIDLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        RCardNoLabel = New System.Windows.Forms.Label
        FolioNumberLabel = New System.Windows.Forms.Label
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgHeader.SuspendLayout()
        Me.StatusBar1.SuspendLayout()
        Me.bgMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.ForeColor = System.Drawing.Color.Black
        DiscountLabel.Location = New System.Drawing.Point(544, 205)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(49, 14)
        DiscountLabel.TabIndex = 248
        DiscountLabel.Text = "Discount"
        '
        'DateOutLabel
        '
        DateOutLabel.AutoSize = True
        DateOutLabel.ForeColor = System.Drawing.Color.Black
        DateOutLabel.Location = New System.Drawing.Point(540, 72)
        DateOutLabel.Name = "DateOutLabel"
        DateOutLabel.Size = New System.Drawing.Size(49, 14)
        DateOutLabel.TabIndex = 244
        DateOutLabel.Text = "Date Out"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.ForeColor = System.Drawing.Color.Black
        NotesLabel.Location = New System.Drawing.Point(319, 249)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 14)
        NotesLabel.TabIndex = 242
        NotesLabel.Text = "Notes:"
        '
        'BusinessSourceIDLabel
        '
        BusinessSourceIDLabel.AutoSize = True
        BusinessSourceIDLabel.Location = New System.Drawing.Point(296, 209)
        BusinessSourceIDLabel.Name = "BusinessSourceIDLabel"
        BusinessSourceIDLabel.Size = New System.Drawing.Size(90, 14)
        BusinessSourceIDLabel.TabIndex = 240
        BusinessSourceIDLabel.Text = "Business Source"
        '
        'RateTypeLabel
        '
        RateTypeLabel.AutoSize = True
        RateTypeLabel.ForeColor = System.Drawing.Color.Black
        RateTypeLabel.Location = New System.Drawing.Point(325, 97)
        RateTypeLabel.Name = "RateTypeLabel"
        RateTypeLabel.Size = New System.Drawing.Size(56, 14)
        RateTypeLabel.TabIndex = 235
        RateTypeLabel.Text = "Rate Type"
        '
        'DateInLabel
        '
        DateInLabel.AutoSize = True
        DateInLabel.ForeColor = System.Drawing.Color.Black
        DateInLabel.Location = New System.Drawing.Point(340, 71)
        DateInLabel.Name = "DateInLabel"
        DateInLabel.Size = New System.Drawing.Size(40, 14)
        DateInLabel.TabIndex = 233
        DateInLabel.Text = "Date In"
        '
        'RoomNumberLabel
        '
        RoomNumberLabel.AutoSize = True
        RoomNumberLabel.ForeColor = System.Drawing.Color.Black
        RoomNumberLabel.Location = New System.Drawing.Point(307, 44)
        RoomNumberLabel.Name = "RoomNumberLabel"
        RoomNumberLabel.Size = New System.Drawing.Size(74, 14)
        RoomNumberLabel.TabIndex = 231
        RoomNumberLabel.Text = "Room Number"
        '
        'PlateNoLabel
        '
        PlateNoLabel.AutoSize = True
        PlateNoLabel.ForeColor = System.Drawing.Color.Black
        PlateNoLabel.Location = New System.Drawing.Point(60, 439)
        PlateNoLabel.Name = "PlateNoLabel"
        PlateNoLabel.Size = New System.Drawing.Size(46, 14)
        PlateNoLabel.TabIndex = 229
        PlateNoLabel.Text = "Plate No"
        '
        'VehicleModelLabel
        '
        VehicleModelLabel.AutoSize = True
        VehicleModelLabel.ForeColor = System.Drawing.Color.Black
        VehicleModelLabel.Location = New System.Drawing.Point(34, 411)
        VehicleModelLabel.Name = "VehicleModelLabel"
        VehicleModelLabel.Size = New System.Drawing.Size(74, 14)
        VehicleModelLabel.TabIndex = 227
        VehicleModelLabel.Text = "Vehicle Model"
        '
        'VehicleIDLabel
        '
        VehicleIDLabel.AutoSize = True
        VehicleIDLabel.ForeColor = System.Drawing.Color.Black
        VehicleIDLabel.Location = New System.Drawing.Point(52, 382)
        VehicleIDLabel.Name = "VehicleIDLabel"
        VehicleIDLabel.Size = New System.Drawing.Size(43, 14)
        VehicleIDLabel.TabIndex = 225
        VehicleIDLabel.Text = "Vehicle"
        '
        'IDNumberLabel
        '
        IDNumberLabel.AutoSize = True
        IDNumberLabel.ForeColor = System.Drawing.Color.Black
        IDNumberLabel.Location = New System.Drawing.Point(56, 320)
        IDNumberLabel.Name = "IDNumberLabel"
        IDNumberLabel.Size = New System.Drawing.Size(56, 14)
        IDNumberLabel.TabIndex = 223
        IDNumberLabel.Text = "ID Number"
        '
        'IDTypeIDLabel
        '
        IDTypeIDLabel.AutoSize = True
        IDTypeIDLabel.ForeColor = System.Drawing.Color.Black
        IDTypeIDLabel.Location = New System.Drawing.Point(72, 292)
        IDTypeIDLabel.Name = "IDTypeIDLabel"
        IDTypeIDLabel.Size = New System.Drawing.Size(40, 14)
        IDTypeIDLabel.TabIndex = 221
        IDTypeIDLabel.Text = "IDType"
        '
        'CountryIDLabel
        '
        CountryIDLabel.AutoSize = True
        CountryIDLabel.ForeColor = System.Drawing.Color.Black
        CountryIDLabel.Location = New System.Drawing.Point(71, 189)
        CountryIDLabel.Name = "CountryIDLabel"
        CountryIDLabel.Size = New System.Drawing.Size(45, 14)
        CountryIDLabel.TabIndex = 219
        CountryIDLabel.Text = "Country"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.ForeColor = System.Drawing.Color.Black
        AddressLabel.Location = New System.Drawing.Point(69, 165)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(49, 14)
        AddressLabel.TabIndex = 217
        AddressLabel.Text = "Address"
        '
        'RCardNoLabel
        '
        RCardNoLabel.AutoSize = True
        RCardNoLabel.ForeColor = System.Drawing.Color.Black
        RCardNoLabel.Location = New System.Drawing.Point(60, 75)
        RCardNoLabel.Name = "RCardNoLabel"
        RCardNoLabel.Size = New System.Drawing.Size(53, 14)
        RCardNoLabel.TabIndex = 215
        RCardNoLabel.Text = "RCard No"
        '
        'FolioNumberLabel
        '
        FolioNumberLabel.AutoSize = True
        FolioNumberLabel.ForeColor = System.Drawing.Color.Black
        FolioNumberLabel.Location = New System.Drawing.Point(45, 48)
        FolioNumberLabel.Name = "FolioNumberLabel"
        FolioNumberLabel.Size = New System.Drawing.Size(69, 14)
        FolioNumberLabel.TabIndex = 214
        FolioNumberLabel.Text = "Folio Number"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(40, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(94, 23)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "Check In"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(2, 2)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(32, 32)
        Me.Image1.TabIndex = 38
        Me.Image1.TabStop = False
        '
        'bgHeader
        '
        Me.bgHeader.BackColor = System.Drawing.SystemColors.Window
        Me.bgHeader.Controls.Add(Me.Label26)
        Me.bgHeader.Controls.Add(Me.Image1)
        Me.bgHeader.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgHeader.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgHeader.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bgHeader.Location = New System.Drawing.Point(0, 1)
        Me.bgHeader.Name = "bgHeader"
        Me.bgHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgHeader.Size = New System.Drawing.Size(739, 37)
        Me.bgHeader.TabIndex = 110
        Me.bgHeader.TabStop = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StatusBar1_Panel1, Me._StatusBar1_Panel2, Me._StatusBar1_Panel3, Me._StatusBar1_Panel4})
        Me.StatusBar1.Location = New System.Drawing.Point(0, 513)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(769, 25)
        Me.StatusBar1.TabIndex = 182
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
        Me._StatusBar1_Panel1.Size = New System.Drawing.Size(251, 25)
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
        Me._StatusBar1_Panel2.Size = New System.Drawing.Size(251, 25)
        Me._StatusBar1_Panel2.Spring = True
        Me._StatusBar1_Panel2.Text = "Check In By:"
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
        Me._StatusBar1_Panel3.Size = New System.Drawing.Size(251, 25)
        Me._StatusBar1_Panel3.Spring = True
        Me._StatusBar1_Panel3.Text = "Check Out By:"
        Me._StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar1_Panel4
        '
        Me._StatusBar1_Panel4.AutoSize = False
        Me._StatusBar1_Panel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar1_Panel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar1_Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar1_Panel4.Name = "_StatusBar1_Panel4"
        Me._StatusBar1_Panel4.Size = New System.Drawing.Size(187, 25)
        Me._StatusBar1_Panel4.Spring = True
        Me._StatusBar1_Panel4.Text = "Business Source:"
        Me._StatusBar1_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bgMain
        '
        Me.bgMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bgMain.Controls.Add(Me.txtAmountPaid)
        Me.bgMain.Controls.Add(DiscountLabel)
        Me.bgMain.Controls.Add(Me.txtDiscount)
        Me.bgMain.Controls.Add(Me.txtOtherCharges)
        Me.bgMain.Controls.Add(Me.txtRate)
        Me.bgMain.Controls.Add(DateOutLabel)
        Me.bgMain.Controls.Add(Me.dtpDateOut)
        Me.bgMain.Controls.Add(NotesLabel)
        Me.bgMain.Controls.Add(Me.txtNotes)
        Me.bgMain.Controls.Add(BusinessSourceIDLabel)
        Me.bgMain.Controls.Add(Me.cboBusinessSource)
        Me.bgMain.Controls.Add(Me.txtChildrens)
        Me.bgMain.Controls.Add(Me.txtAdults)
        Me.bgMain.Controls.Add(Me.txtDays)
        Me.bgMain.Controls.Add(RateTypeLabel)
        Me.bgMain.Controls.Add(Me.cboRateType)
        Me.bgMain.Controls.Add(DateInLabel)
        Me.bgMain.Controls.Add(Me.dtpDateIn)
        Me.bgMain.Controls.Add(RoomNumberLabel)
        Me.bgMain.Controls.Add(Me.txtRoomNumber)
        Me.bgMain.Controls.Add(PlateNoLabel)
        Me.bgMain.Controls.Add(Me.txtPlateNo)
        Me.bgMain.Controls.Add(VehicleModelLabel)
        Me.bgMain.Controls.Add(Me.txtVehicleModel)
        Me.bgMain.Controls.Add(VehicleIDLabel)
        Me.bgMain.Controls.Add(Me.cboVehicle)
        Me.bgMain.Controls.Add(IDNumberLabel)
        Me.bgMain.Controls.Add(Me.txtIDNumber)
        Me.bgMain.Controls.Add(IDTypeIDLabel)
        Me.bgMain.Controls.Add(Me.cboIDType)
        Me.bgMain.Controls.Add(CountryIDLabel)
        Me.bgMain.Controls.Add(Me.cboCountry)
        Me.bgMain.Controls.Add(AddressLabel)
        Me.bgMain.Controls.Add(Me.txtAddress)
        Me.bgMain.Controls.Add(RCardNoLabel)
        Me.bgMain.Controls.Add(Me.txtRCardNo)
        Me.bgMain.Controls.Add(FolioNumberLabel)
        Me.bgMain.Controls.Add(Me.txtFolioNumber)
        Me.bgMain.Controls.Add(Me.btnPrint)
        Me.bgMain.Controls.Add(Me.btnLookupComp)
        Me.bgMain.Controls.Add(Me.btnLookupCust)
        Me.bgMain.Controls.Add(Me.txtTotal)
        Me.bgMain.Controls.Add(Me.txtSubTotal)
        Me.bgMain.Controls.Add(Me.btnUpdateDelete)
        Me.bgMain.Controls.Add(Me.btnChangeRoom)
        Me.bgMain.Controls.Add(Me.txtLastName)
        Me.bgMain.Controls.Add(Me.txtFirstName)
        Me.bgMain.Controls.Add(Me.txtCompany)
        Me.bgMain.Controls.Add(Me.btnCheckInOut)
        Me.bgMain.Controls.Add(Me.btnCancel)
        Me.bgMain.Controls.Add(Me.txtTotalCharges)
        Me.bgMain.Controls.Add(Me.txtBalance)
        Me.bgMain.Controls.Add(Me.hsDays)
        Me.bgMain.Controls.Add(Me.hsChildrens)
        Me.bgMain.Controls.Add(Me.hsAdults)
        Me.bgMain.Controls.Add(Me.Label9)
        Me.bgMain.Controls.Add(Me.Label24)
        Me.bgMain.Controls.Add(Me.lblAmountPaid)
        Me.bgMain.Controls.Add(Me.Label8)
        Me.bgMain.Controls.Add(Me.lblOtherCharges)
        Me.bgMain.Controls.Add(Me.Label4)
        Me.bgMain.Controls.Add(Me.Label6)
        Me.bgMain.Controls.Add(Me.Label10)
        Me.bgMain.Controls.Add(Me.Label12)
        Me.bgMain.Controls.Add(Me.lblRatePerPeriod)
        Me.bgMain.Controls.Add(Me.Label22)
        Me.bgMain.Controls.Add(Me.Label30)
        Me.bgMain.Controls.Add(Me.Label31)
        Me.bgMain.Controls.Add(Me.Label33)
        Me.bgMain.Controls.Add(Me.Label28)
        Me.bgMain.Controls.Add(Me.Label27)
        Me.bgMain.Controls.Add(Me.Label25)
        Me.bgMain.Controls.Add(Me.Label1)
        Me.bgMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgMain.ForeColor = System.Drawing.Color.Black
        Me.bgMain.Location = New System.Drawing.Point(2, 41)
        Me.bgMain.Name = "bgMain"
        Me.bgMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgMain.Size = New System.Drawing.Size(768, 466)
        Me.bgMain.TabIndex = 183
        Me.bgMain.TabStop = True
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(599, 262)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(121, 20)
        Me.txtAmountPaid.TabIndex = 251
        Me.txtAmountPaid.Text = "0.00"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(599, 202)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 250
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.Location = New System.Drawing.Point(599, 151)
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.Size = New System.Drawing.Size(121, 20)
        Me.txtOtherCharges.TabIndex = 249
        Me.txtOtherCharges.Text = "0.00"
        Me.txtOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(599, 95)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 247
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDateOut
        '
        Me.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOut.Location = New System.Drawing.Point(599, 68)
        Me.dtpDateOut.Name = "dtpDateOut"
        Me.dtpDateOut.Size = New System.Drawing.Size(121, 20)
        Me.dtpDateOut.TabIndex = 246
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(322, 265)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(187, 73)
        Me.txtNotes.TabIndex = 245
        '
        'cboBusinessSource
        '
        Me.cboBusinessSource.FormattingEnabled = True
        Me.cboBusinessSource.Location = New System.Drawing.Point(388, 207)
        Me.cboBusinessSource.Name = "cboBusinessSource"
        Me.cboBusinessSource.Size = New System.Drawing.Size(121, 22)
        Me.cboBusinessSource.TabIndex = 243
        '
        'txtChildrens
        '
        Me.txtChildrens.Location = New System.Drawing.Point(388, 180)
        Me.txtChildrens.Name = "txtChildrens"
        Me.txtChildrens.Size = New System.Drawing.Size(31, 20)
        Me.txtChildrens.TabIndex = 241
        Me.txtChildrens.Text = "0"
        Me.txtChildrens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(388, 155)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(31, 20)
        Me.txtAdults.TabIndex = 239
        Me.txtAdults.Text = "1"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(388, 127)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(31, 20)
        Me.txtDays.TabIndex = 238
        Me.txtDays.Text = "1"
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboRateType
        '
        Me.cboRateType.DisplayMember = "RateTypeID"
        Me.cboRateType.FormattingEnabled = True
        Me.cboRateType.Location = New System.Drawing.Point(388, 94)
        Me.cboRateType.Name = "cboRateType"
        Me.cboRateType.Size = New System.Drawing.Size(121, 22)
        Me.cboRateType.TabIndex = 237
        Me.cboRateType.ValueMember = "RateTypeID"
        '
        'dtpDateIn
        '
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateIn.Location = New System.Drawing.Point(388, 67)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.Size = New System.Drawing.Size(113, 20)
        Me.dtpDateIn.TabIndex = 236
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(388, 41)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomNumber.TabIndex = 234
        '
        'txtPlateNo
        '
        Me.txtPlateNo.Location = New System.Drawing.Point(117, 436)
        Me.txtPlateNo.Name = "txtPlateNo"
        Me.txtPlateNo.Size = New System.Drawing.Size(100, 20)
        Me.txtPlateNo.TabIndex = 232
        '
        'txtVehicleModel
        '
        Me.txtVehicleModel.Location = New System.Drawing.Point(117, 408)
        Me.txtVehicleModel.Name = "txtVehicleModel"
        Me.txtVehicleModel.Size = New System.Drawing.Size(100, 20)
        Me.txtVehicleModel.TabIndex = 230
        '
        'cboVehicle
        '
        Me.cboVehicle.DisplayMember = "VehicleID"
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Location = New System.Drawing.Point(117, 379)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(121, 22)
        Me.cboVehicle.TabIndex = 228
        Me.cboVehicle.ValueMember = "VehicleID"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(117, 317)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIDNumber.TabIndex = 226
        '
        'cboIDType
        '
        Me.cboIDType.DisplayMember = "IDTypeID"
        Me.cboIDType.FormattingEnabled = True
        Me.cboIDType.Location = New System.Drawing.Point(117, 290)
        Me.cboIDType.Name = "cboIDType"
        Me.cboIDType.Size = New System.Drawing.Size(121, 22)
        Me.cboIDType.TabIndex = 224
        Me.cboIDType.ValueMember = "IDTypeID"
        '
        'cboCountry
        '
        Me.cboCountry.DisplayMember = "CountryID"
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(117, 188)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 22)
        Me.cboCountry.TabIndex = 222
        Me.cboCountry.ValueMember = "CountryID"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(117, 162)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 220
        '
        'txtRCardNo
        '
        Me.txtRCardNo.Location = New System.Drawing.Point(117, 71)
        Me.txtRCardNo.Name = "txtRCardNo"
        Me.txtRCardNo.Size = New System.Drawing.Size(100, 20)
        Me.txtRCardNo.TabIndex = 218
        '
        'txtFolioNumber
        '
        Me.txtFolioNumber.Location = New System.Drawing.Point(117, 45)
        Me.txtFolioNumber.Name = "txtFolioNumber"
        Me.txtFolioNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioNumber.TabIndex = 216
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(451, 413)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(89, 21)
        Me.btnPrint.TabIndex = 213
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnLookupComp
        '
        Me.btnLookupComp.BackColor = System.Drawing.SystemColors.Control
        Me.btnLookupComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLookupComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookupComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLookupComp.Location = New System.Drawing.Point(241, 219)
        Me.btnLookupComp.Name = "btnLookupComp"
        Me.btnLookupComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLookupComp.Size = New System.Drawing.Size(25, 21)
        Me.btnLookupComp.TabIndex = 186
        Me.btnLookupComp.TabStop = False
        Me.btnLookupComp.Text = ">>"
        Me.btnLookupComp.UseVisualStyleBackColor = False
        '
        'btnLookupCust
        '
        Me.btnLookupCust.BackColor = System.Drawing.SystemColors.Control
        Me.btnLookupCust.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLookupCust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookupCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLookupCust.Location = New System.Drawing.Point(241, 101)
        Me.btnLookupCust.Name = "btnLookupCust"
        Me.btnLookupCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLookupCust.Size = New System.Drawing.Size(25, 21)
        Me.btnLookupCust.TabIndex = 183
        Me.btnLookupCust.TabStop = False
        Me.btnLookupCust.Text = ">>"
        Me.btnLookupCust.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.AcceptsReturn = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal.Location = New System.Drawing.Point(599, 233)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 189
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AcceptsReturn = True
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubTotal.Location = New System.Drawing.Point(599, 177)
        Me.txtSubTotal.MaxLength = 0
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtSubTotal.TabIndex = 188
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnUpdateDelete
        '
        Me.btnUpdateDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdateDelete.Enabled = False
        Me.btnUpdateDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateDelete.Location = New System.Drawing.Point(541, 439)
        Me.btnUpdateDelete.Name = "btnUpdateDelete"
        Me.btnUpdateDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUpdateDelete.Size = New System.Drawing.Size(89, 21)
        Me.btnUpdateDelete.TabIndex = 193
        Me.btnUpdateDelete.Text = "Update"
        Me.btnUpdateDelete.UseVisualStyleBackColor = False
        '
        'btnChangeRoom
        '
        Me.btnChangeRoom.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangeRoom.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChangeRoom.Enabled = False
        Me.btnChangeRoom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeRoom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangeRoom.Location = New System.Drawing.Point(541, 413)
        Me.btnChangeRoom.Name = "btnChangeRoom"
        Me.btnChangeRoom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnChangeRoom.Size = New System.Drawing.Size(89, 21)
        Me.btnChangeRoom.TabIndex = 191
        Me.btnChangeRoom.Text = "Change Room"
        Me.btnChangeRoom.UseVisualStyleBackColor = False
        '
        'txtLastName
        '
        Me.txtLastName.AcceptsReturn = True
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Location = New System.Drawing.Point(117, 101)
        Me.txtLastName.MaxLength = 0
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtLastName.TabIndex = 182
        '
        'txtFirstName
        '
        Me.txtFirstName.AcceptsReturn = True
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(117, 131)
        Me.txtFirstName.MaxLength = 0
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 184
        '
        'txtCompany
        '
        Me.txtCompany.AcceptsReturn = True
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompany.Location = New System.Drawing.Point(117, 219)
        Me.txtCompany.MaxLength = 0
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompany.Size = New System.Drawing.Size(121, 20)
        Me.txtCompany.TabIndex = 185
        '
        'btnCheckInOut
        '
        Me.btnCheckInOut.BackColor = System.Drawing.SystemColors.Control
        Me.btnCheckInOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheckInOut.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckInOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheckInOut.Location = New System.Drawing.Point(631, 413)
        Me.btnCheckInOut.Name = "btnCheckInOut"
        Me.btnCheckInOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCheckInOut.Size = New System.Drawing.Size(89, 21)
        Me.btnCheckInOut.TabIndex = 192
        Me.btnCheckInOut.Text = "Check In"
        Me.btnCheckInOut.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(631, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(89, 21)
        Me.btnCancel.TabIndex = 194
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.AcceptsReturn = True
        Me.txtTotalCharges.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalCharges.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalCharges.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCharges.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalCharges.Location = New System.Drawing.Point(599, 121)
        Me.txtTotalCharges.MaxLength = 0
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.ReadOnly = True
        Me.txtTotalCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalCharges.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalCharges.TabIndex = 187
        Me.txtTotalCharges.Text = "0.00"
        Me.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsReturn = True
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBalance.Location = New System.Drawing.Point(599, 289)
        Me.txtBalance.MaxLength = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBalance.Size = New System.Drawing.Size(121, 20)
        Me.txtBalance.TabIndex = 190
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'hsDays
        '
        Me.hsDays.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsDays.LargeChange = 1
        Me.hsDays.Location = New System.Drawing.Point(426, 125)
        Me.hsDays.Maximum = 32767
        Me.hsDays.Minimum = 1
        Me.hsDays.Name = "hsDays"
        Me.hsDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsDays.Size = New System.Drawing.Size(33, 21)
        Me.hsDays.TabIndex = 198
        Me.hsDays.TabStop = True
        Me.hsDays.Value = 1
        '
        'hsChildrens
        '
        Me.hsChildrens.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsChildrens.LargeChange = 1
        Me.hsChildrens.Location = New System.Drawing.Point(426, 181)
        Me.hsChildrens.Maximum = 32767
        Me.hsChildrens.Name = "hsChildrens"
        Me.hsChildrens.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsChildrens.Size = New System.Drawing.Size(33, 21)
        Me.hsChildrens.TabIndex = 197
        Me.hsChildrens.TabStop = True
        '
        'hsAdults
        '
        Me.hsAdults.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsAdults.LargeChange = 1
        Me.hsAdults.Location = New System.Drawing.Point(426, 153)
        Me.hsAdults.Maximum = 32767
        Me.hsAdults.Minimum = 1
        Me.hsAdults.Name = "hsAdults"
        Me.hsAdults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsAdults.Size = New System.Drawing.Size(33, 21)
        Me.hsAdults.TabIndex = 196
        Me.hsAdults.TabStop = True
        Me.hsAdults.Value = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(500, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 212
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(500, 291)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(93, 20)
        Me.Label24.TabIndex = 211
        Me.Label24.Text = "Balance"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAmountPaid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.Blue
        Me.lblAmountPaid.Location = New System.Drawing.Point(500, 265)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmountPaid.Size = New System.Drawing.Size(93, 20)
        Me.lblAmountPaid.TabIndex = 210
        Me.lblAmountPaid.Text = "Amount Paid"
        Me.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(500, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 209
        Me.Label8.Text = "Sub Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOtherCharges
        '
        Me.lblOtherCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblOtherCharges.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOtherCharges.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherCharges.ForeColor = System.Drawing.Color.Blue
        Me.lblOtherCharges.Location = New System.Drawing.Point(500, 151)
        Me.lblOtherCharges.Name = "lblOtherCharges"
        Me.lblOtherCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOtherCharges.Size = New System.Drawing.Size(93, 20)
        Me.lblOtherCharges.TabIndex = 208
        Me.lblOtherCharges.Text = "Other Charges"
        Me.lblOtherCharges.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(705, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(20, 21)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "%"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Last Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(93, 20)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "First name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(21, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Company"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRatePerPeriod
        '
        Me.lblRatePerPeriod.BackColor = System.Drawing.Color.Transparent
        Me.lblRatePerPeriod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRatePerPeriod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatePerPeriod.ForeColor = System.Drawing.Color.Blue
        Me.lblRatePerPeriod.Location = New System.Drawing.Point(500, 95)
        Me.lblRatePerPeriod.Name = "lblRatePerPeriod"
        Me.lblRatePerPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRatePerPeriod.Size = New System.Drawing.Size(93, 20)
        Me.lblRatePerPeriod.TabIndex = 203
        Me.lblRatePerPeriod.Text = "Rate/Period"
        Me.lblRatePerPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(289, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(93, 20)
        Me.Label22.TabIndex = 202
        Me.Label22.Text = "No. of Days"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(289, 155)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(93, 20)
        Me.Label30.TabIndex = 201
        Me.Label30.Text = "No. of Adults"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(289, 183)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(93, 20)
        Me.Label31.TabIndex = 200
        Me.Label31.Text = "No. of Childrens"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(500, 123)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(93, 20)
        Me.Label33.TabIndex = 199
        Me.Label33.Text = "Total Charges"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Info
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(282, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(129, 20)
        Me.Label28.TabIndex = 181
        Me.Label28.Text = "Rate Information"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Info
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(26, 350)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(146, 20)
        Me.Label27.TabIndex = 180
        Me.Label27.Text = "Vehicle Information"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Info
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(26, 262)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(185, 20)
        Me.Label25.TabIndex = 179
        Me.Label25.Text = "Identification Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Guest Information"
        '
        'frmCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 538)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.bgHeader)
        Me.Controls.Add(Me.bgMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCheckIn"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgHeader.ResumeLayout(False)
        Me.bgHeader.PerformLayout()
        Me.StatusBar1.ResumeLayout(False)
        Me.StatusBar1.PerformLayout()
        Me.bgMain.ResumeLayout(False)
        Me.bgMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents bgHeader As System.Windows.Forms.Panel

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public WithEvents StatusBar1 As System.Windows.Forms.StatusStrip
    Public WithEvents _StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar1_Panel4 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents bgMain As System.Windows.Forms.Panel
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cboBusinessSource As System.Windows.Forms.ComboBox
    Friend WithEvents txtChildrens As System.Windows.Forms.TextBox
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents cboRateType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPlateNo As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleModel As System.Windows.Forms.TextBox
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboIDType As System.Windows.Forms.ComboBox
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtRCardNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioNumber As System.Windows.Forms.TextBox
    Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents btnLookupComp As System.Windows.Forms.Button
    Public WithEvents btnLookupCust As System.Windows.Forms.Button
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Public WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Public WithEvents btnUpdateDelete As System.Windows.Forms.Button
    Public WithEvents btnChangeRoom As System.Windows.Forms.Button
    Public WithEvents txtLastName As System.Windows.Forms.TextBox
    Public WithEvents txtFirstName As System.Windows.Forms.TextBox
    Public WithEvents txtCompany As System.Windows.Forms.TextBox
    Public WithEvents btnCheckInOut As System.Windows.Forms.Button
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Public WithEvents txtBalance As System.Windows.Forms.TextBox
    Public WithEvents hsDays As System.Windows.Forms.HScrollBar
    Public WithEvents hsChildrens As System.Windows.Forms.HScrollBar
    Public WithEvents hsAdults As System.Windows.Forms.HScrollBar
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents lblAmountPaid As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lblOtherCharges As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents lblRatePerPeriod As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
