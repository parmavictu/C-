﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () =>//Todo action não tem retorno
            {

                Console.WriteLine("Lambda com c#!");
            };
            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());


            Func<int, string> conversorHex = numero => numero.ToString("X");//a tipagem que coloca na func primeiro sao sempre o tipo de parametro que vai receber e o ultimo o retorno
            Console.WriteLine(conversorHex(1234));

            Func<int, int ,int ,string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}",dia,mes,ano);
            Console.WriteLine(formatarData(1, 1, 2019));


        }
    }
}
