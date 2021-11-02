using System;
using System.Collections.Generic;

namespace aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pessoas = new List<string>();
            List<string> backup = new List<string>();

            pessoas.Add("Rodrigo");
            pessoas.Add("Aline");
            pessoas.Add("Sofia");

            backup.Add("Ellen");
            backup.Add("Flávia");

            backup.AddRange(pessoas);
            
            foreach (string b in backup)
            {
                Console.WriteLine($" {b} ");
            }
        }
    }
}
