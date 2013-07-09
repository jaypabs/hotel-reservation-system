'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Imports System.Data.OleDb

Module modProcedure
    Public Sub FillListView(ByRef lvList As ListView, ByRef myData As OleDbDataReader)
        Dim itmListItem As ListViewItem

        Dim strValue As String

        Do While myData.Read
            itmListItem = New ListViewItem()
            strValue = IIf(myData.IsDBNull(0), "", myData.GetValue(0))
            itmListItem.Text = strValue

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetValue(shtCntr))
                End If
            Next shtCntr

            lvList.Items.Add(itmListItem)
        Loop
    End Sub

    Public Sub FillCombobox(ByVal cboCombo As ComboBox, ByVal sSQL As String, ByVal strTable As String, ByVal strDisplayMember As String, ByVal strValueMember As String)
        Dim cnHotel As OleDbConnection
        cnHotel = New OleDbConnection

        Try
            With cnHotel
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sSQL, cnHotel)
            Dim dt As New DataSet

            da.Fill(dt, strTable)

            cboCombo.DataSource = dt.Tables(strTable).DefaultView
            cboCombo.DisplayMember = strDisplayMember
            cboCombo.ValueMember = strValueMember
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnHotel.Close()
        End Try
    End Sub

    'Procedure used to highlight text when focus
    Public Sub HLText(ByRef sText As Object)
        On Error Resume Next
        With sText
            .SelStart = 0
            .SelLength = Len(sText.Text)
        End With
    End Sub
End Module
