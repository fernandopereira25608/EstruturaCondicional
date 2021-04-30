using System;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu salário aqui!");
            float salario = float.Parse(Console.ReadLine());
            float ajuste = (salario/100)*30;

            if (salario<500){
                salario = salario *1.3f;
                Console.WriteLine( "Salario ajustado para: "+ salario);
            
            }
            else{
                Console.WriteLine("Teu salario esta bom");

            }

        }
    }
}
