'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmChargeType

    Private Sub Charge_TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charge_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Charge_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmChargeType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Charge_Type' table. You can move, or remove it, as needed.
        Me.Charge_TypeTableAdapter.Fill(Me.HotelDataSet.Charge_Type)

    End Sub
End Class