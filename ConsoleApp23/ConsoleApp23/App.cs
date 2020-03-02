using System;
namespace ConsoleApp23
{
    public class App
    {

        //Animals
        class Animal
        {
            private string animalName;
            private int lengthOfTime;
            private string unitsOfTime;

            public Animal()
            {
                lengthOfTime = 0;
                unitsOfTime = "seconds";
                animalName = "animal";
            }

            public Animal(int lengthOfTime, string unitsOfTime)
            {
                this.lengthOfTime = lengthOfTime;
                this.unitsOfTime = unitsOfTime;
                this.animalName = animalName;
            }
            public void Breathe()
            {
                Console.WriteLine($"The {animalName} exchanges oxygen for carbon dioxide");
            }

            public void Eat()
            {
                Console.WriteLine($"The {animalName} masticates and digests food");
            }

            public void Live()
            {
                Console.WriteLine($"The {animalName} lives { lengthOfTime } { unitsOfTime }");
            }
        }
        //Vertibrates
        class Vertibrate : Animal { }
        //Reptiles
        class GreenAnole : Vertibrate { }

        //Birds
        class Bird : Vertibrate { }
        class Penguin : Bird { }

        //Mammals
        class Mammal : Vertibrate { }
        //Domestic
        class DomesticMammal : Mammal { }

        class DomesticCat : DomesticMammal { }

        class Dog : DomesticMammal { }

        class Cow : DomesticMammal { }

        class Horse : DomesticMammal { }

        class Human : DomesticMammal { }

        //non-domestic
        class WildMammal : Mammal { }

        class Platypus : WildMammal { }
        class JapaneseCat : WildMammal { }

        public void Run()
        {

        }


    }
}
