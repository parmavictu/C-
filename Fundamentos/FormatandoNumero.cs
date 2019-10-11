using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Uma casa decimal
            Console.WriteLine(valor.ToString("C"));//Currency -> valor monetario -> cuidado vai usar o pais da configuração do seu pc
            Console.WriteLine(valor.ToString("P"));//percentual
            Console.WriteLine(valor.ToString("#.##"));//definir como o numero vai ficar, Poderia ter colocado F2 tbm

            CultureInfo cultura = new CultureInfo("en-US");//Formatar para algum pais especifico
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//vai por varios zeros a esquerda

        }
    }
}
