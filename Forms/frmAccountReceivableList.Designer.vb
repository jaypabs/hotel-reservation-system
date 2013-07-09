<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountReceivableList
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
        Me.lvList = New System.Windows.Forms.ListView
        Me.RoomNumber = New System.Windows.Forms.ColumnHeader
        Me.RoomType = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lvList
        '
        Me.lvList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RoomNumber, Me.RoomType, Me.Status})
        Me.lvList.HideSelection = False
        Me.lvList.Location = New System.Drawing.Point(0, 2)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(651, 420)
        Me.lvList.TabIndex = 8
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
        'frmAccountReceivableList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 423)
        Me.Controls.Add(Me.lvList)
        Me.Name = "frmAccountReceivableList"
        Me.Text = "frmAccountReceivableList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents RoomNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents RoomType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
End Class
