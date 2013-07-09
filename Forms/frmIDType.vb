'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmIDType

    Private Sub ID_TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ID_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub IDType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.ID_Type' table. You can move, or remove it, as needed.
        Me.ID_TypeTableAdapter.Fill(Me.HotelDataSet.ID_Type)

    End Sub
End Class