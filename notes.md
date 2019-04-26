1. _Lightning exercise_- dictionary representing a sandwich
1. Create a class that represents a sandwich - Start with public properties - Talk about constructor methods - [Talk about getters and setters](http://johnstejskal.com/wp/getters-setters-and-auto-properties-in-c-explained-get-set/)

```C#
public string breadType {
            get{
                return breadType;
            }
            set{
                breadType = value;
            }
        }

```

1. Create a few specific instances of sandwiches
1. Put them in a list
1. _Lightning exercise_- have them build a class representing a customer
1. Give customers a favorite sandwich property of type sandwich
1. Give customers an eatSandwich method that takes in a parameter of a type of sandwich, write something to the console about what a delicious sandwich it is!
1. Add a conditional to check to see if it's their favorite sandwich? 1._Lighting Exercise_ - have them build an `addRewardsPoints` method to their customer class
1. Talk about access modifiers

   - Make `numberOfCalories` private to the sandwich class. Try to get it or set it in program.

   ```c#
     public int getTotalCalories(int servingSize)
       {
           return servingSize * caloriesPerServing;
       }
   ```

   ```c#
   namespace classes
   {

    class Sandwich
    {

        public Sandwich(int calories)
        {
            caloriesPerServing = calories;
        }
        public string breadType {
            get{
                return breadType;
            }
            set{
                breadType = value;
            }
        }
        public double price {get; set;}

        private int caloriesPerServing {get; set;}

        public int getTotalCalories(int servingSize)
        {
            return servingSize * caloriesPerServing;
        }
    }

}

```
