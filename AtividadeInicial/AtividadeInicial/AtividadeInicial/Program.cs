using System;
using System.Collections.Generic;

namespace AtividadeInicial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var idade = 10;
            int idadeInt = 12;
            double meuDouble = 1500.00;
            float meuFloat = 1500.00f;
            decimal meuDecimal = 1500.00m;

            bool verdadeiroFalso = true;

            string nome = "C Sharp";
            string[] alfabeto = { "A", "B" };

            List<string> alfabetoLista = new List<string>() {"A", "B"};
            Dictionary<int, string> chaveValor = new Dictionary<int, string>() { { 1, "A" }, { 2, "B" } };

            Pessoa pessoa = new Pessoa();

            Console.WriteLine(nome);

            Console.WriteLine("-------------------------------------------");

            foreach (string letra in alfabeto)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("-------------------------------------------");

            foreach (string letra in alfabetoLista)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("-------------------------------------------");

            foreach (var letra in chaveValor)
            {
                Console.WriteLine(letra);
            }
        }

        public class Pessoa
        {
            public string nome { get; set; }
        }
    }
}
