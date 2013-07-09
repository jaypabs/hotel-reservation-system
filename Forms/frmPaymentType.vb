'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmPaymentType

    Private Sub Payment_TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Payment_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Payment_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmPaymentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Payment_Type' table. You can move, or remove it, as needed.
        Me.Payment_TypeTableAdapter.Fill(Me.HotelDataSet.Payment_Type)

    End Sub
End Class