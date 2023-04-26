using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    internal class AddNewRecipe
    {
        public void NewRecipe()
        {
            string recipeName = "";
            int numIngredients = 0;
            string[] ingredientNames = new string[numIngredients];
            double[] ingredientQuantities = new double[numIngredients];
            string[] ingredientUnits = new string[numIngredients];
            int numSteps = 0;
            string[] steps = new string[numSteps];

            while (true)
            {
                Console.WriteLine("\nEnter '1' to enter a new recipe.");
                Console.WriteLine("Enter '2' to scale the recipe.");
                Console.WriteLine("Enter '3' to reset the recipe to its original quantities.");
                Console.WriteLine("Enter '4' to clear all the data and enter a new recipe.");
                Console.WriteLine("Enter '5' to exit the program.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter the name of the recipe: ");
                        recipeName = Console.ReadLine();

                        Console.Write("Enter the number of ingredients: ");
                        numIngredients = int.Parse(Console.ReadLine());

                        // Move array initialization code here
                        ingredientNames = new string[numIngredients];
                        ingredientQuantities = new double[numIngredients];
                        ingredientUnits = new string[numIngredients];

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
                        numSteps = int.Parse(Console.ReadLine());

                        steps = new string[numSteps];

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
                        break;

                }
            }
        }
    }

}