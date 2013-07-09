'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmPayments
    Public FolioNumber As String
    Public GuestName As String
    Public Balance As Double
    Public RefForm As String  'Calling form

    Dim AmountPaid As Double

    Public Sub SaveRecord()
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

        Me.Close()
    End Sub

    Private Sub frmPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Payment_TypeTableAdapter.Fill(Me.HotelDataSet.Payment_Type)
        Me.PaymentsTableAdapter.FillBy(Me.HotelDataSet.Payments, FolioNumber)

        txtTotal.Text = Total().ToString("c")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()

        If RefForm = "frmCheckIn" Then
            frmCheckIn.AmountPaid = txtTotal.Text
        Else
            frmCheckOut.AmountPaid = txtTotal.Text
        End If
    End Sub

    Public Sub RefreshBalance()
        'Compute the balance programmatically

        'txtBalance.Text = toMoney(Balance)
    End Sub

    Private Sub PaymentsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentsDataGridView.CellValueChanged
        If e.ColumnIndex = 6 And PaymentsDataGridView.Rows.Count > 0 Then
            txtTotal.Text = Total().ToString("c")
        End If
    End Sub

    Private Sub PaymentsDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles PaymentsDataGridView.DefaultValuesNeeded
        With e.Row
            .Cells(0).Value = FolioNumber
        End With
    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To PaymentsDataGridView.Rows.Count - 1
            tot = tot + Convert.ToDouble(PaymentsDataGridView.Rows(i).Cells("Amount").Value)
        Next i

        Return tot
    End Function
End Class