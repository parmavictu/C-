using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex5 {
        public static void Executar() {
            Console.Write("Digite o número =): ");
            int.TryParse(Console.ReadLine(), out int N);
            
            int product;
            int oldProduct = 0;

            var testing = new List<int>();
            var final = new List<int>();

            for(int c =1; c < 6; c++)
            {
                int X = N;
                product = 1;
                testing.Clear();
                for(int k=1; k<=c; k++)
                {
                    testing.Add(0);
                }
                while (X > 0)
                {
                    for(int i=0; i < testing.Count; i++)
                    {
                        testing[i]++;
                        X--;
                        if (X == 0)
                        {
                            break;
                        }
                    }
                }
                for(int deleteZero=0; deleteZero < testing.Count; deleteZero++)
                {
                    if (testing[deleteZero] == 0)
                    {
                        testing.RemoveAt(deleteZero);
                    }

                }
                for(var fatorialIndex=0; fatorialIndex < testing.Count; fatorialIndex++)
                {
                    if (c > 1)
                    {
                        product *= testing[fatorialIndex];
                    }
                }
                if(product > oldProduct)
                {
                    oldProduct = product;
                    final = new List<int>(testing);
                }
            }
            Console.Write($"{N} = ");
            foreach (var num in final)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
