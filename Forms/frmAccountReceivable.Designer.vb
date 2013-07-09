<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountReceivable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountReceivable))
        Me.bgHeader = New System.Windows.Forms.Panel
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.lblPaid = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.bgMain = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.bgHeader.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgMain.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgHeader
        '
        Me.bgHeader.BackColor = System.Drawing.SystemColors.Window
        Me.bgHeader.Controls.Add(Me.Label27)
        Me.bgHeader.Controls.Add(Me.Label26)
        Me.bgHeader.Controls.Add(Me.Image1)
        Me.bgHeader.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgHeader.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgHeader.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bgHeader.Location = New System.Drawing.Point(1, 2)
        Me.bgHeader.Name = "bgHeader"
        Me.bgHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgHeader.Size = New System.Drawing.Size(457, 37)
        Me.bgHeader.TabIndex = 27
        Me.bgHeader.TabStop = True
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
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Fill all fields or fields with '*' then click 'Save' button to update."
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
        Me.Label26.Size = New System.Drawing.Size(103, 23)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Payments"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(2, 2)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(32, 32)
        Me.Image1.TabIndex = 12
        Me.Image1.TabStop = False
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblPaid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPaid.Font = New System.Drawing.Font("Andalus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.ForeColor = System.Drawing.Color.Red
        Me.lblPaid.Location = New System.Drawing.Point(294, 10)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPaid.Size = New System.Drawing.Size(59, 29)
        Me.lblPaid.TabIndex = 26
        Me.lblPaid.Text = "PAID"
        Me.lblPaid.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.AcceptsReturn = True
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompany.Location = New System.Drawing.Point(73, 58)
        Me.txtCompany.MaxLength = 0
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompany.Size = New System.Drawing.Size(121, 20)
        Me.txtCompany.TabIndex = 25
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsReturn = True
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBalance.Location = New System.Drawing.Point(73, 88)
        Me.txtBalance.MaxLength = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBalance.Size = New System.Drawing.Size(121, 20)
        Me.txtBalance.TabIndex = 24
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.AcceptsReturn = True
        Me.txtAmountPaid.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPaid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmountPaid.Location = New System.Drawing.Point(297, 88)
        Me.txtAmountPaid.MaxLength = 0
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.ReadOnly = True
        Me.txtAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAmountPaid.Size = New System.Drawing.Size(121, 20)
        Me.txtAmountPaid.TabIndex = 23
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Balance"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(409, 368)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(67, 25)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(230, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Amount Paid"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(345, 368)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(59, 25)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Company"
        '
        'bgMain
        '
        Me.bgMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bgMain.Controls.Add(Me.DataGridView1)
        Me.bgMain.Controls.Add(Me.lblPaid)
        Me.bgMain.Controls.Add(Me.Label3)
        Me.bgMain.Controls.Add(Me.Label2)
        Me.bgMain.Controls.Add(Me.Label1)
        Me.bgMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.bgMain.Location = New System.Drawing.Point(1, 40)
        Me.bgMain.Name = "bgMain"
        Me.bgMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgMain.Size = New System.Drawing.Size(491, 361)
        Me.bgMain.TabIndex = 28
        Me.bgMain.TabStop = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(463, 217)
        Me.DataGridView1.TabIndex = 27
        '
        'frmAccountReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 402)
        Me.Controls.Add(Me.bgHeader)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.bgMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountReceivable"
        Me.Text = "frmAccountReceivable"
        Me.bgHeader.ResumeLayout(False)
        Me.bgHeader.PerformLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgMain.ResumeLayout(False)
        Me.bgMain.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents bgHeader As System.Windows.Forms.Panel
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents lblPaid As System.Windows.Forms.Label
    Public WithEvents txtCompany As System.Windows.Forms.TextBox
    Public WithEvents txtBalance As System.Windows.Forms.TextBox
    Public WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents bgMain As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
