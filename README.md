# Recipe_App

The class with the main method 

This program is a recipe application that allows users to enter the name of a recipe, the number of ingredients, the quantity and unit of each ingredient, and the steps required to make the recipe. It then prints out the recipe details, including the name of the recipe, the ingredients with their respective quantities and units, and the steps required to make the recipe.

To run this program, you will need to have Microsoft Visual Studio or a similar development environment installed on your computer. Once you have the development environment set up, you can follow these steps to run the program:

Open the Recipe_App solution file in your development environment.
Build the solution to compile the code.
Run the program by clicking the Run button in the development environment.
The program will prompt you to enter the name of the recipe, the number of ingredients, and the details of each ingredient, including the quantity and unit of measurement.
After you have entered the details of the ingredients, the program will prompt you to enter the number of steps required to make the recipe, followed by the details of each step.
Once you have entered all the required details, the program will print out the recipe details, including the name of the recipe, the ingredients with their respective quantities and units, and the steps required to make the recipe.
You can then close the program by pressing any key.

The ScaleRecipe class

This program defines a class ScaleRecipe with a method RecipeScaler() that allows the user to input recipe details, such as the name of the recipe, the number of ingredients, the names and quantities of the ingredients, and the steps to follow. The program then displays the recipe details, and offers the user the option to scale the recipe by a factor of 0.5, 2, or 3.

Here is a breakdown of the program's main components:

The program starts by importing the System namespace.
The ScaleRecipe class is defined as an internal class with a single method RecipeScaler().
The RecipeScaler() method uses a try-catch-finally block to handle any potential exceptions.
Within the RecipeScaler() method, the program prompts the user to enter the name of the recipe and the number of ingredients, and then creates arrays to store the names, quantities, and units of measurement for each ingredient.
The program then prompts the user to enter the name, quantity, and unit of measurement for each ingredient, and stores this information in the appropriate arrays.
The program then prompts the user to enter the number of steps in the recipe, and creates an array to store each step.
The program prompts the user to enter each step of the recipe and stores this information in the steps array.
The program then displays the recipe details, including the name, ingredients, and steps.
The program then prompts the user to enter whether or not they want to scale the recipe.
If the user chooses to scale the recipe, the program prompts the user to enter the scale factor and displays the recipe details with scaled quantities for each ingredient.
If the user enters an invalid input format or encounters any other exceptions, the program will display an error message.
Finally, the program waits for the user to press a key before terminating.
