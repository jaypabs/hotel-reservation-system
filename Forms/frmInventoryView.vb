'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Data.OleDb

Public Class frmInventoryView
    Dim sSql As String

    Private Sub frmInventoryView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT * FROM qry_Inventory_View ORDER BY [Date] ASC"

        cbMonth.SelectedIndex = Month(Today) - 1
        txtYear.Text = CStr(Year(Today))

        Call UpdateDate()

        Call FillList()
    End Sub

    Private Sub frmRoomWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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

            Dim lvwColumn As ColumnHeader
            Dim myData As OleDbDataReader

            myData = GetData(sSql)

            Dim shtCntr As Short

            For shtCntr = 0 To myData.FieldCount() - 1
                lvwColumn = New ColumnHeader()
                lvwColumn.Text = myData.GetName(shtCntr)
                .Columns.Add(lvwColumn)
            Next

            FillListView(lvList, myData)
        End With
    End Sub

    Private Sub UpdateDate()
        On Error Resume Next

        ExecNonQuery("UPDATE DateTemp SET DateTemp.[Date] = '" & cbMonth.SelectedIndex + 1 & "' & '/' & Day([Date]) & '/' & '" & txtYear.Text & "'")
    End Sub

    Private Sub CmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChange.Click
        Call UpdateDate()

        Call FillList()
    End Sub
End Class