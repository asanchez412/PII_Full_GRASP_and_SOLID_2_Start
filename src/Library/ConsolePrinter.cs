using System;

// se agrega esta clase con el fin de seguir el principio SRP

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipes(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }

    }
}