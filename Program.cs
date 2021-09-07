using System;
using Inheritnace.Animals;

namespace AnimalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger luke = new Tiger { Name = "Luke", Furlength = 14 };
            Cat jerry = new Cat { Name = "Jerry", Furlength = 21};
            Dog buddy = new Dog { Name = "Buddy", Furlength = 13};
            Snake viper = new Snake { Name = "Viper"};


        Console.Write($"{luke.Name} speaks");
            luke.Roar();
        Console.Write($"{jerry.Name} speaks");
            jerry.Meow();
        Console.Write($"buddy.Name" speaks);
            buddy.Bark();
        Console.Write($"{viper.Name}");
            viper.Hiss();
        }
    }
}
