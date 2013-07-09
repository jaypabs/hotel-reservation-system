'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmRoomType

    Private Sub Room_TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Room_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Room_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmRoomType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Room_Type' table. You can move, or remove it, as needed.
        Me.Room_TypeTableAdapter.Fill(Me.HotelDataSet.Room_Type)

    End Sub
End Class