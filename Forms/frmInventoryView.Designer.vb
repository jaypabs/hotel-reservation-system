<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryView
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lvList = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.CmdChange = New System.Windows.Forms.Button
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.cbMonth = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.SystemColors.Window
        Me.lvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.HideSelection = False
        Me.lvList.LabelWrap = False
        Me.lvList.Location = New System.Drawing.Point(0, 55)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(484, 229)
        Me.lvList.TabIndex = 20
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(190, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Month"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle.Location = New System.Drawing.Point(5, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(321, 14)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Inventory View"
        '
        'CmdChange
        '
        Me.CmdChange.BackColor = System.Drawing.SystemColors.Control
        Me.CmdChange.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdChange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdChange.Location = New System.Drawing.Point(338, 3)
        Me.CmdChange.Name = "CmdChange"
        Me.CmdChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdChange.Size = New System.Drawing.Size(83, 21)
        Me.CmdChange.TabIndex = 26
        Me.CmdChange.Text = "Change"
        Me.CmdChange.UseVisualStyleBackColor = False
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(220, 3)
        Me.txtYear.MaxLength = 0
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(101, 20)
        Me.txtYear.TabIndex = 23
        '
        'cbMonth
        '
        Me.cbMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cbMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(56, 3)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbMonth.Size = New System.Drawing.Size(115, 22)
        Me.cbMonth.TabIndex = 22
        '
        'frmInventoryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 516)
        Me.Controls.Add(Me.lvList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.CmdChange)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cbMonth)
        Me.Name = "frmInventoryView"
        Me.Text = "Inventory View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents lvList As System.Windows.Forms.ListView
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents CmdChange As System.Windows.Forms.Button
    Public WithEvents txtYear As System.Windows.Forms.TextBox
    Public WithEvents cbMonth As System.Windows.Forms.ComboBox
End Class
