'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmChangeRoom
    Dim sSql As String

    Private Sub frmChangeRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpStartDate.Value = Today

        sSql = "SELECT RoomNumber, RoomType, Status FROM qry_Rooms_Window ORDER BY RoomNumber ASC"

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

    Private Sub CmdChangeRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChangeRoom.Click
        With frmCheckIn
            If dtpStartDate.Value < .dtpDateIn.Value Then
                MsgBox("Start date must be higher than the 'Date In' from Check in form", MsgBoxStyle.Information)

                Exit Sub
            End If

            If dtpStartDate.Value > .dtpDateOut.Value Then
                .dtpDateOut.Value = dtpStartDate.Value
            ElseIf dtpStartDate.Value = .dtpDateOut.Value Then
                .dtpDateOut.Value = dtpStartDate.Value.AddDays(1)
            End If

            .txtRoomNumber.Text = txtTo.Text
            .txtRate.Text = toMoney(GetFieldValue("SELECT RoomRate FROM [Room_Rates] WHERE RoomNumber = " & .txtRoomNumber.Text & " AND RateTypeID = " & .cboRateType.SelectedValue, "RoomRate"))

            Call .dtpDateOut_ValueChanged(sender, e)

            .blnChangeRoom = True
            Me.Close()
        End With
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub lvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.Click
        For Each sItem As ListViewItem In lvList.SelectedItems
            txtTo.Text = sItem.Text
        Next
    End Sub

End Class