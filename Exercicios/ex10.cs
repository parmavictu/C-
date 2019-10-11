using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex10 {
        public static void Executar() {
            var arrayNums = new List<int> (){4,5,6,2,1,2,3,4,12,6,4,2,1,5,8,9 };
            int maior=0;
            int soma = 0;
            for(int i=1; i< arrayNums.Count; i++)
            {
                int lessOne = i - 1;
                int lessTwo = i - 2;
                int lengthLessOne = arrayNums.Count -1;
                if (arrayNums[i] > arrayNums[lessOne])
                {
                    if(i < lengthLessOne)
                    {
                        soma += arrayNums[lessOne];
                    }
                    else
                    {
                        soma += arrayNums[i] + arrayNums[lessOne];
                        if ( soma > maior)
                        {
                            maior = soma;
                        }
                    }
                }
                else
                {
                    if (arrayNums[lessOne] > arrayNums[lessTwo])
                    {
                        soma += arrayNums[lessOne];
                        if (i ==1)
                        {
                            maior = soma;
                        }
                    }
                    soma = 0;
                }
            }
            Console.WriteLine(maior);
        }
    }
}
