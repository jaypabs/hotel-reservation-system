Option Strict Off
Option Explicit On

Friend Class frmRPTAccRec
    Inherits System.Windows.Forms.Form

    Private Sub frmRPTAccRec_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        FillCombobox(cboCompany, "SELECT * FROM [Company] WHERE Company Is Not Null ORDER BY Company", "Company", "Company", "CompanyID")
    End Sub

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOK.Click
        With frmReports
            .strReport = "Account Receivable"

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
End Class