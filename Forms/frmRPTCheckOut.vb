Option Strict Off
Option Explicit On

Friend Class frmRPTCheckOut
    Inherits System.Windows.Forms.Form

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        With frmReports
            .strReport = "Check Out"

            .strWhere = "{qry_rpt_CheckOut.DateOut} = #" & dtpCheckOut.Value & "#"

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub frmRPTCheckOut_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        dtpCheckOut.Value = Today
    End Sub
End Class