'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmRoomStatus

    Private Sub Room_StatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Room_StatusBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Room_StatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmRoomStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Room_Status' table. You can move, or remove it, as needed.
        Me.Room_StatusTableAdapter.Fill(Me.HotelDataSet.Room_Status)

    End Sub
End Class