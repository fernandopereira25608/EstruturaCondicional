using System;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o ano do seu nascimento?");
            int anoNascimento = int.Parse(Console.ReadLine());
            
            int anoAtual = DateTime.Now.Year;

            int idade = (anoAtual - anoNascimento);
            Console.WriteLine("Sua idade é  " + idade);

            int semanas = idade * 52;
            Console.WriteLine("Sua idade em semana é aproximadamente: " + semanas);

            







        }
    }
}
