﻿using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Entre com o numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("Escolheu Javascript!");
                    break;
                case 2:
                    Console.WriteLine("Escolheu HTML!");
                    break;
                case 3:
                    Console.WriteLine("Escolheu CSS!");
                    break;
                case 4:
                    Console.WriteLine("Escolheu C#!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
