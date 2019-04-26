using System;
using System.Collections.Generic;

namespace classes {
        class Sandwich{

        public Sandwich(string nameParam, double priceParam, int calorieParam){
            name = nameParam;
            price = priceParam;
            _caloriesPerServing = calorieParam;
        }

        public string name {get;}
        public string breadType {get; set;}

        public double price {get; set;}

        private int _caloriesPerServing {get; set;}

        public void getTotalCalories(int numberOfServings){
            int totalCalories = _caloriesPerServing*numberOfServings;
            Console.WriteLine($"This is total calories: {totalCalories}");
        }

        public List<String> IngredientList {get; set;}
    }
}