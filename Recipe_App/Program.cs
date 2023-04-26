using System;

namespace Recipe_App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Recipe_App.ScaleRecipe recipe = new Recipe_App.ScaleRecipe();
                recipe.RecipeScaler();
                Recipe_App.ResetToOriginalVal reset = new Recipe_App.ResetToOriginalVal();
                reset.resetValues();
                Recipe_App.AddNewRecipe newrecipe = new Recipe_App.AddNewRecipe();
                newrecipe.NewRecipe();

                Console.Title = "Recipe Application";
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

                    while (true)
                    {
                        try
                        {
                            Console.Write($"Enter the quantity of {ingredientNames[i]}: ");
                            ingredientQuantities[i] = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }

                    Console.Write($"Enter the unit of measurement for {ingredientNames[i]}: ");
                    ingredientUnits[i] = Console.ReadLine();
                }

                Console.Write("Enter the number of steps: ");

                while (true)
                {
                    try
                    {
                        int numSteps = int.Parse(Console.ReadLine());
                        string[] steps = new string[numSteps];

                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.Write($"Enter step {i + 1}: ");
                            steps[i] = Console.ReadLine();
                        }

                        PrintRecipeDetails(recipeName, ingredientNames, ingredientQuantities, ingredientUnits, steps);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadKey();
        }

        private static void PrintRecipeDetails(string recipeName, string[] ingredientNames, double[] ingredientQuantities, string[] ingredientUnits, string[] steps)
        {
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine($"Name: {recipeName}");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {ingredientUnits[i]} {ingredientNames[i]}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }
}
