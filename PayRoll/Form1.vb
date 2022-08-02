Public Class frmLogin

    Private Const UName As String = "admin"
    Private Const UPassword As String = "admin123"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUname.Focus()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If txtUname.Text = UName And txtPass.Text = UPassword Then
            Me.Hide()
            frmSalary.Show()
        Else
            MsgBox("Invalid details.", MsgBoxStyle.Critical, "Sorry.!!")
            txtUname.Clear()
            txtPass.Clear()
            txtUname.Focus()
        End If

    End Sub

    Private Sub btnCnsl_Click(sender As Object, e As EventArgs) Handles btnCnsl.Click
        End
    End Sub


    Private Sub txtLPass_click(sender As Object, e As EventArgs) Handles txtLPass.Click
        txtLPass.Hide()
        txtPass.Show()
        txtPass.Focus()
    End Sub

    Private Sub txtLUName_Click(sender As Object, e As EventArgs) Handles txtLUName.Click
        txtLUName.Hide()
        txtUname.Show()
        txtUname.Focus()
    End Sub

    Private Sub frmLogin_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtLUName.Show()
        txtUname.Hide()
        txtLPass.Show()
        txtPass.Hide()
    End Sub


End Class
