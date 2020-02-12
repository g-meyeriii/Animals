using System;
using System.Collections.Generic;
using AnimalLibrary; // this allows the dog constructor to be found

namespace Animals {
    class Program {
           static void Main(string[] args) {
            // var germanSherperd = new AnimalLibrary.Dog(); can do it this way
            

            var bx1 = new Boxer("Cretos");
            var bx2 = new Boxer();
                   
            var pg1 = new Pug("Fluffy");
            var pg2 = new Pug("Roofus");
            var pg3 = new Pug();
                        
            var gs1 = new GermanSheperd("Killer");
            var germanSheperd = new GermanSheperd{
                LongTail = true,
                BarkPitch = BarkPitchType.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = false,
                Name = "Fred"

            };
            
            var pug = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchType.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"

            };
            //Below is a an example of polymorphism
            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(gs1);
            dogs.Add(pg1);
            dogs.Add(pg2);
            dogs.Add(pg3);
            dogs.Add(bx1);
            dogs.Add(bx2);

            foreach (var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());

            }
        }
    }
}
