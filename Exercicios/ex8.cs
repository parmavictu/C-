using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex8 {
        public static void Executar() {
            var array = new List<int>() {7,-6,-3,5,8,4,-6, 5 };
            var SortedArray = new List<int>();

            foreach(var num in array)
            {
                if(num> 0)
                {
                    SortedArray.Add(num);
                    
                }
            }
            SortedArray.Sort();
            int aux = 0;
            for(int i=0; i < array.Count; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = SortedArray[aux];
                    aux++;
                }
            }
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
