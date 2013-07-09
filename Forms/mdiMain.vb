'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Windows.Forms

Public Class mdiMain
    Private blnActive As Boolean

    Private Function IsOpen(ByVal nameForm As String) As Boolean
        Dim childfrm As Form
        Dim strName As String
        Dim intLastIndex As Integer

        For Each childfrm In Me.MdiChildren
            strName = childfrm.GetType.ToString
            intLastIndex = strName.LastIndexOf(".")
            strName = Mid(strName, intLastIndex + 2, Len(strName) - intLastIndex)
            If LCase(strName) = LCase(nameForm) Then
                childfrm.BringToFront()
                Return True
            End If
        Next
        Return False

        'If nameForm.Visible Then
        '    nameForm.Focus()
        '    Return True
        'End If
        'Return False
    End Function

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub mnuGuests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGuests.Click
        If blnActive = IsOpen("frmGuest") Then
            Dim Guest As New frmGuest

            'Guest.MdiParent = Me
            Guest.StartPosition = FormStartPosition.CenterScreen
            Guest.ShowDialog()
        End If
    End Sub

    Private Sub mnuCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompany.Click
        If blnActive = IsOpen("frmCompany") Then
            Dim Company As New frmCompany

            'Company.MdiParent = Me
            Company.StartPosition = FormStartPosition.CenterScreen
            Company.ShowDialog()
        End If
    End Sub

    Private Sub frmBusinessSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmBusinessSource.Click
        If blnActive = IsOpen("frmBusinessSource") Then
            Dim BusinessSource As New frmBusinessSource

            'BusinessSource.MdiParent = Me
            BusinessSource.StartPosition = FormStartPosition.CenterScreen
            BusinessSource.ShowDialog()
        End If
    End Sub

    Private Sub frmChargeType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmChargeType.Click
        If blnActive = IsOpen("frmChargeType") Then
            Dim ChargeType As New frmChargeType

            'ChargeType.MdiParent = Me
            ChargeType.StartPosition = FormStartPosition.CenterScreen
            ChargeType.ShowDialog()
        End If
    End Sub

    Private Sub frmCountries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmCountries.Click
        If blnActive = IsOpen("frmCountries") Then
            Dim Countries As New frmCountries

            'Countries.MdiParent = Me
            Countries.StartPosition = FormStartPosition.CenterScreen
            Countries.ShowDialog()
        End If
    End Sub

    Private Sub frmIDType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmIDType.Click
        If blnActive = IsOpen("frmIDType") Then
            Dim IDType As New frmIDType

            'IDType.MdiParent = Me
            IDType.StartPosition = FormStartPosition.CenterScreen
            IDType.ShowDialog()
        End If
    End Sub

    Private Sub frmPaymentType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmPaymentType.Click
        If blnActive = IsOpen("frmPaymentType") Then
            Dim PaymentType As New frmPaymentType

            'PaymentType.MdiParent = Me
            PaymentType.StartPosition = FormStartPosition.CenterScreen
            PaymentType.ShowDialog()
        End If
    End Sub

    Private Sub frmRateType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmRateType.Click
        If blnActive = IsOpen("frmRateType") Then
            Dim RateType As New frmRateType

            'RateType.MdiParent = Me
            RateType.StartPosition = FormStartPosition.CenterScreen
            RateType.ShowDialog()
        End If
    End Sub

    Private Sub frmRoomStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmRoomStatus.Click
        If blnActive = IsOpen("frmRoomStatus") Then
            Dim RoomStatus As New frmRoomStatus

            'RoomStatus.MdiParent = Me
            RoomStatus.StartPosition = FormStartPosition.CenterScreen
            RoomStatus.ShowDialog()
        End If
    End Sub

    Private Sub frmRoomType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmRoomType.Click
        If blnActive = IsOpen("frmRoomType") Then
            Dim RoomType As New frmRoomType

            RoomType.StartPosition = FormStartPosition.CenterScreen
            RoomType.ShowDialog()
        End If
    End Sub

    Private Sub frmVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmVehicles.Click
        If blnActive = IsOpen("frmVehicles") Then
            Dim Vehicles As New frmVehicles

            'Vehicles.MdiParent = Me
            Vehicles.StartPosition = FormStartPosition.CenterScreen
            Vehicles.ShowDialog()
        End If
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        If blnActive = IsOpen("frmAbout") Then
            Dim About As New frmAbout

            'About.MdiParent = Me
            About.StartPosition = FormStartPosition.CenterScreen
            About.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If blnActive = IsOpen("frmCheckInHistory") Then
            Dim CheckInHistory As New frmCheckInHistory

            CheckInHistory.MdiParent = Me
            CheckInHistory.StartPosition = FormStartPosition.CenterScreen
            CheckInHistory.Show()
        End If
    End Sub

    Private Sub mnuRoomWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRoomWindow.Click
        If blnActive = IsOpen("frmRoomWindow") Then
            Dim RoomWindow As New frmRoomWindow

            RoomWindow.MdiParent = Me
            RoomWindow.StartPosition = FormStartPosition.CenterScreen
            RoomWindow.Show()
        End If
    End Sub

    Private Sub mnuReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReservations.Click
        If blnActive = IsOpen("frmReservationList") Then
            Dim ReservationList As New frmReservationList

            ReservationList.MdiParent = Me
            ReservationList.StartPosition = FormStartPosition.CenterScreen
            ReservationList.Show()
        End If
    End Sub

    Private Sub mnuInventoryView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInventoryView.Click
        If blnActive = IsOpen("frmInventoryView") Then
            Dim InventoryView As New frmInventoryView

            InventoryView.MdiParent = Me
            InventoryView.StartPosition = FormStartPosition.CenterScreen
            InventoryView.Show()
        End If
    End Sub

    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.Close()

        If blnActive = IsOpen("frmRoomWindow") Then
            Dim RoomWindow As New frmRoomWindow

            RoomWindow.MdiParent = Me
            RoomWindow.StartPosition = FormStartPosition.CenterScreen
            RoomWindow.Show()
            RoomWindow.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AccountReceivablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountReceivablesToolStripMenuItem.Click
        If blnActive = IsOpen("frmAccountReceivableList") Then
            Dim AccountReceivableList As New frmAccountReceivableList

            AccountReceivableList.MdiParent = Me
            AccountReceivableList.StartPosition = FormStartPosition.CenterScreen
            AccountReceivableList.Show()
            AccountReceivableList.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub mnuRPTAccRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTAccRec.Click
        frmRPTAccRec.ShowDialog()
    End Sub

    Private Sub mnuRPTOtherCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTOtherCharges.Click
        frmRPTOtherCharges.ShowDialog()
    End Sub

    Private Sub mnuRPTCheckedInGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTCheckedInGuest.Click
        With frmReports
            .strReport = "CheckIn Guest"

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub mnuRPTCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTCheckOut.Click
        frmRPTCheckOut.ShowDialog()
    End Sub

    Private Sub mnuDueReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDueReservation.Click
        frmRPTDueReservation.ShowDialog()
    End Sub

    Private Sub mnuRPTGuestList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTGuestList.Click
        With frmReports
            .strReport = "Guest List"

            frmReports.ShowDialog()
        End With
    End Sub

    Private Sub mnuRPTRoomHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPTRoomHistory.Click
        frmRPTRoomHistory.ShowDialog()
    End Sub
End Class
