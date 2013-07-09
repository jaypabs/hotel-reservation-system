'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://www.sourcecodester.com
'---------------------------------------

Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombobox(cboUser, "SELECT * FROM Users", "Users", "UserID", "PK")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If cboUser.Text = "" Then cboUser.Focus() : Exit Sub

        If txtPass.Text = "" Then txtPass.Focus() : Exit Sub

        Dim strPass As String

        strPass = GetFieldValue("SELECT PK,Password FROM Users WHERE PK=" & cboUser.SelectedValue, "Password")
        'strPass = Enc.DecryptString(strPass)

        If LCase(txtPass.Text) = LCase(strPass) Then
            With CurrUser
                .USER_NAME = cboUser.Text
                .USER_PK = CInt(cboUser.SelectedValue)
                .USER_ISADMIN = CBool(changeYNValue(GetFieldValue("SELECT PK,Admin FROM Users WHERE PK=" & cboUser.SelectedValue, "Admin")))
            End With

            Dim MainForm As New mdiMain

            MainForm.Show()
        Else
            MsgBox("Invalid password.Please try again!", MsgBoxStyle.Exclamation)
            txtPass.Focus()
        End If

        strPass = vbNullString
    End Sub

    Private Sub txtPass_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Enter
        HLText(txtPass)
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        txtPass.SelectionStart = Len(txtPass.Text)
    End Sub
End Class