'Name: Nathan Emmrich
'Course: CS 146 01 WI24
'Instructor: Beyers
'Date: 03/24/2024
'Summary: This program displays a list of recipe ingredients everytime a recipe button is clicked. The array that holds all ingredient information is resized every time a button is clicked.

Public Class frmLab29
    Private Sub btnRecip1_Click(sender As Object, e As EventArgs) Handles btnRecip1.Click
        'Declare local array variable
        Dim recipeList1 As String()
        'assign recipe ingredients to recipeList
        recipeList1 = {"2 tbsp brown sugar", "1 tbsp prepared mustard", "1-1/2 tbsp worcestershire sauce",
            "1 tube (12 oz) refrigerated buttermilk biscuits", "1/2 cup cubed Velveeta"}

        'call on the subroutine
        showIngredients(recipeList1)
    End Sub

    Private Sub btnRecip2_Click(sender As Object, e As EventArgs) Handles btnRecip2.Click
        'Declare local array variable
        Dim recipeList2 As String()
        'assign recipe ingredients to recipeList
        recipeList2 = {"8 oz Italian turkey sausage links", "2 cups whole fresh mushrooms",
            "2 cups cherry tomatoes", "1 medium onion, cut into 1-inch pieces",
            "1 green bell pepper, cut into 1-inch pieces", "30 slices turkey pepperoni (2 oz)",
            "1 tube (13.8 oz) refrigerated pizza crust", "1-1/2 cups shredded part-skim mozzarella cheese",
            "1-1/4 cups pizza sauce, warmed"}

        'call on subroutine
        showIngredients(recipeList2)
    End Sub

    Private Sub btnRecip3_Click(sender As Object, e As EventArgs) Handles btnRecip3.Click
        'Declare local array variable
        Dim recipeList3 As String()
        'assign recipe ingredients to recipeList
        recipeList3 = {"1/4 cup creamy peanut butter", "1/4 cup grape jelly OR jelly of your choice",
            "8 slices sandwich bread", "2 large eggs", "1/4 cup 2% milk", "2 tbsp butter",
            "sliced fresh strawberries AND chopped salted peanuts (optional)", "confectioners sugar OR maple syrup"}

        'call on subroutine
        showIngredients(recipeList3)
    End Sub

    Private Sub showIngredients(ByVal recipeList() As String)
        'clear the listbox every time sub is called
        lstIngredients.Items.Clear()

        'for each item in recipeList, add the ingredient to the listbox
        For Each ingredient As String In recipeList
            lstIngredients.Items.Add(ingredient)
        Next
    End Sub
End Class
