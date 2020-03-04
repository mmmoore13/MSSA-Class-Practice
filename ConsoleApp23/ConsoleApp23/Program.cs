using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp23
{
    #region
    //class Animal
    //{
    //    protected readonly string animalName;
    //    private int lengthOfTime;
    //    private string unitsOfTime;

    //    public Animal()
    //    {
    //        lengthOfTime = 0;
    //        unitsOfTime = "seconds";
    //        animalName = "animal";
    //    }

    //    public Animal(int lengthOfTime, string unitsOfTime)
    //    {
    //        this.lengthOfTime = lengthOfTime;
    //        this.unitsOfTime = unitsOfTime;
    //        this.animalName = animalName;
    //    }
    //    public virtual void Breathe()
    //    {
    //        Console.WriteLine($"The {animalName} exchanges oxygen for carbon dioxide");
    //    }

    //    public void Eat()
    //    {
    //        Console.WriteLine($"The {animalName} masticates and digests food");
    //    }

    //    public void Live()
    //    {
    //        Console.WriteLine($"The {animalName} lives { lengthOfTime } { unitsOfTime }");
    //    }
    //}
    ////Vertibrates
    //class Vertibrate : Animal
    //{
    //    public override void Breathe()
    //    {
    //        Console.WriteLine($"The vertibrate, { animalName } breathes through it's lungs.");
    //    }
    //}
    ////Reptiles
    //class GreenAnole : Vertibrate { }

    ////Birds
    //class Bird : Vertibrate { }
    //class Penguin : Bird { }

    ////Mammals
    //class Mammal : Vertibrate { }
    ////Domestic
    //class DomesticMammal : Mammal { }

    //class DomesticCat : DomesticMammal { }

    //class Dog : DomesticMammal { }

    //class Cow : DomesticMammal { }

    //class Horse : DomesticMammal { }

    //class Human : DomesticMammal { }

    ////non-domestic
    //class WildMammal : Mammal { }

    //class Platypus : WildMammal { }
    //class JapaneseCat : WildMammal { }

    //class Invertibrate : Animal
    //{
    //    protected readonly string animalName;
    //    private int lengthOfTime;
    //    private string unitsOfTime;


    //    public Invertibrate(int lengthOfTime, string unitsOfTime, string animalName)
    //    {
    //        this.lengthOfTime = lengthOfTime;
    //        this.unitsOfTime = unitsOfTime;
    //        this.animalName = animalName;
    //    }
    //}

    //class Insect : Invertibrate
    //{
    //    public Insect(int lengthOfTime, string unitsOfTime, string animalName)
    //        : base(lengthOfTime: lengthOfTime, unitsOfTime: unitsOfTime, animalName: animalName)
    //    {

    //    }

    //    public override void Breathe()
    //    {
    //        Console.WriteLine($"The { animalName }");
    //    }
    //}

    //class Fly : Insect { }
    #endregion

    class OutputStream
    {
        public void StreamType()
        {
            Console.WriteLine("Outputstream");
        }

        public virtual void PrintLine(string s)
        {
            Console.WriteLine($"Default called: {s}");
        }
    }

    class NullStream : OutputStream
    {
        public override void PrintLine(string s)
        {
            ;
        }
    }

    class ConsoleStream : OutputStream
    {
        public override void PrintLine(string s)
        {
            base.PrintLine(s);
        }
    }

    class FileStream :

    class Program
    {
        static void UseAnOutputStream(OutputStream stream)
        {
            stream.StreamType();
            for (int i = 0; i < 10; i++)
            {
                stream.PrintLine($"{i}");
            }
        }


        static void Main(string[] args)
        {
            #region
            //List<Animal> animals = new List<Animal>();

            //animals.Add(new Fly());
            //animals.Add(new Horse());

            //foreach (Animal in animals)
            //{
            //    Animal.Breathe();

            //}


            //Fly fly = new Fly();
            //fly.Breathe();
            //fly.Eat();
            //fly.Live();

            //Horse horse = new Horse();
            //horse.Breathe();
            //horse.Eat();
            //horse.Live();
            #endregion
            OutputStream out1 = new OutputStream();
            NullStream out2 = new NullStream();
            ConsoleStream out3 = new ConsoleStream();
            FileStream out4 = new FileStream("outputfile");

        }

    }
    static class Util
    {
        public static void Ambulate(this int i)
        {
            Console.WriteLine($"The );
            }
    }
}
