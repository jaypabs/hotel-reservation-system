<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRecords = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuGuests = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCompany = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountReceivablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRoomWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMonitoring = New System.Windows.Forms.ToolStripMenuItem
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReservations = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInventoryView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.frmBusinessSource = New System.Windows.Forms.ToolStripMenuItem
        Me.frmChargeType = New System.Windows.Forms.ToolStripMenuItem
        Me.frmCountries = New System.Windows.Forms.ToolStripMenuItem
        Me.frmIDType = New System.Windows.Forms.ToolStripMenuItem
        Me.frmPaymentType = New System.Windows.Forms.ToolStripMenuItem
        Me.frmRateType = New System.Windows.Forms.ToolStripMenuItem
        Me.frmRoomStatus = New System.Windows.Forms.ToolStripMenuItem
        Me.frmRoomType = New System.Windows.Forms.ToolStripMenuItem
        Me.frmVehicles = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTAccRec = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTOtherCharges = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTCheckedInGuest = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTCheckOut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDueReservation = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTGuestList = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRPTRoomHistory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSystem, Me.mnuRecords, Me.mnuMonitoring, Me.mnuReports, Me.mnuTools, Me.mnuWindow, Me.mnuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuWindow
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuSystem
        '
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.mnuSystem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(57, 20)
        Me.mnuSystem.Text = "&System"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem1.Text = "&Manage Users"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(145, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuRecords
        '
        Me.mnuRecords.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripSeparator7, Me.mnuGuests, Me.mnuCompany, Me.AccountReceivablesToolStripMenuItem, Me.mnuRoomWindow})
        Me.mnuRecords.Name = "mnuRecords"
        Me.mnuRecords.Size = New System.Drawing.Size(61, 20)
        Me.mnuRecords.Text = "&Records"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem2.Text = "&New Reservation"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem3.Text = "&Check In History"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(180, 6)
        '
        'mnuGuests
        '
        Me.mnuGuests.Name = "mnuGuests"
        Me.mnuGuests.Size = New System.Drawing.Size(183, 22)
        Me.mnuGuests.Text = "&Guests"
        '
        'mnuCompany
        '
        Me.mnuCompany.Name = "mnuCompany"
        Me.mnuCompany.Size = New System.Drawing.Size(183, 22)
        Me.mnuCompany.Text = "Com&pany"
        '
        'AccountReceivablesToolStripMenuItem
        '
        Me.AccountReceivablesToolStripMenuItem.Name = "AccountReceivablesToolStripMenuItem"
        Me.AccountReceivablesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AccountReceivablesToolStripMenuItem.Text = "&Account Receivables"
        '
        'mnuRoomWindow
        '
        Me.mnuRoomWindow.Name = "mnuRoomWindow"
        Me.mnuRoomWindow.Size = New System.Drawing.Size(183, 22)
        Me.mnuRoomWindow.Text = "Room Window"
        '
        'mnuMonitoring
        '
        Me.mnuMonitoring.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomsToolStripMenuItem, Me.mnuReservations, Me.mnuInventoryView, Me.ToolStripSeparator3, Me.frmBusinessSource, Me.frmChargeType, Me.frmCountries, Me.frmIDType, Me.frmPaymentType, Me.frmRateType, Me.frmRoomStatus, Me.frmRoomType, Me.frmVehicles})
        Me.mnuMonitoring.Name = "mnuMonitoring"
        Me.mnuMonitoring.Size = New System.Drawing.Size(79, 20)
        Me.mnuMonitoring.Text = "&Monitoring"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RoomsToolStripMenuItem.Text = "&Rooms"
        '
        'mnuReservations
        '
        Me.mnuReservations.Name = "mnuReservations"
        Me.mnuReservations.Size = New System.Drawing.Size(158, 22)
        Me.mnuReservations.Text = "Re&servations"
        '
        'mnuInventoryView
        '
        Me.mnuInventoryView.Name = "mnuInventoryView"
        Me.mnuInventoryView.Size = New System.Drawing.Size(158, 22)
        Me.mnuInventoryView.Text = "&Inventory View"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(155, 6)
        '
        'frmBusinessSource
        '
        Me.frmBusinessSource.Name = "frmBusinessSource"
        Me.frmBusinessSource.Size = New System.Drawing.Size(158, 22)
        Me.frmBusinessSource.Text = "&Business Source"
        '
        'frmChargeType
        '
        Me.frmChargeType.Name = "frmChargeType"
        Me.frmChargeType.Size = New System.Drawing.Size(158, 22)
        Me.frmChargeType.Text = "&Charge Type"
        '
        'frmCountries
        '
        Me.frmCountries.Name = "frmCountries"
        Me.frmCountries.Size = New System.Drawing.Size(158, 22)
        Me.frmCountries.Text = "Coun&tries"
        '
        'frmIDType
        '
        Me.frmIDType.Name = "frmIDType"
        Me.frmIDType.Size = New System.Drawing.Size(158, 22)
        Me.frmIDType.Text = "&ID Type"
        '
        'frmPaymentType
        '
        Me.frmPaymentType.Name = "frmPaymentType"
        Me.frmPaymentType.Size = New System.Drawing.Size(158, 22)
        Me.frmPaymentType.Text = "&Payment Type"
        '
        'frmRateType
        '
        Me.frmRateType.Name = "frmRateType"
        Me.frmRateType.Size = New System.Drawing.Size(158, 22)
        Me.frmRateType.Text = "R&ate Type"
        '
        'frmRoomStatus
        '
        Me.frmRoomStatus.Name = "frmRoomStatus"
        Me.frmRoomStatus.Size = New System.Drawing.Size(158, 22)
        Me.frmRoomStatus.Text = "R&oom Status"
        '
        'frmRoomType
        '
        Me.frmRoomType.Name = "frmRoomType"
        Me.frmRoomType.Size = New System.Drawing.Size(158, 22)
        Me.frmRoomType.Text = "Roo&m Type"
        '
        'frmVehicles
        '
        Me.frmVehicles.Name = "frmVehicles"
        Me.frmVehicles.Size = New System.Drawing.Size(158, 22)
        Me.frmVehicles.Text = "&Vehicles"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRPTAccRec, Me.mnuRPTOtherCharges, Me.mnuRPTCheckedInGuest, Me.mnuRPTCheckOut, Me.mnuDueReservation, Me.mnuRPTGuestList, Me.mnuRPTRoomHistory})
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(59, 20)
        Me.mnuReports.Text = "Re&ports"
        '
        'mnuRPTAccRec
        '
        Me.mnuRPTAccRec.Name = "mnuRPTAccRec"
        Me.mnuRPTAccRec.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTAccRec.Text = "Accounts Receivable"
        '
        'mnuRPTOtherCharges
        '
        Me.mnuRPTOtherCharges.Name = "mnuRPTOtherCharges"
        Me.mnuRPTOtherCharges.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTOtherCharges.Text = "Other Charges"
        '
        'mnuRPTCheckedInGuest
        '
        Me.mnuRPTCheckedInGuest.Name = "mnuRPTCheckedInGuest"
        Me.mnuRPTCheckedInGuest.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTCheckedInGuest.Text = "Checked In Guest"
        '
        'mnuRPTCheckOut
        '
        Me.mnuRPTCheckOut.Name = "mnuRPTCheckOut"
        Me.mnuRPTCheckOut.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTCheckOut.Text = "Check Out Report"
        '
        'mnuDueReservation
        '
        Me.mnuDueReservation.Name = "mnuDueReservation"
        Me.mnuDueReservation.Size = New System.Drawing.Size(185, 22)
        Me.mnuDueReservation.Text = "Due Reservation"
        '
        'mnuRPTGuestList
        '
        Me.mnuRPTGuestList.Name = "mnuRPTGuestList"
        Me.mnuRPTGuestList.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTGuestList.Text = "Guest List Report"
        '
        'mnuRPTRoomHistory
        '
        Me.mnuRPTRoomHistory.Name = "mnuRPTRoomHistory"
        Me.mnuRPTRoomHistory.Size = New System.Drawing.Size(185, 22)
        Me.mnuRPTRoomHistory.Text = "Room History Report"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(48, 20)
        Me.mnuTools.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(63, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(168, 22)
        Me.mnuAbout.Text = "&About ..."
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreviewToolStripButton.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Help"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiMain"
        Me.Text = "Hotel Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuRecords As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuGuests As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMonitoring As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountReceivablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReservations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInventoryView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmBusinessSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmChargeType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmCountries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmIDType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmPaymentType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmRateType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmRoomStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmRoomType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmVehicles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRoomWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRPTAccRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRPTOtherCharges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRPTCheckedInGuest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRPTCheckOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDueReservation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRPTGuestList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRPTRoomHistory As System.Windows.Forms.ToolStripMenuItem

End Class
