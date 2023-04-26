using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Recipe_App
{
    internal class scaleRecipe
    {
        public static void ScaleRecipe()
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();

            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            string[] ingredientNames = new string[numIngredients];
            double[] ingredientQuantities = new double[numIngredients];
            string[] ingredientUnits = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                ingredientNames[i] = Console.ReadLine();

                Console.Write($"Enter the quantity of {ingredientNames[i]}: ");
                ingredientQuantities[i] = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {ingredientNames[i]}: ");
                ingredientUnits[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            string[] steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }

            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine($"Name: {recipeName}");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {ingredientUnits[i]} {ingredientNames[i]}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }

            Console.WriteLine("\nDo you want to scale the recipe? (Y/N)");
            string scaleRecipe = Console.ReadLine();

            if (scaleRecipe.ToLower() == "y")
            {
                Console.WriteLine("Enter the scale factor (0.5, 2, or 3):");
                double scaleFactor = double.Parse(Console.ReadLine());

                Console.WriteLine("\nScaled Recipe Details:");
                Console.WriteLine($"Name: {recipeName}");

                Console.WriteLine("Ingredients:");
                for (int i = 0; i < numIngredients; i++)
                {
                    double scaledQuantity = ingredientQuantities[i] * scaleFactor;
                    Console.WriteLine($"{scaledQuantity} {ingredientUnits[i]} {ingredientNames[i]}");
                }

                Console.WriteLine("Steps:");
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"{i + 1}. {steps[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
*/
