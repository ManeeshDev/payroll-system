Public Class frmSalary

    Private Sub frmSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Ans As String

        Ans = MsgBox("Do you Want to Exit?", vbYesNo + vbQuestion, "Close Form")

        If Ans = vbYes Then
            Me.Hide()
            frmLogin.Show()
            End
        End If
    End Sub

    Private Sub btnPrces_Click(sender As Object, e As EventArgs) Handles btnPrces.Click
        If txtEmpId.Text <> "" And txtEmpName.Text <> "" And txtBSal.Text <> "" And txtSalAdvnc.Text <> "" And txtOtH.Text <> "" Then
            txtOtR.Text = Math.Round(Val(((txtBSal.Text) * 8) / 240), 2, MidpointRounding.AwayFromZero)
            txtOtA.Text = Math.Round(Val((txtOtR.Text) * Val(txtOtH.Text)), 2, MidpointRounding.AwayFromZero)
            txtNtSalary.Text = Math.Round(Val((txtBSal.Text) + Val(txtOtA.Text) - Val(txtSalAdvnc.Text)), 2, MidpointRounding.AwayFromZero)
        Else
            MsgBox("Every field is required.", MsgBoxStyle.Critical, "Sorry.!!")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim Ans As String

        If txtEmpId.Text <> "" Or txtEmpName.Text <> "" Or txtBSal.Text <> "" Or txtSalAdvnc.Text <> "" Or txtOtH.Text <> "" Or txtOtR.Text <> "" Or txtOtA.Text <> "" Or txtNtSalary.Text <> "" Then
            Ans = MsgBox("Do you Want to Clear?", vbYesNo + vbQuestion, "Clear Form")

            If Ans = vbYes Then
                txtEmpId.Text = ""
                txtEmpName.Text = ""
                txtBSal.Text = ""
                txtSalAdvnc.Text = ""
                txtOtH.Text = ""
                txtOtR.Text = ""
                txtOtA.Text = ""
                txtNtSalary.Text = ""
            End If
        End If
    End Sub



End Class