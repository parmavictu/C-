using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullable {
        public static void Executar() {
            Nullable<int> num1 = null;//Primeiro jeito
            int? num2 = null;//Segundo jeito
            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num : {0}", num1);
            }else
            {
                Console.WriteLine("A variável não possui valor.");
            }
            int valor = num1 ?? 1000;//se for null vai pegar o valor o valor padrão que nesse caso é 1000
            Console.WriteLine(num1);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();//pegar valor e se for null definir para default que no caso é falso
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();//se colocasse .Value iria dar erro 
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
