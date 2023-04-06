'Name: Donut Project
'Purpose: 
'Programmer: Alison Vaughan

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain

    Private Sub CalcSubtotal(ByRef decSubtotalCost As Decimal)
        Select Case True
            Case radGlazed.Checked, radSugar.Checked
                decSubtotalCost = 1.05D
            Case radChocolate.Checked
                decSubtotalCost = 1.25D
            Case Else
                decSubtotalCost = 1.5D
        End Select

        Select Case True
            Case radRegular.Checked
                decSubtotalCost += 1.5D
            Case radCappuccino.Checked
                decSubtotalCost += 2.75D
        End Select
    End Sub

    Private Function GetSaleTax(ByVal decPurchase As Decimal) As Decimal
        Return decPurchase * 0.06D
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
    Dim decSubtotal As Decimal
    Dim decSalesTax As Decimal
    Dim decTotal As Decimal

    CalcSubtotal(decSubtotal)
    decSalesTax = GetSalesTax(decSubtotal)
    decSalesTax = Math.Round(decSubtotal)
    decTotal = decSubtotal + decSalesTax

    lblSubtotal.Text = decSubtotal.ToString("N2")
    lblSalestax.Text = decSalesTax.ToString("N2")
    lblTotal.Text = decTotal.ToString("N2")
End Sub

    Private Sub ClearOutput(sender As Object, e As EventArgs) Handles radCappuccino 

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

