using GoRecipesApi.Models;

namespace GoRecipesApi.Dtos;

public class RecipeDto
{
    public int RecipeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public int PreparationTime { get; set; }
    public decimal Rating { get; set; }
    public ICollection<RecipeIngredientDto> Ingredients { get; set; } = new List<RecipeIngredientDto>();
    public ICollection<RecipeStepDto> Steps { get; set; } = new List<RecipeStepDto>();
}
