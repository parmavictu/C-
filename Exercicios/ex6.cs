using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex6 {
        public static void Executar() {
            int N = 100;
            while (N > 50){
                Console.Write("Digite o número para conversão: ");
                int.TryParse(Console.ReadLine(), out N);
            }
            
            int ctI = 0;
            int ctV = 0;
            int ctX = 0;
            string numRoman = "";

            var Translator = new Dictionary<string, int>(){
                {"I",1 },
                {"V",5 },
                {"X",10 },
                {"L",50 },
            };
            while (N != 0){
                if (N >= 10)
                {
                    N = N - 10;
                    ctX++;
                }
                else if(N >= 5)
                {
                    N = N - 5;
                    ctV++;
                }
                else
                {
                    N = N - 1;
                    ctI++;
                }
            }
            int valuectX = ctX * 10;
            int valuectV = ctV * 5;
            if(valuectX == 50)
            {
                numRoman = "L";
            }
            if(valuectX == 40)
            {
                numRoman += "XL";
            }
            if(valuectX>=10 && valuectX <= 30)
            {
                for(int i=0; i< ctX; i++)
                {
                    numRoman += "X";
                }
            }
            if( valuectV +ctI == 9)
            {
                numRoman += "IX";
            }
            if(ctV ==1 && ctI < 4)
            {
                numRoman += "V";
            }
            if (ctI == 4)
            {
                numRoman += "IV";
            }
            if (ctI > 0 && ctI <4)
            {
                for (int i = 0; i < ctI; i++)
                {
                    numRoman += "I";
                }
            }
            Console.WriteLine(numRoman);
        }
    }
}
