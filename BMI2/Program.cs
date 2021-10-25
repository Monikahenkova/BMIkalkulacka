using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Výpočet BMI");
         Console.WriteLine("****************");
         Console.WriteLine("Zadej váhu v kg:");
         float váha = float.Parse(Console.ReadLine());
         Console.WriteLine("Zadej výšku m:");
         float výška = float.Parse(Console.ReadLine());
         float BMI = váha / (výška * výška);
         Console.WriteLine("Vypočítané BMI: " + BMI);
         Console.WriteLine(" Děkuji za použití BMI kalkulačky ");
         Console.ReadKey();
        }
            
    }
}

