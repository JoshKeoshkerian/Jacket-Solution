Option Infer On
Option Explicit On
Option Strict Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intAmountDue As Double
        Dim YourMom As Double

        intAmountDue = (Val(txtBlack.Text) * 45.99) + (Val(txtNavy.Text) * 39.99) + (Val(txtRed.Text) * 39.99)

        YourMom = intAmountDue

        If chkCard.Checked = True Then
            intAmountDue = intAmountDue * 0.9
        End If

        If Val(txtBlack.Text) + Val(txtNavy.Text) + Val(txtRed.Text) >= 2 Then
            intAmountDue = intAmountDue * 0.95
        End If

        lblTotalOrdered.Text = Val(txtBlack.Text) + Val(txtNavy.Text) + Val(txtRed.Text)

        lblTotalDue.Text = intAmountDue.ToString("C2")

        lblMoneySaved.Text = (YourMom - intAmountDue).ToString("C2")
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtBlack_TextChanged(sender As Object, e As EventArgs) Handles txtBlack.TextChanged, txtNavy.TextChanged, txtRed.TextChanged
        lblMoneySaved.Text = ""
        lblTotalDue.Text = ""
        lblTotalOrdered.Text = ""
    End Sub

    Private Sub chkCard_CheckedChanged(sender As Object, e As EventArgs) Handles chkCard.CheckedChanged
        lblMoneySaved.Text = ""
        lblTotalDue.Text = ""
        lblTotalOrdered.Text = ""
    End Sub

    Private Sub txtBlack_Enter(sender As Object, e As EventArgs) Handles txtBlack.Enter, txtNavy.Enter, txtRed.Enter
        txtBlack.SelectAll()
        txtRed.SelectAll()
        txtNavy.SelectAll()
    End Sub
End Class
