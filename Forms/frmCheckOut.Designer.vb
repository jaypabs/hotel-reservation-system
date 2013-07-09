<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOut
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.txtGuestName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDateIn = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboRateType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDays = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAdults = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChildrens = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDateOut = New System.Windows.Forms.DateTimePicker
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.lblRatePerPeriod = New System.Windows.Forms.Label
        Me.txtTotalCharges = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOtherCharges = New System.Windows.Forms.TextBox
        Me.lblOtherCharges = New System.Windows.Forms.Label
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.lblAmountPaid = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnCheckOut = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Number"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(116, 63)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(111, 20)
        Me.txtRoomNumber.TabIndex = 1
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(116, 89)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(167, 20)
        Me.txtGuestName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Guest Name"
        '
        'dtpDateIn
        '
        Me.dtpDateIn.Location = New System.Drawing.Point(116, 128)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.Size = New System.Drawing.Size(111, 20)
        Me.dtpDateIn.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date In"
        '
        'cboRateType
        '
        Me.cboRateType.FormattingEnabled = True
        Me.cboRateType.Location = New System.Drawing.Point(116, 158)
        Me.cboRateType.Name = "cboRateType"
        Me.cboRateType.Size = New System.Drawing.Size(110, 21)
        Me.cboRateType.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rate Type"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(115, 185)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(111, 20)
        Me.txtDays.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No. of Days"
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(115, 211)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(111, 20)
        Me.txtAdults.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No. of Adults"
        '
        'txtChildrens
        '
        Me.txtChildrens.Location = New System.Drawing.Point(116, 237)
        Me.txtChildrens.Name = "txtChildrens"
        Me.txtChildrens.Size = New System.Drawing.Size(111, 20)
        Me.txtChildrens.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No. of Childrens"
        '
        'dtpDateOut
        '
        Me.dtpDateOut.Location = New System.Drawing.Point(394, 128)
        Me.dtpDateOut.Name = "dtpDateOut"
        Me.dtpDateOut.Size = New System.Drawing.Size(95, 20)
        Me.dtpDateOut.TabIndex = 14
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(394, 159)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(111, 20)
        Me.txtRate.TabIndex = 16
        '
        'lblRatePerPeriod
        '
        Me.lblRatePerPeriod.AutoSize = True
        Me.lblRatePerPeriod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRatePerPeriod.ForeColor = System.Drawing.Color.Blue
        Me.lblRatePerPeriod.Location = New System.Drawing.Point(306, 167)
        Me.lblRatePerPeriod.Name = "lblRatePerPeriod"
        Me.lblRatePerPeriod.Size = New System.Drawing.Size(82, 13)
        Me.lblRatePerPeriod.TabIndex = 15
        Me.lblRatePerPeriod.Text = "Rate Per Period"
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.Location = New System.Drawing.Point(394, 188)
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.Size = New System.Drawing.Size(111, 20)
        Me.txtTotalCharges.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Charges"
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.Location = New System.Drawing.Point(394, 215)
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.Size = New System.Drawing.Size(111, 20)
        Me.txtOtherCharges.TabIndex = 20
        '
        'lblOtherCharges
        '
        Me.lblOtherCharges.AutoSize = True
        Me.lblOtherCharges.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOtherCharges.ForeColor = System.Drawing.Color.Blue
        Me.lblOtherCharges.Location = New System.Drawing.Point(313, 219)
        Me.lblOtherCharges.Name = "lblOtherCharges"
        Me.lblOtherCharges.Size = New System.Drawing.Size(75, 13)
        Me.lblOtherCharges.TabIndex = 19
        Me.lblOtherCharges.Text = "Other Charges"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(394, 240)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtSubTotal.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Subt Total"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(394, 266)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(111, 20)
        Me.txtDiscount.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(339, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Discount"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(394, 292)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtTotal.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(357, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Total"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(394, 318)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(111, 20)
        Me.txtAmountPaid.TabIndex = 28
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.Blue
        Me.lblAmountPaid.Location = New System.Drawing.Point(321, 321)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(67, 13)
        Me.lblAmountPaid.TabIndex = 27
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(394, 344)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(111, 20)
        Me.txtBalance.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(342, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Balance"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(338, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Date Out"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(338, 383)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckOut.TabIndex = 32
        Me.btnCheckOut.Text = "Check &Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(430, 383)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 41)
        Me.Panel1.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(197, 26)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Company Information"
        '
        'frmCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 419)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOtherCharges)
        Me.Controls.Add(Me.lblOtherCharges)
        Me.Controls.Add(Me.txtTotalCharges)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblRatePerPeriod)
        Me.Controls.Add(Me.dtpDateOut)
        Me.Controls.Add(Me.txtChildrens)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdults)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRateType)
        Me.Controls.Add(Me.dtpDateIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCheckOut"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateIn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRateType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtChildrens As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents lblRatePerPeriod As System.Windows.Forms.Label
    Friend WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOtherCharges As System.Windows.Forms.TextBox
    Friend WithEvents lblOtherCharges As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
