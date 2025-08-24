namespace GoRecipesApi.Models;

public class RecipeIngredient
{
    public int IngredientId { get; set; }
    public int RecipeId { get; set; }
    public string Ingredient { get; set; } = string.Empty;
    
    public Recipe? Recipe { get; set; }

}