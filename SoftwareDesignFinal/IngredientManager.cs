using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignFinal
{
    public class IngredientManager : IIngredientManager
    {
        private readonly IRecipeManager _recipeManager;

        public IngredientManager(IRecipeManager recipeManager)
        {
            _recipeManager = recipeManager;
        }

        public bool AddIngredient(string recipeName, string ingredient)
        {
            return _recipeManager.AddIngredient(recipeName, ingredient);
        }

        public List<string> GetIngredients(string recipeName)
        {
            return _recipeManager.GetIngredientsForRecipe(recipeName);
        }
    }
}
