Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data

Public Class frmReports
    Public strWhere As String
    Public strReport As String

    Private mReport As ReportDocument

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
        Dim pdvBusName As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim pdvBusAddress As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim pdvContactInfo As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim BusName As String = "ABC Company"
        Dim BusAddress As String = "Bacolod City"
        Dim ContactInfo As String = "1234567"

        mReport = New ReportDocument()

        Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

        pdvBusName.Value = BusName
        pdvBusAddress.Value = BusAddress
        pdvContactInfo.Value = ContactInfo

        Select Case strReport
            Case "Folio"
                mReport.Load("Reports\rpt_Folio.rpt")

                mReport.RecordSelectionFormula = strWhere
            Case "Account Receivable"
                mReport.Load("Reports\rpt_Account_Receivable.rpt")

                If frmRPTAccRec.cboCompany.Text <> "" Then
                    mReport.RecordSelectionFormula = "{qry_Account_Receivable.Company} = '" & frmRPTAccRec.cboCompany.Text & "'"
                End If

                mReport.RecordSelectionFormula = strWhere
            Case "Other Charges"
                mReport.Load("Reports\rpt_Other_Charges.rpt")

                mReport.RecordSelectionFormula = strWhere
            Case "CheckIn Guest"
                mReport.Load("Reports\rpt_CheckIn_Guest.rpt")
            Case "Check Out"
                mReport.Load("Reports\rpt_CheckOut.rpt")

                mReport.RecordSelectionFormula = strWhere
            Case "Due Reservation"
                mReport.Load("Reports\rpt_Due_Reservation.rpt")

                mReport.RecordSelectionFormula = strWhere
            Case "Guest List"
                mReport.Load("Reports\rpt_Guest_List.rpt")
            Case "Room History"
                mReport.Load("Reports\rpt_Room_History.rpt")

                mReport.RecordSelectionFormula = strWhere
            Case "Reservation"
                mReport.Load("Reports\rpt_Reservation.rpt")

                mReport.RecordSelectionFormula = strWhere
        End Select

        pvCollection.Add(pdvBusName)
        mReport.DataDefinition.ParameterFields("prmBusName").ApplyCurrentValues(pvCollection)

        pvCollection.Add(pdvBusAddress)
        mReport.DataDefinition.ParameterFields("prmBusAddress").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        pvCollection.Add(pdvContactInfo)

        mReport.DataDefinition.ParameterFields("prmContactInfo").ApplyCurrentValues(pvCollection)

        For Each tbCurrent In mReport.Database.Tables
            tliCurrent = tbCurrent.LogOnInfo
            With tliCurrent.ConnectionInfo
                .ServerName = Application.StartupPath & "\data.mdb"
                .UserID = ""
                .Password = "12345"
                .DatabaseName = Application.StartupPath & "\data.mdb"
            End With
            tbCurrent.ApplyLogOnInfo(tliCurrent)
        Next tbCurrent

        myCrystalReportViewer.ReportSource = mReport

    End Sub

End Class
