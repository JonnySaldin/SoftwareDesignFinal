using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignFinal
{
    public class RecipeManager : IRecipeManager
    {
        private Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>();

        public bool AddRecipe(string recipeName)
        {
            if (!recipes.ContainsKey(recipeName))
            {
                recipes[recipeName] = new List<string>();
                return true;
            }
            return false;
        }

        public bool AddIngredient(string recipeName, string ingredient)
        {
            if (recipes.ContainsKey(recipeName))
            {
                recipes[recipeName].Add(ingredient);
                return true;
            }
            return false;
        }

        public List<string> GetIngredientsForRecipe(string recipeName)
        {
            if (recipes.ContainsKey(recipeName))
            {
                return recipes[recipeName];
            }
            return new List<string>();
        }

        public async Task<List<string>> GetAllRecipesAsync()
        {
            await Task.Delay(500); // Simulate async operation
            return recipes.Keys.ToList();
        }
    }
}
