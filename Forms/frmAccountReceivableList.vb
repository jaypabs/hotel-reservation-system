'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmAccountReceivableList
    Dim sSql As String


    Private Sub frmAccountReceivableList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT AccRecID,Company,FolioNumber,Total,AmountPaid,Balance FROM qry_Account_Receivable ORDER BY Company ASC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        With frmCheckIn
            .State = modGlobal.FormState.adStatePopupMode
            .FolioNumber = lvList.SelectedItems(0).Text

            .ShowDialog()

            Call FillList()
        End With

        frmCheckIn = Nothing
    End Sub

    Private Sub frmAccountReceivableList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState <> FormWindowState.Minimized Then
            If Me.Width < 550 Then Me.Width = 550
            If Me.Height < 250 Then Me.Height = 250
            lvList.Height = Me.Height - 96
            lvList.Width = Me.Width - 10
        End If
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("AccRecID", 90)
            .Columns.Add("Company", 130)
            .Columns.Add("FolioNumber", 90, HorizontalAlignment.Right)
            .Columns.Add("Total", 100, HorizontalAlignment.Right)
            .Columns.Add("AmountPaid", 100, HorizontalAlignment.Right)
            .Columns.Add("Balance", 100, HorizontalAlignment.Right)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub
End Class