' Name:        Jacket Problem
' Purpose:     Display different colored jackets  
' Programmer:  Joshua Keoshkerian on 9/22/2022

Public Class frmMain
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picChart.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        ' Display the Black Jacket

        picJacket.Image = My.Resources.BlackJacket
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        ' Display the Blue Jacket

        picJacket.Image = My.Resources.BlueJacket

    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        ' Display the Brown Jacket

        picJacket.Image = My.Resources.BrownJacket

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        ' Display the Red Jacket

        picJacket.Image = My.Resources.RedJacket

    End Sub
End Class
