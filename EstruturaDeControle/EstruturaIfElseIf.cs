using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void  Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0)
            {
                Console.WriteLine("quadro de honra!!");
            }else if(nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            }else{
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
