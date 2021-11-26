using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string peso = "";
            string altura = "";

            Console.WriteLine("Por favor digite su peso(kg): ");
            peso = Console.ReadLine();
            Console.WriteLine("Por favor digite su altura (en metros y use coma no punto):  ");
            altura = Console.ReadLine();

            double peso1 = double.Parse(peso);
            double altura1 = double.Parse(altura);

            double imcorporal = peso1 / ((Math.Pow(altura1, 2)) );

            if (imcorporal < 16 ){
                Console.WriteLine($"Delgadez es severa, su IMC es: {imcorporal}");
            }else if (imcorporal >= 16 & imcorporal < 16.99 ){
                Console.WriteLine($"Delgadez es moderada, su IMC es: {imcorporal}");
            }else if (imcorporal >= 17 & imcorporal < 18.49 ){
                Console.WriteLine($"Delgadez es aceptable, su IMC es: {imcorporal}");
            }else if (imcorporal >= 18.5 & imcorporal < 24.99 ){
                Console.WriteLine($"Peso normal, su IMC es: {imcorporal}");
            }else if (imcorporal >= 25 & imcorporal < 29.99 ){
                Console.WriteLine($"Sobrepeso, su IMC es: {imcorporal}");
            }else if (imcorporal >= 30 & imcorporal < 34.99 ){
                Console.WriteLine($"Obesidad tipo 1, su IMC es: {imcorporal}");
            }else if (imcorporal >= 35 & imcorporal < 39.99 ){
                Console.WriteLine($"Obesidad tipo 2, su IMC es: {imcorporal}");
            }else if (imcorporal >= 40 & imcorporal < 49.99 ){
                Console.WriteLine($"Obesidad tipo 3 o morbida, su IMC es: {imcorporal}");
            }else if (imcorporal > 50 ){
                Console.WriteLine($"Obesidad tipo 4 o extrema, su IMC es: {imcorporal}");
            }

        }
    }
}
