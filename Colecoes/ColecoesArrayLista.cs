using System;
using System.Collections;//ela n usa generic
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayLista {
        public static void Executar() {
            var arraylist = new ArrayList {
                "palavra",
                3,
                true
            };
            arraylist.Add(3.14);

            foreach (object item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
