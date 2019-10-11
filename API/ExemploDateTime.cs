using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2000, month: 2, day: 3);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);
            //adiciona um dia
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine("Amanhã" + amanha);
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine("Ontem" + ontem);

            //Usando o toString

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
            

        }
    }
}
