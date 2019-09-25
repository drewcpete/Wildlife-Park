using System;
using System.Collections.Generic;
using System.Linq;
using Park;

namespace Park 
{
    public class Program
    {
        public static void Main()
        {
            List<Animal> Animals = new List <Animal>(0);
            AddAnimal(Animals);
        
            }
            
            
            public static void AddAnimal(List<Animal> Animals)
            {
             Console.WriteLine("Do you want an add animal?");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                Console.WriteLine("Whats the animals name?");
                string aname = Console.ReadLine();

                Console.WriteLine("Whats the animals age?");
                int aage = int.Parse(Console.ReadLine());

                Console.WriteLine("Whats the animals?");
                string atype = Console.ReadLine();

                Console.WriteLine("Animals favorite food?");
                string afavFood = Console.ReadLine();
                
               
            
             
                Animal newOne = new Animal(aname,aage, atype,afavFood);
                Animals.Add(newOne);

                foreach(Animal item in Animals)
                {
                    Console.WriteLine(item.Name);
                }
            }
            AddAnimal(Animals);
            }
            
        
    }
    
}