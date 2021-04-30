using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int IdadeMeses = idade * 12;
            int IdadeDias = idade * 365;
            int IdadeHoras = IdadeDias * 24;
            int IdadeMinutos = IdadeHoras * 60;

            Console.WriteLine("Idade em minutos: " + IdadeMinutos);
            Console.WriteLine("Idade em horas: " + IdadeHoras);
            Console.WriteLine("Idade em dias: " + IdadeDias);
            Console.WriteLine("Idade em meses: " + IdadeMeses);

        }

        
    }
}
