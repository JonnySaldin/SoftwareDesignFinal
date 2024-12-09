using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignFinal
{
    public class LoggingRecipeManagerDecorator : IRecipeManager
    {
        private readonly IRecipeManager _innerRecipeManager;

        public LoggingRecipeManagerDecorator(IRecipeManager recipeManager)
        {
            _innerRecipeManager = recipeManager;
        }

        public bool AddRecipe(string recipeName)
        {
            Console.WriteLine($"Adding recipe: {recipeName}");
            return _innerRecipeManager.AddRecipe(recipeName);
        }

        public bool AddIngredient(string recipeName, string ingredient)
        {
            Console.WriteLine($"Adding ingredient '{ingredient}' to recipe '{recipeName}'");
            return _innerRecipeManager.AddIngredient(recipeName, ingredient);
        }

        public List<string> GetIngredientsForRecipe(string recipeName)
        {
            Console.WriteLine($"Fetching ingredients for recipe: {recipeName}");
            return _innerRecipeManager.GetIngredientsForRecipe(recipeName);
        }

        public async Task<List<string>> GetAllRecipesAsync()
        {
            Console.WriteLine("Fetching all recipes asynchronously.");
            return await _innerRecipeManager.GetAllRecipesAsync();
        }
    }
}
