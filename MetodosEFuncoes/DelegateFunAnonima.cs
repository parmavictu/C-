using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFunAnonima {

        delegate string StringOperacao(string s);

        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();//quebra os caracteres e transformar em um array
                Array.Reverse(charArray);//colocar ao contrario.
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# É SHOW!!!"));
        }
    }
}
