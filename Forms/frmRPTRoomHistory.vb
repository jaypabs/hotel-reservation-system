Option Strict Off
Option Explicit On

Imports System.Data.OleDb

Friend Class frmRPTRoomHistory
    Inherits System.Windows.Forms.Form

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        With frmReports
            .strReport = "Room History"

            If cboRoomNumber.Text = "All Rooms" Then
                .strWhere = "{qry_rpt_Room_History.DateIn} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "# OR {qry_rpt_Room_History.DateOut} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "#"
            Else
                .strWhere = "{qry_rpt_Room_History.RoomNumber} = " & cboRoomNumber.Text & " AND ({qry_rpt_Room_History.DateIn} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "# OR {qry_rpt_Room_History.DateOut} IN #" & dtpBegDate.Value & "# TO #" & dtpEndDate.Value & "#)"
            End If

            frmReports.ShowDialog()
        End With

    End Sub

    Private Sub frmRPTRoomHistory_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboRoomNumber.Items.Add("All Rooms")

        Dim sqlQRY As String = "SELECT RoomNumber FROM Rooms ORDER BY RoomNumber ASC"

        'Create connection
        Dim conn As OleDbConnection = New OleDbConnection(cnString)

        Try
            ' Open connection
            conn.Open()

            'create command 
            Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)

            'create data reader
            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            While (rdr.Read)
                cboRoomNumber.Items.Add(rdr("RoomNumber").ToString)
            End While

        Catch ex As OleDbException
            MsgBox(ex.ToString)
        Finally
            ' Close connection
            conn.Close()
        End Try

        cboRoomNumber.SelectedIndex = 0

        dtpBegDate.Value = Today
        dtpEndDate.Value = Today
    End Sub
End Class