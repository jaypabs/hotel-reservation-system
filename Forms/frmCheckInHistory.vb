'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmCheckInHistory
    Dim sSql As String

    Private Sub frmCheckInHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT FolioNumber, [Name], RoomNumber, DateIn, DateOut  FROM qry_CheckIn WHERE Status = 'Check Out' ORDER BY [Name] ASC"

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

    Private Sub frmCheckInHistory_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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
            .Columns.Add("Folio Number", 90)
            .Columns.Add("Name", 130)
            .Columns.Add("Room Number", 90, HorizontalAlignment.Right)
            .Columns.Add("Date In", 100, HorizontalAlignment.Right)
            .Columns.Add("Date Out", 100, HorizontalAlignment.Right)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub
End Class