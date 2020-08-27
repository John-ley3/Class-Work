using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
           //
            // OLD MACDONALD
            //
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            // Let's try singing about a Farm Animal
            FarmAnimal animal = new Horse();
            FarmAnimal bird = new Duck();
            FarmAnimal cow1 = new Cow("Bessie");
            FarmAnimal cow2 = new Cow("Angus");
            // Can we swap out any animal in place here?
            List<FarmAnimal> farmAnimals = new List<FarmAnimal>();
            farmAnimals.Add(animal);
            farmAnimals.Add(bird);
            farmAnimals.Add(cow1);
            farmAnimals.Add(cow2);
            Cat felix = new Cat();
            farmAnimals.Add(felix);
            felix.ToggleSleeping();
            animal.ToggleSleeping();
            bird.ToggleSleeping();

            foreach(FarmAnimal critter in farmAnimals)
            {
                if(critter.GetType() == typeof(Duck))
                {
                    Console.WriteLine(((Duck)critter).WhatSeason());
                }

                Console.WriteLine("And on his farm there was a " + critter.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + critter.MakeSoundTwice() + " here and a " + critter.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + critter.MakeSoundOnce() + ", there a " + critter.MakeSoundOnce() + " everywhere a " + critter.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
                Console.WriteLine($"{critter.Name} is eating by {critter.Eat()}");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh: Interfaces");

            // What if we wanted to sing about other things on the farm that were 
            // singable but not farm animals?
            // Can it be done? 
            Tractor tractor = new Tractor();
            List<ISingable> singables = new List<ISingable>();
            singables.Add(tractor);
            singables.AddRange(farmAnimals);
            Apple apple = new Apple("Red Delicious");
            singables.Add(apple);
            foreach(ISingable tunefull in singables)
            {
                Console.WriteLine("And on his farm there was a " + tunefull.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + tunefull.MakeSoundTwice() + " here and a " + tunefull.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + tunefull.MakeSoundOnce() + ", there a " + tunefull.MakeSoundOnce() + " everywhere a " + tunefull.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();

            }

            Console.WriteLine(apple);
            ISellable gd = new Apple("Golden Delicious");
            Console.WriteLine(gd);
            Console.WriteLine(((Duck)bird).GetSalesPrice());
            Console.WriteLine(((Duck)bird).WhatSeason());
            Console.ReadLine();
        }
    }
}