using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o  seu salario?  ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);//Para ser sempre ponto o separador em vez de virgula independe do lugar

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
