namespace GoRecipesApi.Models;

public class RecipeStep
{
    public int StepId { get; set; }
    public int RecipeId { get; set; }
    public int StepNumber { get; set; }
    public string StepDescription { get; set; } = string.Empty;
    
    public Recipe? Recipe { get; set; }

}