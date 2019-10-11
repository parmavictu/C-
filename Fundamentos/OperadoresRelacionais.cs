using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {   //Console.Write("Digite a nota: ");
            //double.TryParse(Console.ReadLine(), out double nota);
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota Inválida {nota > 10.00}");
            Console.WriteLine($"Nota Inválida {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou Por media? {nota >= notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3}");

        }
    }
}
