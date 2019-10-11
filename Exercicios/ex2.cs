using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex2 {
        public static void Executar() {

            
            Console.Write("N:");
            int.TryParse(Console.ReadLine(), out int N);
            string text = "217 1891 4819 2291 2987 3811 1739 2491 4717 445 65 1079 8383 5353 901 187 649 1003 697 3239 7663 291 123 779 1007 3551 1943 2117 1679 989 3053";
            int L = 32;
            var newtext = text.Split(" ");

            var odd = new List<int>();
            var newodd = new List<int>();
            int count;
            for(int i = 1; i <= N; i++)
            {
                count = 0;
                for(int isPrime = 1; isPrime <= i; isPrime++)
                {
                    if(i % isPrime == 0)
                    {
                        count++;
                    }
                }
                if(count == 2 && i %2 !=0 && i !=1)
                {
                    odd.Add(i);
                }
            }
            int x;
            Random random = new Random();
            while (newodd.Count != 26) {
                x = random.Next(odd.Count);
                if (!newodd.Contains(odd[x]))
                {
                    newodd.Add(odd[x]);
                }
            }
            var keyCode = new Dictionary<char, int>();
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            newodd.Sort();
            for (int i =0; i < 26; i++)
            {
                keyCode.Add(abc[i], newodd[i]);
            }
            var stringFinal = new List<char>();
            bool gotIt;
            int num1=0;
            int num2=0;
            
            
            int trying;
            var  numToText = new List<int>();
           foreach(var numText in newtext)
            {
                gotIt = false;
                int.TryParse(numText, out trying);
                foreach(var firstnum in keyCode)
                {
                    foreach(var secondnum in keyCode)
                    {
                        if (gotIt == true)
                        {
                            break;
                        }
                        if(firstnum.Value * secondnum.Value == trying )
                        {
                            if(gotIt == true)
                            {
                                continue;
                            }
                            num1 = Convert.ToInt32(firstnum.Value);
                            num2 = Convert.ToInt32(secondnum.Value);
                            gotIt = true;
                            numToText.Add(num1);
                            numToText.Add(num2);

                            
                        }
                    }
                    
                }
                

            }
            var lastNum = new List<int>();
            int ind = 3;
            int ct = 0;

            while(ind < numToText.Count)
            {
                
                int indexMenos3 = ind - 3;
                int indexMenos2 = ind - 2;
                int indexMenos1 = ind - 1;
                Console.WriteLine(ind);

                


                if(numToText[ind] == numToText[indexMenos3])
                {
                    
                    lastNum.Add(numToText[indexMenos2] );
                    lastNum.Add(numToText[ind]);
                    lastNum.Add(numToText[indexMenos1]);
                    
                }
                if(numToText[ind] == numToText[indexMenos2])
                {
                    
                    lastNum.Add(numToText[indexMenos3]);
                    lastNum.Add(numToText[ind]);
                    lastNum.Add(numToText[indexMenos1]);
                }
                if (numToText[indexMenos1] == numToText[indexMenos3])
                {
                    
                    lastNum.Add(numToText[indexMenos2]);
                    lastNum.Add(numToText[indexMenos1]);
                    lastNum.Add(numToText[ind]);
                }
                if(numToText[indexMenos1] == numToText[indexMenos2])
                {
                    
                    lastNum.Add(numToText[indexMenos3]);
                    lastNum.Add(numToText[indexMenos1]);
                    lastNum.Add(numToText[ind]);
                }
                ct += 1;
                int ctL = L - 1;
                if(ct == ctL)
                {
                    ind += 2;
                }
                else 
                {
                    ind += 4;
                } 

            }

            var finalIntString = new List<int>();
            for (int i =0; i< lastNum.Count; i++)
            {
                int lessOne = i - 1;
                if (i == 0 || lastNum[i] != lastNum[lessOne])
                {
                    finalIntString.Add(lastNum[i]);
                }
                
            }
            char letter=' ';
            for (int i = 0; i < finalIntString.Count; i++)
            {

                foreach (var item in keyCode)
                {
                    if (finalIntString[i] == item.Value)
                    {
                        letter = item.Key;
                    }
                    


                }
                
                stringFinal.Add(letter);

            }

            foreach(var i in stringFinal)
            {
                Console.Write(i + " ");
            }
            
        }
        
    }
}
