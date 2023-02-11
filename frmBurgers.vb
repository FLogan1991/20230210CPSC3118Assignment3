Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True

        If btnSelectMeal.Enabled = False Then
            btnSelectMeal.Enabled = True
        End If

        If picVeggie.Visible = True Then
            picVeggie.Visible = False
        End If
    End Sub
    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True

        If btnSelectMeal.Enabled = False Then
            btnSelectMeal.Enabled = True
        End If

        If picPrime.Visible = True Then
            picPrime.Visible = False
        End If

    End Sub
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click

        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = True
        lblInstructions.Visible = False
        lblConfirmation.Visible = True

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
