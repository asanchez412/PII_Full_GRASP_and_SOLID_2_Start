using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class PrintRecipe
    {
        public static void PrintRecipes(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }

    }
}