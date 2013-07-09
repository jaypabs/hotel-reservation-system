Option Strict Off
Option Explicit On

Friend Class frmRPTDueReservation
    Inherits System.Windows.Forms.Form

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        With frmReports
            .strReport = "Due Reservation"

            .strWhere = "{qry_rpt_Due_Reservation.DateIn} = #" & dtpCheckIn.Value & "#"

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub frmRPTDueReservation_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        dtpCheckIn.Value = Today
    End Sub
End Class