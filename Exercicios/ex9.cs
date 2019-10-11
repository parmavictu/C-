using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex9 {
        public static void Executar() {
            var array = new List<int>() {2,3,6,2,7,2,4,6 };
            var Sortedarray = new List<int>(array);
            var aloneNumbers = new List<int>() ;
            var LastArray = new List<int>() ;
            Sortedarray.Sort();
            for(int i=1; i < Sortedarray.Count; i++)
            {
                int auxLess = i - 1;
                int auxMore = i + 1;
                int auxCount = Sortedarray.Count - 2;

                if (i <= auxCount)
                {
                    if (Sortedarray[i] != Sortedarray[auxLess] && Sortedarray[i] != Sortedarray[auxMore] )
                    {
                        aloneNumbers.Add(Sortedarray[i]);
                    }
                }
                else
                {
                    if (Sortedarray[i] != Sortedarray[auxLess])
                    {
                        aloneNumbers.Add(Sortedarray[i]);
                    }
                }

                
            }

            foreach(var nums in array)
            {
                bool inIt = false;
                foreach(var outer in aloneNumbers)
                {
                    if(outer == nums)
                    {
                        inIt = true;
                    }
                }
                if (inIt)
                {
                    LastArray.Add(nums);
                }
                

            }
            foreach(var item in LastArray)
            {
                Console.Write(item);
            }
        }
    }
}
