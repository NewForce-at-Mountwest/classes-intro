using System;
using System.Collections.Generic;

namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {

            // Lightning Exercise One

            // 1.  Create a new dictionary to represent a sandwich. The dictionary should store the follow data:
            //     - Bread type
            //     - Price
            //     - Number of calories
            //     - A comma-seperated, stringified list of ingridients
            // Dictionary<string, string> sandwich = new Dictionary<string, string>(){
            //     {"breadType", "wheat"},
            //     {"price", "7.99"}
            // };

            // sandwich.Add("numberOfCalories", "400");
            // sandwich.Add("ingredientList", "Pickles, Turkey, Cheese");

            Sandwich tuna = new Sandwich("Tuna", 6.99, 150);
            tuna.breadType = "pumpernickel";
            tuna.getTotalCalories(4);



            tuna.IngredientList = new List<string>(){
                "Tuna",
                "Pickles",
                "Lettuce",
                "Cucumber"
            };

            Sandwich rueben = new Sandwich("Rueben", 9.99, 250);
            rueben.breadType = "white";


            List<Sandwich> sandwichList = new List<Sandwich>(){
                tuna,
                rueben
            };

            sandwichList.ForEach(sandwich => Console.WriteLine(sandwich.breadType));

            Customer Tommy = new Customer("Tommy", "Spurlock", "tommy@t.com"){
                RewardsPoints = 1000,
                favoriteSandwich = rueben
            };

            Customer Josh = new Customer("Josh", "Havey", "josh@josh.com"){
                RewardsPoints = 4000,
                favoriteSandwich = tuna
            };

            Josh.eatSandwich(tuna);
            Tommy.eatSandwich(tuna);

            List<Customer> customerDataBase = new List<Customer>(){
                Josh,
                Tommy
            };

            Console.WriteLine(Josh.RewardsPoints);
            Josh.addRewardsPoints(100);


        }
    }
}
