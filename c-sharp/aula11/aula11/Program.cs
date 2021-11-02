using System;
using System.Collections.Generic;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> carros = new List<string>();

            
            carros.Add("Pegeout");
            carros.Add("Honda");
            carros.Add("Corolla");

            foreach(string c in carros)
            {
                Console.WriteLine($"Carro: {c}");
            }

            Console.ReadKey();
        }
    }
}
