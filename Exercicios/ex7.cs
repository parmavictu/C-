using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {
    class ex7 {
        public  static string Convert(string word, int index, string oldChar, char newChar) {
            var broken = word.Split(" ");
            string finalword = "";
            string end = broken[index - 1].Replace(oldChar.ToCharArray()[0], newChar);
            var listBroken = broken.ToList();
            listBroken.RemoveAt(index - 1);

            foreach(var letter in listBroken)
            {
                finalword += $"{letter} ";
            }

            finalword += end;
            return finalword;
        }
        public static void Executar() {
            Console.WriteLine(Convert("hello world", 2, "o", 'i'));
        }
    }
}
