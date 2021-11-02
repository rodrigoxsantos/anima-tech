using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 7;
            String[] semana = new string[quantidade];

         
            Console.WriteLine("| Dias da semana |");
        

            semana[0] = "Domingo";
            semana[1] = "Segunda";
            semana[2] = "Terça";
            semana[3] = "Quarta";
            semana[4] = "Quinta";
            semana[5] = "Sexta";
            semana[6] = "Sábado";

            Console.WriteLine();

          
            for(int i=0; i<semana.Length; i++)
            {
                Console.Write($"{semana[i]} ");
            }

            Console.ReadKey();
        }
    }
}
