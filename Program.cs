using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<string> planetList = new List<string>(){"Mercury", "Mars"};


            //Add() Jupiter and Saturn at the end of the list

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

                    List<string> NewPlanetList = new List<string>() { "Uranus", "Neptune" };

                     planetList.AddRange(NewPlanetList);
                      planetList.Insert(2,"Earth");
                      planetList.Insert(3,"Venus");
                      planetList.Add("Pluto");

                    List<string> rockyPlanets = new List<string>();
                     rockyPlanets.AddRange(planetList.GetRange(0,2)); 
                     planetList.Remove("Pluto");
       


       //Practice: Random Numbers
//Instructions:
//Use the following code to create a list of random numbers. Each number will be between 0 and 5.


Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};

for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
  if(numbers.Contains(i))
  {
      Console.WriteLine($"the index number {i} is a random number");
  }
}

        }


    }
}
