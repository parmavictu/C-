using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper().Insert(3, "World")
                .Replace("World", "mundo");

            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);//Esse ? é de segurança, pois só vai ser executado se for diferente de null, evitando erros
        }
    }
}
