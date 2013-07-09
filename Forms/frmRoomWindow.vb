'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Data.OleDb

Public Class frmRoomWindow
    Dim sSql As String
    
    Private Sub frmRoomWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT RoomNumber, RoomType, Status FROM qry_Rooms_Window ORDER BY RoomNumber ASC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        Dim intRoomNumber As Integer

        For Each sItem As ListViewItem In lvList.SelectedItems
            intRoomNumber = sItem.Text
        Next

        If lvList.FocusedItem.SubItems(2).Text = "Vacant" Then
            btnAdd_Click(sender, e)

            Exit Sub
        End If

        With frmCheckIn
            .State = modGlobal.FormState.adStateEditMode
            .RoomNumber = intRoomNumber

            .ShowDialog()

            Call FillList()
        End With

        frmCheckIn = Nothing
    End Sub

    Private Sub frmRoomWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState <> FormWindowState.Minimized Then
            If Me.Width < 550 Then Me.Width = 550
            If Me.Height < 250 Then Me.Height = 250
            lvList.Height = Me.Height - 96
            lvList.Width = Me.Width - 10
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim intRoomNumber As Integer

        frmCheckIn.State = modGlobal.FormState.adStateAddMode

        For Each sItem As ListViewItem In lvList.SelectedItems
            intRoomNumber = sItem.Text
        Next

        frmCheckIn.RoomNumber = intRoomNumber
        frmCheckIn.ShowDialog()

        Call FillList()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Room Number", 90)
            .Columns.Add("Room Type", 120)
            .Columns.Add("Status", 90)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.sourcecodester.com")
    End Sub
End Class