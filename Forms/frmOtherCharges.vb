'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmOtherCharges
    Public FolioNumber As String
    Public GuestName As String
    Public RefForm As String  'Calling form

    Dim OtherCharges As Double

    Public Sub SaveRecord()
        Me.Validate()
        Me.Other_ChargesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

        Me.Close()
    End Sub

    Private Sub frmOtherCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Charge_Type' table. You can move, or remove it, as needed.
        Me.Charge_TypeTableAdapter.Fill(Me.HotelDataSet.Charge_Type)
        'TODO: This line of code loads data into the 'HotelDataSet.Other_Charges' table. You can move, or remove it, as needed.
        Me.Other_ChargesTableAdapter.FillBy(Me.HotelDataSet.Other_Charges, FolioNumber)

        txtTotal.Text = Total().ToString("c")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()

        If RefForm = "frmCheckIn" Then
            frmCheckIn.OtherCharges = txtTotal.Text
        Else
            frmCheckOut.OtherCharges = txtTotal.Text
        End If
    End Sub

    Private Sub Other_ChargesDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Other_ChargesDataGridView.CellValueChanged
        If e.ColumnIndex = 4 And Other_ChargesDataGridView.Rows.Count > 0 Then
            txtTotal.Text = Total().ToString("c")
        End If
    End Sub

    Private Sub Other_ChargesDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Other_ChargesDataGridView.DefaultValuesNeeded
        With e.Row
            .Cells(0).Value = FolioNumber
        End With
    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To Other_ChargesDataGridView.Rows.Count - 1
            tot = tot + Convert.ToDouble(Other_ChargesDataGridView.Rows(i).Cells("Amount").Value)
        Next i

        Return tot
    End Function
End Class