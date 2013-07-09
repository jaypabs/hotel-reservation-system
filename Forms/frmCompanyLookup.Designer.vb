<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyLookup
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cboField = New System.Windows.Forms.ComboBox
        Me.lvList = New System.Windows.Forms.ListView
        Me.RoomNumber = New System.Windows.Forms.ColumnHeader
        Me.RoomType = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(197, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(125, 20)
        Me.txtSearch.TabIndex = 14
        '
        'cboField
        '
        Me.cboField.FormattingEnabled = True
        Me.cboField.Items.AddRange(New Object() {"Company", "Lastname", "Firstname"})
        Me.cboField.Location = New System.Drawing.Point(64, 12)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(117, 21)
        Me.cboField.TabIndex = 13
        '
        'lvList
        '
        Me.lvList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RoomNumber, Me.RoomType, Me.Status})
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(12, 44)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(552, 310)
        Me.lvList.TabIndex = 12
        Me.lvList.UseCompatibleStateImageBehavior = False
        '
        'RoomNumber
        '
        Me.RoomNumber.Text = "Room Number"
        Me.RoomNumber.Width = 90
        '
        'RoomType
        '
        Me.RoomType.Text = "Room Type"
        Me.RoomType.Width = 120
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 90
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(456, 361)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmCompanyLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 391)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cboField)
        Me.Controls.Add(Me.lvList)
        Me.Controls.Add(Me.btnCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompanyLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Lookup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboField As System.Windows.Forms.ComboBox
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents RoomNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents RoomType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
