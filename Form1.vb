Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'The following steps calculate the percentage profit from the sale of a stock
        'Declare the variable item as string. Declare the variables regularPrice And discount as type Double.
        'Assign “ketchup” to the variable item.
        'Assign 1.80 to the variable regularPrice.
        'Assign 0.27 to the variable discount.
        'Display the phrase “RM1.53 is the sale of the ketchup”.
        Dim item As String = "ketchup"
        Dim regularPrice As Double = 1.8
        Dim discount As Double = 0.27
        Dim finalPrice, stockProfit As Double
        finalPrice = regularPrice - discount
        stockProfit = (finalPrice - regularPrice) / regularPrice

        Label1.Text = finalPrice.ToString("C") & " is the sale of the " & item & " with a stock profit of " & stockProfit.ToString("p0")


    End Sub
End Class
