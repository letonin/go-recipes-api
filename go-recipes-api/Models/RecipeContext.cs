using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoRecipesApi.Models;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> options)
        : base(options)
    {
    }

    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<RecipeStep> RecipeSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Recipe entity
        modelBuilder.Entity<Recipe>()
            .HasKey(r => r.RecipeId);

        // Configure RecipeIngredient entity
        modelBuilder.Entity<RecipeIngredient>()
            .HasKey(ri => ri.IngredientId);

        // Configure RecipeStep entity
        modelBuilder.Entity<RecipeStep>()
            .HasKey(rs => rs.StepId);
        
        // Configure relationships
        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Ingredients)
            .WithOne(i => i.Recipe)
            .HasForeignKey(i => i.RecipeId);

        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Steps)
            .WithOne(s => s.Recipe)
            .HasForeignKey(s => s.RecipeId);
    }

}