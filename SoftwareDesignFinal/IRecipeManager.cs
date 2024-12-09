using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignFinal
{
    public interface IRecipeManager
    {
        bool AddRecipe(string recipeName);
        bool AddIngredient(string recipeName, string ingredient);
        List<string> GetIngredientsForRecipe(string recipeName);
        Task<List<string>> GetAllRecipesAsync();
    }
}
