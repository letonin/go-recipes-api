namespace GoRecipesApi.Models;

public class Recipe
{
    public int RecipeId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreationDate { get; set; }

    public int PreparationTime { get; set; } // in minutes

    public decimal? Rating { get; set; }
    
    public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
    
    public ICollection<RecipeStep> Steps { get; set; } = new List<RecipeStep>();

}
