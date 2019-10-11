using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex11 {
        public static void Executar() {
            var array = new List<int>() {1,1,1,1,1,1,1 };
            int countOne =0;
            int countLine = 0;
            int countArrayLessOne = array.Count - 1;
            for(int i =1; i<array.Count; i++)
            {
                int lessOne = i - 1;
                if (array[i] == array[lessOne] && array[i]==1)
                {       
                    countOne++;
                    if(i == countArrayLessOne)
                    {
                        countLine++;
                    }
                }
                else
                {
                    if(countOne>0)
                    {
                        countLine++;
                        countOne = 0;
                    }
                }
            }
            Console.WriteLine(countLine);
        }
    }
}
