'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmBusinessSource

    Private Sub Business_SourceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Business_SourceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Business_SourceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)
    End Sub

    Private Sub frmBusinessSource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Business_Source' table. You can move, or remove it, as needed.
        Me.Business_SourceTableAdapter.Fill(Me.HotelDataSet.Business_Source)
    End Sub

End Class