using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public abstract class Celular {//Não pode ser instanciada
        public abstract string Assistente();//Podemos criar um metodo abstrato para definir depois nas classes que vai herdar

        public string Tocar() {
            return "Trim trim trim...";
        }
    }
    public class Samsung : Celular {
        public override string Assistente() {//Para sobrescrever
            return "Olá! Meu nome é Bixby";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }
    class Abstract {
        public static void Executar() {
            var celulares = new List<Celular>
           {
               new Iphone(),
               new Samsung()
           };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
