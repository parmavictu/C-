using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome}  e tenho {Idade} anos");//esse format é quando ter que retornar uma string formatada
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        //outro exemplo de metodo que n retorna nada
        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
