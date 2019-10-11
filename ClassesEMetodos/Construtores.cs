using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Modelo, string fabricante, int ano) {
            this.Modelo = Modelo;//Qnd for por o mesmo nome de parametro usa this
            Fabricante = fabricante;//ou senão usa assim
            Ano = ano;
        }

        public Carro() {//Só para n dar erro falando que n tem parametro nos outros exemplos isso seria o construtor padrao que n precisa ser definido

        }
    }


    class Construtores {
        public static void Executar() {
            //Modo qnd tu deixa o construtor padrao e n coloca para passar parametros direto
            //var carro1 = new Carro();
            //carro1.Fabricante = "BMW";
            //carro1.Modelo = "324i";
            //carro1.Ano = 2017;
            //Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            //Modo sem o construtor padrao que vc passa no parametros os danos

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
            //terceiro modo
            var carro3 = new Carro(){
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");



        }
    }
}
