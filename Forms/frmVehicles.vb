'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmVehicles

    Private Sub VehiclesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiclesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiclesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmVehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Vehicles' table. You can move, or remove it, as needed.
        Me.VehiclesTableAdapter.Fill(Me.HotelDataSet.Vehicles)

    End Sub
End Class