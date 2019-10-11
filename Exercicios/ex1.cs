using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios {


    class ex1 {
        public static void Executar() {
            int x;
            int y;

            var vet = new List<int>();
            var maior = new List<int>();
            var igual = new List<int>();
            var menor = new List<int>();

            Console.Write("Digite o X: ");
            int.TryParse(Console.ReadLine(), out x);

            while (x < 0){
                Console.Write("Digite o X: (tem que ser positivo)");
                int.TryParse(Console.ReadLine(), out x);
            }

            for(int i=1; i<=10; i++){
                Console.Write("Digite o y: ");
                int.TryParse(Console.ReadLine(), out  y);

                while (y < 0){
                    Console.Write("Digite o Y: (tem que ser positivo)");
                    int.TryParse(Console.ReadLine(), out  y);
                }
                vet.Add(y);
            }
            foreach(int num in vet){
                if (num > x){
                    maior.Add(num);
                }else if (num < x){
                    menor.Add(num);
                }
                else{
                    igual.Add(num);
                }
            }
            Console.WriteLine("Maiores");
            foreach(int item in maior){
                Console.Write($"{item} ");
            }

            Console.WriteLine("Menores");
            foreach (int item in menor)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("Iguais");
            foreach (int item in igual)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
