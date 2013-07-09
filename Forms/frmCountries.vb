'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmCountries

    Private Sub CountriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CountriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub frmCountries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.Countries' table. You can move, or remove it, as needed.
        Me.CountriesTableAdapter.Fill(Me.HotelDataSet.Countries)

    End Sub
End Class