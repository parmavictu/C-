using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex4 {
        public static void Executar() {
            Console.Write("Digite a palavra: ");
            string text = Console.ReadLine();

            var words = new List<string>();
            var anagrams = new List<string>();
            var index = new List<int>();

            Random random = new Random();
            string word;
            int final = 1;

            for(int i=1; i<= text.Length; i++){
                final *= i;

            }
            while (words.Count <= final){
                word = "";
                index.Clear();
                int x = 0;

                for(int i=0; i < text.Length; i++){
                    bool contin = true;
                    while (contin==true){
                        x = random.Next(text.Length);
                        if (index.Contains(x)==false){

                            word += text[x];
                            index.Add(x);
                            contin =false;
                        }
                    }
                }

                words.Add(word);
            }
            foreach(var anagram in words)
            {
                if (!anagrams.Contains(anagram))
                {
                    anagrams.Add(anagram);
                }
            }
            Console.WriteLine("==========================================================================");
            foreach(var anagram in anagrams){
                Console.WriteLine(anagram);
            }

        }
    }
}
