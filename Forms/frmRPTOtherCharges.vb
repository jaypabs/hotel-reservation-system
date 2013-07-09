Option Strict Off
Option Explicit On

Friend Class frmRPTOtherCharges
    Inherits System.Windows.Forms.Form

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        With frmReports
            .strReport = "Other Charges"

            If cboChargeType.Text <> "" Then
                .strWhere = "{qry_rpt_Other_Charges.ChargeType} = '" & cboChargeType.Text & "' AND {qry_rpt_Other_Charges.DateIn} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "#"
            Else
                .strWhere = "{qry_rpt_Other_Charges.DateIn} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "#"
            End If

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub frmRPTOtherCharges_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        FillCombobox(cboChargeType, "SELECT * FROM Charge_Type", "Charge_Type", "ChargeType", "ChargeTypeID")

        dtpBegDate.Value = Today
        dtpEndDate.Value = Today
    End Sub
End Class