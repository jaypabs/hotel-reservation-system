'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmCompanyLookup
    Dim sSql As String

    Private Sub frmCustomerLookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT CompanyID, Company, LastName, FirstName, Address, TelNo  FROM Company ORDER BY Company ASC"

        Call FillList()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Customer ID", 0)
            .Columns.Add("Company", 150)
            .Columns.Add("Lastname", 140)
            .Columns.Add("Firstname", 140)
            .Columns.Add("Address", 200)
            .Columns.Add("TelNo", 100)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            sSql = "SELECT CompanyID, Company, LastName, FirstName, Address, TelNo  FROM Company ORDER BY Company ASC"
        Else
            sSql = "SELECT CompanyID, Company, LastName, FirstName, Address, TelNo  FROM Company WHERE " & cboField.SelectedItem & " Like '" & txtSearch.Text & "%' ORDER BY Company ASC"
        End If

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        CurrCust.Company = lvList.FocusedItem.SubItems(1).Text

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class