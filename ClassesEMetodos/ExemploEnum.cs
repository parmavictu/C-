using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia  };//não precisa de acentos e aspas -> primeira letra maiscula

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;


            Console.WriteLine($"{filmeParaFamilia.Titulo} é {filmeParaFamilia.GeneroDoFilme}");

        }
    }
}
