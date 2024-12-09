using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignFinal
{
    public interface IIngredientManager
    {
        bool AddIngredient(string recipeName, string ingredient);
        List<string> GetIngredients(string recipeName);
    }
}
