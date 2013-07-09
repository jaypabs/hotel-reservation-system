'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmReservationList
    Dim sSql As String

    Private Sub frmReservationList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT ReservationNo, Customer, Company, Address FROM qry_Reservation WHERE Status = 'Reserved' ORDER BY ReservationNo ASC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        With frmReservation
            .State = modGlobal.FormState.adStateEditMode
            .ReservationNo = lvList.SelectedItems(0).Text

            .ShowDialog()

            Call FillList()
        End With

        frmReservation = Nothing
    End Sub

    Private Sub frmReservationList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState <> FormWindowState.Minimized Then
            If Me.Width < 550 Then Me.Width = 550
            If Me.Height < 250 Then Me.Height = 250
            lvList.Height = Me.Height - 96
            lvList.Width = Me.Width - 10
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmReservation.State = modGlobal.FormState.adStateAddMode

        frmReservation.ShowDialog()

        Call FillList()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Reservation No", 90)
            .Columns.Add("Customer", 120)
            .Columns.Add("Company", 130)
            .Columns.Add("Address", 150)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub
End Class