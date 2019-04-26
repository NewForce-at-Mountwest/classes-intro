using System;

namespace classes {
        class Customer{

            public Customer(string firstNameParam, string lastNameParam, string emailParam){
                FirstName = firstNameParam;
                LastName = lastNameParam;
                Email = emailParam;
            }

        public string FirstName {get; set;}
        public string LastName {get; set;}

       public int RewardsPoints {get; set;}

       public string Email {get; set; }

       public Sandwich favoriteSandwich {get; set;}

       public void eatSandwich(Sandwich sandwichToEat){
           if(sandwichToEat.name == favoriteSandwich.name){
               Console.WriteLine("Delcious sandwich!! Wow!!");
           } else {
               Console.WriteLine("That sandwich sucked");
           }
       }

       public void addRewardsPoints(int pointsToAdd){
           RewardsPoints += pointsToAdd;
           Console.WriteLine(RewardsPoints);
       }


    }
}