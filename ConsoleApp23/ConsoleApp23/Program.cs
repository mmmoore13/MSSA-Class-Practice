using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    class Animal
    {
        protected readonly string animalName;
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
        public virtual void Breathe()
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
    class Vertibrate : Animal
    {
        public override void Breathe()
        {
            Console.WriteLine($"The vertibrate, { animalName } breathes through it's lungs.");
        }
    }
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

    class Invertibrate : Animal
    {
        protected readonly string animalName;
        private int lengthOfTime;
        private string unitsOfTime;


        public Invertibrate(int lengthOfTime, string unitsOfTime, string animalName)
        {
            this.lengthOfTime = lengthOfTime;
            this.unitsOfTime = unitsOfTime;
            this.animalName = animalName;
        }
    }

    class Insect : Invertibrate
    {
        public Insect(int lengthOfTime, string unitsOfTime, string animalName)
            : base(lengthOfTime: lengthOfTime, unitsOfTime: unitsOfTime, animalName: animalName)
        {

        }

        public override void Breathe()
        {
            Console.WriteLine($"The { animalName }");
        }
    }

    class Fly : Insect { }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Fly());
            animals.Add(new Horse());

            foreach (Animal in animals)
            {
                Animal.Breathe();

            }


            Fly fly = new Fly();
            fly.Breathe();
            fly.Eat();
            fly.Live();

            Horse horse = new Horse();
            horse.Breathe();
            horse.Eat();
            horse.Live();
        }
    }
}
