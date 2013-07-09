'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmRateType

    Private Sub Rate_TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rate_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rate_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmRateType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Rate_Type' table. You can move, or remove it, as needed.
        Me.Rate_TypeTableAdapter.Fill(Me.HotelDataSet.Rate_Type)

    End Sub
End Class