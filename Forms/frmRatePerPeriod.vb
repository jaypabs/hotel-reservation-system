'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmRatePerPeriod
    Public FolioNumber As String

    Private Sub Rate_Per_PeriodBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Rate_Per_PeriodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)
    End Sub

    Private Sub frmRatePerPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Rate_Type' table. You can move, or remove it, as needed.
        Me.Rate_TypeTableAdapter.Fill(Me.HotelDataSet.Rate_Type)
        Me.Rate_Per_PeriodTableAdapter.FillBy(Me.HotelDataSet.Rate_Per_Period, FolioNumber)
    End Sub

    Private Sub Rate_Per_PeriodBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rate_Per_PeriodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rate_Per_PeriodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)
    End Sub

    Private Sub Rate_Per_PeriodDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Rate_Per_PeriodDataGridView.DefaultValuesNeeded
        With e.Row
            .Cells(0).Value = FolioNumber
        End With
    End Sub
End Class